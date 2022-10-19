using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
    internal class ApplicationDictionary<Tkey, Tvalue>
    {
        private Dictionary<Tkey, Tvalue> _dictionary;
        public ApplicationDictionary()
        {
            _dictionary = new Dictionary<Tkey, Tvalue>();
        }
        public void Add(Tkey key, Tvalue value)
        {
            _dictionary.Add(key, value);
        }
        public void Remove(Tkey key)
        {
            _dictionary.Remove(key);
        }
        public Tvalue GetValueByKey(Tkey key)
        {
            if (_dictionary.ContainsKey(key))
            {
                _dictionary.TryGetValue(key, out Tvalue? value);
                return value;
            }

            else
            {
                throw new Exception("Этого ключа нет в словаре");
            }
        }
        public void ListOfKey()
        {
            foreach (var temp in _dictionary)
            { Console.WriteLine(temp.Key); }
        }

    }
}

