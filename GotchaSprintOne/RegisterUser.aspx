<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="GotchaSprintOne.RegisterUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Username: <asp:TextBox ID="usernameInput" runat="server" /> <br />
    Real Name: <asp:TextBox ID="realnameInput" runat="server" /> <br />
    Password: <asp:TextBox ID="userpassInput" runat="server" /> <br />
    userlevel: <asp:TextBox ID="userlevelInput" runat="server" /> <br />
    playgroup: <asp:TextBox ID="playgroupInput" runat="server" /> <br />
    Place: <asp:TextBox ID="placeInput" runat="server" /> <br />
    picture: <asp:TextBox ID="picturelinkInput" runat="server" /> <br />
    <asp:Button ID="createaccButton" runat="server" Text="Login" OnClick="createaccButton_Click" /> <br />

</asp:Content>
