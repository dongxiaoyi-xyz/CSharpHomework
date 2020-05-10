using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
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
