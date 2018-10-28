
using MovieRatingAssignment.Core.Entity;
using MovieRatingAssignment.Infrastructure;
using MovieRatingAssignment.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestMovieRating
{
    public class FunctionTestMovieReviewService
    {
        private MovieReviewRepository MRR = new MovieReviewRepository(new JsonRead("TestRatings.json"));

        //.1
        [Theory]
        [InlineData(1,10)]
        [InlineData(2,10)]
        [InlineData(3,10)]
        [InlineData(4,10)]
        [InlineData(5,10)]
        public void TestForCorrectRetrievelOfReviewsPerReviewer(int input, int result)
        {
            int numberOfReviewsFromReviewer = MRR.getNumberOfReviewsFromReviewer(input);

            Assert.Equal(result, numberOfReviewsFromReviewer);
        }
    }
}
