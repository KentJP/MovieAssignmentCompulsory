using System;

namespace MovieRatingAssignment.Core.Entity
{
    public class MovieReview : IComparable
    {

        public int Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        public int CompareTo(object obj)
        {
            MovieReview mr = (MovieReview) obj;

            if(obj == null)
            {
                return 1;
            }

            return Grade.CompareTo(mr.Grade);

        }

        public override string ToString()
        {
            return "Reviewer: " + Reviewer + "   Movie: " + Movie + "   Grade: " + Grade + "   Date: " + Date.ToShortDateString();
        }


    }
}
