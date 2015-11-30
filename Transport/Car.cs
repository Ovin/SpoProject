using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Transport
{
    [Serializable]
    public class Car:ITransport
    {
        private double _tank;
        private double _fuelOnKillometers;
        private double _distance;
        private double _spentFuel;

        public double Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Дистанция не может быть меньше нуля");
                }
                _distance = value;
            }
        }
        public double FuelOnKillometers
        {
            get
            {
                return _fuelOnKillometers;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Затраты топлива не могут быть меньше нуля");
                }
                _fuelOnKillometers = value;
            }
        }
        public double Tank
        {
            get
            {
                return _tank;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Заполненность бака не может быть меньше нуля");
                }
                _tank = value;
            }
        }

        public double SpentFuel
        {
            get { return _spentFuel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Затраты топлива не могут быть меньше нуля");
                }
                _spentFuel = value;
            }
        }

        public Car()
        {
            _tank = 0;
            _distance = 0;
        }

        public Car(double distance, double fuelOnKillometers, double tank)
        {
            _tank = tank;
            _fuelOnKillometers = fuelOnKillometers;
           _distance = distance;
        }
        public double GetSpentFuel()
        {
            double spentFuel = 0.01 * _fuelOnKillometers * _distance;
            if(spentFuel > _tank)
            {
                _distance = _tank * (100/_fuelOnKillometers);
                return _tank;
            }
            else
            {
                _tank = _tank - spentFuel;
                _spentFuel = spentFuel;
                return spentFuel;
            }

        }


    }
}
