using System.Collections.Generic;

namespace flower_shop
{
    public class FlowerShop
    {
        public List<Rose> Roses = new List<Rose> ();
        public List<Irise> Irises = new List<Irise> ();
        public List<Sunflower> Sunflowers = new List<Sunflower> ();
        public List<Tulip> Tulips = new List<Tulip> ();
        public List<Lily> Lilys = new List<Lily> ();

        public List<IMothersDay> MakeMothersDayArrangment ()
        {
            List<IMothersDay> Arrangment = new List<IMothersDay> ();
            Arrangment.Add (new Rose ());
            Arrangment.Add (new Rose ());
            Arrangment.Add (new Tulip ());
            Arrangment.Add (new Tulip ());

            return Arrangment;
        }
        public List<IBirthday> MakeBirthdayArrangment ()
        {
            List<IBirthday> Arrangment = new List<IBirthday> ();
            Arrangment.Add (new Sunflower ());
            Arrangment.Add (new Sunflower ());
            Arrangment.Add (new Irise ());
            Arrangment.Add (new Irise ());

            return Arrangment;
        }
        public List<IGetWell> MakeGetWellArrangment ()
        {
            List<IGetWell> Arrangment = new List<IGetWell> ();
            Arrangment.Add (new Lily ());
            Arrangment.Add (new Lily ());
            Arrangment.Add (new Lily ());

            return Arrangment;
        }
    }
}