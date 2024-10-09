using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsCountry
    {
     
            public int ID { set; get; }
            public string CountryName { set; get; }
            private clsCountry(int ID, string CountryName)
            {
                this.ID = ID;
                this.CountryName = CountryName;

            }
            public static clsCountry Find(int ID)
            {

                string CountryName = "";

                if (clsCountryData.GetCountryInfoByID(ID, ref CountryName))
                    return new clsCountry(ID, CountryName);
                else
                    return null;

            }

        
    }
}
