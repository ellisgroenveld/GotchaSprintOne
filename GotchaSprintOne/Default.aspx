<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GotchaSprintOne.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
            Enter username: <br />
            <asp:TextBox ID="usernameInput" runat="server" /> <br />
            <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" /> <br />

    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="userid" DataSourceID="retrieveUsersGotcha">
        <Columns>
            <asp:BoundField DataField="userid" HeaderText="userid" ReadOnly="True" InsertVisible="False" SortExpression="userid"></asp:BoundField>
            <asp:BoundField DataField="realname" HeaderText="realname" SortExpression="realname"></asp:BoundField>
            <asp:BoundField DataField="userpass" HeaderText="userpass" SortExpression="userpass"></asp:BoundField>
            <asp:BoundField DataField="username" HeaderText="username" SortExpression="username"></asp:BoundField>
            <asp:BoundField DataField="userlevel" HeaderText="userlevel" SortExpression="userlevel"></asp:BoundField>
            <asp:BoundField DataField="playgroup" HeaderText="playgroup" SortExpression="playgroup"></asp:BoundField>
            <asp:BoundField DataField="place" HeaderText="place" SortExpression="place"></asp:BoundField>
            <asp:BoundField DataField="picture" HeaderText="picture" SortExpression="picture"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource runat="server" ID="retrieveUsersGotcha" ConnectionString='<%$ ConnectionStrings:GotchaSprintOneConnectionString %>' SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>

    <a runat="server" href="~/RegisterUser">Register new account!</a>

</asp:Content>
