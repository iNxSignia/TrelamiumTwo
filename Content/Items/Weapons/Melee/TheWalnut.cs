using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TrelamiumTwo.Content.Items.Weapons.Melee
{
	public class TheWalnut : TrelamiumItem
	{		
		public override void SetDefaults()
		{
			item.width = item.height = 44;
			item.rare = ItemRarityID.Blue;
			item.value = Item.buyPrice(0, 0, 4, 66);
			
			item.crit = 4;
			item.damage = 10;
			item.knockBack = 6f;
			
			item.useTime = 20;
			item.useAnimation = 40;
			item.useStyle = ItemUseStyleID.HoldingOut;
			
			item.melee = true;
			item.noMelee = true;
			item.channel = true;			
			item.noUseGraphic = true;
			
			item.shootSpeed = 12f;
			item.shoot = ModContent.ProjectileType<Projectiles.Melee.TheWalnut>();
			
			item.UseSound = SoundID.Item1;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position, Vector2.Zero, type, damage, knockBack, player.whoAmI, new Vector2(speedX, speedY).ToRotation());
			return (false);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddIngredient(ModContent.ItemType<Materials.Nut>(), 18);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}