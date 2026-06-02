using HotelListing.Api.Data;
using HotelListing.Api.Repository;
using Microsoft.AspNetCore.Mvc;


namespace HotelListing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController(ICountryRepository countryRepository) : ControllerBase
    {


        // GET: api/<CountriesController>
        [HttpGet]
        public ActionResult<IEnumerable<Country>> Get()
        {
            return Ok(countryRepository.GetAll());
        }

        // GET api/<CountriesController>/5
        [HttpGet("{id}")]
        public ActionResult<Country> Get(int id)
        {
            var country = countryRepository.GetById(id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST api/<CountriesController>
        [HttpPost]
        public ActionResult<Country> Post([FromBody] Country newCountry)
        {
            if (countryRepository.Exists(newCountry.Id))
            {
                return BadRequest("Country with this Id already exists.");
            }

            countryRepository.Create(newCountry);
            return CreatedAtAction(nameof(Get), new { id = newCountry.Id }, newCountry);
        }

        // PUT api/<CountriesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Country updatedCountry)
        {
            var updated = countryRepository.Update(id, updatedCountry);
            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE api/<CountriesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var deleted = countryRepository.Delete(id);
            if (!deleted)
            {
                return NotFound(new { message = "Country not found."});
            }

            return NoContent();

        }
    }
}
