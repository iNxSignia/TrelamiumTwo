using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TrelamiumTwo.Common.Items;

namespace TrelamiumTwo.Content.Items.Tools.Shovels
{
    public class CrimtaneShovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skullduggery");
            Tooltip.SetDefault("Able to mine Hellstone");
        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 12;
            item.useTime = 23;
            item.useAnimation = 23;
            item.rare = ItemRarityID.Blue;
            DiggingPower(73);

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;

            item.value = Item.sellPrice(silver: 8, copper: 25);
            item.useTurn = true;

            item.UseSound = SoundID.Item18;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe.AddIngredient(ItemID.TissueSample, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}