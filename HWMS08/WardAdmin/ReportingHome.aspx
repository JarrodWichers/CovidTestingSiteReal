<%@ Page Title="" Language="C#" MasterPageFile="~/WardAdmin/WardAdminDashboard.Master" AutoEventWireup="true" CodeBehind="ReportingHome.aspx.cs" Inherits="HWMS08.WardAdmin.ReportingHome" %>

<asp:Content ID="cntReportingHomeHead" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 27px;
        }
    </style>
</asp:Content>

<asp:Content ID="cntReportingHome" ContentPlaceHolderID="cphContent" runat="server">

    <h3 class="page-title col-sm-4 col-3">Reports:</h3>

    <br />
    <br />

    <div class="col-md-12 col-sm-12 col-lg-12 col-xl-6 offset-1">
        <div class="row">
            <div class="card-box">
                <div class="card-block">
                    <h4 class="card-title">Booking Dates:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnExport" runat="server" Text="Export" CssClass="btn btn-primary" OnClick="btnExport_Click" />
                    </h4>
                    <div class="table-responsive">
                        <table class="table mb-0">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">Bookings from: </td>
                                    <td class="auto-style1">
                                        <asp:TextBox runat="server" ID="txtAdmitDateFrom" TextMode="Date"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">Bookings to: </td>
                                    <td class="auto-style2">
                                        <asp:TextBox runat="server" ID="txtAdmitDateTo" TextMode="Date"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td>
                                        Nurse:</td>
                                    <td>
                                        <asp:DropDownList ID="ddlNurse" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button runat="server" ID="btnSearchAdmissions" OnClick="btnSearchAdmissions_Click" Text="Search" CssClass="btn btn-primary" /></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView runat="server" ID="dgvAdmissions"></asp:GridView>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="col-md-6 col-sm-6 col-lg-6 col-xl-3 offset-2">
    </div>

</asp:Content>
