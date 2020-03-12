using System.Collections.Generic;
using System.Linq;

namespace generics_intro
{
    public class Pager<T> // ! T for Type
        {
            public int ItemsPerPage { get; set; }

            public int PageNumber { get; set; }

            public List<T> AllItems { get; set; }

            public List<T> GetPage()
            {
                return AllItems
                    .Skip(ItemsPerPage * PageNumber)
                    .Take(ItemsPerPage)
                    .ToList();
            }
        }
}