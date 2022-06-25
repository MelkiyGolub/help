using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public static class Database
    {
        private static ObservableCollection<Cat> _cats = new();

        public static ObservableCollection<Cat> GetCats()
        {
            return _cats;
        }

        public static void AddCat(Cat cat)
        {
            _cats.Add(cat);
        }
    }
}
