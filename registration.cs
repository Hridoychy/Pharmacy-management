using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sh_project
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        private string uname, upass, gmail,phone; //variable diclare

        public void setValues() 
        {
            this.uname = userBox.Text; 
            this.upass = passBox.Text;
            
            this.gmail = gmailBox.Text;
            this.phone = phoneBox.Text;
        }

        public string getUname()
        {
            return this.uname; // public return 
        }

        public string getPass()
        {
            return this.upass;
        }

        public string getgmail()
        {
            return this.gmail;
        }
        public string getphone()
        {
            return this.phone;
        }
      

        private void signup_Click(object sender, EventArgs e)
        {
            this.setValues();
            MessageBox.Show("OK");
            


        }

        
        
        
        private void registration_Load(object sender, EventArgs e)
        {

           

        }

       
    }
}
