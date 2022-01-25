<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HWMS08._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ONP400 Project Login</title>
    <style>
        body, html {
            margin:0 auto;
            padding:0;
            border:0;
            outline:0;
        }
    </style>
</head>
<body style="margin:0; background-image: url('Resources/pines.jpg'); text-align:center;">
    
    <div style="background-color: #B1D182; font-family: 'Calibri Light';text-align:left;">
        <h1 style="margin-top:0;padding-top:5px;padding-bottom:5px;">ONP400 Project</h1>
    </div>              
       
    
    <div style="text-align:center; background-color:white;opacity:0.8; display:inline-block;padding-top: 3%;padding-bottom:3%;padding-left:3%;padding-right:3%;margin-top:8%">
            <form id="frmLogin" runat="server">
                <h1 style="margin-top:0;font-family: 'Calibri Light'; text-decoration: underline;">Welcome</h1>
            <div style="">
                <asp:Table runat="server" HorizontalAlign="Center" Font-Names="Arial">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
                </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                    </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" ></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <br />
                <asp:Button ID="btnRegister" runat="server" BackColor="#B1D182" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Height="25px" OnClick="btnRegister_Click" Text="Register" Width="80px" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" Text="Log In" BackColor="#B1D182" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Font-Names="Arial" Width="80px" Height="25px" ID="btnLogin" OnClick="btnLogin_Click"/>                
            </div>
                </form>
        </div>        
</body>
</html>
