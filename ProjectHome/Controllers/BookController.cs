using Microsoft.AspNetCore.Mvc;
using ProjectHome.Models;

namespace ProjectHome.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            //danh sách convert selectLisstItem để hiển thị trên combobox
            ViewBag.authors = book.Authors; //truyền dữ liệu SelectListItem qua view
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books); // truyền dữ liệu qua view  dưới dạng tham số
        }

        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = new Book();
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = book.GetBookById(id);
            return View(model);
        }

        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}
