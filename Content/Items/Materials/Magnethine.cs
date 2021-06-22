using Terraria;
using Terraria.ID;

namespace TrelamiumTwo.Content.Items.Materials
{
	public class Magnethine : TrelamiumItem
	{
		public override void SetDefaults()
		{
			item.width = item.height = 20;
			item.maxStack = 999;
			item.rare = ItemRarityID.White;
			item.value = Item.buyPrice(silver: 5);
		}
	}
}