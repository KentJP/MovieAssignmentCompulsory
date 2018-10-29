using MovieRatingAssignment.Core.Entity;
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

        //2
        [Fact]
        public void WithinTimeLimitTestForGetAverageRateFromReviewer()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double result = MRR.getAverageRateFromReviewer(1);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }   
        
        //3
        [Fact]
        public void WithinTimeLimitTestForGetNumberOfReviewsWithReviewValueFromReviewer()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = MRR.getNumberOfReviewsWithReviewValueFromReviewer(1,4);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }

        //4
        [Fact]
        public void WithinTimeLimitTestForGetReviewAmountForMovie()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = MRR.getReviewAmountForMovie(30878);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }      
        
        //5
        [Fact]
        public void WithinTimeLimitTestForGetAverageRatingForMovie()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double result = MRR.getAverageRatingForMovie(30878);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }   
        
        //6
        [Fact]
        public void WithinTimeLimitTestForGetAmountOfSpecificRatingForMovie()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = MRR.getAmountOfSpecificRatingForMovie(1488844, 3);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }

        //7
        [Fact]
        public void WithinTimeLimitTestGetIdsFromHighestRatedMovies()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> result = MRR.getIdsFromHighestRatedMovies();
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }      
        
        //8
        [Fact]
        public void WithinTimeLimitTestGetMostActiveReviewers()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> result = MRR.getMostActiveReviewers();
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }      
        
        //9
        [Fact]
        public void WithinTimeLimitTestGetTopMoviesFromInput()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> result = MRR.getTopMoviesFromInput(5);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }      
        
        //10
        [Fact]
        public void WithinTimeLimitTestGetMoviesRatedByReviewers()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<MovieReview> list = MRR.getMoviesRatedByReviewers(1);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }      
        
        //11
        [Fact]
        public void WithinTimeLimitTestGetReviewersHavingRatedSpecificMovie()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<MovieReview> list = MRR.getReviewersHavingRatedSpecificMovie(1488844);
            sw.Stop();

            Assert.True(sw.ElapsedMilliseconds < 4000);
        }
    }
}
