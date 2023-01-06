using AuthServer.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Web.Helpers;

namespace AuthServer.API.Data
{
    public static class SeedData
    {
        public static void SeedUser(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsDelete = false,
                    Email = "muhammetcagatay@gmail.com",
                    Password = Crypto.HashPassword("123456"),
                }
            );
        }
    }
}
