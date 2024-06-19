using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{


    internal class Repository<T> where T  : IEntity, new() // must implemet interface IEntity and must have parameterless constactor  
    {
        private List<T> data = new List<T>();

        public void AddElemt(T elemet)
        {
            var newElement = new T();
            newElement.Id = 23;

            if (elemet != null) 
            {
                Console.WriteLine(elemet.Id);
                data.Add(elemet);
            }
           
        }
        public T GetElementById(int id)
        {
           var elemet = data.FirstOrDefault(e => e.Id == id);
            return elemet;
        }
        public T GetElemet(int index)
        {
            if( index < data.Count)
            {
                return data[index];
            }
            else
            {
                return default;
            }
        }
    }

    internal class Repository<TKey, TValue>
        where TKey : class
        where TValue : new()
    {
        private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();

        public void AddElemt(TKey key, TValue elemet)
        {
            if (elemet != null)
            {
                data.Add(key, elemet);
            }

        }

        public TValue GetElemet(TKey key)
        {
            if (data.TryGetValue(key, out TValue result))
            {
                return result;
            }
            else
            {
                return default;
            }
        }
    }
}
