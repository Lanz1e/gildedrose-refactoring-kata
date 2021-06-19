using GildedRose.Application.Interfaces;
using GildedRose.Domain.Models.Base;
using System.Collections.Generic;

namespace GildedRose.Application.Services
{
    public class GildedRoseService : IGildedRoseService
    {
        private IList<CompleteItem> _items;

        public GildedRoseService()
        {
            this._items = new List<CompleteItem>();
        }

        public void SetItems(List<CompleteItem> items)
        {
            this._items = items;
        }

        public IList<CompleteItem> GetItems()
        {
            return this._items;
        }

        public void UpdateQuality()
        {
            foreach (CompleteItem item in _items)
            {
                item.UpdateItem();
            }
        }
    }
}
