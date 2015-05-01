<%@ Page Title="" Language="C#" MasterPageFile="~/public.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RonsHouse.Primatus.Web.DefaultPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head_placeholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content_placeholder" runat="server">

	<fieldset>
		<legend>Add items to your list</legend>

		<asp:Repeater ID="items_list" runat="server">
			<ItemTemplate>
				<div class="col-lg-12">
					<%# Eval("Item") %> [edit] [delete]
				</div>
			</ItemTemplate>
		</asp:Repeater>

		<div class="form-group">
			<div class="col-lg-12">
				<asp:TextBox ID="listitem_textbox" runat="server" CssClass="form-control col-lg-12" placeholder="Enter an item for your list" OnTextChanged="OnListItemTextChanged" />
			</div>
		</div>
	</fieldset>

</asp:Content>
