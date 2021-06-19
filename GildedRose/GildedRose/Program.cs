using GildedRose.Configurations.Setup;
using GildedRose.Domain.Models.Base;
using GildedRose.Domain.Models.Items;
using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("OMGHAI!");

            var gildedRoseService = DependencyInjectionSetup.AddDependencyInjectionSetup();

            gildedRoseService.SetItems(
                new List<CompleteItem> {
                    new Default (
                        "+5 Dexterity Vest",
                        10,
                        20
                    ),
                    new AgedBrie (
                        "Aged Brie",
                        2,
                        0
                    ),
                    new Default (
                        "Elixir of the Mongoose",
                        5,
                        7
                    ),
                    new Sulfuras (
                        "Sulfuras, Hand of Ragnaros",
                        0,
                        80
                    ),
                    new Sulfuras (
                        "Sulfuras, Hand of Ragnaros",
                        -1,
                        80
                    ),
                    new BackstagePasses (
                        "Backstage passes to a TAFKAL80ETC concert",
                        15,
                        20
                    ),
                    new BackstagePasses (
                        "Backstage passes to a TAFKAL80ETC concert",
                        10,
                        49
                    ),
                    new BackstagePasses (
                        "Backstage passes to a TAFKAL80ETC concert",
                        5,
                        49
                    ),
                    new ManaCake (
                        "Conjured Mana Cake",
                        3,
                        6
                    )
                });

            IList<CompleteItem> Items = gildedRoseService.GetItems();

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                gildedRoseService.UpdateQuality();
            }

            Console.ReadKey();
        }
    }
}
