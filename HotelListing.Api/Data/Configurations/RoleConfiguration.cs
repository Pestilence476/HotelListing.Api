using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Data.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                //Guid values
                Id = "efb20e03-2ac8-4560-ad8a-7c5044564b34",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
            },
            new IdentityRole
            {
                Id = "1ac0614a-9261-42a8-a017-b26a27ddf6ad",
                Name = "User",
                NormalizedName = "USER",
            }
        );
    }
}
