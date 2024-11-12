using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Net.Sockets;


namespace ProjectHome.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Tiến Anh Book",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "~/images/product/product1.jfif",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 2,
                    Title = "Tiến Anh Book 2",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "~/images/product/product2.jfif",
                    Price = 600000,
                    Sumary = "",
                    TotalPage = 150
                },
                new Book()
                {
                    Id = 3,
                    Title = "Tiến Anh Book 3",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "~/images/product/product3.jfif",
                    Price = 700000,
                    Sumary = "",
                    TotalPage = 350
                },
                new Book()
                {
                    Id = 4,
                    Title = "Tiến Anh Book 4",
                    AuthorId = 4,
                    GenreId = 4,
                    Image = "~/images/product/product1.jfif",
                    Price = 900000,
                    Sumary = "",
                    TotalPage = 450
                }

            };
            return books;
        }

        //chi tiết 1 cuốn sách theo id
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //selectLisstItem Author 
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Nam Cao"},
            new SelectListItem {Value = "2", Text = "Ngô Tất Tố"},
            new SelectListItem {Value = "3", Text = "Adamkhoom"},
            new SelectListItem {Value = "4", Text = "Thiền sư"}
        };

        //selectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Truyện tranh" },
            new SelectListItem {Value = "1", Text = "Văn học đương đại" },
            new SelectListItem {Value = "1", Text = "Phật học phổ thông" },
            new SelectListItem {Value = "1", Text = "Truyện cười" }
        };
    }
}