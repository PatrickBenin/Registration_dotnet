using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Data
{
    public class CitiesRepository
    {
        public IEnumerable<SelectListItem> GetCities()
        {
            List<SelectListItem> cities = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = null,
                    Text = " "
                }
            };
            return cities;
        }

        public IEnumerable<SelectListItem> GetCities(string countryId)
        {
            if (!String.IsNullOrWhiteSpace(countryId))
            {

                List<City> lstCountry = new List<City> { new City { CountryId = "US", CityId = "India", CityNameEnglish = "Connecticut"},
                                                         new City { CountryId = "US",CityId = "ME",CityNameEnglish = "Maine"},
                                                         new City { CountryId = "US",CityId = "MA",CityNameEnglish = "Massachusetts"},
                                                         new City { CountryId = "US",CityId = "NH",CityNameEnglish = "New Hampshire"},
                                                         new City { CountryId = "US",CityId = "RI",CityNameEnglish = "Rhode Island"},
                                                         new City { CountryId = "US",CityId = "VE",CityNameEnglish = "Vermont"},
                                                         new City { CountryId = "US",CityId = "NB",CityNameEnglish = "New Brunswick"},
                                                         new City { CountryId = "US",CityId = "NF",CityNameEnglish = "Newfoundland"},
                                                         new City { CountryId = "CA",CityId = "NT",CityNameEnglish = "Northwest Territories"},
                                                         new City { CountryId = "CA",CityId = "NU",CityNameEnglish = "Nunavut"},
                                                         new City { CountryId = "CA",CityId = "ON",CityNameEnglish = "Ontario"},
                                                         new City { CountryId = "CA",CityId = "PE",CityNameEnglish = "Prince Edward Island"},
                                                         new City { CountryId = "CA",CityId = "NS",CityNameEnglish = "Nova Scotia"},
                                                         new City { CountryId = "CA",CityId = "QC",CityNameEnglish = "Québec"},
                                                         new City { CountryId = "CA",CityId = "SK",CityNameEnglish = "Saskatchewan"},
                                                         new City { CountryId = "CA",CityId = "YT",CityNameEnglish = "Yukon"},

               };
                    
           
            IEnumerable<SelectListItem> regions = lstCountry
                    .OrderBy(n => n.CityNameEnglish)
                    .Where(n => n.CountryId == countryId)
                    .Select(n =>
                        new SelectListItem
                        {
                            Value = n.CityId,
                            Text = n.CityNameEnglish
                        }).ToList();
                return new SelectList(regions, "Value", "Text");
            }
            return null;
        }
    }
}
