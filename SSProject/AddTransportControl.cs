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
    public partial class AddTransportControl : UserControl
    {
        public AddTransportControl()
        {
            InitializeComponent();
        }

        public ITransport TransportData { get; set; }

        private CarControl _carControl = new CarControl();
        private HybridControl _hybridControl = new HybridControl();
        private HelicopterControl _helicopterControl = new HelicopterControl();

        private void carRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            infoGroupBox.Controls.Clear();
            infoGroupBox.Controls.Add(_carControl);
            _carControl.Location = new Point(3, 11);
            _carControl.Size = new Size(infoGroupBox.Width - 10, _carControl.Height);
            _carControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _carControl.Visible = true;
        }

        private void hybridRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            infoGroupBox.Controls.Clear();
            infoGroupBox.Controls.Add(_hybridControl);
            _hybridControl.Location = new Point(3, 11);
            _hybridControl.Size = new Size(infoGroupBox.Width - 10, _hybridControl.Height);
            _hybridControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _hybridControl.Visible = true;
        }

        private void helecopterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            infoGroupBox.Controls.Clear();
            infoGroupBox.Controls.Add(_helicopterControl);
            _helicopterControl.Location = new Point(3, 11);
            _helicopterControl.Size = new Size(infoGroupBox.Width - 10, _helicopterControl.Height);
            _helicopterControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _helicopterControl.Visible = true;
        }

        public void GetTransport()
        {
            if (carRadioButton.Checked)
            {
                TransportData = _carControl.GetCar();
            }
            if (hybridRadioButton.Checked)
            {
                TransportData = _hybridControl.GetHybrid();
            }
            if (helecopterRadioButton.Checked)
            {
                TransportData = _helicopterControl.GetHelicopter();
            }
        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            GetTransport();
            calculTextBox.Text = TransportData.GetSpentFuel().ToString();
        }
    }
}
