using System;
using System.Text;
using System.Web.UI.WebControls;

namespace RonsHouse.Primatus.Web.Controls
{
	public partial class AlertUserControl : System.Web.UI.UserControl
	{
		public bool IsDismissable { get; set; }
		
		public AlertType AlertType { get; set; }
		
		public string Text { get; set; }

		public bool Visible { get; set; }
		
		protected void Page_Load(object sender, EventArgs e)
		{
			alert_panel.Visible = this.Visible;

			if (this.Visible)
			{
				StringBuilder code = new StringBuilder();
				code.Append("<div class=\"alert");
				
				if (this.IsDismissable)
					code.Append(" alert-dismissable");

				switch(this.AlertType)
				{
					case Web.Controls.AlertType.Info:
						code.Append(" alert-info");
						break;
					case Web.Controls.AlertType.Success:
						code.Append(" alert-success");
						break;
					case Web.Controls.AlertType.Warning:
						code.Append(" alert-warning");
						break;
					case Web.Controls.AlertType.Danger:
						code.Append(" alert-danger");
						break;
				}

				code.Append("\">");

				if (this.IsDismissable)
					code.Append("<button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>");

				if (!String.IsNullOrEmpty(this.Text))
					code.AppendFormat("<span>{0}</span>", this.Text);

				code.Append("</div>");


				alert_literal.Text = code.ToString();
			}
		}
	}

	public enum AlertType
	{
		Info,
		Success,
		Warning,
		Danger
	}
}