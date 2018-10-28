using MovieRatingAssignment.Infrastructure;
using MovieRatingAssignment.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace XUnitTestMovieRating
{
    public class PerformanceTestMovieReview
    {
        private MovieReviewRepository MRR = new MovieReviewRepository(new JsonRead("ratings.json"));

        //1
        [Fact]
        public void WithinTimeLimitTestForGetNumberOfReviewsFromReviewer()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = MRR.getNumberOfReviewsFromReviewer(1);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }
    }
}
