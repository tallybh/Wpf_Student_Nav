using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Student_Nav
{
  public  class ServiceClient
    {
        public CityList GetAllCity()
        {
            CityList lst = new CityList();
            lst.Add(new City() { ID = 1, Name="Haifa", Population=280000 });
            lst.Add(new City() { ID = 2, Name = "TelAviv", Population = 435000 });
            lst.Add(new City() { ID = 3, Name = "Raanana", Population = 74000 });
            lst.Add(new City() { ID = 4, Name = "Eilat", Population = 85000 });
            lst.Add(new City() { ID = 5, Name = "Jerusalem", Population = 857000 });

            return lst;
        }

        public PrefixList GetAllPrefix()
        {
            PrefixList lst = new PrefixList();
            lst.Add(new Prefix() { ID = 1, Name = "050" });
            lst.Add(new Prefix() { ID = 2, Name = "052" });
            lst.Add(new Prefix() { ID = 3, Name = "054" });
            return lst;
        }
        public User GetUser1()
        {
            User user = new User();
            user.FName = "fname";
            user.LName = "lname";
            user.City = new City { ID = 3 ,Name= "Raanana" };
            user.BDate = new DateTime (2002,5,4,21,12,13);    // time=  4/5/2002  21:12:13
            user.Gender = false;
            user.Prefix= new Prefix { ID = 1, Name = "050" };
            user.PhoneNum = 123456;
            return user;
        }
        public User GetUser2()
        {
            User user = new User();
            user.FName = "fname2";
            user.LName = "lname2";
            user.City = new City { ID = 4 , Name = "Eilat" };
            user.BDate = new DateTime(1990,3,8,12,34,21);   // time=  12/8/1990  12:34:21
            user.Gender = true;
            user.Prefix = new Prefix { ID =2, Name = "052" };
            user.PhoneNum = 987654;
            return user;
        }
    }
}
