using MovieRatingAssignment.Core.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MovieRatingAssignment.Infrastructure
{
    public class JsonRead
    {
        public List<MovieReview> ratings = new List<MovieReview>();

        public JsonRead(string filePath)
        {
            if (!String.IsNullOrEmpty(filePath))
            {
                InitJsonRead(filePath);
            }
        }

        private void InitJsonRead(string filePath)
        {

            using (StreamReader streamReader = new StreamReader(filePath))
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
        }

        private MovieReview ReadOneMovieRating(JsonTextReader reader)
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



    }
}
