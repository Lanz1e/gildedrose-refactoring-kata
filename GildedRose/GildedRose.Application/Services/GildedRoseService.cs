using GildedRose.Application.Interfaces;
using GildedRose.Domain.Models;
using System.Collections.Generic;

namespace GildedRose.Application.Services
{
    public class GildedRoseService : IGildedRoseService
    {
        private const int MAX_ITEM_QUALITY = 50;
        private const int MIN_ITEM_QUALITY = 0;
        private const int INCREASE_QUALITY_RATE = 1;
        private const int DECREASE_QUALITY_RATE = 1;
        private IList<Item> _items;

        public GildedRoseService()
        {
            this._items = new List<Item>();
        }

        public void SetItems(IList<Item> items)
        {
            this._items = items;
        }

        public IList<Item> GetItems()
        {
            return this._items;
        }
        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                UpdateQualityByItems(item);
            }
        }

        private void UpdateQualityByItems(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    if (item.Quality < MAX_ITEM_QUALITY)
                    {
                        item.Quality += INCREASE_QUALITY_RATE;
                    }

                    item.SellIn--;

                    if (item.SellIn < 0)
                    {
                        if (item.Quality < MAX_ITEM_QUALITY)
                        {
                            item.Quality += INCREASE_QUALITY_RATE;
                        }
                    }
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    if (item.Quality < MAX_ITEM_QUALITY)
                    {
                        item.Quality++;

                        if (item.SellIn < 11)
                        {
                            if (item.Quality < MAX_ITEM_QUALITY)
                            {
                                item.Quality += INCREASE_QUALITY_RATE;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < MAX_ITEM_QUALITY)
                            {
                                item.Quality += INCREASE_QUALITY_RATE;
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
                case "Conjured Mana Cake":
                    if (item.Quality > MIN_ITEM_QUALITY)
                    {
                        item.Quality -= DECREASE_QUALITY_RATE * 2;

                        if (item.Quality < 0)
                            item.Quality = MIN_ITEM_QUALITY;
                    }

                    item.SellIn--;

                    if (item.SellIn < 0)
                    {
                        if (item.Quality > MIN_ITEM_QUALITY)
                        {
                            item.Quality -= DECREASE_QUALITY_RATE * 2;

                            if (item.Quality < 0)
                                item.Quality = MIN_ITEM_QUALITY;
                        }
                    }
                    break;
                default:
                    if (item.Quality > MIN_ITEM_QUALITY)
                    {
                        item.Quality--;
                    }

                    item.SellIn--;

                    if (item.SellIn < 0)
                    {
                        if (item.Quality > MIN_ITEM_QUALITY)
                        {
                            item.Quality--;
                        }
                    }
                    break;
            }
        }
    }
}
