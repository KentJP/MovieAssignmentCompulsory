using MovieRatingAssignment.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingAssignment.Core.DomainService
{
    public interface IMovieReviewRepository
    {
        //1.
        int getNumberOfReviewsFromReviewer(int id);

        //2.
        double getAverageRateFromReviewer(int id);

        //3.
        int getNumberOfReviewsWithReviewValueFromReviewer(int id, int grade);

        //4.
        int getReviewAmountForMovie(int id);

        //5.
        double getAverageRatingForMovie(int id);

        //6.
        int getAmountOfSpecificRatingForMovie(int id, int grade);

        //7.
        List<int> getIdsFromHighestRatedMovies();

        //8.
        List<MovieReview> getMostActiveReviewers();

        //9.
        List<MovieReview> getTopMoviesFromInput(int value);

        //10.
        List<MovieReview> getMoviesRatedByReviewers(int id);

        //11.
        List<int> getReviewersHavingRatedSpecificMovie(int id); 
    }
}
