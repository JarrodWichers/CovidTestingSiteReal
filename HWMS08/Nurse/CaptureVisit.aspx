<%@ Page Title="" Language="C#" MasterPageFile="~/Nurse/NurseMasterPage.Master" AutoEventWireup="true" CodeBehind="CaptureVisit.aspx.cs" Inherits="HWMS08.Nurse.TableHeartRates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
          
    <div class="col-md-12 col-sm-12 col-lg-12 col-xl-6 offset-1">
        <div class="row">
            <div class="card-box">
                <div class="card-block">
                    <h4 class="card-title">
                        <asp:Label ID="Label21" runat="server" Font-Size="XX-Large" Text="Test Result Details"></asp:Label>
                    </h4>
                    <div class="table-responsive">
                        <table class="table mb-0">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">Patient To Be Tested:<br />
                                        <br />
                <asp:Label ID="Label8" runat="server" Text="Patient:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:DropDownList ID="ddlPatient" runat="server">
              </asp:DropDownList>
                                        <br />
                                        <br />
                                    </td>
                                    <td class="auto-style1">
                                        </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">Vital Information:<br />
                                        <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="Temperature:"></asp:Label>
                &nbsp;&nbsp;
              <asp:TextBox ID="txtTemp" runat="server"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTemp" ErrorMessage="Please enter a valid temperature!" ForeColor="Red" ValidationExpression="^\d+(\,\d+$)?$"></asp:RegularExpressionValidator>
                                        <br />
                                        <br />
                <asp:Label ID="Label10" runat="server" Text="Blood Pressure:"></asp:Label>
                &nbsp;
              <asp:TextBox ID="txtBloodPressure" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
                                        <br />
&nbsp;
                <asp:Label ID="Label11" runat="server" Text="Oxygen Levels:"></asp:Label>
                &nbsp;
              <asp:TextBox ID="txtOxygen" runat="server"></asp:TextBox>
                                        <br />
                                    </td>
                                    <td class="auto-style2">
                                        
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                <asp:Button runat="server" Text="Add" BackColor="#B1D182" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Font-Names="Arial" Width="80px" Height="25px" ID="btnAdd" OnClick="btnLogin_Click"/>                
                                        
                                </tr>
                                
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
