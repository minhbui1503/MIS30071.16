using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyCuaHangACaPhe
{
    public partial class Form2 : Form
    {
        bool isThoat = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void qLMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isThoat)
            Application.Exit();
        }
    }
}
