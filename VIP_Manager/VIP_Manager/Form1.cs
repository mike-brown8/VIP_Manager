using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIP_Manager
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,World", "TestMsgBox");
        }
    }
}
