using System;


namespace Classes4
{
    public class Movie
    {
        string rating;
        string studio;
        string title;

        public Movie(string aRating, string aStudio, string aTitle)
        {
            rating = aRating;
            studio = aStudio;
            title = aTitle;
        }

        public string GetRating()
        {
            return rating;
        }

        public void SetRating(string aRating)
        {
            rating = aRating;
        }

        public string Getstudio()
        {
            return studio;
        }

        public void Setstudio(string aStudio)
        {
            studio = aStudio;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string aTitle)
        {
            title = aTitle;
        }

        public bool IsMovieThere(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                Movie other = (Movie)obj;
                return (rating.Equals(other.rating) && studio == other.studio && title.Equals(other.title));
            }
        }
    }
}
