using MovieRatingAssignment.Core.Entity;
using MovieRatingAssignment.Infrastructure;
using MovieRatingAssignment.Infrastructure.Repository;
using System;
using System.Collections.Generic;

namespace MovieRatingApp
{
    class Program
    {
        static void Main(string[] args)
        {

             MovieReviewRepository MRR = new MovieReviewRepository(new JsonRead("TestRatings.json"));

            List<int> topMoviesFromAverageScore = MRR.getTopMoviesFromInput(5);

            foreach (var item in topMoviesFromAverageScore)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();


    }
}
}
