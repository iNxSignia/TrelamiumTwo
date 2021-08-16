using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ModLoader;

using TrelamiumTwo.Common.Projectiles;
using TrelamiumTwo.Core;

namespace TrelamiumTwo.Content.Projectiles.Ranged
{
	public class ToadstoolClusterclot : TomahawkProjectile
	{
		public override string Texture => Assets.Items.Fungore + "ToadstoolClusterclot";
		public override void SetStaticDefaults() => base.SetStaticDefaults();	
		public override void SetDefaults()
		{
			Projectile.width = Projectile.height = 20;

			base.SetDefaults();
		}
        public override void Kill(int timeLeft)
		{
			Player player = Main.player[Projectile.owner];
			int num281 = 22;
			for (int num282 = 0; num282 < num281; num282++)
			{
				int num283 = Dust.NewDust(Projectile.Center, 0, 0, ModContent.DustType<Dusts.Mushroom>(), 0f, 0f, 0, default, 0.5f);
				Dust dust = Main.dust[num283];
				dust.velocity *= 1.6f;
				Dust dust25 = Main.dust[num283];
				dust25.velocity.Y = 1f;
				Main.dust[num283].position = Vector2.Lerp(Main.dust[num283].position, Projectile.Center, 0.5f);
			}
			for (int i = 0; i <= 3; ++i)
			{
				Projectile.NewProjectile(Projectile.Center, -Vector2.UnitY.RotatedByRandom(MathHelper.PiOver2) * 4f,
					ModContent.ProjectileType<Toadstool>(), (int)(Projectile.damage * 0.5f), 0.5f, Projectile.owner);
			}
		}
	}
}