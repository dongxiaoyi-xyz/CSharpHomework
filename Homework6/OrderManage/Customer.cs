using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Customer
    {
        public int id { get; set; }                      //用户账号
        public string name { get; set; }                 //用户名

        public Customer()
        {
            id = 0;
            name = "";
        }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        //重写ToString方法
        public override string ToString()
        {
            return "Customer:"+"\tid--"+id+"\tname--"+name;
        }
    }
}
