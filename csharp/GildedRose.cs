using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> items;

        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                UpdateQualityByItems(item);
            }
        }

        private void UpdateQualityByItems(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    if (item.Quality < 50)
                    {
                        item.Quality++;
                    }

                    item.SellIn--;

                    if (item.SellIn < 0)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }
                    }
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    if (item.Quality < 50)
                    {
                        item.Quality++;

                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality++;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality++;
                            }
                        }
                    }

                    item.SellIn--;

                    if (item.SellIn < 0)
                    {
                        item.Quality = 0;
                    }
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    break;
                default:
                    if (item.Quality > 0)
                    {
                        item.Quality--;
                    }

                    item.SellIn--;

                    if (item.SellIn < 0)
                    {
                        if (item.Quality > 0)
                        {
                            item.Quality--;
                        }
                    }
                    break;
            }
        }

        public IList<Item> getItems()
        {
            return items;
        }
    }
}
