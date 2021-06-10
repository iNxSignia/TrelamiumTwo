﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrelamiumTwo.Content.Items.Fungore
{
    public class FungoreTrophy : TrelamiumItem
    {
        public override void SetStaticDefaults() 
            => DisplayName.SetDefault("Fungore Trophy");

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
            item.maxStack = 999;
            item.width = 18;
            item.height = 24;
            item.useAnimation = 18;
            item.useTime = 18;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;
            item.consumable = true;
            item.value = Item.sellPrice(silver: 8);
            item.createTile = ModContent.TileType<Tiles.Furniture.Fungore.FungoreTrophyTile>();
        }
    }
}