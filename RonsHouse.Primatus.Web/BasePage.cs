using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using RonsHouse.Primatus.Core.Domain;
using RonsHouse.Primatus.Web.Controls;

namespace RonsHouse.Primatus.Web
{
	public class BasePage : System.Web.UI.Page
	{
		//stores Session data as a json string
		public List ListJson
		{
			get { return Session["Primatus.UserData"] == null ? new List("Temp List") : List.ToObject(Session["Primatus.UserData"].ToString()); }
			set { Session["Primatus.UserData"] = value.ToString(); }	
		}
		
		public void DisplayAlert(string text, AlertType type, bool isDismissable, bool isVisible)
		{
			AlertUserControl alert = (AlertUserControl)this.Master.FindControl("alert_control");
			if (alert != null)
			{
				alert.AlertType = type;
				alert.Text = text;
				alert.Visible = isVisible;
				alert.IsDismissable = isDismissable;
			}
		}
		
		public void DisplayError(string text)
		{
			DisplayAlert(text, AlertType.Danger, true, true);
		}

		public void DisplayInfo(string text)
		{
			DisplayAlert(text, AlertType.Info, true, true);
		}

		public void DisplaySuccess(string text)
		{
			DisplayAlert(text, AlertType.Success, true, true);
		}

		public void DisplayWarning(string text)
		{
			DisplayAlert(text, AlertType.Warning, true, true);
		}
	}
}