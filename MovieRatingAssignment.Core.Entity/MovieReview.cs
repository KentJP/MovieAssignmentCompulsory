using System;

namespace MovieRatingAssignment.Core.Entity
{
    public class MovieReview
    {

        public string Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public string Date { get; set; }
    }
}
