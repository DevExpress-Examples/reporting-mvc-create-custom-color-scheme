<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.vb" Inherits="WebReportingCustomColorScheme.Designer" %>
<%@ Register Assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="devextreme.light.custom.css" type="text/css" />
    <link rel="stylesheet" href="reporting.light.custom.css" type="text/css" />  

    <dx:ASPxReportDesigner ID="ASPxReportDesigner1" runat="server">
    </dx:ASPxReportDesigner>
</asp:Content>