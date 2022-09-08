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
    public partial class Sheet2 : Form
    {
        public Sheet2()
        {
            InitializeComponent();
        }

        private void Sheet2_Load(object sender, EventArgs e)
        {
            txtLarge2.Text = Settings.Default["Sheet1"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Settings.Default["Sheet2"] = txtLarge2.Text;
            this.Close();
        }
    }
}
