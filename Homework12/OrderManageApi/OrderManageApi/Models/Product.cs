
namespace OrderManageApi.Models
{
    public class Product
    {
        public int Id { get; set; }           //产品Id
        public string name { get; set; }      //产品名
        public double price { get; set; }     //产品单价

        public Product()
        {
            name = "";
            price = 0;
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        //重写ToString方法
        public override string ToString()
        {
            return "Product:" + " name--" + name + " price--" + price;
        }
    }
}
