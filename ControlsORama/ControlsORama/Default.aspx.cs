﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsORama
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello .Here's what you type into the text box: <br/>");
            Response.Write(this.TextBox1.Text);

            Response.Write("<br/>");
            Response.Write("And the select item is:<br/>");
            Response.Write(this.DropDownList1.SelectedItem.Text);
        }
    }
}