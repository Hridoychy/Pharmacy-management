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
    public partial class dashboard : Form
    {
        registration re = new registration();
        userinfo u = new userinfo();
        private string userid,gm,ph;
        

        public void setFields(string uname,string gm,string ph) // value set
        {
            this.userid = uname;
            this.gm = gm;
            this.ph = ph;
        } 

        public dashboard()
        {
            InitializeComponent();
            
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            welBox.Text =  "wellcome  Admin " + this.userid;
        }

        private void profile_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.setValue(this.userid,this.gm,this.ph);
            p.Show();

        }
    }
}
