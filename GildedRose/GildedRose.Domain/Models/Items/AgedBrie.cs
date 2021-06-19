using GildedRose.Domain.Models.Base;

namespace GildedRose.Domain.Models.Items
{
    public class AgedBrie : ItemCompanion
    {
        public AgedBrie(string name, int sellIn, int quality): base(name, sellIn, quality)
        {

        }

        public override void QualityHandler()
        {
            if (Quality < MAX_ITEM_QUALITY)
            {
                IncreaseQuality(1);
            }
        }

        public override void SellInCallback()
        {
            if (SellIn < 0)
            {
                if (Quality < MAX_ITEM_QUALITY)
                {
                    IncreaseQuality(1);
                }
            }
        }
    }
}
