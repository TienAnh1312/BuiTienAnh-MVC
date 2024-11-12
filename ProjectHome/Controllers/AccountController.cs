using Microsoft.AspNetCore.Mvc;
using ProjectHome.Models;
using System.Linq;

namespace ProjectHome.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,Name = "Tiến Anh",
                    Email="buitienanh13122003@gmail.com",
                    Phone="0828345288", Address="Tuyên Quang",
                    Avatar=Url.Content("~/images/avatar/avt1.jfif"),
                    Gender=1, Bio="my name is small",
                    Birthday=new DateTime(2003,12,13)
                },
                 new Account()
                {
                    Id = 2,Name = "Hello",
                    Email="Hello@gmail.com",
                    Phone="0828345288", Address="Thái Bình",
                    Avatar=Url.Content("~/images/avatar/avt2.jfif"),
                    Gender=1, Bio="my name is small",
                    Birthday=new DateTime(2005,8,3)
                },
                  new Account()
                {
                    Id = 3,Name = "Tuan bu",
                    Email="TuanVu@gmail.com",
                    Phone="0828345288", Address="Hà Giang",
                    Avatar=Url.Content("~/images/avatar/avt3.jfif"),
                    Gender=1, Bio="my name is big",
                    Birthday=new DateTime(2004,10,14)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }

        //định nghĩa url và nam cho action
        [Route("ho-so-cua-toi",Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,Name = "Tiến Anh",
                    Email="buitienanh13122003@gmail.com",
                    Phone="0828345288", Address="Tuyên Quang",
                    Avatar=Url.Content("~/images/avatar/avt1.jfif"),
                    Gender=1, Bio="my name is small",
                    Birthday=new DateTime(2003,12,13)
                },
                 new Account()
                {
                    Id = 2,Name = "Hello",
                    Email="Hello@gmail.com",
                    Phone="0828345288", Address="Thái Bình",
                    Avatar=Url.Content("~/images/avatar/avt2.jfif"),
                    Gender=1, Bio="my name is small",
                    Birthday=new DateTime(2005,8,3)
                },
                  new Account()
                {
                    Id = 3,Name = "Tuan bu",
                    Email="TuanVu@gmail.com",
                    Phone="0828345288", Address="Hà Giang",
                    Avatar=Url.Content("~/images/avatar/avt3.jfif"),
                    Gender=1, Bio="my name is big",
                    Birthday=new DateTime(2004,10,14)
                },
            };

            //sử dụng Linq; truy xuất dữ liệu 1 đối tượng trong danh sách theo id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            //gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }
    }
}
