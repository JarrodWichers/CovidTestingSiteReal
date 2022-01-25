<%@ Page Title="" Language="C#" MasterPageFile="~/MainMember/Doctor.Master" AutoEventWireup="true" CodeBehind="Test Request.aspx.cs" Inherits="HWMS08.Doctor.DoctorMedication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Medication</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    

    <div class="col-md-12 col-sm-12 col-lg-12 col-xl-6 offset-1">
        <div class="row">
            <div class="card-box">
                <div class="card-block">
                    <h4 class="card-title">
                        <asp:Label ID="Label21" runat="server" Font-Size="XX-Large" Text="Test Request Details"></asp:Label>
                    </h4>
                    <div class="table-responsive">
                        <table class="table mb-0">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">Test Date &amp; Time:<br />
                                        <br />
                <asp:Label ID="Label7" runat="server" Text="Request Date:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtRequestDate" runat="server" TextMode="Date"></asp:TextBox>
                                        <br />
                                        <br />
                <asp:Label ID="Label8" runat="server" Text="Request Time:"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtTime" runat="server" TextMode="Time"></asp:TextBox>
                                        <br />
                                        <br />
                                    </td>
                                    <td class="auto-style1">
                                        Person To Be Tested:<br />
                                        <br />
                <asp:Label ID="Label9" runat="server" Text="Test Subject:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlSubject" runat="server">
                </asp:DropDownList>
                                        </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">Test Address:<br />
                                        <br />
                <asp:Label ID="Label10" runat="server" Text="Test Address Line 1:"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
                <asp:Label ID="Label11" runat="server" Text="Test Address Line 2:"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label12" runat="server" Text="Test Suburb:"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="ddlSuburb" runat="server">
                </asp:DropDownList>
                                    </td>
                                    <td class="auto-style2">
                                        
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
