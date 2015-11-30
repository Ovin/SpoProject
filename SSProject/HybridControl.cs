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
    public partial class HybridControl : UserControl
    {
        public HybridControl()
        {
            InitializeComponent();
        }

        private void fuelTrackBar_Scroll(object sender, EventArgs e)
        {
            fuelLevelTextBox.Text = fuelTrackBar.Value.ToString();
        }

        private void capacitorTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        public Hybrid GetHybrid()
        {
            return new Hybrid(Convert.ToDouble(distanceTextBox.Text),Convert.ToDouble(fuelOnKillometersTextBox.Text),Convert.ToDouble(fuelLevelTextBox.Text),Convert.ToDouble(capacitorTextBox.Text));
        }

        public void SetHybrid(Hybrid hybrid)
        {
            distanceTextBox.Text = hybrid.Distance.ToString();
            capacitorTextBox.Text = hybrid.Capacitor.ToString();
            fuelOnKillometersTextBox.Text = hybrid.FuelOnKillometers.ToString();
            fuelLevelTextBox.Text = hybrid.Tank.ToString();
        }

    }
}
