using System;

namespace MovieRatingAssignment.Core.Entity
{
    public class MovieReview
    {

        public int Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return "Reviewer: " + Reviewer + "   Movie: " + Movie + "   Grade: " + Grade + "   Date: " + Date.ToShortDateString();
        }


    }
}
