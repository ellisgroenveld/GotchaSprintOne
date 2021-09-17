<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GotchaSprintOne.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="gameid" DataSourceID="GotchaSprintOneGame">
        <Columns>
            <asp:BoundField DataField="gameid" HeaderText="gameid" ReadOnly="True" InsertVisible="False" SortExpression="gameid"></asp:BoundField>
            <asp:BoundField DataField="gamename" HeaderText="gamename" SortExpression="gamename"></asp:BoundField>
            <asp:BoundField DataField="leaderuserid" HeaderText="leaderuserid" SortExpression="leaderuserid"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource runat="server" ID="GotchaSprintOneGame" ConnectionString='<%$ ConnectionStrings:GotchaSprintOneConnectionString %>' SelectCommand="SELECT * FROM [Game]"></asp:SqlDataSource>
</asp:Content>
