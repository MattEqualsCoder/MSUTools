using YamlDotNet.Serialization;

namespace MSUYamlValidator;

public class MSUTrackList
{
    [YamlMember(Alias = "zelda_title")]
    [TrackNumber(ZeldaFirst = 1, MetroidFirst = 101)]
    public MSUTrackConfig? ZeldaTitle { get; set; }
    
    [YamlMember(Alias = "light_world")]
    [TrackNumber(ZeldaFirst = 2, MetroidFirst = 102)]
    public MSUTrackConfig? LightWorld { get; set; }
    
    [YamlMember(Alias = "rainy_intro")]
    [TrackNumber(ZeldaFirst = 3, MetroidFirst = 103)]
    public MSUTrackConfig? RainyIntro { get; set; }
    
    [YamlMember(Alias = "bunny_theme")]
    [TrackNumber(ZeldaFirst = 4, MetroidFirst = 104)]
    public MSUTrackConfig? BunnyTheme { get; set; }
    
    [YamlMember(Alias = "lost_woods")]
    [TrackNumber(ZeldaFirst = 5, MetroidFirst = 105)]
    public MSUTrackConfig? LostWoods { get; set; }
    
    [YamlMember(Alias = "prologue")]
    [TrackNumber(ZeldaFirst = 6, MetroidFirst = 106)]
    public MSUTrackConfig? Prologue { get; set; }
    
    [YamlMember(Alias = "kakariko")]
    [TrackNumber(ZeldaFirst = 7, MetroidFirst = 107)]
    public MSUTrackConfig? Kakariko { get; set; }
    
    [YamlMember(Alias = "mirror")]
    [TrackNumber(ZeldaFirst = 8, MetroidFirst = 108)]
    public MSUTrackConfig? Mirror { get; set; }
    
    [YamlMember(Alias = "dark_world")]
    [TrackNumber(ZeldaFirst = 9, MetroidFirst = 109)]
    public MSUTrackConfig? DarkWorld { get; set; }
    
    [YamlMember(Alias = "pedestal_pull")]
    [TrackNumber(ZeldaFirst = 10, MetroidFirst = 110)]
    public MSUTrackConfig? PedestalPull { get; set; }
    
    [YamlMember(Alias = "zelda_game_over")]
    [TrackNumber(ZeldaFirst = 11, MetroidFirst = 111)]
    public MSUTrackConfig? ZeldaGameOver { get; set; }
    
    [YamlMember(Alias = "guards")]
    [TrackNumber(ZeldaFirst = 12, MetroidFirst = 112)]
    public MSUTrackConfig? Guards { get; set; }
    
    [YamlMember(Alias = "dark_death_mountain")]
    [TrackNumber(ZeldaFirst = 13, MetroidFirst = 113)]
    public MSUTrackConfig? DarkDeathMountain { get; set; }
    
    [YamlMember(Alias = "minigame")]
    [TrackNumber(ZeldaFirst = 14, MetroidFirst = 114)]
    public MSUTrackConfig? Minigame { get; set; }
    
    [YamlMember(Alias = "dark_woods")]
    [TrackNumber(ZeldaFirst = 15, MetroidFirst = 115)]
    public MSUTrackConfig? DarkWoods { get; set; }
    
    [YamlMember(Alias = "hyrule_castle")]
    [TrackNumber(ZeldaFirst = 16, MetroidFirst = 116)]
    public MSUTrackConfig? HyruleCastle { get; set; }
    
    [YamlMember(Alias = "pendant_dungeon")]
    [TrackNumber(ZeldaFirst = 17, MetroidFirst = 117)]
    public MSUTrackConfig? PendantDungeon { get; set; }
    
    [YamlMember(Alias = "cave_1")]
    [TrackNumber(ZeldaFirst = 18, MetroidFirst = 118)]
    public MSUTrackConfig? Cave1 { get; set; }
    
    [YamlMember(Alias = "boss_victory")]
    [TrackNumber(ZeldaFirst = 19, MetroidFirst = 119)]
    public MSUTrackConfig? BossVictory { get; set; }
    
    [YamlMember(Alias = "sanctuary")]
    [TrackNumber(ZeldaFirst = 20, MetroidFirst = 120)]
    public MSUTrackConfig? Sanctuary { get; set; }
    
