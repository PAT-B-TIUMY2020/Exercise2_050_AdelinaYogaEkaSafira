using Newtonsoft.Json;
using Service_050_AdelinaYogaEkaSafira;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_050_AdelinaYogaEkaSafira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }      

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            textBoxNama.Clear();
            textBoxNIM.Clear();
            textBoxProdi.Clear();
            textBoxAngkatan.Clear();

            buttonSimpan.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCari.Enabled = true;

            textBoxByNIM.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {

        }

        private void buttonJumlahData_Click(object sender, EventArgs e)
        {
          
        }

        private void dtMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNama.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[0].Value);
            textBoxNIM.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[1].Value);
            textBoxProdi.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[2].Value);
            textBoxAngkatan.Text = Convert.ToString(dtMahasiswa.Rows[e.RowIndex].Cells[3].Value);

            buttonSimpan.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;

            textBoxByNIM.Enabled = false;

        }
    }
}
