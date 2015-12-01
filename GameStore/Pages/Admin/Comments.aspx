<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="GameStore.Pages.Admin.Comments" 
    MasterPageFile="~/Pages/Admin/Admin.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" ItemType="GameStore.Models.Comment" SelectMethod="GetComments"
        DataKeyNames="id" DeleteMethod="DeleteComment"
        EnableViewState="false"
        runat="server">
        <LayoutTemplate>
            <div class="outerContainer">
                <table id="productsTable">
                    <tr>
                        <th>Логин</th>
                        <th>Отзыв</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                
                <td><%# Item.login %></td>
                <td class="description"><span><%# Item.text %></span></td>
                <td>
                    <asp:Button ID="Button2" CommandName="Delete" Text="Удалить" runat="server" />
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
