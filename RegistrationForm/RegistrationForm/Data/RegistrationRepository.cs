using RegistrationForm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Data
{
    public class RegistrationRepository
    {
        public RegistrationEditViewModel CreateRegistration()
        {
            var cRepo = new CountriesRepository();
            var rRepo = new CitiesRepository();
            var registration = new RegistrationEditViewModel()
            {
                Countries = cRepo.GetCountries(),
                Cities = rRepo.GetCities()
            };
            return registration;
        }

        //public bool SaveCustomer(CustomerEditViewModel customeredit)
        //{
        //    if (customeredit != null)
        //    {
        //        if (Guid.TryParse(customeredit.CustomerId, out Guid newGuid))
        //        {
        //            var customer = new Customer()
        //            {
        //                CustomerId = newGuid,
        //                CustomerName = customeredit.CustomerName,
        //                CountryId = customeredit.SelectedCountryId,
        //                RegionId = customeredit.SelectedRegionId
        //            };
        //            customer.Country = _context.Countries.Find(customeredit.SelectedCountryId);
        //            customer.Region = _context.Regions.Find(customeredit.SelectedRegionId);

        //            _context.Customers.Add(customer);
        //            _context.SaveChanges();
        //            return true;
        //        }
        //    }
        //    // Return false if customeredit == null or CustomerID is not a guid
        //    return false;
        //}
    }
}
