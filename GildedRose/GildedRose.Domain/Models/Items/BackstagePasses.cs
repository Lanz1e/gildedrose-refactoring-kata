using GildedRose.Domain.Models.Base;

namespace GildedRose.Domain.Models.Items
{
    public class BackstagePasses : ItemCompanion
    {
        public BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void QualityHandler()
        {
            if (Quality < MAX_ITEM_QUALITY)
            {
                IncreaseQuality(1);

                if (SellIn < 11)
                {
                    if (Quality < MAX_ITEM_QUALITY)
                    {
                        IncreaseQuality(1);
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < MAX_ITEM_QUALITY)
                    {
                        IncreaseQuality(1);
                    }
                }
            }
        }

        public override void SellInCallback()
        {
            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
