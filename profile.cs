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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private string uid;
        private string ph;
        private string gm;
        public void setValue(string uid,string ph,string gm) //value set
        {

            this.uid = uid;
            this.ph = ph;
            this.gm = gm;
        }  
        private void profile_Load(object sender, EventArgs e)
        {
            namebox.Text = this.uid;
            phoneBox.Text = this.ph;
            gmailBox.Text = this.gm;

        }
        Edit_profile ep = new Edit_profile(); //another class call 
        private void refress_Click(object sender, EventArgs e)
        {
            
            namebox.Text = ep.uid; //update value set
            phoneBox.Text = ep.ph; 
            gmailBox.Text = ep.gm;
        }

        private void Editp_Click(object sender, EventArgs e)
        {
            
                ep.Show();
        }
    }
}
