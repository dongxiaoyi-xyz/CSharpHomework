using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OrderManage
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }                      //用户账号
        public string name { get; set; }                //用户名

        public Customer()
        {
            Id = 0;
            name = "";
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }

        //重写ToString方法
        public override string ToString()
        {
            return "Customer:" + " Id--" + Id + " name--" + name;
        }
    }
}
