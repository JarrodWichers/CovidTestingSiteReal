<%@ Page Title="" Language="C#" MasterPageFile="~/WardAdmin/WardAdminDashboard.Master" AutoEventWireup="true" CodeBehind="WardAdminHome.aspx.cs" Inherits="HWMS08.WardAdmin.WardAdminHome" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="cntHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="cntHome" ContentPlaceHolderID="cphContent" runat="server">

    <%--<asp:Label runat="server" ID="lblHeading" Text="Welcome!" Font-Names="Calibri" Font-Size="40px" Font-Underline="True"></asp:Label>--%>
    <h3 class="page-title col-sm-4 col-3">Welcome!</h3>
    
    <div class="col-md-8 col-sm-8 col-lg-8 col-xl-4 offset-1">
            <div class="row">
                <div class="card-box">
                    <div class="card-block">
                        <h4 class="card-title">User Details:</h4>
                        <div class="table-responsive">
                            <table class="table mb-0">
                                <tbody>
                                    <tr>
                                        <td><asp:Label runat="server" ID="lblName"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><asp:Label runat="server" ID="lblEmail"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><asp:Label runat="server" ID="lblContactNum"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><asp:Label runat="server" ID="lblRole"></asp:Label></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>

</asp:Content>
