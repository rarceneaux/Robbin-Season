using System;
using System.Collections.Generic;
using System.Text;

namespace Robbin__Season
{
    class Robber
    {
        private int _skillLevel;
        private decimal _courageFactor;
        public string Name { get; set; }

        public int SkillLevel {
            get
            {
                return _skillLevel;
            }
            set
            {
                if (value > 0 && value < 11)
                {
                    _skillLevel = value;
                }
            }
        }

        public decimal CougarFactor
        {
            get
            {
                return _courageFactor;
            }
            set
            {
                if(value >= 0.0m && value <= 2.0m)
                {
                    _courageFactor = value;
                }
            }
        }
        
    }
}
