using MovieRatingAssignment.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRatingAssignment.Infrastructure.Repository
{
    public class MovieReviewRepository
    {
        private JsonRead _jsonRead;

        public MovieReviewRepository(JsonRead jsonRead)
        {
            _jsonRead = jsonRead;
        }

        //1.
        public int getNumberOfReviewsFromReviewer(int id)
        {
            return _jsonRead.ratings.Where(mr => mr.Reviewer == id).Count();
        }

        //2.
        public double getAverageRateFromReviewer(int id)
        {
            return _jsonRead.ratings.Where(mr => mr.Reviewer == id).Average(mr => mr.Grade);
        }

        //3.
        public int getNumberOfReviewsWithReviewValueFromReviewer(int id, int grade)
        {
            return _jsonRead.ratings.Where(mr => mr.Reviewer == id && mr.Grade == grade).Count();
        }

        //4.
        public int getReviewAmountForMovie(int id)
        {
            return _jsonRead.ratings.Where(mr => mr.Movie == id).Count();
        }

        //5.
        public double getAverageRatingForMovie(int id)
        {
            return _jsonRead.ratings.Where(mr => mr.Movie == id).Average(mr => mr.Grade);
        }

        //6.
        public int getAmountOfSpecificRatingForMovie(int id, int grade)
        {
            return _jsonRead.ratings.Where(mr => mr.Movie == id && mr.Grade == grade).Count();
        }

        //7.
        public List<int> getIdsFromHighestRatedMovies()
        {
            //   return _jsonRead.ratings.Where(mr => mr.Grade ==5).
                return null;
        }

        //8.
        public List<MovieReview> getMostActiveReviewers()
        {
            return null;
        }

        //9.
        public List<MovieReview> getTopMoviesFromInput(int value)
        {
            return null;
        }

        //10.
        public List<MovieReview> getMoviesRatedByReviewers(int id)
        {
            return null;
        }

        //11.
        public List<int> getReviewersHavingRatedSpecificMovie(int id)
        {
            return null;
        }
    }
}
