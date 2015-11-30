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
    public partial class HelicopterControl : UserControl
    {
        public HelicopterControl()
        {
            InitializeComponent();
        }

        private void fuelOnKillometersTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void fuelTrackBar_Scroll_1(object sender, EventArgs e)
        {
            fuelLevelTextBox.Text = fuelTrackBar.Value.ToString();
        }

        public Helicopter GetHelicopter()
        {
            return new Helicopter(Convert.ToDouble(distanceTextBox.Text), Convert.ToDouble(fuelOnKillometersTextBox.Text), Convert.ToDouble(fuelLevelTextBox.Text));
        }

        public void SetHelicopter(Helicopter helicopter)
        {
            distanceTextBox.Text = helicopter.Distance.ToString();
            fuelOnKillometersTextBox.Text = helicopter.FuelOnKillometers.ToString();
            fuelLevelTextBox.Text = helicopter.Tank.ToString();
        }

    }
}
