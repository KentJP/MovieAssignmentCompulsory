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

            List<MovieReview> list = MRR.getReviewersHavingRatedSpecificMovie(1488844);

            foreach (MovieReview item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();


    }
}
}
