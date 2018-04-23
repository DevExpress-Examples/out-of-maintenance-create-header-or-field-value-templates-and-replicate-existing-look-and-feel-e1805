using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;

namespace E1805 {
    public partial class _Default :System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxPivotGrid1.HeaderTemplate = new HeaderTemplate();
            ASPxPivotGrid1.FieldValueTemplate = new FieldValueTemplate();
        }
    }

    public class HeaderTemplate :ITemplate {
        public void InstantiateIn(Control container) {
            PivotGridHeaderTemplateContainer c = (PivotGridHeaderTemplateContainer)container;
            PivotGridHeaderHtmlTable table = c.CreateHeader();
            table.Content = new HeaderLink();
            c.Controls.Add(table);
        }
    }

    class FieldValueTemplate :ITemplate {
        public void InstantiateIn(Control container) {
            PivotGridFieldValueTemplateContainer c = (PivotGridFieldValueTemplateContainer)container;
            PivotGridFieldValueHtmlCell cell = c.CreateFieldValue();
            cell.Controls.AddAt(cell.Controls.IndexOf(cell.TextControl), new HeaderLink());
            cell.Controls.Remove(cell.TextControl);
            c.Controls.Add(cell);
        }
    }

    public class HeaderLink :HyperLink {
        public HeaderLink()
            : base() {
            Text = "Templated Text";
            NavigateUrl = "#";
            Attributes["onclick"] = "alert('this is the test prompt')";
        }
    }
}
