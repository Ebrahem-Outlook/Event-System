using Event_System.Domain.Products;
using Event_System.Domain.Products.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Event_System.Infrastructure.Configuraitons;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {  // Configure the table name
        builder.ToTable("Products");

        // Configure the primary key
        builder.HasKey(p => p.Id);

        // Configure the properties
        builder.Property(p => p.Name)
            .HasConversion(name => name.Value, value => new Name(value))
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Description)
            .HasConversion(description => description.Value, value => new Description(value))
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(p => p.Price)
            .HasConversion(price => price.Value, value => new Price(value))
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.Stock)
            .HasConversion(stock => stock.Value, value => new Stock(value))
            .IsRequired();

        // Configure the collection of Photos
        builder.OwnsMany(p => p.Photos, photoBuilder =>
        {
            photoBuilder.ToTable("ProductPhotos");
            photoBuilder.WithOwner().HasForeignKey("ProductId");
            photoBuilder.Property<int>("Id");
            photoBuilder.HasKey("Id");
            photoBuilder.Property(p => p.Url)
                .HasConversion(url => url.Value, value => new Url(value))
                .IsRequired();
        });

        // Configure the audit fields
        builder.Property(p => p.CreatedAt).IsRequired();
        builder.Property(p => p.LastModifiedAt);
        builder.Property(p => p.IsDeleted).IsRequired();
        builder.Property(p => p.DeletedAt);

        // Apply any other configurations as needed

    }
}
