using Core.Mapping;
using Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class UserMap : CoreMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(50).IsRequired(false);
            builder.HasMany(x => x.RentedApartmants).WithOne(x => x.User);
            base.Configure(builder);
        }
    }
}
