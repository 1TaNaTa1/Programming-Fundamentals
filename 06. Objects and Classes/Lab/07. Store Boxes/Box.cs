namespace _07._Store_Boxes
{
    public class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceBox { get; set; }
    }
}
