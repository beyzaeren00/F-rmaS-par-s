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
    internal class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CompanyId);
            builder.Property(x => x.productName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.productStock).IsRequired();
            builder.Property(x => x.productPrice).IsRequired();
            
            builder.HasOne(x=> x.Company).WithMany(x => x.Products).HasForeignKey(x=> x.CompanyId);


        }
    }
}
