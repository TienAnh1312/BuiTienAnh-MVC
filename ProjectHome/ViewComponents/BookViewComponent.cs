using Microsoft.AspNetCore.Mvc;
using ProjectHome.Models;

namespace ProjectHome.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}
