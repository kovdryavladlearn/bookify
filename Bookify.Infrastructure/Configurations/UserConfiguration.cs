﻿using Bookify.Domain.Apartments;
using Bookify.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookify.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(user => user.Id);

        builder.Property(apartment => apartment.FirstName)
            .HasMaxLength(200)
            .HasConversion(firstName => firstName.Value, value => new FirstName(value));
        
        builder.Property(apartment => apartment.LastName)
            .HasMaxLength(200)
            .HasConversion(lastName => lastName.Value, value => new LastName(value));

        builder.Property(apartment => apartment.Email)
            .HasMaxLength(400)
            .HasConversion(email => email.Value, value => new Domain.Users.Email(value));

        builder.HasIndex(user => user.Email).IsUnique();
    }
}