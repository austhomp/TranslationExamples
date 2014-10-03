<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms._Default" meta:resourcekey="PageResource1" %>
<%@ Import Namespace="CultureHelper" %>
<%@ Import Namespace="SharedResources" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="row">
    <div class="col-md-4 pull-right">
        <h3>Supported languages</h3>
        <h6>Current language: <%: Localized.ResourceLanguage%></h6>
        <h6>UICulture: <%: System.Globalization.CultureInfo.CurrentUICulture.EnglishName %></h6>
        <ul>
            <% foreach (var culture in new CultureHelperFactory().Create().SupportedCultureNames)
               { %>
                   <li><%: culture %></li>
               <% } %>
        </ul>

    </div>
</div>
<div class="row">
    <div class="col-md-2">
        <h2>Greeting</h2>
        <p>
            <%:Localized.Greeting%>
        </p>
        <p>
            <asp:Label ID="LocalizedLabel" runat="server" Text="This is a label" meta:resourcekey="Label1Resource1"></asp:Label>
        </p>
    </div>

    <div class="col-md-2 col-lg-offset-1">
        <h2>More</h2>
        <p><%: DateTime.Now.ToLongDateString() %></p>
    </div>
</div>

</asp:Content>
