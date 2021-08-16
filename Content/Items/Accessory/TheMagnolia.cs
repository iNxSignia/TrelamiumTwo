using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using TrelamiumTwo.Core;

namespace TrelamiumTwo.Content.Items.Accessory
{
	public class TheMagnolia : ModItem
	{
		public override string Texture => Assets.Items.Accessory + "TheMagnolia";
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases movement speed and life regenereation."
				+ "\nIncreases movement speed and life regeneration even further when at 30% health");
		}
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 28;
			Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 30);
            
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<Common.Players.TrelamiumPlayer>().theMagnolia = true;
            
			player.lifeRegen += 3;
			player.moveSpeed += 0.05f;
			player.maxRunSpeed += 0.05f;
            
			if (player.statLife <= player.statLifeMax2 / 3)
			{
				player.lifeRegen += 6;
				player.moveSpeed += 0.1f;
				player.maxRunSpeed += 0.1f;
			}
		}
	}
}
