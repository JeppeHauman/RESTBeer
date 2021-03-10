using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave_1;

namespace RESTBeer.Managers
{
    public class BeerManagerEntity : IBeerManager
    {
        public List<Beer> GetAll(string name = null, string sortBy = null)
        {
            throw new NotImplementedException();
        }

        public Beer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Beer Add(Beer newBeer)
        {
            throw new NotImplementedException();
        }

        public Beer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Beer Update(int id, Beer updates)
        {
            throw new NotImplementedException();
        }
    }
}
