<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="GameStore.Pages.Comments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Content/CommentsStyles.css" />
</head>
<body>
    <asp:ListView ID="ListView1" ItemType="GameStore.Models.Comment" InsertMethod="InsertComment" SelectMethod="GetComments"  DataKeyNames="id" InsertItemPosition="FirstItem" EnableViewState="false" runat="server">
        <ItemTemplate>
            <div class="comments-container">
                <ul class="comments">
                    <li><span class="login"><%# Item.login %></span>: <%# Item.text %></li>
                </ul>
            </div>
        </ItemTemplate>
        <InsertItemTemplate>
            <form id="form1" runat="server">
            <input type="hidden" name="id" value="0" />
            <label>Login<input type="text" name="login"/></label>
            <label>Comment<input type="text" name="text" /></label>
            <asp:Button ID="Button5" CommandName="Insert" Text="Вставить" runat="server" />  
            </form>
        </InsertItemTemplate>
    </asp:ListView>
</body>
</html>
