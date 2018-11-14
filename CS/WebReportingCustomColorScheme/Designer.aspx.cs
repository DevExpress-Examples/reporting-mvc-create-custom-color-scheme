using System;
using System.Web.UI;

namespace WebReportingCustomColorScheme {
    public partial class Designer : Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxReportDesigner1.OpenReport(new XtraReport1());
        }
    }
}