using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public EfProductRepository(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Product> Products => _context.Products;
    }
}
