using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }

    public class RentedApartmantRepository : Repository<RentedApartmant>
    {
        private readonly AppDbContext _context;
        public RentedApartmantRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
