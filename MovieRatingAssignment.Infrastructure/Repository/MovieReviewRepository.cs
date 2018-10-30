using MovieRatingAssignment.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRatingAssignment.Infrastructure.Repository
{
    public class MovieReviewRepository :IMovieReviewRepository
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
            var maxVal = _jsonRead.ratings.Where(mr => mr.Grade == 5).GroupBy(mr => mr.Movie).Max(g => g.Count());
            return _jsonRead.ratings.Where(mr => mr.Grade == 5).GroupBy(mr => mr.Movie).Where(g => g.Count() == maxVal).Select(k => k.Key).ToList();
        }

        //8.
        public List<int> getMostActiveReviewers()
        {
            var maxVal = _jsonRead.ratings.GroupBy(mr => mr.Reviewer).Max(r => r.Count());
            return _jsonRead.ratings.GroupBy(mr => mr.Reviewer).Where(r => r.Count() == maxVal).Select(r => r.Key).ToList();
        }

        //9.
        public List<int> getTopMoviesFromInput(int value)
        {
            return _jsonRead.ratings.GroupBy(mr => mr.Movie).OrderByDescending(g => g.Average(r => r.Grade)).Take(value).Select(g => g.Key).ToList();
        }

        //10.
        public List<MovieReview> getMoviesRatedByReviewers(int id)
        {
            return _jsonRead.ratings.Where(mr => mr.Reviewer == id).OrderByDescending(mr => mr.Grade).ThenByDescending(mr => mr.Date).ToList();
        }

        //11.
        public List<MovieReview> getReviewersHavingRatedSpecificMovie(int id)
        {
            return _jsonRead.ratings.Where(mr => mr.Movie == id).OrderByDescending(mr => mr.Grade).ThenByDescending(mr => mr.Date).ToList();
        }
    }
}
