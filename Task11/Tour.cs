using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task11
{
    class Tour
    {
        string place = "Egypt";
        int days = 10;
        int dayCost = 4000;

        public Tour(string place, int days, int dayCost)
        {
            this.place = place;
            this.days = days;
            this.dayCost = dayCost;
        }

        public string Place
        {
            set
            {
                place = Place;
            }
            get
            {
                return place;
            }
        }

        public int Days
        {
            set
            {
                days = Days;
            }
            get
            {
                return days;
            }
        }

        public int DayCost
        {
            set
            {
                dayCost = DayCost;
            }
            get
            {
                return dayCost;
            }
        }

    }
}
