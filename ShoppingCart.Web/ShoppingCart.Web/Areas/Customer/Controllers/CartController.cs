using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Repositories;
using ShoppingCart.DataAccess.ViewModels;
using System.Security.Claims;

namespace ShoppingCart.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private IUnitOfWork _unitOfWork;
        //public Boolean showPayment = false;
        public CartVM itemList { get; set; }
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            itemList = new CartVM()
            {
                ListOfCart = _unitOfWork.Cart.GetAll(x => x.ApplicationUserId == claims.Value,
                includeProperties: "Product")
            };
            foreach(var item in itemList.ListOfCart)
            {
                itemList.Total += ((int)item.Product.Price * item.Count);
            }
            return View(itemList);
        }
        public IActionResult plus(int id)
        {
            var cart = _unitOfWork.Cart.GetT(x => x.Id == id);
            _unitOfWork.Cart.IncrementCartItem(cart,1);
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult minus(int id)
        {
            var cart = _unitOfWork.Cart.GetT(x => x.Id == id);
            if(cart.Count == 1)
            {
                _unitOfWork.Cart.Delete(cart);
            }
            else
            {
            _unitOfWork.Cart.DecrementCartItem(cart, 1);
            }
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult delete(int id)
        {
            var cart = _unitOfWork.Cart.GetT(x => x.Id == id);
            _unitOfWork.Cart.Delete(cart);
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Summary()
        {
            Console.WriteLine("Ordered");
            return View();
        }
    }
}
