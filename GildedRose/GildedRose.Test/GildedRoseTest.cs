using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using GildedRose.Application.Services;
using GildedRose.Domain.Models.Base;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose.Test
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void UpdateQuality()
        {
            string[] nameTestValues = { "+5 Dexterity Vest", "Aged Brie",
                "Backstage passes to a TAFKAL80ETC concert", "Elixir of the Mongoose", "Sulfuras, Hand of Ragnaros", "Conjured Mana Cake" };
            int[] sellInTestValues = { -1, 1, 5, 7, 11 };
            int[] qualityTestValues = { 0, 1, 49, 51 };

            CombinationApprovals.VerifyAllCombinations(UpdateQualityTestSender, nameTestValues, sellInTestValues, qualityTestValues);
        }

        private string UpdateQualityTestSender(string name, int sellIn, int quality)
        {
            IList<Item> items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRoseService app = new GildedRoseService();
            app.SetItems(items);

            app.UpdateQuality();

            return app.GetItems()[0].ToString();
        }
    }
}
