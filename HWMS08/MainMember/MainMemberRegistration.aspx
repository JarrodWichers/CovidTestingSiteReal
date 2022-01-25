<%@ Page Title="" Language="C#" MasterPageFile="~/MainMember/Doctor.Master" AutoEventWireup="true" CodeBehind="MainMemberRegistration.aspx.cs" Inherits="HWMS08.Doctor.DoctorPatientDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    
    <div class="col-md-12 col-sm-12 col-lg-12 col-xl-6 offset-1">
        <div class="row">
            <div class="card-box">
                <div class="card-block">
                    <h4 class="card-title">
                        <asp:Label ID="Label21" runat="server" Font-Size="XX-Large" Text="Register Main Member"></asp:Label>
                    </h4>
                    <div class="table-responsive">
                        <table class="table mb-0">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">Personal Details: 
                                        <br />
                                        <br />
                                        <asp:Label ID="Label19" runat="server" Text="ID Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="Invalid ID Number!" ForeColor="Red" ValidationExpression="^[0-9]{13,13}$"></asp:RegularExpressionValidator>
                                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                        <br />
&nbsp;<br />
&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="Surname:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
&nbsp; <asp:Label ID="Label17" runat="server" Text="Password:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                                        <br />
                                    </td>
                                    <td class="auto-style1">
                                        <asp:Label ID="Label20" runat="server" Text="Medical Aid:"></asp:Label>
                                        <asp:RadioButtonList ID="rdbMedical" runat="server" AutoPostBack="True" CssClass="auto-style1" OnSelectedIndexChanged="rdbMedical_SelectedIndexChanged">
                    <asp:ListItem Value="1">Yes</asp:ListItem>
                    <asp:ListItem Value="2">No</asp:ListItem>
                </asp:RadioButtonList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label14" runat="server" Text="Medical Aid:"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlMedicalAid" runat="server" OnSelectedIndexChanged="ddlMedicalAid_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                                        <br />
                                        <br />
                <asp:Label ID="Label15" runat="server" Text="Medical Aid Plan:"></asp:Label>
                &nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlMedicalPlan" runat="server">
                </asp:DropDownList>
                                        <br />
                                        <br />
                <asp:Label ID="Label16" runat="server" Text="Medical Aid Number:"></asp:Label>
                <asp:TextBox ID="txtMedicalNum" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
                <asp:Label ID="Label18" runat="server" Text="Responsible Person:"></asp:Label>
                                        <asp:TextBox ID="txtResponsiblePerson" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
                                        </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">Contact Details:<br />
                                        <br />
                <asp:Label ID="Label8" runat="server" Text="Cellphone Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCellNum" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revCell" runat="server" ControlToValidate="txtCellNum" ErrorMessage="Invalid Cellphone number!" ForeColor="Red" ValidationExpression="^[0-9xX\x20\x28\x29\x2D\x2E]*$"></asp:RegularExpressionValidator>
                                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Text="Email Address:"></asp:Label>
                &nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
                                    </td>
                                    <td class="auto-style2">
                                        
                                </tr>
                                <tr>
                                    <td>
                                        Personal Address:<br />
                                        <br />
                <asp:Label ID="Label11" runat="server" Text="Address Line 1:"></asp:Label>
                &nbsp;<br />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
                <asp:Label ID="Label12" runat="server" Text="Address Line 2:"></asp:Label>
                &nbsp;&nbsp;<br />
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label13" runat="server" Text="Suburb:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlSuburb" runat="server">
                </asp:DropDownList>
                                        <br />
                                        </td>
                                    <td>
                                        
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                <asp:Button runat="server" Text="Register" ID="btnLogin0" OnClick="btnLogin_Click" CssClass="btn btn-primary"/>                
                                        
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
