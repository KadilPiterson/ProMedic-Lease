using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Utilities
{
    public class IdentityMap<T>
    {
        private Dictionary<long, T> map = new Dictionary<long, T>();

        public T GetOrCreate(long id, Func<T> createItem)
        {
            if (map.ContainsKey(id))
            {
                return map[id];
            }
            else
            {
                var newItem = createItem();
                map.Add(id, newItem);
                return newItem;
            }
        }

        public void Clear()
        {
            map.Clear();
        }

        public bool Remove(long id)
        {
            return map.Remove(id);
        }

        public bool Update(long id, T newItem)
        {
            if (map.ContainsKey(id))
            {
                map[id] = newItem;
                return true;
            }
            return false;
        }

        public void Add(long id, T item)
        {
            map.Add(id, item);
        }

        public T Get(long id)
        {
            if (map.ContainsKey(id))
            {
                return map[id];
            }
            return default(T);
        }

        public bool ContainsKey(long id)
        {
            return map.ContainsKey(id);
        }
    }
}
