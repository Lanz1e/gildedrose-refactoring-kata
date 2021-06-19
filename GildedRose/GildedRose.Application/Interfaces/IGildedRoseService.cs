using GildedRose.Domain.Models.Base;
using System.Collections.Generic;

namespace GildedRose.Application.Interfaces
{
    public interface IGildedRoseService
    {
        void SetItems(IList<Item> items);
        IList<Item> GetItems();
        void UpdateQuality();
    }
}
