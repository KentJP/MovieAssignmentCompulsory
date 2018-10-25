using MovieRatingAssignment.Core.DomainService;
using MovieRatingAssignment.Core.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MovieRatingAssignment.Infrastructure.Repository
{
    public class MovieReviewRepository : IMovieReviewRepository
    {
        private const string FILE_NAME = "ratings.json";  // Change the path
        public static List<MovieReview> ratings = new List<MovieReview>();

        public static void InitJsonRead()
        {
         //   List<MovieReview> ratings = new List<MovieReview>();

            Console.Write("Converting Json file to objects... ");

            Stopwatch sw = Stopwatch.StartNew();

            using (StreamReader streamReader = new StreamReader(FILE_NAME))
            using (JsonTextReader reader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                try
                {
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            MovieReview mr = ReadOneMovieRating(reader);
                            ratings.Add(mr);
                        }
                    }
                }
                catch (JsonReaderException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            sw.Stop();
            Console.WriteLine("Done. Time = {0:f4} sec.", sw.ElapsedMilliseconds / 1000d);
            Console.ReadLine();
           

        }

        private static MovieReview ReadOneMovieRating(JsonTextReader reader)
        {
            MovieReview m = new MovieReview();
            for (int i = 0; i < 4; i++)
            {
                reader.Read();
                switch (reader.Value)
                {
                    case "Reviewer": m.Reviewer = (int)reader.ReadAsInt32(); break;
                    case "Movie": m.Movie = (int)reader.ReadAsInt32(); break;
                    case "Grade": m.Grade = (int)reader.ReadAsInt32(); break;
                    case "Date": m.Date = (DateTime)reader.ReadAsDateTime(); break;
                    default: throw new InvalidDataException("no such token: " + reader.Value);
                }
            }
            return m;
        }

        public int getAmountOfSpecificRatingForMovie(int id, int grade)
        {
            throw new NotImplementedException();
        }

        public double getAverageRateFromReviewer(int id)
        {
            throw new NotImplementedException();
        }

        public double getAverageRatingForMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<int> getIdsFromHighestRatedMovies()
        {
            throw new NotImplementedException();
        }

        public List<MovieReview> getMostActiveReviewers()
        {
            throw new NotImplementedException();
        }

        public List<MovieReview> getMoviesRatedByReviewers(int id)
        {
            throw new NotImplementedException();
        }

        public int getNumberOfReviewsFromReviewer(int id)
        {
            throw new NotImplementedException();
        }

        public int getNumberOfReviewsWithReviewValueFromReviewer(int id, int grade)
        {
            throw new NotImplementedException();
        }

        public int getReviewAmountForMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<int> getReviewersHavingRatedSpecificMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<MovieReview> getTopMoviesFromInput(int value)
        {
            throw new NotImplementedException();
        }
    }
}
