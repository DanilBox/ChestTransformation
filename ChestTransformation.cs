using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChestTransformation
{
    public class ChestTransformation : Mod
    {
        private static readonly string ChestGroupName = "ChestTransformation:AnyChest";

        private static readonly int[] ChestIDs =
        [
            ItemID.GoldChest,
            ItemID.ShadowChest,
            ItemID.EbonwoodChest,
            ItemID.RichMahoganyChest,
            ItemID.PearlwoodChest,
            ItemID.IvyChest,
            ItemID.IceChest,
            ItemID.LivingWoodChest,
            ItemID.SkywareChest,
            ItemID.ShadewoodChest,
            ItemID.WebCoveredChest,
            ItemID.LihzahrdChest,
            ItemID.WaterChest,
            ItemID.JungleChest,
            ItemID.CorruptionChest,
            ItemID.CrimsonChest,
            ItemID.HallowedChest,
            ItemID.FrozenChest,
            ItemID.DynastyChest,
            ItemID.HoneyChest,
            ItemID.SteampunkChest,
            ItemID.PalmWoodChest,
            ItemID.MushroomChest,
            ItemID.BorealWoodChest,
            ItemID.SlimeChest,
            ItemID.GreenDungeonChest,
            ItemID.PinkDungeonChest,
            ItemID.BlueDungeonChest,
            ItemID.BoneChest,
            ItemID.CactusChest,
            ItemID.FleshChest,
            ItemID.ObsidianChest,
            ItemID.PumpkinChest,
            ItemID.SpookyChest,
            ItemID.GlassChest,
            ItemID.MartianChest,
            ItemID.GraniteChest,
            ItemID.MeteoriteChest,
            ItemID.MarbleChest
        ];

        public override void AddRecipeGroups()
        {
            RecipeGroup chestGroup = new RecipeGroup(
                () => $"{Lang.misc[37]} Chest",
                ChestIDs
            );
            RecipeGroup.RegisterGroup(ChestGroupName, chestGroup);
        }

        public override void AddRecipes()
        {
            Recipe.Create(ItemID.Chest)
                .AddRecipeGroup(ChestGroupName)
                .Register();
        }
    }
}
