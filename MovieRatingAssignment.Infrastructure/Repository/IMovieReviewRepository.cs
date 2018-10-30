using MovieRatingAssignment.Core.Entity;
using System.Collections.Generic;

namespace MovieRatingAssignment.Infrastructure.Repository
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
        List<int> getMostActiveReviewers();

        //9.
        List<int> getTopMoviesFromInput(int value);

        //10.
        List<MovieReview> getMoviesRatedByReviewers(int id);

        //11.
        List<MovieReview> getReviewersHavingRatedSpecificMovie(int id);
    }
}