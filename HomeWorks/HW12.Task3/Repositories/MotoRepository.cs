
using HW12.Task3.Types;
using System;
using System.Collections.Generic;

namespace HW12.Task3.Repositories
{
    class MotoRepository : IRepository<Motorcycle>
    {
        private List<Motorcycle> _motorcycles;
        internal MotoRepository()
        {
           _motorcycles = new List<Motorcycle>();
        }

        public void Create(Motorcycle item)
        {
            Logger.Log.Info($"Item {item.ID} was created");

            _motorcycles.Add(item);
        }

        public void Delete(Guid id)
        {
            Logger.Log.Info($"Item {id} was deleted");

            _motorcycles.Remove(GetByID(id));
        }

        public IEnumerable<Motorcycle> GetAll()
        {
            return _motorcycles;
        }

        public Motorcycle GetByID(Guid id)
        {
            Motorcycle result = new Motorcycle();

            foreach (Motorcycle motorcycle in _motorcycles)
            {
                if (motorcycle.ID == id)
                {
                    result = motorcycle;
                    break;
                }
            }
            return result;
        }

        public void Update(Motorcycle motorcycle)
        {
            Logger.Log.Info($"Item {motorcycle.ID} was updated");

            int index = 0;
            for  (int i = 0; i<_motorcycles.Count; i++)
            {
                if (_motorcycles[i].ID==motorcycle.ID)
                {
                    index = i;
                    break;
                }
            }
            _motorcycles[index] = motorcycle;
        }
    }
}
