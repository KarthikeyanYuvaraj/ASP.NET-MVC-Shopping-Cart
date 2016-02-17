using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPMVCShoppingCart.Models;

namespace ASPMVCShoppingCart.Controllers
{
    public class Item
    {

        private tblProduct product = new tblProduct();

        public tblProduct Product
        {
            get { return product; }
            set { product = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item()
        {

        }

        public Item(tblProduct product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

    }
}