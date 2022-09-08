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
    public partial class Locker : Form
    {
        public Locker()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //LargeSheet next = new LargeSheet();
            //next.Show();
        }

        private void Locker_Load(object sender, EventArgs e)
        {
            txtloker1.Text = Settings.Default["Locker1"].ToString();
            txtlocker2.Text = Settings.Default["Locker2"].ToString();
            txtlocker3.Text = Settings.Default["Locker3"].ToString();
            txtlocker4.Text = Settings.Default["Locker4"].ToString();
            txtlocker5.Text = Settings.Default["Locker5"].ToString();
            txtlocker6.Text = Settings.Default["Locker6"].ToString();
            txtlocker7.Text = Settings.Default["Locker7"].ToString();
            txtlocker8.Text = Settings.Default["Locker8"].ToString();
            txtlocker9.Text = Settings.Default["Locker9"].ToString();
            txtLocker10.Text = Settings.Default["Locker10"].ToString();
            //txtInsidePassword.Text = Settings.Default["ChangePassword1"].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["Locker1"] = txtloker1.Text;
            Settings.Default["Locker2"] = txtlocker2.Text;
            Settings.Default["Locker3"] = txtlocker3.Text;
            Settings.Default["Locker4"] = txtlocker4.Text;
            Settings.Default["Locker5"] = txtlocker5.Text;
            Settings.Default["Locker6"] = txtlocker6.Text;
            Settings.Default["Locker7"] = txtlocker7.Text;
            Settings.Default["Locker8"] = txtlocker8.Text;
            Settings.Default["Locker9"] = txtlocker9.Text;
            Settings.Default["Locker10"] =txtLocker10.Text;
            //Settings.Default["ChangePassword1"] = txtInsidePassword.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default["Locker1"] = txtloker1.Text;
            //Settings.Default["ChangePassword1"] = txtInsidePassword.Text;
            this.Close();
        }
    }
}
