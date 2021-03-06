

namespace AdApp
{
    public class Poster : Advert
    {
        private int _height;
        private int _width;
        private int _copies;
        private int _costPerCopy;

        public Poster(int fee, int height, int width,
        int copies, int costPerCopy) : base(fee)
        {
            _copies = copies;
            _costPerCopy = costPerCopy;
            _height = height;
            _width = width;
        }

        private new int Cost()
        {
            var fee = base.Cost();
            fee += _copies * _costPerCopy;
            return fee;
        }

        public override string ToString()
        {
            return $"\nPoster: Cost={Cost()}";
        }
    }
}
