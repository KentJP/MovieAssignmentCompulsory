using MovieRatingAssignment.Core.DomainService;
using MovieRatingAssignment.Core.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MovieRatingAssignment.Infrastructure.Repository
{
    public class MovieReviewRepository : IMovieReviewRepository
    {
  
        public int getAmountOfSpecificRatingForMovie(int id, int grade)
        {
            throw new NotImplementedException();
        }

        public double getAverageRateFromReviewer(int id)
        {
            throw new NotImplementedException();
        }

        public double getAverageRatingForMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<int> getIdsFromHighestRatedMovies()
        {
            throw new NotImplementedException();
        }

        public List<MovieReview> getMostActiveReviewers()
        {
            throw new NotImplementedException();
        }

        public List<MovieReview> getMoviesRatedByReviewers(int id)
        {
            throw new NotImplementedException();
        }

        public int getNumberOfReviewsFromReviewer(int id)
        {
            throw new NotImplementedException();
        }

        public int getNumberOfReviewsWithReviewValueFromReviewer(int id, int grade)
        {
            throw new NotImplementedException();
        }

        public int getReviewAmountForMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<int> getReviewersHavingRatedSpecificMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<MovieReview> getTopMoviesFromInput(int value)
        {
            throw new NotImplementedException();
        }
    }
}
