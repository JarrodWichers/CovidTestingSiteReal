<%@ Page Title="" Language="C#" MasterPageFile="~/Nurse/NurseMasterPage.Master" AutoEventWireup="true" CodeBehind="SchduleTests.aspx.cs" Inherits="HWMS08.Nurse.TableRespirationRates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
       
      
    <div class="col-md-12 col-sm-12 col-lg-12 col-xl-6 offset-1">
        <div class="row">
            <div class="card-box">
                <div class="card-block">
                    <h4 class="card-title">
                        <asp:Label ID="Label21" runat="server" Font-Size="XX-Large" Text="Schedule Test"></asp:Label>
                    </h4>
                    <div class="table-responsive">
                        <table class="table mb-0">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">
              <asp:Label ID="Label3" runat="server" Text="Current Schedule" Font-Size="Large"></asp:Label>
                                        <br />
                                        <br />
            <asp:GridView ID="dgvSchedule" runat="server">
            </asp:GridView>
                                        <br />
                                    </td>
                                    <td class="auto-style1">
                                        </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Pick And Schedule Tests" Font-Names="Calibri" Font-Size="Large"></asp:Label>
                                        <br />
                                        <br />
            <asp:GridView ID="dgvTestToSchedule" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvTestToSchedule_SelectedIndexChanged">
            </asp:GridView>
                                        <br />
                                    </td>
                                    <td class="auto-style2">
                                        
                                </tr>
                                <tr>
                                    <td>
                                        Booking Date &amp; Time:<br />
                                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="Label4" runat="server" Text="Booking Date:"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtBookingDate" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="txtBookingDate_TextChanged"></asp:TextBox>
              <asp:Label ID="lblDateValid" runat="server" Text="Please select a valid date!" ForeColor="Red"></asp:Label>
                                        <br />
                                        <br />
              <asp:Label ID="Label5" runat="server" Text="Booking Time Slot:"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:DropDownList ID="ddlTimeSlot" runat="server" AutoPostBack="True">
              </asp:DropDownList>
                                        <br />
                                        <br />
                                        <br />
                <asp:Button runat="server" Text="Add" BackColor="#B1D182" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Font-Names="Arial" Width="80px" Height="25px" ID="btnAdd" OnClick="btnLogin_Click"/>                
                                        
                                        </td>
                                    <td>
                                        
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        
                                    </td>
                                </tr>
                                
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
