using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Student_Nav
{
  public  class User
    {
        private string fNmae;
        private string lNmae;
        private DateTime bDate;
        private City city;
        private bool gender;
        private Prefix prefix;
        private int phoneNum;

        public string FName { get { return fNmae; } set { fNmae = value; } }
        public string LName { get { return lNmae; } set { lNmae = value; } }
        public DateTime  BDate { get { return bDate; } set { bDate = value; } }
        public City City { get { return city; } set { city = value; } }
        public bool Gender { get { return gender; } set { gender = value; } }

        public Prefix Prefix { get => prefix; set => prefix = value; }
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }
        public bool IsAdmin { get; set; }
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
    }

   public class CityList : List<City>
    { }
    public    class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }


    public class PrefixList : List<Prefix>
    { }
    public class Prefix
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
