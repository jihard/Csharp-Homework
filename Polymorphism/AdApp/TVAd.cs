namespace AdApp
{
    public class TVAd: Advert
    {
        private int _airTime;
        private int _peakTime;
        private bool _hasPeakTime;

        public TVAd(int fee, int airTime, int peakTime, bool hasPeakTime = false) : base(fee)
        {
            _hasPeakTime = hasPeakTime;
            _airTime = airTime;
            _peakTime = peakTime;
        }

        public new int Cost()
        {
            var fee = base.Cost();
            var cost = (_airTime - _peakTime)* fee;
            if (_hasPeakTime)
                cost += fee * _peakTime * 2;
            return cost;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}