    [YamlMember(Alias = "zelda_boss_battle")]
    [TrackNumber(ZeldaFirst = 21, MetroidFirst = 121)]
    public MSUTrackConfig? ZeldaBossBattle { get; set; }
    
    [YamlMember(Alias = "crystal_dungeon")]
    [TrackNumber(ZeldaFirst = 22, MetroidFirst = 122)]
    public MSUTrackConfig? CrystalDungeon { get; set; }
    
    [YamlMember(Alias = "shop")]
    [TrackNumber(ZeldaFirst = 23, MetroidFirst = 123)]
    public MSUTrackConfig? Shop { get; set; }
    
    [YamlMember(Alias = "cave_2")]
    [TrackNumber(ZeldaFirst = 24, MetroidFirst = 124)]
    public MSUTrackConfig? Cave2 { get; set; }
    
    [YamlMember(Alias = "zelda_rescued")]
    [TrackNumber(ZeldaFirst = 25, MetroidFirst = 125)]
    public MSUTrackConfig? ZeldaRescued { get; set; }
    
    [YamlMember(Alias = "crystal_retrieved")]
    [TrackNumber(ZeldaFirst = 26, MetroidFirst = 126)]
    public MSUTrackConfig? CrystalRetrieved { get; set; }
    
    [YamlMember(Alias = "fairy")]
    [TrackNumber(ZeldaFirst = 27, MetroidFirst = 127)]
    public MSUTrackConfig? Fairy { get; set; }
    
    [YamlMember(Alias = "agahnims_floor")]
    [TrackNumber(ZeldaFirst = 28, MetroidFirst = 128)]
    public MSUTrackConfig? AgahnimsFloor { get; set; }
    
    [YamlMember(Alias = "ganon_reveal")]
    [TrackNumber(ZeldaFirst = 29, MetroidFirst = 129)]
    public MSUTrackConfig? GanonReveal { get; set; }
    
    [YamlMember(Alias = "ganons_message")]
    [TrackNumber(ZeldaFirst = 30, MetroidFirst = 130)]
    public MSUTrackConfig? GanonsMessage { get; set; }
    
    [YamlMember(Alias = "ganon_battle")]
    [TrackNumber(ZeldaFirst = 31, MetroidFirst = 131)]
    public MSUTrackConfig? GanonBattle { get; set; }
    
    [YamlMember(Alias = "triforce_room")]
    [TrackNumber(ZeldaFirst = 32, MetroidFirst = 132)]
    public MSUTrackConfig? TriforceRoom { get; set; }
    
    [YamlMember(Alias = "epilogue")]
    [TrackNumber(ZeldaFirst = 33, MetroidFirst = 133)]
    public MSUTrackConfig? Epilogue { get; set; }
    
    [YamlMember(Alias = "zelda_credits")]
    [TrackNumber(ZeldaFirst = 34, MetroidFirst = 134)]
    public MSUTrackConfig? ZeldaCredits { get; set; }
    
    [YamlMember(Alias = "eastern_palace")]
    [TrackNumber(ZeldaFirst = 35, MetroidFirst = 135)]
    public MSUTrackConfig? EasternPalace { get; set; }
    
    [YamlMember(Alias = "desert_palace")]
    [TrackNumber(ZeldaFirst = 36, MetroidFirst = 136)]
    public MSUTrackConfig? DesertPalace { get; set; }
    
    [YamlMember(Alias = "agahnims_tower")]
    [TrackNumber(ZeldaFirst = 37, MetroidFirst = 137)]
    public MSUTrackConfig? AgahnimsTower { get; set; }
    
    [YamlMember(Alias = "swamp_palace")]
    [TrackNumber(ZeldaFirst = 38, MetroidFirst = 138)]
    public MSUTrackConfig? SwampPalace { get; set; }
    
    [YamlMember(Alias = "palace_of_darkness")]
    [TrackNumber(ZeldaFirst = 39, MetroidFirst = 139)]
    public MSUTrackConfig? PalaceOfDarkness { get; set; }
    
    [YamlMember(Alias = "misery_mire")]
    [TrackNumber(ZeldaFirst = 40, MetroidFirst = 140)]
    public MSUTrackConfig? MiseryMire { get; set; }
    
    [YamlMember(Alias = "skull_woods")]
    [TrackNumber(ZeldaFirst = 41, MetroidFirst = 141)]
    public MSUTrackConfig? SkullWoods { get; set; }
    
