namespace GildedRose.Domain.Models.Base
{
    public abstract class CompleteItem : Item
    {
        protected const int MAX_ITEM_QUALITY = 50;
        protected const int MIN_ITEM_QUALITY = 0;
        protected const int INCREASE_QUALITY_RATE = 1;
        protected const int DECREASE_QUALITY_RATE = 1;

        public CompleteItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        protected CompleteItem()
        {
        }

        public void UpdateItem()
        {
            QualityHandler();
            SellInHandler();
            SellInCallback();
        }

        public virtual void QualityHandler()
        {
            //vai ser implementado por cada item
        }

        public virtual void SellInHandler()
        {
            //pode ser alterado em cada item, mas por hora só decrementa            
            DecreaseSellIn();
        }

        public virtual void SellInCallback()
        {

        }

        //internal quality handlers
        protected void IncreaseQuality(int valueToIncrease)
        {
            Quality += (INCREASE_QUALITY_RATE * valueToIncrease);
            CheckMaximumQuality();
        }

        protected void DecreaseQuality(int valueToDecrease)
        {
            Quality -= (DECREASE_QUALITY_RATE * valueToDecrease);
            CheckMinimumQuality();
        }

        protected virtual void CheckMaximumQuality()
        {
            if (Quality > MAX_ITEM_QUALITY)
            {
                Quality = MAX_ITEM_QUALITY;
            }
        }

        protected virtual void CheckMinimumQuality()
        {
            if (Quality < MIN_ITEM_QUALITY)
            {
                Quality = MIN_ITEM_QUALITY;
            }
        }

        //internal sellIn handlers

        protected void DecreaseSellIn()
        {
            SellIn--;
        }
    }
}
