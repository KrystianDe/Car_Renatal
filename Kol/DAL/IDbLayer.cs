using Kol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kol.DAL
{
    public interface IDbLayer
    {
        IEnumerable<Rent> GetRents();
        IEnumerable<Car> GetCars();

        void AddNewRent(Rent newRent);
    }
}