    [YamlMember(Alias = "ice_palace")]
    [TrackNumber(ZeldaFirst = 42, MetroidFirst = 142)]
    public MSUTrackConfig? IcePalace { get; set; }
    
    [YamlMember(Alias = "tower_of_hera")]
    [TrackNumber(ZeldaFirst = 43, MetroidFirst = 143)]
    public MSUTrackConfig? TowerOfHera { get; set; }
    
    [YamlMember(Alias = "thieves_town")]
    [TrackNumber(ZeldaFirst = 44, MetroidFirst = 144)]
    public MSUTrackConfig? ThievesTown { get; set; }
    
    [YamlMember(Alias = "turtle_rock")]
    [TrackNumber(ZeldaFirst = 45, MetroidFirst = 145)]
    public MSUTrackConfig? TurtleRock { get; set; }
    
    [YamlMember(Alias = "ganons_tower")]
    [TrackNumber(ZeldaFirst = 46, MetroidFirst = 146)]
    public MSUTrackConfig? GanonsTower { get; set; }
    
    [YamlMember(Alias = "armos_knights")]
    [TrackNumber(ZeldaFirst = 47, MetroidFirst = 147)]
    public MSUTrackConfig? ArmosKnights { get; set; }
    
    [YamlMember(Alias = "lanmolas")]
    [TrackNumber(ZeldaFirst = 48, MetroidFirst = 148)]
    public MSUTrackConfig? Lanmolas { get; set; }
    
    [YamlMember(Alias = "agahnim_1")]
    [TrackNumber(ZeldaFirst = 49, MetroidFirst = 149)]
    public MSUTrackConfig? Agahnim1 { get; set; }
    
    [YamlMember(Alias = "arrghus")]
    [TrackNumber(ZeldaFirst = 50, MetroidFirst = 150)]
    public MSUTrackConfig? Arrghus { get; set; }
    
    [YamlMember(Alias = "helmasaur_king")]
    [TrackNumber(ZeldaFirst = 51, MetroidFirst = 151)]
    public MSUTrackConfig? HelmasaurKing { get; set; }
    
    [YamlMember(Alias = "vitreous")]
    [TrackNumber(ZeldaFirst = 52, MetroidFirst = 152)]
    public MSUTrackConfig? Vitreous { get; set; }
    
    [YamlMember(Alias = "mothula")]
    [TrackNumber(ZeldaFirst = 53, MetroidFirst = 153)]
    public MSUTrackConfig? Mothula { get; set; }
    
    [YamlMember(Alias = "kholdstare")]
    [TrackNumber(ZeldaFirst = 54, MetroidFirst = 154)]
    public MSUTrackConfig? Kholdstare { get; set; }
    
    [YamlMember(Alias = "moldorm")]
    [TrackNumber(ZeldaFirst = 55, MetroidFirst = 155)]
    public MSUTrackConfig? Moldorm { get; set; }
    
    [YamlMember(Alias = "blind")]
    [TrackNumber(ZeldaFirst = 56, MetroidFirst = 156)]
    public MSUTrackConfig? Blind { get; set; }
    
    [YamlMember(Alias = "trinexx")]
    [TrackNumber(ZeldaFirst = 57, MetroidFirst = 157)]
    public MSUTrackConfig? Trinexx { get; set; }
    
    [YamlMember(Alias = "agahnim_2")]
    [TrackNumber(ZeldaFirst = 58, MetroidFirst = 158)]
    public MSUTrackConfig? Agahnim2 { get; set; }
    
    [YamlMember(Alias = "ganons_tower_climb")]
    [TrackNumber(ZeldaFirst = 59, MetroidFirst = 159)]
    public MSUTrackConfig? GanonsTowerClimb { get; set; }
    
    [YamlMember(Alias = "light_world_2")]
    [TrackNumber(ZeldaFirst = 60, MetroidFirst = 160)]
    public MSUTrackConfig? LightWorld2 { get; set; }
    
    [YamlMember(Alias = "dark_world_2")]
    [TrackNumber(ZeldaFirst = 61, MetroidFirst = 161)]
    public MSUTrackConfig? DarkWorld2 { get; set; }
    
    [YamlMember(Alias = "smz3_credits")]
    [TrackNumber(ZeldaFirst = 99, MetroidFirst = 99)]
    public MSUTrackConfig? Smz3Credits { get; set; }
    
