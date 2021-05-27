using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string username = this.tb_reg_username.Text;
            string password = this.tb_reg_password.Text;

            if (BusinessLogic.User.login(username, password))
            {
                Utility.JsHelper.AlertAndRedirect("Login Success!", "index.aspx");
            }
            else {
                Utility.JsHelper.AlertAndRedirect("Login Error! Try again!", "index.aspx");
            }
        }
    }
}