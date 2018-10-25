using MovieRatingAssignment.Core.Entity;
using MovieRatingAssignment.Infrastructure.Repository;
using System;

namespace MovieRatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieReviewRepository.InitJsonRead();
            MovieReview test = MovieReviewRepository.ratings[666];
            Console.WriteLine(test.Reviewer);
            Console.ReadLine();
        }
    }
}
