﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationDemo {
  public partial class Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void Button1_Click(object sender, EventArgs e) {
      if (Page.IsValid) {
        Label2.Text = "Valid!   Text  Is " + TextBox1.Text;
      }
    }
  }
}