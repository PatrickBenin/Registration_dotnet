using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationForm.Models;
using RegistrationForm.ViewModel;
using RegistrationForm.Data;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public RegistrationEditViewModel RegistrationEditViewModel { get; set; }


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #region Private Methods
        //void BindCountry()
        //{
        //    List<Country> lstCountry = new List<Country>{new Country { ID = null, Name = "Select" },
        //                                                 new Country { ID = 1, Name = "India" },
        //                                                 new Country { ID = 2, Name = "USA" }
        //                                                };

        //    ViewBag.Country = lstCountry;
        //}

        //for server side
        //void BindCity(int? mCountry)
        //{
        //    try
        //    {
        //        if (mCountry != 0)
        //        {
        //            //below code is only for demo, since city list will come from database based on country
        //            //Hence remove below lines of code when you will query data from city table with in database based on country 
        //            int index = 1;
        //            List<City> lstCity = new List<City>{

        //             new City
        //            {
        //                Country = 0,
        //                ID=null,   // using index++ for making unique ID for city
        //                Name = "Select"
        //            },
        //                new City
        //            {
        //                Country = 1,
        //                ID=index++,   // using index++ for making unique ID for city
        //                Name = "Delhi"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Lucknow"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Noida"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Guragon"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Pune"
        //            },

        //        new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "New-York"
        //            },
        //           new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "California"
        //            },
        //        new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "Washington"
        //            },
        //        new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "Vermont"
        //            },

        //    };

        //            var city = from c in lstCity
        //                       where c.Country == mCountry || c.Country == 0
        //                       select c;

        //            ViewBag.City = city;

        //        }
        //        else
        //        {
        //            List<City> City = new List<City> { new City { ID = null, Name = "Select" } };
        //            ViewBag.City = City;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }


        //}
        #endregion

        //for client side using jquery
        //public JsonResult CityList(int mCountry)
        //{
        //    try
        //    {
        //        if (mCountry != 0)
        //        {
        //            //below code is only for demo, since city list will come from database based on country
        //            //Hence remove below lines of code when you will query data from city table with in database based on country 
        //            int index = 1;
        //            List<City> lstCity = new List<City>{

        //         new City
        //            {
        //                Country = 0,
        //                ID=null,   // using index++ for making unique ID for city
        //                Name = "Select"
        //            },
        //                new City
        //            {
        //                Country = 1,
        //                ID=index++,   // using index++ for making unique ID for city
        //                Name = "Delhi"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Lucknow"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Noida"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Guragon"
        //            },
        //        new City
        //            {
        //                Country = 1,
        //                ID=index++,
        //                Name = "Pune"
        //            },

        //        new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "New-York"
        //            },
        //           new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "California"
        //            },
        //        new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "Washington"
        //            },
        //        new City
        //            {
        //                Country = 2,
        //                ID=index++,
        //                Name = "Vermont"
        //            },

        //    };

        //            var city = from c in lstCity
        //                       where c.Country == mCountry || c.Country == 0
        //                       select c;

        //            //  return Json(city, JsonRequestBehavior.AllowGet);
        //            return Json(new SelectList(city.ToArray(), "ID", "Name"), JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return Json(null);
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            //BindCountry();
            //BindCity(0);

            var repo = new RegistrationRepository();
            var RegistrationEditViewModel = repo.CreateRegistration();
            //return Page();
            return View(RegistrationEditViewModel);
        }


        [HttpPost]
        public ActionResult RegistrationForm(Registration mRegister)
        {
            try
            {
                //Check Server Side Validation by using data annotation
                if (ModelState.IsValid)
                {
                    return View("Completed");
                }
                //else
                //{
                //    // To DO: if client validation failed
                //    ViewBag.Selpwd = mRegister.Password; //for setting password value
                //    ViewBag.Selconfirmpwd = mRegister.ConfirmPassword;
                //    ViewBag.SelCountry = mRegister.Country; // for setting selected country
                //                                            //BindCountry();
                //                                            //ViewBag.SelCity = mRegister.City;// for setting selected city

                //    //if (mRegister.Country != null)
                //    //    BindCity(mRegister.Country.ID);
                //    //else
                //    //    BindCity(null);
                //    throw new ApplicationException("Invalid model");
                //    //return View();
                //}
                return View();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }                    

        }

        [HttpPost]
        public IActionResult Cities()
        {
            MemoryStream stream = new MemoryStream();
            Request.Body.CopyToAsync(stream);
            stream.Position = 0;
            using StreamReader reader = new StreamReader(stream);
            string requestBody = reader.ReadToEnd();
            if (requestBody.Length > 0)
            {
                var repo = new CitiesRepository();

                IEnumerable<SelectListItem> cities = repo.GetCities(requestBody);
                return new JsonResult(cities);
            }
            return null;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
