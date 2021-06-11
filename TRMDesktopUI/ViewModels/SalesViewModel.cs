using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;

        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }
        private string _itemQuantity;

        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal
        {
            get
            {
                //TODO - Replace with calulation
                return "£0.00";
            }
        }

        public string Tax
        {
            get
            {
                //TODO - Replace with calulation
                return "£0.00";
            }
        }
        public string Total
        {
            get
            {
                //TODO - Replace with calulation
                return "£0.00";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;


                return output;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;


                return output;

            }
        }

        public void RemoveToCart()
        {

        }

        public bool CanCheckout
        {
            get
            {
                bool output = false;

                //Make sure there is something in the cart
                return output;

            }
        }

        public void Checkout()
        {

        }
    }
}
