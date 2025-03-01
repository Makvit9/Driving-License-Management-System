﻿using System.Data;
using System.Diagnostics.PerformanceData;
using DAL;

namespace BL
{
    public class Country
    {
       
        public int? CountryID { get; set; }
        public string CountryName { get; set; }
        public string IsoCode { get; set; }

       
        public Country(int countryID, string countryName, string isoCode)
        {
            CountryID = countryID;
            CountryName = countryName;
            IsoCode = isoCode;
        }

        public Country()
        {
            CountryID = 0;
            CountryName = "";
            IsoCode = "";
        }

        public static DataTable GetAllCountries()
        {
            return CountryDAL.GetCountriesList();
        }


        public static Country Find(string countryName)
        {
            int ID = -1;
            string code = "";
            
            if (CountryDAL.GetInfoByCountryName(countryName, ref ID, ref code))
            {
                return new Country(ID, countryName, code);
            }
            return null;
        }

        public static string FindCountry(int CountryID)
        {
            string CountryName = CountryDAL.GetCountryName(CountryID);

            if ( CountryName != null)
            {
                return CountryName;
            }

            return null;

        }


        public static int GetCountryID(string CountryName)
        {
            return CountryDAL.GetCountryID(CountryName);
        }


    }
}
