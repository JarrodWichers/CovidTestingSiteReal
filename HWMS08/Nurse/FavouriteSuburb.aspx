<%@ Page Title="" Language="C#" MasterPageFile="~/Nurse/NurseMasterPage.Master" AutoEventWireup="true" CodeBehind="FavouriteSuburb.aspx.cs" Inherits="HWMS08.Nurse.OBSERVATION" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    
    <div class="col-md-12 col-sm-12 col-lg-12 col-xl-6 offset-1">
        <div class="row">
            <div class="card-box">
                <div class="card-block">
                    <h4 class="card-title">
                        <asp:Label ID="Label21" runat="server" Font-Size="XX-Large" Text="Favourite Suburb"></asp:Label>
                    </h4>
                    <div class="table-responsive">
                        <table class="table mb-0">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">
    <asp:Label ID="Label3" runat="server" Text="Please Select Your Favourite Suburb:" Font-Names="Calibri" Font-Size="18px"></asp:Label>
                                        <br />
    <asp:DropDownList ID="ddlSuburb" runat="server">
    </asp:DropDownList>
                                        <br />
                                    </td>
                                    <td class="auto-style1">
                                        </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td class="auto-style2">
                                        
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
