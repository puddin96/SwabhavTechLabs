using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festival;

        public FixedDeposit(string Name, double Amount, int Duration, FestivalType Festival)
        {
            _name = Name;
            _amount = Amount;
            _duration = Duration;
            _festival = Festival;
        }

        public double CalculateRate()
        {
            float interestRate = 7f;
            if (_festival == FestivalType.Diwali)
            {
                interestRate = 8f;
                return interestRate;
            }
            else if (_festival == FestivalType.Eid)
            {
                interestRate = 8.5f;
                return interestRate;
            }
            else if (_festival == FestivalType.New_Year)
            {
                interestRate = 9f;
                return interestRate;
            }
            else
            {
                return interestRate;
            }
        }

        public double SimpleInterest()
        {
            float interest = (float)(_amount * CalculateRate() * _duration / 100);
            return interest;
        }
    }
}
