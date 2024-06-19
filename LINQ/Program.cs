using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

// ReSharper disable UseFormatSpecifierInInterpolation

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"C:\Users\Media\Desktop\Files\GoogleApps\googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            //Display(googleApps);
            //GetData(googleApps);
            //ProjectData(googleApps);
            //DivideData(googleApps);
            //OrderData(googleApps);
            //DataSetOperations(googleApps);
            //DataVerification(googleApps);
            //GroupData(googleApps);
            GroupDataOperations(googleApps);

            Console.ReadLine();

        }
        static void GroupDataOperations(IEnumerable<GoogleApp> googleApps)
        {
            /*
            var categoryGroup = googleApps
                .GroupBy(g => g.Category)
                .Where(g => g.Min(a => a.Reviews) > 10);
            */

            var categoryGroup = googleApps
              .GroupBy(g => g.Category);
              

            foreach (var group in categoryGroup)
            {
               var averageReviews =  group.Average(g => g.Reviews);
               var minReviews = group.Min(g => g.Reviews);
               var maxReviews =  group.Max(g => g.Reviews);

                var reviewsSum = group.Sum(g => g.Reviews);

               var allAppsFromGroupHaveRatingOfThree =  group.All(a => a.Rating > 3.0);

                Console.WriteLine($"categoryGroup: {group.Key}");
                Console.WriteLine($"averageReviews: {averageReviews}");
                Console.WriteLine($"minReviews: {minReviews}");
                Console.WriteLine($"maxReviews: {maxReviews}");
                Console.WriteLine($"reviewsSum: {reviewsSum}");
                Console.WriteLine($"allAppsFromGroupHaveRatingOfThree: {allAppsFromGroupHaveRatingOfThree}");
            }
        }
        static void GroupData(IEnumerable<GoogleApp> googleApps)
        {
            var categoryGroup = googleApps.GroupBy(g => new {g.Category, g.Type});

            foreach (var group in categoryGroup)
            {
                var key = group.Key;
                //var apps = artAndDesignGroup.Select(g => g);
                var apps = group.ToList();

                Console.WriteLine($"Displaying elemets for {group.Key.Category}, {group.Key.Type}");
                Display(apps);
            }
  
        }
        static void DataVerification(IEnumerable<GoogleApp> googleApps)
        {
            var allOperatorResult = googleApps.Where(app => app.Category == Category.WEATHER)
                .All(app => app.Reviews > 10);

            Console.WriteLine($"allOperatorResult: {allOperatorResult}");

            var anyOperatorResult = googleApps.Where(app => app.Category == Category.WEATHER)
               .Any(app => app.Reviews > 2_000_000);

            Console.WriteLine($"anyOperatorResult: {anyOperatorResult}");
        }


        static void DataSetOperations(IEnumerable<GoogleApp> googleApps)
        {
            var paidAppsCategories = googleApps.Where(app => app.Type == Type.Paid)
                .Select(app => app.Category)
                .Distinct(); //

            var dataSetA = googleApps.Where(app => app.Rating > 4.7 && app.Type == Type.Paid && app.Reviews > 1000);
            var dataSetB = googleApps.Where(app => app.Name.Contains("Pro") && app.Rating > 4.6 && app.Reviews > 10000);
            Console.WriteLine("dataSetA: ");
            Display(dataSetA);

            Console.WriteLine("**************");
            Console.WriteLine("dataSetB: ");
            Display(dataSetB);

            var dataUnion = dataSetA.Union(dataSetB);
            Console.WriteLine("**************");
            Console.WriteLine("dataUnion: ");
            Display(dataUnion);

            var dataIntersect = dataSetA.Intersect(dataSetB);
            Console.WriteLine("**************");
            Console.WriteLine("dataIntersect: ");
            Display(dataIntersect);

            var dataExept = dataSetA.Except(dataSetB);
            Console.WriteLine("**************");
            Console.WriteLine("dataExept: ");
            Display(dataExept);



        }
        static void OrderData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedPhotographyApps = googleApps.Where(app => app.Rating > 4.5 && app.Category == Category.PHOTOGRAPHY);

            var sortedResults = highRatedPhotographyApps.OrderBy(app => app.Rating);
            var sortedResults2 = highRatedPhotographyApps.OrderByDescending(app => app.Rating).ThenBy(app => app.Name);
            Display(sortedResults2);
        }
        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            var first5HighRatedBeautyApps = highRatedBeautyApps.Take(5);
            var whileHighRatedBeautyApps = highRatedBeautyApps.TakeWhile(app => app.Reviews > 1000);
            Display(whileHighRatedBeautyApps);

            var skippedResuts = highRatedBeautyApps.Skip(5);
            Console.WriteLine("Skipped results: ");
            Display(skippedResuts);
        }
        static void ProjectData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);

            Console.WriteLine(string.Join(",",highRatedBeautyAppsNames));

            var dtos = highRatedBeautyApps.Select(app => new GoogleAppDto() // Projction of data
            {
                Name = app.Name,
                Reviews = app.Reviews,
            });

            var anonymousDtos = highRatedBeautyApps.Select(app => new  // Anonymouse type
            {
                Name = app.Name,
                Reviews = app.Reviews,
                Category = app.Category,
            });

            foreach (var dto in dtos)
            {
                Console.WriteLine($"{dto.Name}: {dto.Reviews}");
            }

            var geners = highRatedBeautyApps.SelectMany(app => app.Genres);
        }
        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedApps = googleApps.Where(app => app.Rating > 4.6);
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            Display(highRatedBeautyApps);

            var firstHighRatedBeautyApps = highRatedBeautyApps.FirstOrDefault(app => app.Reviews < 300);
            var singleHighRatedBeautyApps = highRatedBeautyApps.SingleOrDefault(app => app.Reviews < 200);// only one record
            var lastHighRatedBeautyApps = highRatedBeautyApps.LastOrDefault(app => app.Reviews < 400);
            Console.WriteLine("firstHighRatedBeautyApps");
            Console.WriteLine(firstHighRatedBeautyApps);

            Console.WriteLine("singleHighRatedBeautyApps");
            Console.WriteLine(singleHighRatedBeautyApps);

            Console.WriteLine("lastHighRatedBeautyApps");
            Console.WriteLine(lastHighRatedBeautyApps);
        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }

        }
        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }
        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }

        }

    }
}
