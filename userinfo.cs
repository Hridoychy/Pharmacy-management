using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sh_project
{
    class userinfo
    {

        private string userid; 
        private string pass;
        //private string name;
        private string phone;
        private string gmail;


        public void setUserInfo(string uid, string pass) //peramiter pass
        {
            this.userid = uid;
            this.pass = pass;  //private value set 
        }

        public void setUser(string phone, string gmail) //peramiter pass
        {
            this.phone=phone;
            this.gmail=gmail;
        }

        public string getUserphone() //getuserid 
        {
            return this.phone;
        }

        public string getUsergmail() //getuserid 
        {
            return this.gmail;
        }

        public string getUserId() //getuserid 
        {
            return this.userid;
        }

        public string getUserPass() 
        {
            return this.pass;
        }
    }
}

