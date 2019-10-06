using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafetyTech
{
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Mtosistema_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int a = rdn.Next(0, 100);
            a = a * 50;
            mtosistema.Text = a.ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          // comboBox1
        }
    }
}
