using GildedRose.Domain.Models.Base;

namespace GildedRose.Domain.Models.Items
{
    public class Default : CompleteItem
    {
        public Default(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void QualityHandler()
        {
            DecreaseQuality(1);
        }

        public override void SellInCallback()
        {
            if (SellIn < 0)
            {
                if (Quality > MIN_ITEM_QUALITY)
                {
                    DecreaseQuality(1);
                }
            }
        }
    }
}
