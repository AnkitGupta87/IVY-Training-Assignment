using Microsoft.AspNetCore.Mvc;
using MyApp.DataAccessLayer;
using MyApp.DataAccessLayer.Infrastructure.IRepository;
using MyApp.Models;
using MyApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyAppWeb.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork _unitofwork;
        public IWebHostEnvironment _hostingEnvironment;

        public ProductController(IUnitOfWork unitofwork, IWebHostEnvironment hostingEnvironment)
        {
            _unitofwork = unitofwork;
            _hostingEnvironment = hostingEnvironment;
        }

        #region APICALL
        public IActionResult AllProducts()
        {
            var products = _unitofwork.Product.GetAll(includeProperties:"Category");
                return Json(new {data = products});
        }
        #endregion

        public IActionResult Index()
        { 
            //ProductVM productVM = new ProductVM();
            //productVM.Products = _unitofwork.Product.GetAll();
            return View();
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //    _unitofwork.Category.Add(category);
        //    _unitofwork.Save();
        //        TempData["success"] = "Category Created Successfully";
        //    return RedirectToAction("Index");
        //    }
        //    return View(category);
        //}
        [HttpGet]
        public IActionResult CreateUpdate(int? id)
        {
            ProductVM vm = new ProductVM()
            {
                Product = new(),
                Categories = _unitofwork.Category.GetAll().Select(x=>
                new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                })
            };
            if(id == null || id == 0)
            {
                return View(vm);
            }
            else
            {
                vm.Product = _unitofwork.Product.GetT(x => x.Id == id);
                if (vm.Product == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(vm);
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUpdate(ProductVM vm, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string fileName = String.Empty;
                if(file != null)
                {
                    string uploadDir = Path.Combine(_hostingEnvironment.WebRootPath, "ProductImage");
                    fileName = Guid.NewGuid().ToString()+"-"+file.FileName;
                    string filePath = Path.Combine(uploadDir, fileName);

                    if(vm.Product.ImageUrl != null)
                    {
                        var oldImagePath = Path.Combine(_hostingEnvironment.WebRootPath, vm.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    vm.Product.ImageUrl = @"\ProductImage\"+ fileName;
                }
                if(vm.Product.Id == 0)
                {
                _unitofwork.Product.Add(vm.Product);
                    TempData["success"] = "Product Created Successfully";
                }

                _unitofwork.Save();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var category = _unitofwork.Category.GetT(x => x.Id == id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(category);
        //}

        #region DeleteAPICALL
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var product = _unitofwork.Product.GetT(x => x.Id == id);
            if (product == null)
            {
                return Json(new {success=false,message="Error in Fetching Data"});
            }
            else
            {
                var oldImagePath = Path.Combine(_hostingEnvironment.WebRootPath, product.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
                _unitofwork.Product.Delete(product);                
                _unitofwork.Save();
                return Json(new { success = true, message = "Product Deleted Successfully." });
            }
        }
        #endregion

    }
}
