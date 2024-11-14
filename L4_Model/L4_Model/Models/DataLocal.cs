namespace L4_Model.Models
{
    public class DataLocal
    {
        public static List<People> _peoples = new List<People>()
        {
            new People()
            {
                Id = 0,
                Name = "Tiến Anh",
                Email = "buitienanh@gmail.com",
                Phone = "0828345288",
                Address = "Chiêm Hóa, Tuyên Quang",
                Avatar = "/images/avatar/avt1.jfif",
                Birthday = new DateTime(2003/12/13),
                Gender =1
            },
            new People (){
                Id = 1,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/avt1.jfif",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
             },
            new People (){
                Id = 2,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/avt2.jfif",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
            },
            new People (){
                Id = 3,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/avt3.jfif",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
            },
            new People (){
                Id = 4,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/avt4.jfif",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
            },
            new People (){
                Id = 5,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/avt5.jfif",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
            },
            new People (){
                Id = 6,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/avt6.jfif",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
            },
        };

        //GetPeoples: lấy danh sách dữ liệu peoples
        public static List<People> GetPeoples()
        {
            return _peoples;
        }

        //GetPeolpleById: Lấy đối tượng peoples theo id
        public static People? GetPeopleById(int Id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }

    }
}
