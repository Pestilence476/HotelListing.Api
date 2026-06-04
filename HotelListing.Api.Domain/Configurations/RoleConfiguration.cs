using HotelListing.Api.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Domain.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                //Guid values
                Id = "efb20e03-2ac8-4560-ad8a-7c5044564b34",
                Name = RoleNames.Administrator,
                NormalizedName = RoleNames.Administrator.ToUpper()
            },
            new IdentityRole
            {
                Id = "1ac0614a-9261-42a8-a017-b26a27ddf6ad",
                Name = RoleNames.User,
                NormalizedName = RoleNames.User.ToUpper()
            },
            new IdentityRole
            {
                Id = "cbc71780-4548-4f6e-a8d7-a92eec9669cd",
                Name = RoleNames.HotelAdmin,
                NormalizedName = RoleNames.HotelAdmin.ToUpper()
            }
        );
    }
}
