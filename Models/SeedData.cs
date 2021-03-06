﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookStoreContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                //seed the data 
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFname = "Victor",
                        AuthorMiddle = "",
                        AuthorLname = "Hugo",
                        Classification = "Fiction",
                        Publisher = "Signet",
                        Category = "Classic",
                        ISBN = "978-0451419439",
                        Price = 9.95,
                        Pages = 1488,
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFname = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLname = "Goodwin",
                        Classification = "Non-Fiction",
                        Publisher = "Simon & Schuster",
                        Category = "Biography",
                        ISBN = "978-0743270755",
                        Price = 14.58,
                        Pages = 944,
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFname = "Alice",
                        AuthorMiddle = "",
                        AuthorLname = "Schroeder",
                        Classification = "Non-Fiction",
                        Publisher = "Bantam",
                        Category = "Biography",
                        ISBN = "978-0553384611",
                        Price = 21.54,
                        Pages = 832,
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFname = "Ronald",
                        AuthorMiddle = "C",
                        AuthorLname = "White",
                        Classification = "Non-Fiction",
                        Publisher = "Random House",
                        Category = "Biography",
                        ISBN = "978-0812981254",
                        Price = 11.61,
                        Pages = 864,
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFname = "Laura",
                        AuthorMiddle = "",
                        AuthorLname = "Hillenbrand",
                        Classification = "Non-Fiction",
                        Publisher = "Random House",
                        Category = "Historical",
                        ISBN = "978-0812974492",
                        Price = 13.33,
                        Pages = 528,
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFname = "Michael",
                        AuthorMiddle = "",
                        AuthorLname = "Crichton",
                        Classification = "Fiction",
                        Publisher = "Vintage",
                        Category = "Historical Fiction",
                        ISBN = "978-0804171281",
                        Price = 15.95,
                        Pages = 288,
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFname = "Cal",
                        AuthorMiddle = "",
                        AuthorLname = "Newport",
                        Classification = "Non-Fiction",
                        Publisher = "Grand Central Publishing",
                        Category = "Self-Help",
                        ISBN = "978-1455586691",
                        Price = 14.99,
                        Pages = 304,
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFname = "Michael",
                        AuthorMiddle = "",
                        AuthorLname = "Abrashoff",
                        Classification = "Non-Fiction",
                        Publisher = "Grand Central Publishing",
                        Category = "Self-Help",
                        ISBN = "978-1455523023",
                        Price = 21.66,
                        Pages = 240,
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFname = "Richard",
                        AuthorMiddle = "",
                        AuthorLname = "Branson",
                        Classification = "Non-Fiction",
                        Publisher = "Portfolio",
                        Category = "Business",
                        ISBN = "978-1591847984",
                        Price = 29.16,
                        Pages = 400,
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFname = "Josh",
                        AuthorMiddle = "",
                        AuthorLname = "Grisham",
                        Classification = "Fiction",
                        Publisher = "Bantam",
                        Category = "Thrillers",
                        ISBN = "978-0553393613",
                        Price = 15.03,
                        Pages = 642,
                    },

                    new Book
                    {
                        Title = "The Count of Monte Cristo",
                        AuthorFname = "Alexandre",
                        AuthorMiddle = "",
                        AuthorLname = "Dumas",
                        Classification = "Non-Fiction",
                        Publisher = "Bantam",
                        Category = "Adventure",
                        ISBN = "978-0553213508",
                        Price = 6.95,
                        Pages = 544,
                    },


                    new Book
                    {
                        Title = "The Words of Radiance",
                        AuthorFname = "Brandon",
                        AuthorMiddle = "",
                        AuthorLname = "Sanderson",
                        Classification = "Fiction",
                        Publisher = "Tom Doherty Associates",
                        Category = "Fantasy",
                        ISBN = "978-1250166531",
                        Price = 16.99,
                        Pages = 1104,
                    },

                    new Book
                    {
                        Title = "Oathbringer",
                        AuthorFname = "Brandon",
                        AuthorMiddle = "",
                        AuthorLname = "Sanderson",
                        Classification = "Fiction",
                        Publisher = "Tor Books",
                        Category = "Fantasy",
                        ISBN = "978-0765399830",
                        Price = 15.03,
                        Pages = 1248,
                    }
                );
                //save seeded data to the db
                context.SaveChanges();
            }
        }
    }
}
