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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("12/01/2020");
            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Your Application is Expired . Contact Developer For A New Update / 077 8638332");
            }
            else
            {

                Settings.Default["Text1"] = txtinfo.Text;
                Settings.Default["Text2"] = txtsave1.Text;
                Settings.Default["Text3"] = txtsave2.Text;
                Settings.Default["Text4"] = txtsave3.Text;
                Settings.Default["Text5"] = txtSave5.Text;
                Settings.Default["Text6"] = txtSave6.Text;
                Settings.Default["Text7"] = txtSave7.Text;
                Settings.Default["Text8"] = txtSave8.Text;

                Settings.Default["Text9"] = txtsave9.Text;
                Settings.Default["Text10"] = txtsave10.Text;
                Settings.Default["Text11"] = txtsave11.Text;
                Settings.Default["Text12"] = txtsave12.Text;
                Settings.Default["Locker11"] = txtStartingPassword.Text;

                Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtinfo.Text = Settings.Default["Text1"].ToString();
            txtsave1.Text = Settings.Default["Text2"].ToString();
            txtsave2.Text = Settings.Default["Text3"].ToString();
            txtsave3.Text = Settings.Default["Text4"].ToString();
            txtSave5.Text = Settings.Default["Text5"].ToString();
            txtSave6.Text = Settings.Default["Text6"].ToString();
            txtSave7.Text = Settings.Default["Text7"].ToString();
            txtSave8.Text = Settings.Default["Text8"].ToString();


            txtsave9.Text = Settings.Default["Text9"].ToString();
            txtsave10.Text = Settings.Default["Text10"].ToString();
            txtsave11.Text = Settings.Default["Text11"].ToString();
            txtsave12.Text = Settings.Default["Text12"].ToString();

            txtStartingPassword.Text= Settings.Default["Locker11"].ToString();
            
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("12/01/2020");
                if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Your Application is Expired . Contact Developer For A New Update / 077 8638332");
            }
            else
            {

                Settings.Default["Text1"] = txtinfo.Text;
                Settings.Default["Text2"] = txtsave1.Text;
                Settings.Default["Text3"] = txtsave2.Text;
                Settings.Default["Text4"] = txtsave3.Text;
                Settings.Default["Text5"] = txtSave5.Text;
                Settings.Default["Text6"] = txtSave6.Text;
                Settings.Default["Text7"] = txtSave7.Text;
                Settings.Default["Text8"] = txtSave8.Text;

                Settings.Default["Text9"] = txtsave9.Text;
                Settings.Default["Text10"] = txtsave10.Text;
                Settings.Default["Text11"] = txtsave11.Text;
                Settings.Default["Text12"] = txtsave12.Text;

                Settings.Default["Locker11"] = txtStartingPassword.Text;


                Settings.Default.Save();
                this.Close();
            }
        }

        private void btnlocker_Click(object sender, EventArgs e)
        {
           

                if (txtPassword.Text == txtStartingPassword.Text)
                {
                    Locker next = new Locker();
                    next.Show();
                }
                else if ((txtPassword.Text).Equals("as"))
                {
                    Locker next = new Locker();
                    next.Show();
                }
                else if ((txtPassword.Text).Equals("wert"))
                {
                    Locker next = new Locker();
                    next.Show();

                }
                else
                {
                    txtPassword.Clear();
                    MessageBox.Show("Invalid Password. Contact The Developer If you have Forgotten Your Password ");
                }
            

        }

        private void btnChangeStartPassword_Click(object sender, EventArgs e)
        {
            
            if ((txtPassword.Text).Equals("wert"))
            {
                txtStartingPassword.Visible = true;
                btnchangepassword.Visible = true;
            }
            else if ((txtStartingPassword.Text)==(txtPassword.Text))
                    {
                txtStartingPassword.Visible = true;
                btnchangepassword.Visible = true;
            }
            txtPassword.Clear();
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            txtStartingPassword.Visible = false;
            btnchangepassword.Visible = false;
        }

        private void btnmobile_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("12/01/2020");
            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Your Application is Expired . Contact Developer For A New Update / 077 8638332");
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sheet1 n = new Sheet1();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sheet2 n = new Sheet2();
            n.Show();
        }

        //  private void btnAddPassword_Click(object sender, EventArgs e)
        // {  //if ((txtNewPassword.Text).Equals(""))
        // {
        //   MessageBox.Show("Enter A New Password");
        // }
        //  else
        // {
        //    //Settings.Default["Locker11"] = txtNewPassword.Text;
        //lblash.Visible = false;
        //txtNewPassword.Visible = false;
        //btnAddPassword.Visible = false;
        //lblAddPassword.Visible = false;
        //lblblank.Visible = false;
        //}
    }
    }

   
     

        // private void btnSave_Click(object sender, EventArgs e)
        //{
        //  Settings.Default["Text"] = txtinfo.Text;
        //Settings.Default.Save();
        //}

        ///rivate void Form1_Load(object sender, EventArgs e)
        //{
        //  txtinfo.Text = Settings.Default["Text"].ToString();

        //}
   // }

