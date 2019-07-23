using Kol.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol.DAL
{
    public class SqlServerDbContext : IDbLayer
    {
        private readonly RentDbContext _context;

        public SqlServerDbContext(RentDbContext context)
        {
            _context = context;
        }
        public void AddNewRent(Rent newRent)
        {
            _context.Rents.Add(newRent);
            _context.SaveChanges();
        }

        public IEnumerable<Car> GetCars()
        {
            return _context.Cars.ToList();
        }

        public IEnumerable<Rent> GetRents()
        {
            return _context.Rents.Include(p => p.Car).ToList();
        }
    }
}
