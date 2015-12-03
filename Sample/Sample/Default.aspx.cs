using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
using DHTMLX.Scheduler;
 
namespace Sample
{
    public partial class _Default : System.Web.UI.Page
    {
        public DHXScheduler Scheduler { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Scheduler = new DHXScheduler();
        }
    }
}

