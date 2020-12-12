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
    public partial class loGIN : Form
    {
        public loGIN()
        {
            InitializeComponent();
            
        }
        userinfo u = new userinfo();
        registration r = new registration();
        private void loGIN_Load(object sender, EventArgs e)
        {
            MessageBox.Show("wellcome");
            
           
        }

        private void log_Click(object sender, EventArgs e)
        {
            u.setUserInfo(userBox.Text, passsBox.Text);

            if (u.getUserId() == r.getUname() && u.getUserPass() == r.getPass() )
            {
                

                    
                MessageBox.Show("successful"  );
                
                this.Hide();
                dashboard d = new dashboard();
                d.setFields(r.getUname(),r.getphone(),r.getgmail());
                d.Show();

               




            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            r.Show();

         
      
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            userBox.Text = "";
            passsBox.Text = "";

        }
    }
}
