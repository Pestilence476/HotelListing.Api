using HotelListing.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Domain.Configurations;

public class ApiKeyConfiguration : IEntityTypeConfiguration<ApiKey>
{
    public void Configure(EntityTypeBuilder<ApiKey> builder)
    {
        builder.HasIndex(k => k.Key).IsUnique();
        builder.HasData(
            new ApiKey
            {
                //Guid values
                Id = 1,
                AppName = "app",
                CreatedAtUtc = new DateTime(2026, 06, 03),
                Key = "dXNlcjFAbG9jYWxob3N0LmNvbTpQQHNzd29yZDE="
            }
        );
    }
}
