using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniDataGridViewUyg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphane206DataSet.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kutuphane206DataSet.Kitaplar);
            //this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter; this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter; this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            //public System.Windows.Forms.DataGridViewEditMode EditMode { get; set; } olmadı hata veriyor

    }
    }
}
