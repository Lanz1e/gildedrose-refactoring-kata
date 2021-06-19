using GildedRose.Domain.Models.Base;
using System.Collections.Generic;

namespace GildedRose.Application.Interfaces
{
    public interface IGildedRoseService
    {
        void SetItems(List<CompleteItem> items);
        IList<CompleteItem> GetItems();
        void UpdateQuality();
    }
}
