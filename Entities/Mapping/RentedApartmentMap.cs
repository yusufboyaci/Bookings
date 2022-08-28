using Core.Mapping;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class RentedApartmentMap : CoreMap<RentedApartmant>
    {
        public override void Configure(EntityTypeBuilder<RentedApartmant> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Postcode).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.City).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.State).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.StartingDate).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.EndDate).HasMaxLength(50).IsRequired(false);
            builder.HasOne(x => x.User).WithMany(x => x.RentedApartmants).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            base.Configure(builder);
        }
    }
}
