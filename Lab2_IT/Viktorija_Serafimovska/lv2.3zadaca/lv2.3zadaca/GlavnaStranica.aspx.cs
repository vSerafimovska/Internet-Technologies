using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lv2._3zadaca
{
    public partial class GlavnaStranica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogged"].Equals(false))
            {
                txtUsername.Text = "Неможе да пристапите не сте најавени";
            }
            else
            {
                txtUsername.Text = Session["korisnik"].ToString();
            }
        }
    }
}
