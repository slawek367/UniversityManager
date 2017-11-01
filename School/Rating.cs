using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Rating
    {
        List<int> ratings {get; set;}

        public Rating()
        {
            ratings = new List<int>();
        }

        public void addRating(int rate)
        {
            ratings.Add(rate);
        }

        public void deleteRating(int rate)
        {
            ratings.Remove(rate);
        }

        public void changeRating(int rate)
        {
            //TODO
            return;
        }

        public List<int> getRatings()
        {
            return ratings;
        }
    }
}
