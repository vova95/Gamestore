<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authentication.aspx.cs" Inherits="GameStore.Pages.Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="loginContainer">
        <div>
            <label for="name">Имя:</label>
            <asp:TextBox ID="login" runat="server"/>
        </div>
        <asp:Literal ID="UserPassword" runat="server"></asp:Literal>
        <div>
            <label for="password">Пароль:</label>
            <asp:TextBox ID="password" type="password" name="password" runat="server"></asp:TextBox>
        </div>
        <asp:button type="submit" runat="server" Text="Войти" OnClick="checkUser"></asp:button>
    </div>
    </form>
</body>
</html>
