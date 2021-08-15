using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _avalible;
        private List<double> _ratings;

        public Video(string title)
        {
            _title = title;
            _avalible = true;
            _ratings = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _avalible = false;
        }

        public void BeingReturned()
        {
            _avalible = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            return _ratings.Average();
        }

        public bool Available()
        {
            return _avalible;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"Title: {Title}, Rating: {AverageRating()}, avilable: {Available()}";
        }
    }
}
