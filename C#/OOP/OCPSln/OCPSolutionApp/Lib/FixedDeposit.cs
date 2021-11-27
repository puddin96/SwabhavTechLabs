using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolutionApp.Lib
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private IFestivalPolicy _festivalPolicy;


        public FixedDeposit(string name, double amount, int duration, IFestivalPolicy festivalPolicy)
        {
            this._name = name;
            this._amount = amount;
            this._duration = duration;
            this._festivalPolicy = festivalPolicy;
        }



        public double SimpleIntest()
        {
            float interest = (float)(_amount * _festivalPolicy.CalculateRate() * _duration / 100);
            return interest;

        }
    }
}
