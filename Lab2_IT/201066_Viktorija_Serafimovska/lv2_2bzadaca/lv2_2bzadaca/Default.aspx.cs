﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lv2_2bzadaca
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoggedIn.Visible = false;
            if (!Page.IsPostBack)
                caBirthDate.SelectedDate = DateTime.Now.Date;
        }

        protected void Поднеси_Click(object sender, EventArgs e)
        {
            lblLoggedIn.Visible = true;
            lblLoggedIn.Text = "Усшешно креиран корисник!";
        }
    }
}