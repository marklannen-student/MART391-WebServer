﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class expert_registration_first_step : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Expert_Skill_Registration(object sender, EventArgs e)
    {
        Server.Transfer("/expert-skills.aspx");
    }
}