using System.Collections.Generic;
using System.Linq;

namespace generics_intro
{
    public class BookPager
    {
        public int ItemsPerPage { get; set; }

        public int PageNumber { get; set; }

        public List<Book> AllItems { get; set; }

        public List<Book> GetPage()
        {
            return AllItems
                .Skip(ItemsPerPage * PageNumber)
                .Take(ItemsPerPage)
                .ToList();
        }
    }
}