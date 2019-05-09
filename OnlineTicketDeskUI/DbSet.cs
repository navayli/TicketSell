using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI
{
    public class DbSet<T>
    {
        private readonly List<T> _items;
        public DbSet()
        {
            _items = new List<T>();
        }
        public  void Add(T item)
        {
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public List<T> GetAll()
        {
            return _items;
        }




            
    }
}
