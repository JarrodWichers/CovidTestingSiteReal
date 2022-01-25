<%@ Page Title="" Language="C#" MasterPageFile="~/MainMember/Doctor.Master" AutoEventWireup="true" CodeBehind="NurseDashboard.aspx.cs" Inherits="HWMS08.Doctor.DoctorDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <div style="margin-left:240px;text-align:left;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="#6F8C46" Text="Dashboard" Font-Names="Calibri" Font-Size="25px"></asp:Label>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Personal Schedule" Font-Names="Calibri" Font-Size="18px"></asp:Label>
        <br />
        <br />
            <div style="text-align:left" class="col">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Doctor/DoctorDashboardHelp.aspx">Help</asp:HyperLink>
                <br />
                <br />
            </div>
            <div class="col">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </div>
        </div>
</asp:Content>
