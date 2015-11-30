using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport;
using Tools;
namespace SSProject
{
    public partial class mainForm : Form
    {
        private List<ITransport> _transportList = new List<ITransport>();
        private ProjectSerialize _sr = new ProjectSerialize();
        public mainForm()
        {
            InitializeComponent();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                if(e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addObjectButton_Click(object sender, EventArgs e)
        {
            addTransportForm addForm = new addTransportForm();
            addForm.ShowDialog();
            if (addForm.DialogResult != DialogResult.Cancel)
            {
                ITransport source = addForm.TransportData;
                _transportList.Add(source);
                for (int i = 0; i < _transportList.Count; i++)
                {
                    dataGridView1.Rows.Add(_transportList[i].GetType().Name, _transportList[i].Distance);
                }
            }
        }

        private void removeObjectButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentCell.Value != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void searchFormButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = dataGridView1.CurrentRow.Index;
                transportTypeTextBox.Text = _transportList[id].GetType().Name;
                distanceTextBox.Text = _transportList[id].Distance.ToString();
                tankTextBox.Text = _transportList[id].Tank.ToString();
            }
            catch
            {
                return;
            }
            
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            _transportList = _sr.DeserializeTransport(fileName);
            for (int i = 0; i < _transportList.Count; i++)
            {
                dataGridView1.Rows.Add(_transportList[i].GetType().Name, _transportList[i].Distance);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            _sr.SerializeTranspot(fileName, _transportList);
        }

    }
}
