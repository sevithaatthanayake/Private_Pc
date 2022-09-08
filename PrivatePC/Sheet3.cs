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
    public partial class Sheet3 : Form
    {
        public Sheet3()
        {
            InitializeComponent();
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            Settings.Default["Sheet3"] = txtLarge3.Text;
            this.Close();
        }

        private void Sheet3_Load(object sender, EventArgs e)
        {
            txtLarge3.Text = Settings.Default["Sheet3"].ToString();
        }
    }
}
