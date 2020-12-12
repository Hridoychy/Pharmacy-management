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
    public partial class Edit_profile : Form
        
    {
        public Edit_profile()
        {
            InitializeComponent();
        }
        public string uid, gm, ph; // value diclare
        private void Edit_profile_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e) 
        {
            uid = naBox.Text;
            gm = gmBox.Text;  
            ph = phBox.Text;
            MessageBox.Show("PROFILE UPDATED");
            this.Hide();
            

                
        }
    }
}
