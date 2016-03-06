<%@ Page Title="" Language="C#" MasterPageFile="~/Admin Site/Admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="IT191P_Project.Admin_Site.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title_bar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <h1 class="page-header">Dashboard</h1>
    <div class="col-lg-4">
        <img class="img-thumbnail" alt="Profile Pic" src="../images/buffer.gif"/>
    </div>
    <div class="col-lg-8">
        <h4 class="page-header">Personal Details</h4>
        <label id="lblGenderPrefix">(Mr. / Mrs. / Ms)</label>
        <label id="lblLastName">(Last Name of User) ,</label>
        <label id="lblFirstName">(First Name of User)</label>
        <label id="lblMiddleName">(Middle Name of User)</label>
        <br />
        Contact No: <label id="lblContact">(09xxxxxxxxxxx)</label><br />

        <h4 class="page-header">Company Details</h4>
        Total Income : ($ Kaching bebe)
        Licenses: (Licenses should be here)
        <br />
        Branches: (A gridview should be here)
        <br />
        Account Level: (Admin / Employee / etc)
        <br />
        <br />
    </div>
</asp:Content>
