using SearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Service
{
    public class SearchService
    {
        List<Search> results = new()
        {
            new Search
            {
                Id = 1,
                Title = "KURSLAR.AZ - KURSLAR və Telimler, Online kurslar",
                Description = "Telimlər, Online kurslar. Bakida hazirliq kurslari 2022",
                Url = "adswff"

            },
            new Search
            {
                Id = 2,
                Title = "KURSLAR.AZ - KURSLAR və Telimler, Online kurslar",
                Description = "Telimlər, Online kurslar. Bakida hazirliq kurslari 2022",
                Url = "fdggtg"

            },
            new Search
            {
                Id = 3,
                Title = "KURSLAR.AZ - KURSLAR və Telimler, Online kurslar",
                Description = "Telimlər, Online kurslar. Bakida hazirliq kurslari 2022",
                Url = "rgggge"

            }
        };

        public List<Search> Searching(string Name)
        {
            var res = results.Where(x => x.Title.Contains(Name) || x.Description.Contains(Name)).ToList();
            return results;
        }



    }
}
