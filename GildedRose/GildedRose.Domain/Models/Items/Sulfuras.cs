using GildedRose.Domain.Models.Base;

namespace GildedRose.Domain.Models.Items
{
    public class Sulfuras : ItemCompanion
    {
        public Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void QualityHandler() { }

        public override void SellInHandler() { }

        protected override void CheckMaximumQuality() { }

        protected override void CheckMinimumQuality() { }
    }
}
