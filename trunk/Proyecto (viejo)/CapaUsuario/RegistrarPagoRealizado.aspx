<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPagoRealizado.aspx.cs" Inherits="UI.RegistrarPagosRealizados" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "Lucida Console";
            font-weight: bold;
            text-align: center;
            color: #FFFFFF;
            background-color: #3366FF;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 395px;
        }
        .style4
        {
            font-size: 8pt;
        }
        .style5
        {
            width: 395px;
            font-size: 8pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    
        REGISTRAR PAGO REALIZADO</div>
    <table class="style2">
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                <asp:TextBox ID="TextBox1" runat="server" style="text-align: right" 
                    Width="272px" CssClass="style4"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="examinarbtn" runat="server" style="margin-left: 0px" 
                    Text="Examinar" CssClass="style4" />
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td style="text-align: right">
                <asp:Button ID="guardarbtn" runat="server" Text="Guardar" CssClass="style4" />
                <span class="style4">&nbsp;
                </span>
                <asp:Button ID="cancelarbtn" runat="server" onclick="cancelarbtn_Click" 
                    Text="Cancelar" CssClass="style4" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
