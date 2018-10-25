using MovieRatingAssignment.Core.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestMovieRating
{
    public class UnitTestMovieReviewService
    {
        private List<MovieReview> MockList = new List<MovieReview>
        {
            new MovieReview(){Reviewer = 1, Movie = 1, Grade = 5, Date = new DateTime(2017, 10, 20)},
            new MovieReview(){Reviewer = 1, Movie = 2, Grade = 3, Date = new DateTime(2016, 09, 20)},
            new MovieReview(){Reviewer = 1, Movie = 3, Grade = 4, Date = new DateTime(2018, 07, 20)},
            new MovieReview(){Reviewer = 2, Movie = 1, Grade = 5, Date = new DateTime(2017, 10, 20)},
            new MovieReview(){Reviewer = 2, Movie = 4, Grade = 2, Date = new DateTime(2016, 12, 20)},
            new MovieReview(){Reviewer = 3, Movie = 1, Grade = 1, Date = new DateTime(2016, 03, 20)},
            new MovieReview(){Reviewer = 3, Movie = 3, Grade = 4, Date = new DateTime(2017, 06, 20)},
            new MovieReview(){Reviewer = 3, Movie = 4, Grade = 3, Date = new DateTime(2017, 01, 20)},
            new MovieReview(){Reviewer = 4, Movie = 1, Grade = 2, Date = new DateTime(2015, 12, 20)},
            new MovieReview(){Reviewer = 4, Movie = 3, Grade = 2, Date = new DateTime(2018, 03, 20)},
            new MovieReview(){Reviewer = 4, Movie = 2, Grade = 2, Date = new DateTime(2016, 12, 20)},
            new MovieReview(){Reviewer = 5, Movie = 5, Grade = 5, Date = new DateTime(2017, 12, 20)},
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
