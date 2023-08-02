using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlienBurger;

public class AlienBurger : ModItem
{
	public override void SetStaticDefaults() {
		Item.ResearchUnlockCount = 5;

		Main.RegisterItemAnimation(Type, new DrawAnimationVertical(int.MaxValue, 3));

		ItemID.Sets.FoodParticleColors[Item.type] = new Color[3] {
			new Color(255, 180, 89),
			new Color(94, 112, 45),
			new Color(138, 169, 75)
		};

		ItemID.Sets.IsFood[Type] = true;
	}

	public override void SetDefaults() {
		Item.DefaultToFood(24, 22, BuffID.WellFed3, 43200); // 12 minutes: 12 * 60 * 60
		Item.value = Item.buyPrice(0, 2, 50);
		Item.rare = ItemRarityID.Green;
	}
}