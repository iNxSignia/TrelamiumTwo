﻿using Terraria;

namespace TrelamiumTwo.Content.Items.Materials
{
    public sealed class Fossilite : TrelamiumItem
    {
        public override void SetStaticDefaults() => DisplayName.SetDefault("Fossilite");

        public override void SafeSetDefaults() 
            => item.value = Item.buyPrice(silver: 10);
    }
}