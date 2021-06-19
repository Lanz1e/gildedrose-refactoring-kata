using GildedRose.Domain.Models.Base;

namespace GildedRose.Domain.Models.Items
{
    public class ManaCake : ItemCompanion
    {
        public ManaCake(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void QualityHandler()
        {
            if (Quality > MIN_ITEM_QUALITY)
            {
                DecreaseQuality(2);
            }
        }

        public override void SellInCallback()
        {
            if (SellIn < 0)
            {
                if (Quality > MIN_ITEM_QUALITY)
                {
                    DecreaseQuality(2);
                }
            }
        }
    }
}
