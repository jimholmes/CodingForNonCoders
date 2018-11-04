using System.Collections.Generic;

namespace MyApp.Shopping {

    class ShoppingCart {
        private Customer customer;

        private IList<Product> cartItems;
        private Money cartTotalValue;

        public Money CartTotalValue {
            get {
                return cartTotalValue;
            }
        }
        public ShoppingCart(Customer customer) {
            this.customer = customer;
            cartTotalValue = new Money();
            cartItems = new List<Product>();
        }

        public void AddItemToCart(Product item) {
            cartItems.Add(item);
        }

        public Money ComputeCartShippingCosts(DeliveryEngine engine, Order order){
            //magic stuff happens here
            return new Money();
        }


    }
}