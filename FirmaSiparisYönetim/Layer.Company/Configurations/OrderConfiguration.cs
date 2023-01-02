using Layer.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure (EntityTypeBuilder<Order> builder)   
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.CompanyId);
            builder.Property(x => x.ProductsId);
            builder.Property(x => x.CustomerName).IsRequired().HasMaxLength(70);
            builder.Property(x => x.OrderDate);
            
        }
    }
}
