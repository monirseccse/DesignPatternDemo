using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class BookCollection : IEnumerable<string>
    {
        private List<string> _books;
        public BookCollection()
        {
            _books = new List<string>();
        }

        public void Add(string book)
        {
            _books.Add(book);
        }
        public IEnumerator<string> GetEnumerator()
        {
            return _books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
