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
					Id = 1,
					KayakTypeId = 2,
					UserId = user.Id,
					Name = "Kayak boy",
				},

				new Kayak()
				{
					Id = 2,
					KayakTypeId = 3,
					UserId = user.Id,
					Name = "Kayak boy but for the long boy",
				},

				new Kayak()
				{
					Id = 3,
					KayakTypeId = 2,
					UserId = user.Id,
					Name = "Kayak boy but for a different boy",
				}
			);
			modelBuilder.Entity<Customer>().HasData(
			new Customer()
			{
				Id = 1,
				UserId = user.Id,
				KayakId = 1,
				Name = "Customer Boy",
				PhoneNumber = "304-123-1234",
				Email = "emailboy@email.com",
				RentalDate = new DateTime(2020, 1, 27, 3, 30, 00),
				ReturnDate = new DateTime(2022, 2, 28, 5, 30, 00)
			}
		);
		}
	}
}
