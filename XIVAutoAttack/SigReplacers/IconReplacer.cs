using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.Hooking;
using Dalamud.Logging;
using FFXIVClientStructs.FFXIV.Client.Game;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using XIVAutoAttack.Actions;
using XIVAutoAttack.Actions.BaseAction;
using XIVAutoAttack.Combos.CustomCombo;
using XIVAutoAttack.Data;
using XIVAutoAttack.Helpers;

namespace XIVAutoAttack.SigReplacers;

internal sealed class IconReplacer : IDisposable
{
    private delegate ulong IsIconReplaceableDelegate(uint actionID);

    private delegate uint GetIconDelegate(IntPtr actionManager, uint actionID);

    private delegate IntPtr GetActionCooldownSlotDelegate(IntPtr actionManager, int cooldownGroup);

    private static SortedList<Role, CustomCombo[]> _customCombosDict;
    internal static SortedList<Role, CustomCombo[]> CustomCombosDict
    {
        get
        {
            if (_customCombosDict == null)
            {
                SetStaticValues();
            }
            return _customCombosDict;
        }
    }
    private static CustomCombo[] _customCombos;
    internal static CustomCombo[] CustomCombos
    {
        get
        {
            if (_customCombos == null)
            {
                SetStaticValues();
            }
            return _customCombos;
        }
    }

    private readonly Hook<IsIconReplaceableDelegate> isIconReplaceableHook;

    private readonly Hook<GetIconDelegate> getIconHook;

    private IntPtr actionManager = IntPtr.Zero;


    public IconReplacer()
    {
        unsafe
        {
            getIconHook = Hook<GetIconDelegate>.FromAddress((IntPtr)ActionManager.fpGetAdjustedActionId, GetIconDetour);
        }
        isIconReplaceableHook = Hook<IsIconReplaceableDelegate>.FromAddress(Service.Address.IsActionIdReplaceable, IsIconReplaceableDetour);

        getIconHook.Enable();
        isIconReplaceableHook.Enable();
    }



    private static void SetStaticValues()
    {
        _customCombos = (from t in Assembly.GetAssembly(typeof(CustomCombo)).GetTypes()
                         where t.BaseType?.BaseType == typeof(CustomCombo)
                         select (CustomCombo)Activator.CreateInstance(t)).ToArray();

        _customCombosDict = new SortedList<Role, CustomCombo[]>
            (_customCombos.GroupBy(g => g.Role).ToDictionary(set => set.Key, set => set.OrderBy(i => i.JobID).ToArray()));
    }

    public void Dispose()
    {
        getIconHook.Dispose();
        isIconReplaceableHook.Dispose();
    }

    internal uint OriginalHook(uint actionID)
    {
        return getIconHook.Original.Invoke(actionManager, actionID);
    }

    private unsafe uint GetIconDetour(IntPtr actionManager, uint actionID)
    {
        this.actionManager = actionManager;
        return RemapActionID(actionID);
    }

#if DEBUG
    internal static BaseAction nextAction = null;
#endif

    private uint RemapActionID(uint actionID)
    {
        try
        {
            PlayerCharacter localPlayer = Service.ClientState.LocalPlayer;
            if (localPlayer == null || Service.Configuration.NeverReplaceIcon)
            {
                return OriginalHook(actionID);
            }

            byte level = localPlayer.Level;
            foreach (CustomCombo customCombo in CustomCombos)
            {
                if (customCombo.JobID != localPlayer.ClassJob.Id) continue;

                if (customCombo.TryInvoke(actionID, Service.Address.LastComboAction, Service.Address.ComboTime, level, out var newAction))
                {
                    if (newAction is BaseAction baseAct)
                    {
#if DEBUG
                        nextAction = baseAct;
#endif
                        return OriginalHook(baseAct.ID);
                    }
                }
            }

            return OriginalHook(actionID);
        }
        catch (Exception ex)
        {
            PluginLog.Error(ex, "Don't crash the game", Array.Empty<object>());
            return OriginalHook(actionID);
        }
    }

    private ulong IsIconReplaceableDetour(uint actionID)
    {
        return 1uL;
    }
}