using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Model = RonsHouse.Primatus.Core.Domain;

namespace RonsHouse.Primatus.Web
{
	public partial class DefaultPage : BasePage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (this.ListJson.Items.Count == 0)
				{
					this.DisplayInfo("You haven't created any items for your list yet!  Get started below.");
				}

				BindData();
			}
		}

		protected void OnListItemTextChanged(object sender, EventArgs e)
		{
			TextBox listItemText = (TextBox)sender;
			
			Model.List list = this.ListJson;
			list.Items.Add(new Model.ListItem(listItemText.Text, ""));
			this.ListJson = list;
			listItemText.Text = "";

			BindData();
		}

		private void BindData()
		{
			items_list.DataSource = this.ListJson.Items;
			items_list.DataBind();
		}
	}
}