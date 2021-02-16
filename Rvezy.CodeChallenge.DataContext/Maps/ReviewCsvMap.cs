using CsvHelper.Configuration;
using Rvezy.CodeChallenge.Models;

namespace Rvezy.CodeChallenge.DataContext.Maps
{
    public class ReviewCsvMap : ClassMap<ReviewModel>
    {
        public ReviewCsvMap()
        {
            Map(m => m.ListingId).Name("listing_id");
            Map(m => m.Id).Name("id");
            Map(m => m.Date).Name("date");
            Map(m => m.ReviewerId).Name("reviewer_id");
            Map(m => m.ReviewerName).Name("reviewer_name");
            Map(m => m.Comments).Name("comments");
        }
    }
}
