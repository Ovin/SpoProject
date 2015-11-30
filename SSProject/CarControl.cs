using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport;

namespace SSProject
{
    public partial class CarControl : UserControl
    {
        public CarControl()
        {
            InitializeComponent();
        }

        private void fuelOnKillometersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void distanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void fuelLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void fuelTrackBar_Scroll(object sender, EventArgs e)
        {
            fuelLevelTextBox.Text = fuelTrackBar.Value.ToString();
        }

        public Car GetCar()
        {
            return new Car(Convert.ToDouble(distanceTextBox.Text), Convert.ToDouble(fuelOnKillometersTextBox.Text), Convert.ToDouble(fuelLevelTextBox.Text));
        }

        public void SetCar(Car car)
        {
            distanceTextBox.Text = car.Distance.ToString();
            fuelOnKillometersTextBox.Text = car.FuelOnKillometers.ToString();
            fuelLevelTextBox.Text = car.Tank.ToString();
        }
    }
}
