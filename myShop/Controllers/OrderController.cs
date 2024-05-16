using Microsoft.AspNetCore.Mvc;
using myShop.Data;
using myShop.Data.Interfaces;
using myShop.Data.Models;

namespace myShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart ShopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.ShopCart = shopCart;
        }
        public ActionResult Checkout()
        {
            ViewBag.Title = "Оформление заказа";
            return View();
        }
        [HttpPost]
        public ActionResult Checkout(Order order)
        {
            ShopCart.listShopItems = ShopCart.getShopItems();
            if (ShopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "Для оформления у вас должны быть товары в корзине.");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOreder(order);
                return RedirectToAction("Complete");
            }
            return View(order);

        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан!";
            ViewBag.Title = "Заказ успешно обработан!";
            return View();
        }
    }
}
