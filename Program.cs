using System;
using System.Collections.Generic;

namespace flower_shop
{
    class Program
    {
        static void Main (string[] args)
        {
            Rose redRose = new Rose ();
            Irise blueIrise = new Irise ();
            Tulip whiteTulip = new Tulip ();
            Sunflower yellowSunflower = new Sunflower ();

            FlowerShop MacsFlowerShop = new FlowerShop ();
            List<IBirthday> Arrangment = MacsFlowerShop.MakeBirthdayArrangment ();
        }
    }
}