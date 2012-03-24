<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizarValoresMonetarios.aspx.cs" Inherits="UI.ActualizarValoresMonetarios" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "Lucida Console";
            font-weight: bold;
            color: #FFFFFF;
            text-align: center;
            background-color: #3366FF;
        }
        .style2
        {
            width: 100%;
            font-family: "Lucida Console";
        }
        .style3
        {
            text-align: right;
            font-size: 8pt;
        }
        .style4
        {
            width: 119px;
        }
        .style5
        {
            width: 129px;
        }
        .style6
        {
            text-align: right;
            height: 28px;
            font-size: 8pt;
        }
        .style7
        {
            width: 119px;
            height: 28px;
        }
        .style8
        {
            width: 129px;
            height: 28px;
        }
        .style9
        {
            height: 28px;
        }
        .style10
        {
            font-size: 8pt;
        }
        .style11
        {
            width: 129px;
            font-size: 8pt;
        }
        .style12
        {
            width: 119px;
            font-size: 8pt;
        }
    </style>
</head>
<body>
    <p class="style1">
        ACTUALIZAR VALORES MONETARIOS</p>
    <form id="form1" runat="server">
    <table class="style2">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style12">
                Matriculas</td>
            <td class="style11">
                Cuotas</td>
            <td class="style10">
                Descuentos</td>
        </tr>
        <tr>
            <td class="style3">
                Nivel Inicial:</td>
            <td class="style4">
                <asp:TextBox ID="matriculanivelinicialtb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:TextBox ID="cuotanivelinicialtb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="descuentonivelinicialtb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                EGB-Primario:</td>
            <td class="style4">
                <asp:TextBox ID="matriculaegbtb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:TextBox ID="cuotaegbtb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="descuentoegbtb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Nivel Medio:</td>
            <td class="style4">
                <asp:TextBox ID="matriculanivelmediotb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:TextBox ID="cuotanivelmediotb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="descuentonivelmediotb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style12">
                Vencimientos</td>
            <td class="style11">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                1era Fecha:</td>
            <td class="style4">
                <asp:TextBox ID="vencimientofecha1tb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td class="style11">
                &nbsp;</td>
            <td style="text-align: right" class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                2da Fecha:</td>
            <td class="style7">
                <asp:TextBox ID="vencimientofecha2tb" runat="server" CssClass="style10"></asp:TextBox>
            </td>
            <td class="style8">
            </td>
            <td class="style9" style="text-align: right">
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td style="text-align: right">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td style="text-align: right">
                <asp:Button ID="guardarbtn" runat="server" Text="Guardar" Width="63px" 
                    CssClass="style10" />
            &nbsp;
                <asp:Button ID="cancelarbtn" runat="server" onclick="cancelarbtn_Click" 
                    Text="Cancelar" CssClass="style10" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
