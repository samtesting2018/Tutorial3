<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Filtering_Default" %>

<%@ Register src="../UserControls/SectionLevelTutorialListing.ascx" tagname="SectionLevelTutorialListing" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:SectionLevelTutorialListing ID="SectionLevelTutorialListing1" runat="server" />
</asp:Content>

