<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemperatureConvert.aspx.cs" Inherits="WebFormsClient.TemperatureConvert"%>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-sm-4">
            <label>To convert:</label>
            <asp:TextBox ID="txt" runat="server"></asp:TextBox>
        </div>
        <div class="col-sm-4">
           <asp:DropDownList ID="toConvert" runat="server" OnSelectedIndexChanged="toConvert_SelectedIndexChanged" AutoPostBack="True">

        </asp:DropDownList>
            <asp:DropDownList ID="convertTo" runat="server" OnSelectedIndexChanged="convertTo_SelectedIndexChanged" AutoPostBack="True">

            </asp:DropDownList>
        </div>
        <div class="col-sm-4">
            <asp:Button ID="submitBTN" runat="server" Text="SUBMIT" OnClick="submitBTN_Click" />
            <label>Result: </label><asp:Label runat="server" ID="display"></asp:Label>
        </div>
    </form>
</body>
</html>
