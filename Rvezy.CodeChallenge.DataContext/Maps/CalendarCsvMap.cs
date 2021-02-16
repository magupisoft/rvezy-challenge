using CsvHelper.Configuration;
using Rvezy.CodeChallenge.Models;

namespace Rvezy.CodeChallenge.DataContext.Maps
{
    public class CalendarCsvMap : ClassMap<CalendarModel>
    {
        public CalendarCsvMap()
        {
            Map(m => m.ListingId).Name("listing_id");
            Map(m => m.Date).Name("date");
            Map(m => m.Available).Name("available");
            Map(m => m.Price).Name("price");
        }
    }

}
