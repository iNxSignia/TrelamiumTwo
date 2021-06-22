﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TrelamiumTwo.Content.Items.Materials;

namespace TrelamiumTwo.Content.Items.Weapons.Melee
{
    public class LuminescentBlade : TrelamiumItem
    {
        public override void SetStaticDefaults() => DisplayName.SetDefault("Luminescent Blade");

        public override void SafeSetDefaults()
        {
            item.melee = true;
            item.useTurn = true;
            item.autoReuse = true;

            item.useAnimation = 25;
            item.useTime = 25;
            item.damage = 9;
            item.crit = 1;

            item.knockBack = 4.5f;

            item.rare = ItemRarityID.White;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.value = Item.buyPrice(silver: 50);
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Granite, 10);
            recipe.AddIngredient(ItemID.Sapphire, 4);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}