using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rvezy.CodeChallenge.DataContext.Maps;
using Rvezy.CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Rvezy.CodeChallenge.DataContext.SeedData
{
    public class RvezyContextSeedInitializer 
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RvezyDataContext(serviceProvider.GetRequiredService<DbContextOptions<RvezyDataContext>>()))
            {
                if (context.Calendar.Any())  return;
                var calendarEntries = SeedData<CalendarModel, CalendarCsvMap>("Rvezy.CodeChallenge.DataContext.SeedData.calendar.csv");
                context.Calendar.AddRange(calendarEntries);

                if (context.Listing.Any())  return;
                var listings = SeedData<ListingModel, ListingCsvMap>("Rvezy.CodeChallenge.DataContext.SeedData.listings.csv");
                context.Listing.AddRange(listings);
                context.SaveChanges();

                if (context.Calendar.Any()) return;
                var reviews = SeedData<ReviewModel, ReviewCsvMap>("Rvezy.CodeChallenge.DataContext.SeedData.reviews.csv");
                context.Review.AddRange(reviews);
                context.SaveChanges();
            }
        }

        private static T[] SeedData<T, TModel>(string resourceName) where TModel : ClassMap
        {
            var badRecord = new List<string>();
            var missingFields = new List<int>();

            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    BadDataFound = x => badRecord.Add(x.get_Field()),
                    MissingFieldFound = x => missingFields.Add(x.get_Index()),
                    TrimOptions = TrimOptions.Trim
                };
                CsvReader csvReader = new CsvReader(reader, config);
                csvReader.Context.RegisterClassMap<TModel>();
                csvReader.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add("NULL");
                csvReader.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.AddRange(new[] { "NULL", "0" });
                csvReader.Context.TypeConverterOptionsCache.GetOptions<int?>().NullValues.Add("NULL");
                var entries = csvReader.GetRecords<T>().ToArray();
                return entries;
            }
        }
    }
}
