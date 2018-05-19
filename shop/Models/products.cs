namespace shop.Models
{
    public class products
    {
        public products(int id, string name, decimal price)
        {
            this.Id = id;
            this.name = name;
            this.price = price;

        }
        public int Id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string imageurl { get; set; }


    }
}