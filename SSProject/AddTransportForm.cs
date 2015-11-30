using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using Transport;
using Tools;

namespace SSProject
{
    public partial class addTransportForm : Form
    {
        public addTransportForm()
        {
            InitializeComponent();
        }

        public ITransport TransportData { get; set; }

        private void addButton_Click(object sender, EventArgs e)
        {
            TransportData = addTransportControl1.TransportData;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
