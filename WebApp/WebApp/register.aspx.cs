using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            Model.User user = new Model.User();
            user.Username = this.tb_username.Text;
            user.Password = this.tb_password.Text;
            user.Name = this.tb_name.Text;
            user.Address = this.tb_address.Text;
            user.Sex = int.Parse(this.ddl_sex.Text);
            user.Mobile = this.tb_mobile.Text;
            user.Email = this.tb_email.Text;
            user.SocialNumber = this.tb_socialNumber.Text;
            user.State = 1;
            user.Date = DateTime.Now;

            if (BusinessLogic.User.isUniqueUser(this.tb_username.Text))
            {
                Utility.JsHelper.AlertAndRedirect("Success!", "index.aspx");
            }
            else {
                Utility.JsHelper.AlertAndRedirect("The user name already exists, try again!", "register.aspx");
            }

            if (BusinessLogic.User.add(user)) {
                Utility.JsHelper.AlertAndRedirect("Success!", "index.aspx");
            }
            else {
                Utility.JsHelper.AlertAndRedirect("Error!", "index.aspx");
            }
        }
    }
}