    [YamlMember(Alias = "samus_fanfare")]
    [TrackNumber(ZeldaFirst = 101, MetroidFirst = 1)]
    public MSUTrackConfig? SamusFanfare { get; set; }
    
    [YamlMember(Alias = "item_acquired")]
    [TrackNumber(ZeldaFirst = 102, MetroidFirst = 2)]
    public MSUTrackConfig? ItemAcquired { get; set; }
    
    [YamlMember(Alias = "item_room")]
    [TrackNumber(ZeldaFirst = 103, MetroidFirst = 3)]
    public MSUTrackConfig? ItemRoom { get; set; }
    
    [YamlMember(Alias = "metroid_opening_with_intro")]
    [TrackNumber(ZeldaFirst = 104, MetroidFirst = 4)]
    public MSUTrackConfig? MetroidOpeningWithIntro { get; set; }
    
    [YamlMember(Alias = "metroid_opening_without_intro")]
    [TrackNumber(ZeldaFirst = 105, MetroidFirst = 5)]
    public MSUTrackConfig? MetroidOpeningWithoutIntro { get; set; }
    
    [YamlMember(Alias = "crateria_landing_with_thunder")]
    [TrackNumber(ZeldaFirst = 106, MetroidFirst = 6)]
    public MSUTrackConfig? CrateriaLandingWithThunder { get; set; }
    
    [YamlMember(Alias = "crateria_landing_without_thunder")]
    [TrackNumber(ZeldaFirst = 107, MetroidFirst = 7)]
    public MSUTrackConfig? CrateriaLandingWithoutThunder { get; set; }
    
    [YamlMember(Alias = "crateria_space_pirates_appear")]
    [TrackNumber(ZeldaFirst = 108, MetroidFirst = 8)]
    public MSUTrackConfig? CrateriaSpacePiratesAppear { get; set; }
    
    [YamlMember(Alias = "golden_statues")]
    [TrackNumber(ZeldaFirst = 109, MetroidFirst = 9)]
    public MSUTrackConfig? GoldenStatues { get; set; }
    
    [YamlMember(Alias = "samus_aran_theme")]
    [TrackNumber(ZeldaFirst = 110, MetroidFirst = 10)]
    public MSUTrackConfig? SamusAranTheme { get; set; }
    
    [YamlMember(Alias = "green_brinstar")]
    [TrackNumber(ZeldaFirst = 111, MetroidFirst = 11)]
    public MSUTrackConfig? GreenBrinstar { get; set; }
    
    [YamlMember(Alias = "red_brinstar")]
    [TrackNumber(ZeldaFirst = 112, MetroidFirst = 12)]
    public MSUTrackConfig? RedBrinstar { get; set; }
    
    [YamlMember(Alias = "upper_norfair")]
    [TrackNumber(ZeldaFirst = 113, MetroidFirst = 13)]
    public MSUTrackConfig? UpperNorfair { get; set; }
    
    [YamlMember(Alias = "lower_norfair")]
    [TrackNumber(ZeldaFirst = 114, MetroidFirst = 14)]
    public MSUTrackConfig? LowerNorfair { get; set; }
    
    [YamlMember(Alias = "inner_maridia")]
    [TrackNumber(ZeldaFirst = 115, MetroidFirst = 15)]
    public MSUTrackConfig? InnerMaridia { get; set; }
    
    [YamlMember(Alias = "outer_maridia")]
    [TrackNumber(ZeldaFirst = 116, MetroidFirst = 16)]
    public MSUTrackConfig? OuterMaridia { get; set; }
    
    [YamlMember(Alias = "tourian")]
    [TrackNumber(ZeldaFirst = 117, MetroidFirst = 17)]
    public MSUTrackConfig? Tourian { get; set; }
    
    [YamlMember(Alias = "mother_brain_battle")]
    [TrackNumber(ZeldaFirst = 118, MetroidFirst = 18)]
    public MSUTrackConfig? MotherBrainBattle { get; set; }
    
    [YamlMember(Alias = "big_boss_battle_1")]
    [TrackNumber(ZeldaFirst = 119, MetroidFirst = 19)]
    public MSUTrackConfig? BigBossBattle1 { get; set; }
    
    [YamlMember(Alias = "evacuation")]
    [TrackNumber(ZeldaFirst = 120, MetroidFirst = 20)]
    public MSUTrackConfig? Evacuation { get; set; }
    
