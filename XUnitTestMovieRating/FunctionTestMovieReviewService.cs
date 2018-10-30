
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

        //2
        [Theory]
        [InlineData(1,3.6)]
        [InlineData(2,3.9)]
        [InlineData(3,3.9)]
        [InlineData(4,3.6)]
        [InlineData(5,3.5)]
        public void TestForCorrectAverageRateFromReviewer(int input, double result)
        {
            double averageRate = MRR.getAverageRateFromReviewer(input);
            Assert.Equal(result, averageRate);
        }  
        
        //3
        [Theory]
        [InlineData(1,1,0)]
        [InlineData(1,2,0)]
        [InlineData(1,3,5)]
        [InlineData(1,4,4)]
        [InlineData(1,5,1)]
        public void TestForCorrectAmountOfSpecifiedRatesFromReviewer(int reviewer, int grade, double result)
        {
            int SpeceficGradeAmonut = MRR.getNumberOfReviewsWithReviewValueFromReviewer(reviewer, grade);
            Assert.Equal(result, SpeceficGradeAmonut);
        }       
        
        //4
        [Theory]
        [InlineData(1488844, 5)]
        [InlineData(822109, 4)]
        [InlineData(885013, 2)]
        [InlineData(1842128, 4)]
        [InlineData(124105, 1)]
        public void TestForCorrectAmountOfReviewsForMovie(int movieID, int result)
        {
            int amountOfReviews = MRR.getReviewAmountForMovie(movieID);
            Assert.Equal(result, amountOfReviews);
        }


        //5
        [Theory]
        [InlineData(1488844, 3.2)]
        [InlineData(822109, 4.25)]
        [InlineData(885013, 4.5)]
        [InlineData(1842128, 4.25)]
        [InlineData(124105, 4)]
        public void TestForCorrectAverageRateForMovie(int movieID, double result)
        {
            double averageGrade = MRR.getAverageRatingForMovie(movieID);
            Assert.Equal(result, averageGrade);
        } 
        
        //6
        [Theory]
        [InlineData(1488844, 3, 4)]
        [InlineData(822109, 5, 2)]
        [InlineData(885013, 5, 1)]
        [InlineData(1842128, 4, 3)]
        [InlineData(124105, 1, 0)]
        public void TestForCorrectAmountOfSpeceficGradesForMovie(int movieID, int grade, int result)
        {
            int specefiedGradeAmountForMovie = MRR.getAmountOfSpecificRatingForMovie(movieID, grade);
            Assert.Equal(result, specefiedGradeAmountForMovie);
        }


        //7
        [Fact]
        public void TestForCorrectTopIdWithHighestScore()
        {
            List<int> topMovies = MRR.getIdsFromHighestRatedMovies();

            Assert.True(topMovies[0] == 822109);
        }

        //TODO
        //Lav en ordentlig test btw... 
        //8
        [Fact]
        public void TestForCorrectAmountOfMostActiveReviewers()
        {           
            List<int> fiveMostActiveReviewers = MRR.getMostActiveReviewers();
            if(fiveMostActiveReviewers.Contains(1) && fiveMostActiveReviewers.Contains(2) && fiveMostActiveReviewers.Contains(3) && fiveMostActiveReviewers.Contains(4) && fiveMostActiveReviewers.Contains(5))
            {
                Assert.True(true);
            }
        }   
        
        //TODO
        //Lav en ordentlig test btw... 
        //9
        [Fact]
        public void TestForCorrectTopMoviesListFromAverageScore()
        {
            List<int> topMoviesFromAverageScore = MRR.getTopMoviesFromInput(5);

        }

        //TODO
        //Lav en ordentlig test btw...
        //10

        //TODO
        //Lav en ordentlig test btw...
        //11






    }
}
