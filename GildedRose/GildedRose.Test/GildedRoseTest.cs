using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using GildedRose.Application.Services;
using GildedRose.Domain.Models.Base;
using GildedRose.Domain.Models.Items;
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
            IList<CompleteItem> testList = new List<CompleteItem> {
                new Default("+5 Dexterity Vest", -1, 0),
                new Default("+5 Dexterity Vest", -1, 1),
                new Default("+5 Dexterity Vest", -1, 49),
                new Default("+5 Dexterity Vest", -1, 51),
                new Default("+5 Dexterity Vest", 1, 0),
                new Default("+5 Dexterity Vest", 1, 1),
                new Default("+5 Dexterity Vest", 1, 49),
                new Default("+5 Dexterity Vest", 1, 51),
                new Default("+5 Dexterity Vest", 5, 0),
                new Default("+5 Dexterity Vest", 5, 1),
                new Default("+5 Dexterity Vest", 5, 49),
                new Default("+5 Dexterity Vest", 5, 51),
                new Default("+5 Dexterity Vest", 7, 0),
                new Default("+5 Dexterity Vest", 7, 1),
                new Default("+5 Dexterity Vest", 7, 49),
                new Default("+5 Dexterity Vest", 7, 51),
                new Default("+5 Dexterity Vest", 11, 0),
                new Default("+5 Dexterity Vest", 11, 1),
                new Default("+5 Dexterity Vest", 11, 49),
                new Default("+5 Dexterity Vest", 11, 51),
                new AgedBrie("Aged Brie",-1,0),
                new AgedBrie("Aged Brie",-1,1),
                new AgedBrie("Aged Brie",-1,49),
                new AgedBrie("Aged Brie",-1,51),
                new AgedBrie("Aged Brie",1,0),
                new AgedBrie("Aged Brie",1,1),
                new AgedBrie("Aged Brie",1,49),
                new AgedBrie("Aged Brie",1,51),
                new AgedBrie("Aged Brie",5,0),
                new AgedBrie("Aged Brie",5,1),
                new AgedBrie("Aged Brie",5,49),
                new AgedBrie("Aged Brie",5,51),
                new AgedBrie("Aged Brie",7,0),
                new AgedBrie("Aged Brie",7,1),
                new AgedBrie("Aged Brie",7,49),
                new AgedBrie("Aged Brie",7,51),
                new AgedBrie("Aged Brie",11,0),
                new AgedBrie("Aged Brie",11,1),
                new AgedBrie("Aged Brie",11,49),
                new AgedBrie("Aged Brie",11,51),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",-1,0),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",-1,1),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",-1,49),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",-1,51),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",1,0),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",1,1),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",1,49),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",1,51),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",5,0),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",5,1),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",5,49),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",5,51),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",7,0),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",7,1),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",7,49),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",7,51),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",11,0),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",11,1),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",11,49),
                new BackstagePasses("Backstage passes to a TAFKAL80ETC concert",11,51),
                new Default("Elixir of the Mongoose",-1,0),
                new Default("Elixir of the Mongoose",-1,1),
                new Default("Elixir of the Mongoose",-1,49),
                new Default("Elixir of the Mongoose",-1,51),
                new Default("Elixir of the Mongoose",1,0),
                new Default("Elixir of the Mongoose",1,1),
                new Default("Elixir of the Mongoose",1,49),
                new Default("Elixir of the Mongoose",1,51),
                new Default("Elixir of the Mongoose",5,0),
                new Default("Elixir of the Mongoose",5,1),
                new Default("Elixir of the Mongoose",5,49),
                new Default("Elixir of the Mongoose",5,51),
                new Default("Elixir of the Mongoose",7,0),
                new Default("Elixir of the Mongoose",7,1),
                new Default("Elixir of the Mongoose",7,49),
                new Default("Elixir of the Mongoose",7,51),
                new Default("Elixir of the Mongoose",11,0),
                new Default("Elixir of the Mongoose",11,1),
                new Default("Elixir of the Mongoose",11,49),
                new Default("Elixir of the Mongoose",11,51),
                new Sulfuras("Sulfuras, Hand of Ragnaros",-1,0),
                new Sulfuras("Sulfuras, Hand of Ragnaros",-1,1),
                new Sulfuras("Sulfuras, Hand of Ragnaros",-1,49),
                new Sulfuras("Sulfuras, Hand of Ragnaros",-1,51),
                new Sulfuras("Sulfuras, Hand of Ragnaros",1,0),
                new Sulfuras("Sulfuras, Hand of Ragnaros",1,1),
                new Sulfuras("Sulfuras, Hand of Ragnaros",1,49),
                new Sulfuras("Sulfuras, Hand of Ragnaros",1,51),
                new Sulfuras("Sulfuras, Hand of Ragnaros",5,0),
                new Sulfuras("Sulfuras, Hand of Ragnaros",5,1),
                new Sulfuras("Sulfuras, Hand of Ragnaros",5,49),
                new Sulfuras("Sulfuras, Hand of Ragnaros",5,51),
                new Sulfuras("Sulfuras, Hand of Ragnaros",7,0),
                new Sulfuras("Sulfuras, Hand of Ragnaros",7,1),
                new Sulfuras("Sulfuras, Hand of Ragnaros",7,49),
                new Sulfuras("Sulfuras, Hand of Ragnaros",7,51),
                new Sulfuras("Sulfuras, Hand of Ragnaros",11,0),
                new Sulfuras("Sulfuras, Hand of Ragnaros",11,1),
                new Sulfuras("Sulfuras, Hand of Ragnaros",11,49),
                new Sulfuras("Sulfuras, Hand of Ragnaros",11,51),
                new ManaCake("Conjured Mana Cake",-1,0),
                new ManaCake("Conjured Mana Cake",-1,1),
                new ManaCake("Conjured Mana Cake",-1,49),
                new ManaCake("Conjured Mana Cake",-1,51),
                new ManaCake("Conjured Mana Cake",1,0),
                new ManaCake("Conjured Mana Cake",1,1),
                new ManaCake("Conjured Mana Cake",1,49),
                new ManaCake("Conjured Mana Cake",1,51),
                new ManaCake("Conjured Mana Cake",5,0),
                new ManaCake("Conjured Mana Cake",5,1),
                new ManaCake("Conjured Mana Cake",5,49),
                new ManaCake("Conjured Mana Cake",5,51),
                new ManaCake("Conjured Mana Cake",7,0),
                new ManaCake("Conjured Mana Cake",7,1),
                new ManaCake("Conjured Mana Cake",7,49),
                new ManaCake("Conjured Mana Cake",7,51),
                new ManaCake("Conjured Mana Cake",11,0),
                new ManaCake("Conjured Mana Cake",11,1),
                new ManaCake("Conjured Mana Cake",11,49),
                new ManaCake("Conjured Mana Cake",11,51)
            };

            CombinationApprovals.VerifyAllCombinations(UpdateQualityTestSender, testList);
        }

        private string UpdateQualityTestSender(CompleteItem item)
        {
            List<CompleteItem> items = new List<CompleteItem> { item };
            GildedRoseService app = new GildedRoseService();
            app.SetItems(items);

            app.UpdateQuality();

            return app.GetItems()[0].ToString();
        }
    }
}
