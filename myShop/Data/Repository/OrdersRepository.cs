using myShop.Data.Interfaces;
using myShop.Data.Models;

namespace myShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBContent appDBContent;
        private readonly ShopCart ShopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.ShopCart = shopCart;
        }

        public void createOreder(Order order)
        {
            order.orderTime = System.DateTime.Now;
            appDBContent.Order.Add(order);

            var items = ShopCart.listShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail
                {
                    carID = item.car.id,
                    orderID = order.id,
                    price = item.car.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
