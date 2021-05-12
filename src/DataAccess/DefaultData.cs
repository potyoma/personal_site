using System;
using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace DataAccess
{
    public static class DefaultData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Owner>().HasData(new[]
            {
                new Owner
                {
                    Id = Guid.NewGuid(),
                    Name = "Artyom Novoselov",
                    Username = "potyoma",
                    Firstname = "Artyom",
                    Lastname = "Novoselov",
                    Email = "artyomnovosyolov254@gmail.com"
                }
            });
        }
    }
}