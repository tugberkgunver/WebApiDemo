using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClassLibrary1;
using Heysem.WebApiDemo.DataAccess;
using Heysem.WebApiDemo.Entities;
using Microsoft.AspNetCore.Mvc;
using Rest;

namespace Heysem.WebApiDemo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : Controller
    {
        Class1 a = new Class1();

        ICountryDal _countryDal;
        IDestinationDal _destinationDal;
        ICountryDestinationsDal _countryDestinationsDal;

        public CountriesController(ICountryDal countryDal , ICountryDestinationsDal countryDestinationsDal)
        {
            _countryDal = countryDal;
            _countryDestinationsDal = countryDestinationsDal;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            var countries = _countryDal.GetList();
            return Ok(countries);
        }

        [HttpGet("{counrtyId}")]
        public IActionResult Get(int counrtyId)
        {
            try
            {
                var country = _countryDal.Get(x => x.CountryId == counrtyId);
                if (country == null)
                {
                    return NotFound($"There is no countryID with Id = {counrtyId}");
                }
                return Ok(country);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] Country country)
        {
            try
            {
                _countryDal.Add(country);

                return new StatusCodeResult(201);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Country country)
        {
            try
            {
                _countryDal.Update(country);

                return Ok(country);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpDelete("countryId")]
        public IActionResult Delete([FromBody] int countryId)
        {
            try
            {
                _countryDal.Delete(new Country { CountryId = countryId });

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetDestinations/{countryId}")]
        public IActionResult GetDestinations(int countryId)
        {

            var destinations = _countryDestinationsDal.GetCountryDestinations(countryId);
                return Ok(destinations);
          
        }




        //[HttpGet("book")]
        //public IActionResult Book(string value)
        //{
        //    var test = a.Test().Result;
        //    return Ok(test.InnerXml);

        //}



    }
}