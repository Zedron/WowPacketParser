using System.Diagnostics.CodeAnalysis;

namespace WowPacketParser.Enums
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum DB2Hash : uint
    {
        Achievement                     = 0xD2EE2CA7, // 6.2.2.20444
        AdventureJournal                = 0x8EEF1A97, // 6.2.0.20182
        AreaGroup                       = 0xF6DB5F8B, // 6.2.0.20182
        AreaGroupMember                 = 0x09626FB2, // 6.2.0.20182
        AreaPOI                         = 0xDF3F054A, // WoD - 6.0.1
        AreaPOIState                    = 0x49EFF4C0, // WoD - 6.0.1
        AreaTriggerCylinder             = 0xAC92E4AD, // 6.2.0.20182
        AuctionHouse                    = 0xB8F96456, // 6.2.0.20182
        BarberShopStyle                 = 0x8F09B48B, // 6.2.0.20182
        BattlePetAbility                = 0xCBA43BD7,
        BattlePetAbilityEffect          = 0xDD8B690E,
        BattlePetAbilityState           = 0x3C556E43,
        BattlePetAbilityTurn            = 0xECD8ECDC,
        BattlePetBreedQuality           = 0x1B5A4EA6,
        BattlePetBreedState             = 0x6AFB3206,
        BattlePetEffectProperties       = 0x63B4C4BA,
        BattlePetNPCTeamMember          = 0xF2059DFA,
        BattlePetSpecies                = 0x6C93F9B1,
        BattlePetSpeciesState           = 0x15D87DD0,
        BattlePetSpeciesXAbility        = 0x44237314,
        BattlePetState                  = 0x8F447330,
        BattlePetVisual                 = 0xC3ADEB43,
        BroadcastText                   = 0x021826BB,
        Cfg_Categories                  = 0xC7ED797D, // WoD - 6.0.1
        Cfg_Configs                     = 0x091F6599, // WoD - 6.0.1
        Cfg_Regions                     = 0xA77E7F0D, // WoD - 6.0.1
        CharShipment                    = 0xB032B557, // WoD - 6.0.1
        CharShipmentContainer           = 0xA7894FE7, // WoD - 6.0.1
        CharStartOutfit                 = 0x7B41F581, // 6.2.0.20182
        CharacterFaceBoneSet            = 0x4D62306F, // WoD - 6.0.1
        ChatProfanity                   = 0x23F759C7, // 6.2.0.20182
        ChrClassesXPowerTypes           = 0xC0315ACF, // 6.2.0.20182
        ChrUpgradeBucket                = 0xDDBC25B7, // WoD - 6.0.1
        ChrUpgradeBucketSpell           = 0xC6426A90, // WoD - 6.0.1
        ChrUpgradeTier                  = 0x99F5DC12, // WoD - 6.0.1
        CinematicSequences              = 0x55EC00F0, // 6.2.0.20182
        CombatCondition                 = 0x15F55B6D, // 6.2.0.20182
        Creature                        = 0xC9D6B6B3,
        CreatureDifficulty              = 0xC9E0A749, // MoP - 5.4.0
        CreatureDisplayInfo             = 0xBFDAF9F1, // 6.2.0.20182
        CreatureDisplayInfoTrn          = 0xFD09B803, // 6.2.0.20182
        CreatureImmunities              = 0x211E2DEF, // 6.2.0.20182
        CreatureMovementInfo            = 0xCF156785, // 6.2.0.20182
        CreatureType                    = 0x1F80AD3F, // 6.2.0.20182
        Criteria                        = 0xEF23DC80, // 6.2.2.20444
        CriteriaTree                    = 0x4AD4429C, // 6.2.2.20444
        CurrencyCategory                = 0xD3C46981, // 6.2.0.20182
        CurrencyTypes                   = 0x2F51378E, // 6.2.0.20182
        Curve                           = 0x4BD9DF7A, // MoP - 5.4.0
        CurvePoint                      = 0x700ECA3A, // MoP - 5.4.0
        DestructibleModelData           = 0x7A74425D, // 6.2.0.20182
        DeviceBlacklist                 = 0x3A9E3494, // MoP - 5.4.2
        DeviceDefaultSettings           = 0xD007E829, // WoD - 6.0.1
        DriverBlacklist                 = 0x4F10F976, // MoP - 5.4.2
        DurabilityQuality               = 0xF7808C05, // 6.2.0.20182
        FriendshipRepReaction           = 0x13315BF9, // 6.2.0.20182
        FriendshipReputation            = 0x0DF61E79, // 6.2.0.20182
        GameObjects                     = 0x13C403A5,
        GameTables                      = 0x0053FD87, // 6.2.0.20182
        GarrAbility                     = 0xE47316B8, // WoD - 6.0.1
        GarrAbilityCategory             = 0x32D73CE8, // WoD - 6.0.1
        GarrAbilityEffect               = 0xA41CF54F, // WoD - 6.0.1
        GarrBuilding                    = 0x345B0DB7, // WoD - 6.0.1
        GarrBuildingDoodadSet           = 0x9EBC6471, // WoD - 6.0.1
        GarrBuildingPlotInst            = 0x94A9BA1E, // WoD - 6.0.1
        GarrClassSpec                   = 0x4575BF0F, // WoD - 6.0.1
        GarrEncounter                   = 0xA753AC92, // WoD - 6.0.1
        GarrEncounterXMechanic          = 0x46C53A0B, // WoD - 6.0.1
        GarrFollItemSet                 = 0x5E456D3E, // WoD - 6.0.1
        GarrFollItemSetMember           = 0x2A41D721, // WoD - 6.0.1
        GarrFollower                    = 0xA8D85D45, // WoD - 6.0.1
        GarrFollowerLevelXP             = 0xDE342443, // WoD - 6.0.1
        GarrFollowerQuality             = 0x4205184C, // WoD - 6.0.1
        GarrFollowerType                = 0xBFCD2376, // 6.2.0.20182
        GarrFollowerXAbility            = 0x914D7D9B, // WoD - 6.0.1
        GarrMechanic                    = 0x63AA03A4, // WoD - 6.0.1
        GarrMechanicType                = 0xA91F6CA8, // WoD - 6.0.1
        GarrMission                     = 0x0DF5FA28, // WoD - 6.0.1
        GarrMissionReward               = 0x8584C1F2, // WoD - 6.0.1
        GarrMissionTexture              = 0x37FC4173, // 6.2.0.20182
        GarrMissionType                 = 0xD8D9D218, // WoD - 6.0.1
        GarrMissionXEncounter           = 0x6294C01F, // WoD - 6.0.1
        GarrMssnBonusAbility            = 0xC3369DE5, // 6.2.0.20182
        GarrPlot                        = 0x2CD8C002, // WoD - 6.0.1
        GarrPlotBuilding                = 0x73F2572B, // WoD - 6.0.1
        GarrPlotInstance                = 0xF3F86C96, // WoD - 6.0.1
        GarrPlotUICategory              = 0x0FC6FEC6, // WoD - 6.0.1
        GarrSiteLevel                   = 0x22C7158E, // WoD - 6.0.1
        GarrSiteLevelPlotInst           = 0x69B2A3AC, // WoD - 6.0.1
        GarrSpecialization              = 0x1EE674BD, // WoD - 6.0.1
        GlyphExclusiveCategory          = 0xE122AC03, // WoD - 6.0.1
        GlyphRequiredSpec               = 0x8E304E55, // WoD - 6.0.1
        GlyphSlot                       = 0x161B1DE4, // 6.2.0.20182
        GroupFinderActivity             = 0xAF32E8CA, // WoD - 6.0.1
        GroupFinderActivityGrp          = 0x357024D6, // WoD - 6.0.1
        GroupFinderCategory             = 0x2FE6EF1A, // WoD - 6.0.1
        GuildPerkSpells                 = 0x01956414, // 6.2.0.20182
        Heirloom                        = 0x2E7BAFAE, // 6.2.0.20182
        HighlightColor                  = 0x52191C0A, // WoD - 6.0.1
        HolidayDescriptions             = 0x2927A4BF, // WoD - 6.0.1
        HolidayNames                    = 0x5499185A, // WoD - 6.0.1
        Holidays                        = 0x758E7BCC, // WoD - 6.0.1
        ImportPriceArmor                = 0x3E372864, // 6.2.0.20182
        ImportPriceQuality              = 0x3C615C13, // 6.2.0.20182
        ImportPriceShield               = 0x2BDE6A98, // 6.2.0.20182
        ImportPriceWeapon               = 0x976C8F98, // 6.2.0.20182
        Item                            = 0x50238EC2,
        ItemAppearance                  = 0x42261B89, // WoD - 6.0.1
        ItemBonus                       = 0x8318900A, // WoD - 6.0.1
        ItemBonusTreeNode               = 0xA67E0631, // WoD - 6.0.1
        ItemClass                       = 0xB977271E, // 6.2.0.20182
        ItemCurrencyCost                = 0x6FE05AE9,
        ItemDisenchantLoot              = 0x66A4506E, // 6.2.0.20182
        ItemEffect                      = 0x4002A5B1, // WoD - 6.0.1
        ItemExtendedCost                = 0xBB858355,
        ItemLimitCategory               = 0x7BBA1EB1, // 6.2.0.20182
        ItemModifiedAppearance          = 0xE491AC55, // WoD - 6.0.1
        ItemPriceBase                   = 0x2DE09E95, // 6.2.0.20182
        ItemRandomProperties            = 0x04BD338F, // 6.2.0.20182
        ItemRandomSuffix                = 0xE6811147, // 6.2.0.20182
        ItemSpec                        = 0x08DA6E2A, // 6.2.0.20182
        ItemSpecOverride                = 0x149AAE79, // 6.2.0.20182
        ItemToBattlePet                 = 0x5D2EF1A8, // MoP - 5.4.2 (replaced by ItemToBattlePetSpecies in WoD)
        ItemToBattlePetSpecies          = 0x7185589B, // WoD - 6.0.1
        ItemToMountSpell                = 0x55DE4AC0, // MoP - 5.4.2
        ItemUpgrade                     = 0x7006463B,
        ItemXBonusTree                  = 0x325582EA, // WoD - 6.0.1
        Item_sparse                     = 0x919BE54E,
        JournalEncounter                = 0x57382070, // 6.2.0.20182
        JournalEncounterSection         = 0x7956786C, // 6.2.0.20182
        JournalEncounterXDifficulty     = 0xA83B4856, // 6.2.0.20182
        JournalInstance                 = 0x713E1C99, // 6.2.0.20182
        JournalSectionXDifficulty       = 0x0B051170, // 6.2.0.20182
        KeyChain                        = 0x6D8A2694,
        LanguageWords                   = 0xE849437C, // WoD - 6.0.1
        Languages                       = 0xF3D3E512, // 6.2.0.20182
        LfgDungeonGroup                 = 0x23F64598, // 6.2.0.20182
        LfgRoleRequirement              = 0x7187CA05, // WoD - 6.0.1
        Locale                          = 0x3F85ABB7,
        Location                        = 0x394C3727,
        LookAtController                = 0x5D20CF07, // 6.2.0.20182
        MailTemplate                    = 0xE3C5B7D1, // 6.2.0.20182
        MapChallengeMode                = 0x383B4C27,
        MarketingPromotionsXLocale      = 0xA1D3F1AD,
        ModelManifest                   = 0xC6253ECC, // WoD - 6.0.1
        ModelNameToManifest             = 0x730F0635, // WoD - 6.0.1
        ModifierTree                    = 0x7E692D56, // 6.2.2.20444
        Mount                           = 0x96737A41, // WoD - 6.0.1
        MountCapability                 = 0xF66E0076, // 6.2.0.20182
        MountType                       = 0xC5B875A8, // 6.2.0.20182
        MountTypeXCapability            = 0x28D9DEA9, // 6.2.0.20182
        NameGen                         = 0xF5FA849B, // 6.2.0.20182
        NamesProfanity                  = 0xDA82D96C, // 6.2.0.20182
        NamesReserved                   = 0x25C1CB13, // 6.2.0.20182
        NamesReservedLocale             = 0x3ACAE305, // 6.2.0.20182
        ObjectEffect                    = 0x67660235, // 6.2.0.20182
        ObjectEffectGroup               = 0x4C6EBA83, // 6.2.0.20182
        ObjectEffectModifier            = 0x62C90BAB, // 6.2.0.20182
        ObjectEffectPackage             = 0x5E3E8F24, // 6.2.0.20182
        ObjectEffectPackageElem         = 0xCB2273C2, // 6.2.0.20182
        OverrideSpellData               = 0xCA75DF1C, // WoD - 6.0.1
        PaperDollItemFrame              = 0xADDB889C, // 6.2.2.20444
        Path                            = 0x94F46395,
        PathNode                        = 0x3B9E4CA2,
        PathNodeProperty                = 0xFE21C024,
        PathProperty                    = 0x08E54F60,
        PhaseXPhaseGroup                = 0x25CC2A59, // WoD - 6.0.1
        PlayerCondition                 = 0xB94C2807, // WoD - 6.0.1
        PvpItem                         = 0xF996FA59, // WoD - 6.0.1
        QuestInfo                       = 0x2D11D732, // 6.2.0.20182
        QuestLine                       = 0xEB57A423, // WoD - 6.0.1
        QuestLineXQuest                 = 0x8CC17856, // WoD - 6.0.1
        QuestMoneyReward                = 0xCF096091, // 6.2.0.20182
        QuestObjective                  = 0x01325CA0, // 6.2.2.20444
        QuestObjectiveCliTask           = 0x9EE75AFD, // WoD - 6.0.1
        QuestPOIBlob                    = 0xAE1CA308, // 6.2.2.20444
        QuestPOIPoint                   = 0x83467FEB, // 6.2.2.20444
        QuestPOIPointCliTask            = 0x8FCA1265, // WoD - 6.0.1
        QuestPackageItem                = 0xCC2F84F0,
        QuestSort                       = 0x5479CB09, // 6.2.0.20182
        QuestV2                         = 0x3AC83109, // 6.2.0.20182
        QuestV2CliTask                  = 0x0F992211, // WoD - 6.0.1
        QuestXP                         = 0x3D89A572, // 6.2.0.20182
        RacialMounts                    = 0x426026C2, // 6.2.0.20182
        ResearchBranch                  = 0x420F9A85, // 6.2.0.20182
        ResearchField                   = 0xDDE2C5CF, // 6.2.0.20182
        ResearchProject                 = 0x81560FC3, // 6.2.0.20182
        ResearchSite                    = 0x9C31AE60, // 6.2.0.20182
        Resistances                     = 0x91BB4526, // 6.2.0.20182
        RulesetItemUpgrade              = 0x6DB7086C,
        RulesetRaidLootUpgrade          = 0xED1FBB4D,
        RulesetRaidOverride             = 0x9B5F2FA2, // 6.2.0.20182
        ScalingStatDistribution         = 0x45D2FA27, // 6.2.0.20182
        Scenario                        = 0x830F3A66, // 6.2.0.20182
        ScenarioEventEntry              = 0xC194468C, // 6.2.0.20182
        SceneScript                     = 0xD4B163CC,
        SceneScriptPackage              = 0xE8CB5E09,
        SceneScriptPackageMember        = 0xE44DB71C,
        SoundEmitterPillPoints          = 0xD8A1D70C, // 6.2.0.20182
        SoundEmitters                   = 0xC638B8D4, // 6.2.0.20182
        SoundEntries                    = 0xFA661215, // 6.2.0.20182
        SoundEntriesAdvanced            = 0xAC33039E, // 6.2.0.20182
        SpamMessages                    = 0x91AB8126, // 6.2.0.20182
        SpecializationSpells            = 0x4FBA0E5C, // 6.2.0.20182
        SpellActionBarPref              = 0x84B0BDD7, // WoD - 6.0.1
        SpellAuraRestrictions           = 0xBA978F4E, // WoD - 6.0.1
        SpellAuraRestrictionsDifficulty = 0xF9DD616B, // WoD - 6.0.1
        SpellCastTimes                  = 0xFDBA5A66, // 6.2.0.20182
        SpellCastingRequirements        = 0x61025756, // WoD - 6.0.1
        SpellClassOptions               = 0x288EAB81, // WoD - 6.0.1
        SpellDispelType                 = 0x2B7C0063, // 6.2.0.20182
        SpellDuration                   = 0xB423FA7A, // 6.2.0.20182
        SpellEffectCameraShakes         = 0x73985069, // MoP - 5.4.0
        SpellEffectGroupSize            = 0x23BF7E10, // WoD - 6.0.1
        SpellFlyout                     = 0xB4BC3BE6, // 6.2.0.20182
        SpellFlyoutItem                 = 0xD0BEE46B, // 6.2.0.20182
        SpellItemEnchantmentCondition   = 0xF9513930, // 6.2.0.20182
        SpellKeyboundOverride           = 0xD4B64DCD, // 6.2.0.20182
        SpellLearnSpell                 = 0xDBEDF603, // WoD - 6.0.1
        SpellMechanic                   = 0x726D2B3E, // WoD - 6.0.1
        SpellMisc                       = 0xC603EE28, // WoD - 6.0.1
        SpellMiscDifficulty             = 0x7FC0A695, // WoD - 6.0.1
        SpellMissile                    = 0x688F7A07, // MoP - 5.4.0
        SpellMissileMotion              = 0x37717679, // MoP - 5.4.0
        SpellPower                      = 0xA1ACE1DF, // WoD - 6.0.1
        SpellPowerDifficulty            = 0x7EA08450, // WoD - 6.0.1
        SpellProcsPerMinute             = 0xD0768C6C, // 6.2.0.20182
        SpellProcsPerMinuteMod          = 0xEB24B92C, // 6.2.0.20182
        SpellRadius                     = 0xAB7E4841, // 6.2.0.20182
        SpellRange                      = 0xE051A69C, // 6.2.0.20182
        SpellReagents                   = 0xAB66C99F, // MoP - 5.2.0
        SpellReagentsCurrency           = 0x2049B60C, // 6.2.0.20182
        SpellRuneCost                   = 0x1A27961E, // WoD - 6.0.1
        SpellTotems                     = 0xA50F8A31, // WoD
        SpellVisual                     = 0xF72496D9, // MoP - 5.4.0
        SpellVisualColorEffect          = 0x58E72946, // 6.2.0.20182
        SpellVisualEffectName           = 0x02E18F32, // MoP - 5.4.0
        SpellVisualKit                  = 0xF483EADB, // MoP - 5.4.0
        SpellVisualKitAreaModel         = 0x208AB51D, // MoP - 5.4.0
        SpellVisualKitModelAttach       = 0xF07194C3, // MoP - 5.4.0
        SpellVisualMissile              = 0x51A28350, // MoP - 5.4.0
        SpellXSpellVisual               = 0x27B7A01A, // WoD
        Stationery                      = 0xAF0DC253, // 6.2.0.20182
        StringLookups                   = 0x4A5D42EB, // 6.2.2.20444
        TaxiNodes                       = 0x50D91A78, // WoD - 6.0.1
        TaxiPath                        = 0xAB30A45C, // WoD - 6.0.1
        TaxiPathNode                    = 0xE5E988BC, // WoD - 6.0.1
        TextureFileData                 = 0x1A473014, // WoD - 6.0.1
        TotemCategory                   = 0xA7A2F29A, // 6.2.0.20182
        Toy                             = 0x7B03245C, // WoD - 6.0.1
        TransportAnimation              = 0x6B9AEBE5, // 6.2.0.20182
        TransportPhysics                = 0xD04684DD, // 6.2.0.20182
        TransportRotation               = 0x9645753D, // 6.2.0.20182
        Trophy                          = 0xF13B375C, // WoD - 6.0.1
        TrophyInstance                  = 0x65C9EA50, // WoD - 6.0.1
        TrophyType                      = 0x6F7681CB, // WoD - 6.0.1
        UiTextureAtlas                  = 0x894D3B63, // WoD - 6.0.1
        UiTextureAtlasMember            = 0xB5307A56, // WoD - 6.0.1
        UiTextureKit                    = 0x15EC48BB, // WoD - 6.0.1
        UnitCondition                   = 0x0E540EFD, // 6.2.0.20182
        UnitPowerBar                    = 0x4541CDC7, // 6.2.0.20182
        Vignette                        = 0xEFB13552, // MoP - 5.4.0
        WbAccessControlList             = 0x580B4EF3, // MoP - 5.3.0
        WbCertBlacklist                 = 0xCDAB90DF, // MoP - 5.3.0
        WbCertWhitelist                 = 0x885585BD, // MoP - 5.3.0
        WbPermissions                   = 0xF827ECFB, // MoP - 5.3.0
        WeaponTrail                     = 0xA42476ED, // WoD - 6.0.1
        WindSettings                    = 0x72B25981, // WoD - 6.0.1
        WorldBossLockout                = 0xF416A54C, // WoD - 6.0.1
        WorldElapsedTimer               = 0xC7A973A1, // 6.2.2.20444
        WorldMapOverlay                 = 0x1D740E72  // 6.2.2.20444
    }
}
