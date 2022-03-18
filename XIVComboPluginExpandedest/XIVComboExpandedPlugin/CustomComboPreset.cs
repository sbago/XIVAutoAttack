using XIVComboExpandedPlugin.Attributes;

namespace XIVComboExpandedPlugin;

public enum CustomComboPreset
{
	[CustomComboInfo("None", "This should not be used.", 0, 12)]
	None = 0,
	[CustomComboInfo("Disabled", "This should not be used.", 0, 16)]
	Disabled = 99999,
	[CustomComboInfo("当有即刻BUFF", "当即刻没冷却时候(并且没有连续咏唱buff)分别替换赤魔/召唤/学者/白魔/占星的复活.", 0, 21)]
	AllSwiftcastFeature = 9001,
	[CustomComboInfo("抽卡/出卡", "没有卡被抽出时，替换出卡为抽卡", 33, 28)]
	AstrologianCardsOnDrawFeature = 3301,
	[CustomComboInfo("小奥秘卡 - 袖内抽卡", "当没有抽卡时袖内抽卡替换小奥秘卡.", 33, 31)]
	AstrologianMinorArcanaPlayFeature = 3302,
	[CustomComboInfo("等级同步吉星替换福星", "等级同步时吉星替换福星.", 33, 34)]
	AstrologianBeneficFeature = 3303,
	[CustomComboInfo("dot状态", "当目标dot时间小于3秒时，dot替换煞星", 33, 37)]
	ASTdotFeature = 3304,
	[CustomComboInfo("阳星状态", "当身上阳星相应dot大于5s时候替换成阳星", 33, 40)]
	ASTYangXingFeature = 3305,
	[CustomComboInfo("天语状态", "将火4和冰4更改为当前可以使用的技能.", 25, 47)]
	BlackEnochianFeature = 2501,
	[CustomComboInfo("灵极魂/星灵移位", "当灵极魂可用时，替换星灵移位为灵极魂", 25, 50)]
	BlackManaFeature = 2502,
	[CustomComboInfo("魔纹步 / 黑魔纹", "当黑魔纹激活时，替换黑魔纹为魔纹步", 25, 53)]
	BlackLeyLinesFeature = 2503,
	[CustomComboInfo("火1/火3状态", "在有火苗的时候火1在星极之外变成火3", 25, 56)]
	BlackFireFeature = 2504,
	[CustomComboInfo("玄极冰状态", "当灵极冰时候冰3替换冰1,.", 25, 59)]
	BlackBlizzardFeature = 2505,
	[CustomComboInfo("玄冰/核爆状态", "玄冰/核爆更改为当前可以使用的技能.", 25, 62)]
	BlackFreezeFlareFeature = 2506,
	[CustomComboInfo("崩溃/异言状态", "当激活的时候崩溃变成易言.", 25, 65)]
	BlackScatheFeature = 2507,
	[CustomComboInfo("放浪神 - 完美音调", "当处于放浪神的小步舞曲状态下，替换放浪神的小步舞曲为完美音调", 23, 72)]
	BardWanderersPitchPerfectFeature = 2301,
	[CustomComboInfo("强力射击 - 直线射击", "当触发时，强力射击替换直线射击when available.", 23, 75)]
	BardStraightShotUpgradeFeature = 2302,
	[CustomComboInfo("单人dot", "当2个毒没消失的时候烈毒咬箭/狂风蚀箭替换伶牙俐齿。\n适用于同步情况，如果伶牙俐齿不能使用请两个版本交替试.", 23, 78)]
	BardIronJawsFeature = 2303,
	[CustomComboInfo("Burst Shot/Quick Nock into Apex Arrow", "Replaces Burst Shot and Quick Nock with Apex Arrow when gauge is full.", 23, 81)]
	BardApexFeature = 2304,
	[CustomComboInfo("连珠箭 - 绝峰箭", "当量普满时绝峰箭替换爆连珠箭.", 23, 84)]
	BardShadowbiteFeature = 2305,
	[CustomComboInfo("失血箭状态", "九天连箭\\侧风诱导箭替换失血箭当被激活时候.", 23, 87)]
	BardBloodletterFeature = 2306,
	[CustomComboInfo("死亡箭雨状态", "九天连箭\\侧风诱导箭替换死亡箭雨当被激活时候.", 23, 90)]
	BardRainOfDeathFeature = 2307,
	[CustomComboInfo("扇舞连击", "当扇舞·急预备时，替换扇舞·序和扇舞·破为扇舞·急.", 38, 97)]
	DancerFanDanceCombo = 3801,
	[SecretCustomCombo]
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.DancerDanceComboCompatibility })]
	[CustomComboInfo("跳舞连击", "自动跳舞.", 38, 102)]
	DancerDanceStepCombo = 3802,
	[CustomComboInfo("百花争艳进程保存", "在使用后所有触发技能替换成百花争艳成.", 38, 105)]
	DancerFlourishFeature = 3803,
	[CustomComboInfo("单体连击", "单体连击.", 38, 108)]
	DancerSingleTargetMultibutton = 3804,
	[CustomComboInfo("AOE连击", "AOE连击.", 38, 111)]
	DancerAoeMultibutton = 3805,
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.DancerDanceStepCombo })]
	[CustomComboInfo("舞步状态", "当跳舞时候把技能替换成舞步.\n这有助于确保你仍然可以使用跳舞连招，而不使用自动舞蹈.\n您可以通过为每个舞步输入下面的技能id来更改相应的舞步.\n默认的是倾泻，百花争艳，扇舞·序，扇舞·破，如果设置为0，会重置成这样.\n可以在Garland Tools(http://www.garlandtools.org/)通过搜索点击相应齿轮相应技能id.", 38, 115)]
	DancerDanceComboCompatibility = 3806,
	[CustomComboInfo("进攻之探戈状态", "当进攻之探戈使用后替换成流星之舞.", 38, 125)]
	DancerDevilmentFeature = 3807,
	[CustomComboInfo("噬魂斩连击", "替换噬魂斩为相应的连击", 32, 132)]
	DarkSouleaterCombo = 3201,
	[CustomComboInfo("刚魂连击", "替换刚魂为相应的连击", 32, 135)]
	DarkStalwartSoulCombo = 3202,
	[CustomComboInfo("血乱状态", "当开启前面连击你又处于血乱状态时，替换血乱或血贱", 32, 138)]
	DarkDeliriumFeature = 3203,
	[CustomComboInfo("吸血深渊/精雕怒斩", "根据冷却腐秽大地/精雕怒斩/吸血深渊替换相应技能.", 32, 142)]
	DarkShadowbringerFeature = 3204,
	[CustomComboInfo("嗜血状态", "当你开启前面连击时候，嗜血大于70自动帮你替换血乱或血贱.", 32, 145)]
	DRKOvercapFeature = 3205,
	[CustomComboInfo("弗雷状态", "弗雷CD好时候替换在相应连击上", 32, 148)]
	DRKFoLeiFeature = 3206,
	[CustomComboInfo("暗黑buff", "当你魔量大于8000时替换暗影峰或者暗影波动", 32, 151)]
	DRKMPOvercapFeature = 3207,
	[CustomComboInfo("跳跃 - 幻象冲", "处于幻象冲预备状态下，替换跳跃为幻象冲", 22, 158)]
	DragoonJumpFeature = 2201,
	[CustomComboInfo("山境酷刑连击", "替换山境酷刑为相应的连击", 22, 161)]
	DragoonCoerthanTormentCombo = 2202,
	[CustomComboInfo("樱花怒放连击", "替换樱花怒放为相应的连击", 22, 164)]
	DragoonChaosThrustCombo = 2203,
	[CustomComboInfo("直刺连击", "替换直刺为相应的连击", 22, 167)]
	DragoonFullThrustCombo = 2204,
	[CustomComboInfo("冲 冲 冲!", "当激活时替换破碎冲/龙炎冲/坠星冲.", 22, 171)]
	DragoonDiveFeature = 2205,
	[CustomComboInfo("迅连斩连击", "替换迅连斩为相应的连击", 37, 178)]
	GunbreakerSolidBarrelCombo = 3701,
	[CustomComboInfo("烈牙状态", "替换相应烈牙连击.", 37, 181)]
	GunbreakerGnashingFangCont = 3702,
	[CustomComboInfo("血壤状态", "当你晶壤溢出时用爆发击替换血壤.", 37, 184)]
	GunbreakerBurstStrikeCont = 3703,
	[SecretCustomCombo]
	[CustomComboInfo("弓形冲波 / 音速破", "当一个冷却时候替换另一个", 37, 188)]
	GunbreakerBowShockSonicBreakFeature = 3704,
	[CustomComboInfo("恶魔杀连击", "替换恶魔杀为相应的连击.", 37, 191)]
	GunbreakerDemonSlaughterCombo = 3705,
	[CustomComboInfo("晶壤状态1", "当子弹快满时候自动替换在单体或AOE连上", 37, 194)]
	GunbreakerFatedCircleFeature = 3706,
	[CustomComboInfo("血壤状态2", "当你晶壤溢出时用爆发击替换血壤.", 37, 197)]
	GunbreakerEmptyBloodfestFeature = 3707,
	[CustomComboInfo("无情状态", "用弓形冲波替换无情, 然后用音速破替换, 当无情被激活时.", 37, 200)]
	GunbreakerNoMercyFeature = 3708,
	[CustomComboInfo("一键连击", "枪刃一键gcd连.", 37, 203)]
	GunbreakerZiDongeature = 3709,
	[CustomComboInfo("狙击弹连击", "替换狙击弹为相应的连击", 31, 210)]
	MachinistMainCombo = 3101,
	[CustomComboInfo("散射(过热)", "在过热状态下，替换散射为自动弩", 31, 213)]
	MachinistSpreadShotFeature = 3102,
	[CustomComboInfo("热冲击(过热)", "在过热状态下，替换超荷为热冲击", 31, 216)]
	MachinistOverheatFeature = 3103,
	[CustomComboInfo("机器人状态", "当机器人被激活时候用冲击替换车式浮空炮塔和后式自走人偶", 31, 219)]
	MachinistOverdriveFeature = 3104,
	[SecretCustomCombo]
	[CustomComboInfo("虹吸弹-弹射状态", "如果多余的，一个替换另一个.", 31, 223)]
	MachinistGaussRoundRicochetFeature = 3105,
	[SecretCustomCombo]
	[CustomComboInfo("热弹 (空气锚) / 钻头 / Chainsaw状态", "当哪个可用替换哪个.", 31, 227)]
	MachinistHotShotDrillChainsawFeature = 3106,
	[CustomComboInfo("机工一键", "开启狙击弹连击后的一键gcd连击", 31, 230)]
	MachinistZiDongFeature = 3107,
	[CustomComboInfo("AoE连击", "替换地烈劲为相应的AoE连击,当震脚可用时，替换为地烈劲", 20, 236)]
	MonkAoECombo = 2001,
	[CustomComboInfo("Howling Fist / 斗气 状态", "当斗气量普没打开时候Howling Fist 替换斗气.", 20, 242)]
	MonkHowlingFistMeditationFeature = 2003,
	[CustomComboInfo("强甲破点突连击", "替换强甲破点突为相应的连击", 30, 249)]
	NinjaArmorCrushCombo = 3001,
	[CustomComboInfo("旋风刃连击", "替换旋风刃为相应的连击", 30, 252)]
	NinjaAeolianEdgeCombo = 3002,
	[CustomComboInfo("八卦无刃杀连击", "替换八卦无刃杀为相应的连击", 30, 255)]
	NinjaHakkeMujinsatsuCombo = 3003,
	[CustomComboInfo("攻其不备替换生杀予夺", "当有水遁buff或隐身时攻其不备替换生杀予夺", 30, 258)]
	NinjaKassatsuTrickFeature = 3004,
	[CustomComboInfo("天地人替换命水", "天地人完后命水替换天地人.", 30, 261)]
	NinjaTCJMeisuiFeature = 3005,
	[CustomComboInfo("生杀时天地印", "当你有生杀予夺buff时候把地之印替换成人之印.", 30, 264)]
	NinjaKassatsuChiJinFeature = 3006,
	[CustomComboInfo("夺取替换隐遁", "当你战斗时夺取替换隐遁.", 30, 267)]
	NinjaHideMugFeature = 3007,
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.NinjaGCDNinjutsuFeature })]
	[CustomComboInfo("Aeolian to Ninjutsu Feature", "Replaces Aeolian Edge (combo) with Ninjutsu if any Mudra are used.", 30, 271)]
	NinjaNinjutsuFeature = 3008,
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.NinjaNinjutsuFeature })]
	[CustomComboInfo("GCD连状态", "如果在结印忍术替换GCD连击", 30, 275)]
	NinjaGCDNinjutsuFeature = 3009,
	[CustomComboInfo("分身 / Kamaitachi Feature", "Replaces Bunshin with Phantom Kamaitachi after usage.", 30, 278)]
	NinjaBunshinKamaitachiFeature = 3010,
	[CustomComboInfo("强甲破点突 / Raiju Feature", "当镰鼬激活时替换强甲破点突连击.", 30, 281)]
	NinjaArmorCrushRaijuFeature = 3015,
	[CustomComboInfo("Aeolian Edge / Raiju Feature", "Replaces the Aeolian Edge combo with Forked and Fleeting Raiju when available.", 30, 284)]
	NinjaAeolianEdgeRaijuFeature = 3013,
	[CustomComboInfo("Huraijin / Raiju Feature", "Replaces Huraijin with Forked and Fleeting Raiju when available.", 30, 287)]
	NinjaHuraijinRaijuFeature = 3011,
	[CustomComboInfo("忍气状态", "如果忍气大于40六道替换夺取和大于50六道替换命水", 30, 290)]
	NinjaLiangPuFeature = 3012,
	[CustomComboInfo("自动忍术", "使用天之印来自动单体忍术，使用人之印来群体忍术", 30, 293)]
	NinjaRenShuFeature = 3014,
	[CustomComboInfo("镰鼬状态", "当能使用镰鼬的时候，镰鼬替换双刃旋", 30, 296)]
	NinjaBunshinFeature = 3016,
	[CustomComboInfo("沥血剑连击", "替换沥血剑为相应的连击", 19, 303)]
	PaladinGoringBladeCombo = 1901,
	[CustomComboInfo("王权剑连击", "替换 王权剑/战女神之怒为相应的连击", 19, 306)]
	PaladinRageOfHaloneCombo = 1902,
	[CustomComboInfo("赎罪剑状态", "当前面开启王权剑连击时处于赎罪剑状态时候，赎罪剑替换王权剑连击", 19, 309)]
	PaladinAtonementFeature = 1903,
	[CustomComboInfo("日珥斩连击", "替换日珥斩为相应的连击", 19, 312)]
	PaladinProminenceCombo = 1904,
	[CustomComboInfo("安魂祈祷", "当安魂生效时候赎罪替换安魂.", 19, 315)]
	PaladinRequiescatCombo = 1905,
	[SecretCustomCombo]
	[CustomComboInfo("赎罪状态", "当你魔量低于2000时候，自动替换赎罪.", 19, 319)]
	PaladinConfiteorFeature = 1907,
	[SecretCustomCombo]
	[CustomComboInfo("Scornful Spirits Feature", "Replace Spirits Within and Circle of Scorn with whichever is available soonest.", 19, 323)]
	PaladinScornfulSpiritsFeature = 1908,
	[CustomComboInfo("切连击", "相应连击替换在炼狱切上.", 39, 331)]
	ReaperSliceCombo = 3901,
	[CustomComboInfo("AOE连击", "AOE连击替换在回旋镰上.", 39, 334)]
	ReaperScytheCombo = 3902,
	[CustomComboInfo("炼狱切选项1", "当有妖异之镰或死灵蔽身时用绞杀替换炼狱切.", 39, 337)]
	ReaperSoulReaverGibbetFeature = 3903,
	[ParentCombo(CustomComboPreset.ReaperSoulReaverGibbetFeature)]
	[CustomComboInfo("炼狱切选项2", "当有妖异之镰或死灵蔽身时用枭首替换炼狱切.", 39, 341)]
	ReaperSoulReaverGibbetOption = 3904,
	[CustomComboInfo("死亡之影选项1", "当有妖异之镰或死灵蔽身时用枭首替换死亡之影.", 39, 344)]
	ReaperSoulReaverGallowsFeature = 3905,
	[ParentCombo(CustomComboPreset.ReaperSoulReaverGallowsFeature)]
	[CustomComboInfo("死亡之影选项2", "当有妖异之镰或死灵蔽身时用绞杀替换死亡之影.", 39, 348)]
	ReaperSoulReaverGallowsOption = 3906,
	[CustomComboInfo("断头状态", "当有妖异之镰或死灵蔽身时用梦魇镰替换炼狱切.", 39, 351)]
	ReaperSoulReaverGuillotineFeature = 3907,
	[CustomComboInfo("奥秘之环状态", "当你有死者供物buff时候用丰收替换奥秘之环.", 39, 354)]
	ReaperHarvestFeature = 3908,
	[CustomComboInfo("死灵蔽身状态", "当死灵蔽身时候用鲜血潜猎替换死灵蔽身.", 39, 357)]
	ReaperEnshroudCommunioFeature = 3909,
	[CustomComboInfo("地狱之门状态", "当有地狱之门buff时候溯回替换地狱脱离和地狱侵入.", 39, 360)]
	ReaperRegressFeature = 3910,
	[CustomComboInfo("死亡之影状态", "当目标死亡之影buff小于3s时死亡之影替换在炼狱切上.", 39, 363)]
	ReaperSiWangFeature = 3911,
	[CustomComboInfo("AoE连击", "当连续咏唱/即刻咏唱可用时，替换赤烈风/赤震雷为冲击", 35, 370)]
	RedMageAoECombo = 3501,
	[CustomComboInfo("魔连攻连击", "替换魔连攻为相应的连击", 35, 373)]
	RedMageMeleeCombo = 3502,
	[SecretCustomCombo]
	[ParentCombo(CustomComboPreset.RedMageMeleeCombo)]
	[CustomComboInfo("Redoublement Combo Plus", "Replaces Redoublement with Verflare/Verholy (and then Scorch and Resolution) after Enchanted Redoublement, whichever is more appropriate.", 35, 378)]
	RedMageMeleeComboPlus = 3503,
	[CustomComboInfo("赤火/石 - 震荡", "没有触发时，替换赤飞石/赤火炎为震荡/焦热.", 35, 381)]
	RedMageVerprocCombo = 3504,
	[ParentCombo(CustomComboPreset.RedMageVerprocCombo)]
	[CustomComboInfo("赤火/石 - 震荡 Plus", "另外如果连续咏唱/即刻发动赤飞石/赤火炎替换赤疾风/赤闪雷.", 35, 385)]
	RedMageVerprocComboPlus = 3505,
	[ParentCombo(CustomComboPreset.RedMageVerprocComboPlus)]
	[CustomComboInfo("赤火/石 - 震荡 Plus 开启功能1", "当退出战斗让赤疾风替换赤火焰.", 35, 389)]
	RedMageVerprocOpenerFeatureStone = 3506,
	[ParentCombo(CustomComboPreset.RedMageVerprocComboPlus)]
	[CustomComboInfo("赤火/石 - 震荡 Plus 开启功能2", "当退出战斗让赤闪雷替换赤火焰.", 35, 393)]
	RedMageVerprocOpenerFeatureFire = 3507,
	[SecretCustomCombo]
	[CustomComboInfo("六分反击/ 飞刺状态", "当一个激活时候替换另一个.", 35, 397)]
	RedMageContreFlecheFeature = 3508,
	[CustomComboInfo("震荡状态", "在相应buff下使用相应技能使魔元差不多.", 35, 400)]
	RedMageZiDONGFeature = 3509,
	[CustomComboInfo("雪风连击", "替换雪风为相应的连击", 34, 414)]
	SamuraiYukikazeCombo = 3401,
	[CustomComboInfo("月光连击", "替换月光为相应的连击", 34, 417)]
	SamuraiGekkoCombo = 3402,
	[CustomComboInfo("花车连击", "替换花车为相应的连击", 34, 420)]
	SamuraiKashaCombo = 3403,
	[CustomComboInfo("满月连击", "替换满月为相应的连击", 34, 423)]
	SamuraiMangetsuCombo = 3404,
	[CustomComboInfo("樱花连击", "替换樱花为相应的连击", 34, 426)]
	SamuraiOkaCombo = 3405,
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.SamuraiIaijutsuTsubameGaeshiFeature })]
	[CustomComboInfo("燕回返-居合术", "当无剑压居合术替换燕回返.", 34, 430)]
	SamuraiTsubameGaeshiIaijutsuFeature = 3407,
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.SamuraiIaijutsuShohaFeature })]
	[CustomComboInfo("燕回返-照破", "当剑压大于3层照破替换燕回返.", 34, 434)]
	SamuraiTsubameGaeshiShohaFeature = 3408,
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.SamuraiTsubameGaeshiIaijutsuFeature })]
	[CustomComboInfo("燕回返-居合术", "当居合不为空时居合术替换燕回返.", 34, 438)]
	SamuraiIaijutsuTsubameGaeshiFeature = 3409,
	[ConflictingCombos(new CustomComboPreset[] { CustomComboPreset.SamuraiTsubameGaeshiShohaFeature })]
	[CustomComboInfo("居合术-照破", "当剑压大于3层照破替换居合术.", 34, 442)]
	SamuraiIaijutsuShohaFeature = 3410,
	[CustomComboInfo("无明照破-必杀剑·九天", "当剑压大于3层无明照破替换必杀剑·九天.", 34, 445)]
	SamuraiShoha2Feature = 3412,
	[CustomComboInfo("意气冲天状态", "当激活时候贯穿尖/照破/奥义波切替换意气冲天.", 34, 448)]
	SamuraiIkishotenNamikiriFeature = 3411,
	[CustomComboInfo("异想的祥光/慰藉", "当不在大天使时候慰藉替换祥光.", 28, 455)]
	ScholarSeraphConsolationFeature = 2801,
	[CustomComboInfo("能量吸收 - 以太超流", "零档以太超流时,替换能量吸收为以太超流", 28, 458)]
	ScholarEnergyDrainFeature = 2802,
	[CustomComboInfo("dot状态", "当目标dot时间小于2秒时，dot替换炎法", 28, 461)]
	SCHDotFeature = 2803,
	[CustomComboInfo("应急状态", "当身上有应急或者在CD时候替换成群盾", 28, 464)]
	SCHYingJitFeature = 2804,
	[CustomComboInfo("龙神/凤凰选择", "当龙神/凤凰被召唤时龙神迸发/凤凰会替换龙神召唤/凤凰召唤", 27, 471)]
	SummonerDemiCombo = 2701,
	[CustomComboInfo("宝玉状态", "当龙神/凤凰被召唤时龙神迸发/凤凰会替换宝玉闪光/辉光.", 27, 474)]
	SummonerShinyDemiCombo = 2708,
	[CustomComboInfo("ES痛苦核爆", "当不在以太超流时候能量抽取替换痛苦核爆", 27, 480)]
	SummonerESPainflareCombo = 2703,
	[CustomComboInfo("山崩状态", "当泰坦激活时宝玉闪光/辉光变成爆裂脚.", 27, 483)]
	SummonerMountainBusterFeature = 2710,
	[CustomComboInfo("宝玉毁档状态", "当适应的会后把毁档替换宝玉.\n可能会扰乱你的移动选择.", 27, 486)]
	SummonerShinyRuinFeature = 2709,
	[CustomComboInfo("毁绝状态", "当有毁觉buff时候毁4替换毁1/毁2/毁3.\n这可能会扰乱你的移动选择", 27, 489)]
	SummonerFurtherRuinFeature = 2705,
	[CustomComboInfo("崩裂宝玉状态", "当适合的时候黄玉之辉替换崩裂/三重灾祸.", 27, 492)]
	SummonerShinyOutburstFeature = 2706,
	[CustomComboInfo("崩裂状态", "当激活的时候毁4替换崩裂/三重灾祸.", 27, 495)]
	SummonerFurtherOutburstFeature = 2707,
	[CustomComboInfo("宝石兽召唤状态", "当宝宝召唤时守护之光替换宝石兽召唤.", 27, 498)]
	SummonerCarbyFeature = 2704,
	[CustomComboInfo("暴风斩连击", "替换暴风斩为相应的连击", 21, 505)]
	WarriorStormsPathCombo = 2101,
	[CustomComboInfo("暴风碎连击", "替换暴风碎为相应的连击", 21, 508)]
	WarriorStormsEyeCombo = 2102,
	[CustomComboInfo("秘银暴风连击", "替换秘银暴风为相应的连击", 21, 511)]
	WarriorMythrilTempestCombo = 2103,
	[CustomComboInfo("超压斧循环", "替换超压斧连击 (所以你仍然可以在游戏中单独使用秘银暴风)", 21, 514)]
	WarriorOverpowerCombo = 2104,
	[CustomComboInfo("兽魂量普状态", "兽魂量普快满时暴风战连自动替换相应技能", 21, 517)]
	WarriorGaugeOvercapFeature = 2105,
	[CustomComboInfo("原初的解放状态", "原初解放状态时候用裂石飞环/地毁人亡替换相应连击", 21, 520)]
	WarriorInnerReleaseFeature = 2106,
	[CustomComboInfo("原初的勇猛状态", "同步到76以下时候原初的直觉替换原初的勇猛", 21, 523)]
	WarriorNascentFlashFeature = 2107,
	[CustomComboInfo("原初的撕裂预备状态", "Replace Inner Beast and Steel Cyclone with Primal Rend when available当激活时候原初的撕裂替换原初之魂/钢铁旋风", 21, 526)]
	WarriorPrimalRendFeature = 2108,
	[CustomComboInfo("安慰/苦难之心", "当苦难之心可以使用时，替换安慰之心为苦难之心", 24, 533)]
	WhiteMageSolaceMiseryFeature = 2401,
	[CustomComboInfo("狂喜 / 苦难之心", "当苦难之心可以使用时，替换狂喜之心为苦难之心", 24, 536)]
	WhiteMageRaptureMiseryFeature = 2402,
	[CustomComboInfo("百合状态", "当拜火满时安慰之心替换救疗，狂喜替换医治", 24, 539)]
	WhiteMageCureFeature = 2403,
	[CustomComboInfo("百合状态", "当百合满时安慰之心替换救疗，狂喜替换医治", 24, 542)]
	WhiteMageAfflatusFeature = 2404,
	[CustomComboInfo("dot状态", "当目标dot时间小于3秒时，dot替换闪耀", 24, 545)]
	WhiteStoneFeature = 2405,
	[CustomComboInfo("医济状态", "当身上医济dot时间大于5秒时，医治替换医济", 24, 548)]
	WhiteYiJiFeature = 2406
}