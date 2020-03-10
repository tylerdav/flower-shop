using flower_shop;

namespace flower_shop
{
    public class Sunflower : IBirthday
    {
        public string color { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int cost { get; set; }
        public string water_schedule { get; set; }
        public bool thorny { get; set; }

        public bool fragrent { get; set; }
        public override string ToString ()
        {
            return $"The {color} {type} costs ${cost}.";
        }
    }
}