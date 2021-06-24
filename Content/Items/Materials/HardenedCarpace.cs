using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using TrelamiumTwo.Core;

namespace TrelamiumTwo.Content.Items.Materials
{
	public class HardenedCarapace : ModItem
	{
		public override string Texture => Assets.Items.Materials + "HardenedCarapace";
		public override void SetDefaults()
		{
			item.width = item.height = 20;
			item.maxStack = 999;
			item.value = Item.sellPrice(copper: 1);
			item.rare = ItemRarityID.White;
		}
	}
}