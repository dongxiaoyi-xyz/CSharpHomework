﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class OrderItem
    {
        public Product product { get; set; }       //商品
        public int prdctQuantity { get; set; }     //商品数量
        public double totalPrice { get { return prdctQuantity * product.price; } }    //商品总金额

        //创建空订单明细
        public OrderItem()
        {
            product = null;
            prdctQuantity = 0;
        }

        //创建订单明细
        public OrderItem(Product product, int prdctQuantity)
        {
            this.product = product;
            this.prdctQuantity = prdctQuantity;
        }

        //重写Equals方法
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return product.name == orderItem.product.name;
        }

        //重写GetHashCode方法
        public override int GetHashCode()
        {
            var hashCode = 189248349;
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(product);
            hashCode = hashCode * -1521134295 + prdctQuantity.GetHashCode();
            hashCode = hashCode * -1521134295 + totalPrice.GetHashCode();
            return hashCode;
        }

        //重写ToString方法
        public override string ToString()
        {
            return product + "\tquantity--" + prdctQuantity + "\ttotalPrice--" + totalPrice;
        }
    }
}
