using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Data
{
    public class CountriesRepository
    {
        public IEnumerable<SelectListItem> GetCountries()
        {

            List<Country> lstCountry = new List<Country>{new Country { CountryId = "CA", CountryNameEnglish = "Canada" },
                                                         new Country { CountryId = "India", CountryNameEnglish = "India" },
                                                         new Country { CountryId = "US", CountryNameEnglish = "USA" }
                                                        };



            List<SelectListItem> countries = lstCountry
                .OrderBy(n => n.CountryNameEnglish)
                .Select(n =>
                    new SelectListItem
                    {
                        Value = n.CountryId.ToString(),
                        Text = n.CountryNameEnglish
                    }).ToList();

            //modelBuilder.Entity<Country>().HasData(
            //new Country
            //{
            //    CountryId = "US",
            //    CountryNameEnglish = "United States of America"
            //},
            //new Country
            //{
            //    CountryId = "CA",
            //    CountryNameEnglish = "Canada"
            //});


            var countrytip = new SelectListItem()
            {
                Value = null,
                Text = "--- select country ---"
            };
            countries.Insert(0, countrytip);
            return new SelectList(countries, "Value", "Text");
        }
    }
}
