<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <ul>
        <li>OSVersion: <%: Environment.OSVersion.ToString() %>.</li>
        <li>Version: <%: Environment.Version.ToString() %>.</li>
    </ul>
</asp:Content>
