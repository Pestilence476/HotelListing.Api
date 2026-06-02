using HotelListing.Api.Data;


namespace HotelListing.Api.Repository


{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll();
        Country? GetById(int id);
        bool Exists(int id);
        void Create(Country country);
        bool Update(int id, Country country);
        bool Delete(int id);
    }
}
