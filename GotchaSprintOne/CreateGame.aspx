<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateGame.aspx.cs" Inherits="GotchaSprintOne.CreateGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Enter name: <br />
            <asp:TextBox ID="useridInput" runat="server" /> <br />
            <asp:Button ID="adduserButton" runat="server" Text="Add user by id" OnClick="adduserButton_Click" /> <br />
    <asp:Button ID="generateGame" runat="server" Text="Generate Game" OnClick="generateGame_Click" /> <br />
    <asp:BulletedList ID="BulletedListUserids" runat="server"></asp:BulletedList> <br />
    All users:
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

    

</asp:Content>
