using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace UofA.Content.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Body)]
    internal class Wilburs_Breastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Blue;

            Item.vanity = true;
        }
    }
}
