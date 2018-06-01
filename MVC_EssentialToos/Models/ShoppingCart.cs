using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EssentialToos.Models
{
    public class ShoppingCart //购物车
    {
        //私有购物车商品价格计算器
        private IValueCalculator calc;
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="calcParam">价格计算器</param>
        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        //购物车中的商品集合
        public IEnumerable<Product> Products{ get; set; }
        //计算购物车中商品价格的总和
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}