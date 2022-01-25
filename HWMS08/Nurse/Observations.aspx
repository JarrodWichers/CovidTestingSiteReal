<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NursesMonitor.aspx.cs" Inherits="HWMS08.NursesMonitor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 641px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label11" runat="server" Text="Monitor Patient Form"></asp:Label>
        <br />
        <br />
        <br />
        <br />
            <asp:Label ID="txtPatientID" runat="server" Text="Patient ID"></asp:Label>
            <asp:DropDownList ID="ddlPatientID" runat="server" OnSelectedIndexChanged="ddlPatientID_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <p>
            <asp:Label ID="Label12" runat="server" Text="Date"></asp:Label>
            :<asp:TextBox ID="txtDate" runat="server" Width="108px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label13" runat="server" Text="Time"></asp:Label>
            :<asp:TextBox ID="txtTime" runat="server" Width="108px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Label ID="Label14" runat="server" Text="Current Weight"></asp:Label>
            <asp:TextBox ID="txtWeight" runat="server" Width="97px" AutoCompleteType="Search"></asp:TextBox>
            <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtWeight" ErrorMessage="Only numerical values allowed" ValidationExpression="/d+"></asp:RegularExpressionValidator>--%>
        </p>
        <p>
           
            <asp:Label ID="Label15" runat="server" Text="Current Pulse Rate"></asp:Label>
            <asp:TextBox ID="txtHeartRate" runat="server"></asp:TextBox>
            <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtHeartRate" ErrorMessage="Only numerical values allowed" ValidationExpression="/d+"></asp:RegularExpressionValidator>--%>
        </p>
        <p>
            <asp:Label ID="Label16" runat="server" Text="Current Blood Pressure"></asp:Label>
            <asp:TextBox ID="txtBloodPressure" runat="server" OnTextChanged="txtBloodPressure_TextChanged"></asp:TextBox>
            <%--            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtBloodPressure" ErrorMessage="Only Numerical Data Allowed" ValidationExpression="/d+"></asp:RegularExpressionValidator>--%>
        </p>
        <p>
            <asp:Label ID="txtTemprature" runat="server" Text="Current Temprature "></asp:Label>
            <asp:TextBox ID="txtBloodPressure0" runat="server" OnTextChanged="txtBloodPressure_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label18" runat="server" Text="Current Respitory Rate"></asp:Label>
            <asp:TextBox ID="txtRespitoryRate" runat="server" OnTextChanged="txtBloodPressure_TextChanged"></asp:TextBox>
        </p>
        <p>
            Observations</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" Height="76px" Width="199px" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <br />
    </form>
</body>
</html>
