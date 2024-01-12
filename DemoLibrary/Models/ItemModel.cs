namespace DemoLibrary
{
    public class ItemModel
    {
        public enum CurrencyType
        {
            EUR,
            GBP,
            PLN
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price_Amount { get; set; }
        public CurrencyType Price_Currency { get; set; }

        public string FullDescription
        {
            get
            {
                return $"{Name} {Price_Amount}";
            }
        }
    }
}
