<%@ Page Title="" Language="C#" MasterPageFile="~/Nurse/NurseMasterPage.Master" AutoEventWireup="true" CodeBehind="ViewSchedule.aspx.cs" Inherits="HWMS08.Nurse.TableBodyTempratures" EnableSessionState="True" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
           
    <div class="col-md-12 col-sm-12 col-lg-12 col-xl-6 offset-1">
        <div class="row">
            <div class="card-box">
                <div class="card-block">
                    <h4 class="card-title">
                        <asp:Label ID="Label21" runat="server" Font-Size="XX-Large" Text="Schedule"></asp:Label>
                    </h4>
                    <div class="table-responsive">
                        <table class="table mb-0">
                            <tbody>
                                <tr>
                                    <td class="auto-style1"> 
            <asp:Label ID="Label2" runat="server" Text="View Schedule" Font-Names="Calibri" Font-Size="20px"></asp:Label>
                                        <br />
                                        <br />
               <asp:GridView ID="dgvSchedule" runat="server">
               </asp:GridView>
                                    </td>
                                    <td class="auto-style1">
                                        </td>
                                </tr>
                                >
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
