using System;


namespace Classes4
{
    public class Movie
    {
        String rating;
        String studio;
        String title;
        public Movie()
        {
            rating = "";
            studio = "";
            title = "";
        }
        public Movie(String aRating, string aStudio, String aTitle)
        {
            rating = aRating;
            studio = aStudio;
            title = aTitle;
        }
        public String GetRating()
        {
            return rating;
        }
        public void SetRating(String aRating)
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
        public String GetTitle()
        {
            return title;
        }
        public void SetTitle(String aTitle)
        {
            title = aTitle;
        }
        public Boolean equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                Movie other = (Movie)obj;
                return (rating.Equals(other.rating) && studio == other.studio
                && title.Equals(other.title));
            }
        }
    }
}
