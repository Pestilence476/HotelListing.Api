using HotelListing.Api.Data;


namespace HotelListing.Api.Repository;

public class InMemoryCountryRepository : ICountryRepository
{

    private readonly List<Country> countries =
    [
        new Country { Id = 1, Name = "Jamaica", ShortName = "JM"},
        new Country { Id = 2, Name = "Bahamas", ShortName = "BS"},
        new Country { Id = 3, Name = "Cayman Island", ShortName = "CI"}

    ];


    public IEnumerable<Country> GetAll()
    {
        return countries;
    }

    public Country? GetById(int id)
    {
        return countries.FirstOrDefault(c => c.Id == id);
    }

    public bool Exists(int id)
    {
        return countries.Any(c => c.Id == id);
    }

    public void Create (Country country)
    {
        countries.Add(country);
    }

    public bool Update(int id, Country country)
    {
        var existingCountry = countries.FirstOrDefault(c => c.Id == id);
        if (existingCountry != null)
        {
            return false;
        }

        existingCountry.Name = country.Name;
        existingCountry.ShortName = country.ShortName;

        return true;

    }

    public bool Delete(int id)
    {
        var country = countries.FirstOrDefault(c => c.Id == id);
        if (country is null)
        {
            return false;
        }

        countries.Remove(country);
        return true;
    }
}
