using flower_shop;

namespace flower_shop
{
    public class Tulip : IMothersDay
    {
        public string name { get; set; }
        public string type { get; set; }
        public int cost { get; set; }
        public string water_schedule { get; set; }
        public bool thorny { get; set; }
        public double StemLength { get; set; }
        public bool fragrent { get; set; }
        public override string ToString ()
        {
            return $"The {type} costs ${cost}.";
        }
    }
}