﻿using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.Game.ClientState.Objects.Types;
using System;
using System.ComponentModel;
using System.Linq;
using XIVAutoAttack.Actions;
using XIVAutoAttack.Actions.BaseAction;
using XIVAutoAttack.Controllers;
using XIVAutoAttack.Helpers;
using XIVAutoAttack.SigReplacers;
using XIVAutoAttack.Updaters;

namespace XIVAutoAttack.Combos.CustomCombo
{
    public abstract partial class CustomCombo
    {
        public enum DescType : byte
        {
            循环说明,
            爆发技能,
            范围治疗,
            单体治疗,
            范围防御,
            单体防御,
            移动,
        }
        protected static double TimeSinceLastAction => Watcher.TimeSinceLastAction.TotalSeconds;

        protected static PlayerCharacter Player => Service.ClientState.LocalPlayer;
        protected static BattleChara Target => Service.TargetManager.Target is BattleChara b ? b : Player;

        protected static bool IsMoving => XIVAutoAttackPlugin.movingController.IsMoving;
        protected static bool HaveHostileInRange => TargetUpdater.HaveHostileInRange;
        protected virtual bool CanHealAreaAbility => TargetUpdater.CanHealAreaAbility;
        protected virtual bool CanHealAreaSpell => TargetUpdater.CanHealAreaSpell;

        protected virtual bool CanHealSingleAbility => TargetUpdater.CanHealSingleAbility;
        protected virtual bool CanHealSingleSpell => TargetUpdater.CanHealSingleSpell;

        /// <summary>
        /// 是否处于爆发，自动爆发或者手动点击的爆发
        /// </summary>
        protected bool SettingBreak => CommandController.BreakorProvoke || Service.Configuration.AutoBreak;

        protected static byte Level => Player?.Level ?? 0;

        protected static bool InCombat => ActionUpdater.InCombat;

        protected static bool IsLastSpell(bool isAdjust, params IAction[] actions)
            => IActionHelper.IsLastSpell(isAdjust, actions);

        protected static bool IsLastSpell(params uint[] ids)
            => IActionHelper.IsLastSpell(ids);


        protected static bool IsLastAbility(bool isAdjust, params IAction[] actions)
            => IActionHelper.IsLastAbility(isAdjust, actions);

        protected static bool IsLastAbility(params uint[] ids)
            => IActionHelper.IsLastAbility(ids);


        protected static bool IsLastWeaponSkill(bool isAdjust, params IAction[] actions)
            => IActionHelper.IsLastWeaponSkill(isAdjust, actions);

        protected static bool IsLastWeaponSkill(params uint[] ids)
            => IActionHelper.IsLastWeaponSkill(ids);


        protected static bool IsLastAction(bool isAdjust, params IAction[] actions)
            => IActionHelper.IsLastAction(isAdjust, actions);

        protected static bool IsLastAction(params uint[] ids)
            => IActionHelper.IsLastAction(ids);
    }
}
