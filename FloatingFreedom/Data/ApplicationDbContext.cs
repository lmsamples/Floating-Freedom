using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FloatingFreedom.Models;
using Microsoft.AspNetCore.Identity;

namespace FloatingFreedom.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Kayak> Kayaks { get; set; }
		public DbSet<KayakType> KayakTypes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Create a new user for Identity Framework
			ApplicationUser user = new ApplicationUser
			{
				Id = "00000000-ffff-ffff-ffff-ffffffffffff",
				Name = "admin",
				Address = "123 Infinity Way",
				UserName = "admin@admin.com",
				NormalizedUserName = "ADMIN@ADMIN.COM",
				Email = "admin@admin.com",
				NormalizedEmail = "ADMIN@ADMIN.COM",
				EmailConfirmed = true,
				LockoutEnabled = false,
				SecurityStamp = Guid.NewGuid().ToString("D")
			};
			var passwordHash = new PasswordHasher<ApplicationUser>();
			user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
			modelBuilder.Entity<ApplicationUser>().HasData(user);


			modelBuilder.Entity<KayakType>().HasData(

				new KayakType () {
				Id = 1,
                Name = "Sit-On-Top"

				},

				new KayakType()
				{
					Id = 2,

					Name = "Recreational"

				},

				new KayakType()
				{
					Id = 3,
					Name = "Touring"

				},

				new KayakType()
				{
					Id = 4,
					Name = "Inflatable"

				},

				new KayakType()
				{
					Id = 5,
					Name = "Pedaling"

				}
				);


			modelBuilder.Entity<Kayak>().HasData(

				new Kayak()
				{
					Id = 29,
					KayakTypeId = 1,
					UserId = user.Id,
					Name = "Sun Dolphin Destin #01",
				},
				new Kayak()
				{
					Id = 30,
					KayakTypeId = 1,
					UserId = user.Id,
					Name = "Sun Dolphin Destin #02",
				},
				new Kayak()
				{
					Id = 31,
					KayakTypeId = 1,
					UserId = user.Id,
					Name = "Sun Dolphin Destin #03",
				},
				new Kayak()
				{
					Id = 32,
					KayakTypeId = 1,
					UserId = user.Id,
					Name = "Sun Dolphin Destin #04",
				},
				new Kayak()
				{
					Id = 33,
					KayakTypeId = 1,
					UserId = user.Id,
					Name = "Sun Dolphin Destin #05",
				},


				new Kayak()
				{
					Id = 34,
					KayakTypeId = 2,
					UserId = user.Id,
					Name = "Sun Dolphin Phoenix #01",
				},
				new Kayak()
				{
					Id = 35,
					KayakTypeId = 2,
					UserId = user.Id,
					Name = "Sun Dolphin Phoenix #02",
				},
				new Kayak()
				{
					Id = 36,
					KayakTypeId = 2,
					UserId = user.Id,
					Name = "Sun Dolphin Phoenix #03",
				},
				new Kayak()
				{
					Id = 37,
					KayakTypeId = 2,
					UserId = user.Id,
					Name = "Sun Dolphin Phoenix #04",
				},
				new Kayak()
				{
					Id = 38,
					KayakTypeId = 2,
					UserId = user.Id,
					Name = "Sun Dolphin Phoenix #05",
				},


				new Kayak()
				{
					Id = 39,
					KayakTypeId = 3,
					UserId = user.Id,
					Name = "Sun Dolphin Aruba #01",
				},
				new Kayak()
				{
					Id = 40,
					KayakTypeId = 3,
					UserId = user.Id,
					Name = "Sun Dolphin Aruba #02",
				},
				new Kayak()
				{
					Id = 41,
					KayakTypeId = 3,
					UserId = user.Id,
					Name = "Sun Dolphin Aruba #03",
				},
				new Kayak()
				{
					Id = 42,
					KayakTypeId = 3,
					UserId = user.Id,
					Name = "Sun Dolphin Aruba #04",
				},
				new Kayak()
				{
					Id = 43,
					KayakTypeId = 3,
					UserId = user.Id,
					Name = "Sun Dolphin Aruba #05",
				},


				new Kayak()
				{
					Id = 44,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #01",
				},
				new Kayak()
				{
					Id = 45,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #02",
				},
				new Kayak()
				{
					Id = 46,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #03",
				},
				new Kayak()
				{
					Id = 47,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #04",
				},
				new Kayak()
				{
					Id = 20,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #05",
				},
				new Kayak()
				{
					Id = 21,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #06",
				},
				new Kayak()
				{
					Id = 22,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #07",
				},
				new Kayak()
				{
					Id = 23,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #08",
				},
				new Kayak()
				{
					Id = 24,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #09",
				},
				new Kayak()
				{
					Id = 25,
					KayakTypeId = 4,
					UserId = user.Id,
					Name = "Intex Explorer K2 #10",
				},


				new Kayak()
				{
					Id = 26,
					KayakTypeId = 5,
					UserId = user.Id,
					Name = "BKC PK12 #01",
				},
				new Kayak()
				{
					Id = 27,
					KayakTypeId = 5,
					UserId = user.Id,
					Name = "BKC PK12 #02",
				},
				new Kayak()
				{
					Id = 28,
					KayakTypeId = 5,
					UserId = user.Id,
					Name = "BKC PK12 #03",
				}

			);
			modelBuilder.Entity<Customer>().HasData(
			new Customer()
			{
				Id = 10,
				UserId = user.Id,
				KayakId = 1,
				Name = "John Doe",
				PhoneNumber = "304-123-1234",
				Email = "email@email.com",
				RentalDate = new DateTime(2020, 1, 27, 3, 30, 00),
				ReturnDate = new DateTime(2022, 2, 28, 5, 30, 00)
			},
			new Customer()
			{
				Id = 11,
				UserId = user.Id,
				KayakId = 18,
				Name = "Anne Example",
				PhoneNumber = "304-321-1111",
				Email = "email@email.com",
				RentalDate = new DateTime(2020, 1, 27, 3, 30, 00),
				ReturnDate = new DateTime(2022, 2, 28, 5, 30, 00)
			}
		);
		}
	}
}
