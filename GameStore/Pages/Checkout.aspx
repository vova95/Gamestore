<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="GameStore.Pages.Checkout" 
    MasterPageFile="~/Pages/Store.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">

        <div id="checkoutForm" class="checkout" runat="server">
            <h2>Оформить заказ</h2>
            Пожалуйста, введите свои данные, и мы отправим Ваш товар прямо сейчас!

        <div id="errors">
            <ul>
                <li style="display:none"></li>
            </ul>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>

            <h3>Заказчик</h3>
            <div>
                <label for="name">Имя:</label>
                <input id="name" name="name" runat="server" />
            </div>
            <div>
                <label for="phone">Телефон:</label>
                <input id="phone" name="phone" runat="server" />
            </div>
            <h3>Адрес доставки</h3>
            <div>
                <label for="address">Адрес:</label>
                <input id="address" name="address" runat="server" />
            </div>
            
            <div>
                <label for="city">Город:</label>
                <input id="city" name="city" runat="server" />
            </div>

            <h3>Детали заказа</h3>
            <input type="checkbox" id="giftwrap" name="giftwrap" value="true" />
            Использовать подарочную упаковку?
        
        <p class="actionButtons">
            <button class="actionButtons" type="submit">Обработать заказ</button>
        </p>
        </div>
        <div id="checkoutMessage" runat="server">
            <h2>Спасибо!</h2>
            Спасибо что выбрали наш магазин! Мы постараемся максимально быстро отправить ваш заказ   
        </div>
    </div>
</asp:Content>
