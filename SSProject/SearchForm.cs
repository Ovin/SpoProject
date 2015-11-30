using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Transport;
using Tools;

namespace SSProject
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        static ProjectSerialize sr = new ProjectSerialize();
        private List<ITransport> transportList;

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            List<ITransport> list = sr.SearchTransport(transportList,transportTypeTextBox.Text,distanceTextBox.Text);
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dataGridView1.Rows.Add(list[i].GetType().Name, list[i].Distance);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
