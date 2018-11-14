using System;
using System.Web.UI;

namespace WebReportingCustomColorScheme {
    public partial class Viewer : Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxWebDocumentViewer1.OpenReport(new XtraReport1());
        }
    }
}