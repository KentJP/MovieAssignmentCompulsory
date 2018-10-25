using System;

namespace MovieRatingAssignment.Core.Entity
{
    public class MovieReview
    {

        public int Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
