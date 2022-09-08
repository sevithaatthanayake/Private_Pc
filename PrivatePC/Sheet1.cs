using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrivatePC.Properties;

namespace PrivatePC
{
    public partial class Sheet1 : Form
    {
        public Sheet1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            Settings.Default["Sheet1"] = txtLarge.Text;
            this.Close();
            
        }

        private void Sheet1_Load(object sender, EventArgs e)
        {
            txtLarge.Text = Settings.Default["Sheet1"].ToString();
        }
    }
}