    [YamlMember(Alias = "chozo_statue_awakens")]
    [TrackNumber(ZeldaFirst = 121, MetroidFirst = 21)]
    public MSUTrackConfig? ChozoStatueAwakens { get; set; }
    
    [YamlMember(Alias = "big_boss_battle_2")]
    [TrackNumber(ZeldaFirst = 122, MetroidFirst = 22)]
    public MSUTrackConfig? BigBossBattle2 { get; set; }
    
    [YamlMember(Alias = "tension")]
    [TrackNumber(ZeldaFirst = 123, MetroidFirst = 23)]
    public MSUTrackConfig? Tension { get; set; }
    
    [YamlMember(Alias = "plant_miniboss")]
    [TrackNumber(ZeldaFirst = 124, MetroidFirst = 24)]
    public MSUTrackConfig? PlantMiniboss { get; set; }
    
    [YamlMember(Alias = "ceres_station")]
    [TrackNumber(ZeldaFirst = 125, MetroidFirst = 25)]
    public MSUTrackConfig? CeresStation { get; set; }
    
    [YamlMember(Alias = "wrecked_ship_powered_off")]
    [TrackNumber(ZeldaFirst = 126, MetroidFirst = 26)]
    public MSUTrackConfig? WreckedShipPoweredOff { get; set; }
    
    [YamlMember(Alias = "wrecked_ship_powered_on")]
    [TrackNumber(ZeldaFirst = 127, MetroidFirst = 27)]
    public MSUTrackConfig? WreckedShipPoweredOn { get; set; }
    
    [YamlMember(Alias = "theme_of_super_metroid")]
    [TrackNumber(ZeldaFirst = 128, MetroidFirst = 28)]
    public MSUTrackConfig? ThemeOfSuperMetroid { get; set; }
    
    [YamlMember(Alias = "death_cry")]
    [TrackNumber(ZeldaFirst = 129, MetroidFirst = 29)]
    public MSUTrackConfig? DeathCry { get; set; }
    
    [YamlMember(Alias = "metroid_credits")]
    [TrackNumber(ZeldaFirst = 130, MetroidFirst = 30)]
    public MSUTrackConfig? MetroidCredits { get; set; }
    
    [YamlMember(Alias = "kraid_incoming")]
    [TrackNumber(ZeldaFirst = 131, MetroidFirst = 31)]
    public MSUTrackConfig? KraidIncoming { get; set; }
    
    [YamlMember(Alias = "kraid_battle")]
    [TrackNumber(ZeldaFirst = 132, MetroidFirst = 32)]
    public MSUTrackConfig? KraidBattle { get; set; }
    
    [YamlMember(Alias = "phantoon_incoming")]
    [TrackNumber(ZeldaFirst = 133, MetroidFirst = 33)]
    public MSUTrackConfig? PhantoonIncoming { get; set; }
    
    [YamlMember(Alias = "phantoon_battle")]
    [TrackNumber(ZeldaFirst = 134, MetroidFirst = 34)]
    public MSUTrackConfig? PhantoonBattle { get; set; }
    
    [YamlMember(Alias = "draygon_battle")]
    [TrackNumber(ZeldaFirst = 135, MetroidFirst = 35)]
    public MSUTrackConfig? DraygonBattle { get; set; }
    
    [YamlMember(Alias = "ridley_battle")]
    [TrackNumber(ZeldaFirst = 136, MetroidFirst = 36)]
    public MSUTrackConfig? RidleyBattle { get; set; }
    
    [YamlMember(Alias = "baby_incoming")]
    [TrackNumber(ZeldaFirst = 137, MetroidFirst = 37)]
    public MSUTrackConfig? BabyIncoming { get; set; }
    
    [YamlMember(Alias = "the_baby")]
    [TrackNumber(ZeldaFirst = 138, MetroidFirst = 38)]
    public MSUTrackConfig? TheBaby { get; set; }
    
    [YamlMember(Alias = "hyper_beam")]
    [TrackNumber(ZeldaFirst = 139, MetroidFirst = 39)]
    public MSUTrackConfig? HyperBeam { get; set; }
    
    [YamlMember(Alias = "metroid_game_over")]
    [TrackNumber(ZeldaFirst = 140, MetroidFirst = 40)]
    public MSUTrackConfig? MetroidGameOver { get; set; }
    
}