using GildedRose.Domain.Models;
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
