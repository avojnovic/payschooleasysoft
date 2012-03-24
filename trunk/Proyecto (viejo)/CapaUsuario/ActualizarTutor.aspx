<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizarTutor.aspx.cs" Inherits="UI.ActualizarTutor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            color: #FFFFFF;
            font-weight: bold;
            font-family: "Lucida Console";
            text-align: center;
            background-color: #3366FF;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 339px;
            font-family: "Lucida Console";
            text-align: right;
            font-size: 8pt;
        }
        .style4
        {
            font-size: 8pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    
        ACTUALIZAR TUTOR</div>
    <table class="style2">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                DNI:</td>
            <td>
                <asp:TextBox ID="dnitb" runat="server" Width="170px" CssClass="style4"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Button ID="buscarbtn" runat="server" Text="Buscar" CssClass="style4" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                Apellido:</td>
            <td>
                <asp:TextBox ID="apellidotb" runat="server" Enabled="False" Width="170px" 
                    CssClass="style4"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Nombre:</td>
            <td>
                <asp:TextBox ID="nombretb" runat="server" Width="170px" Enabled="False" 
                    CssClass="style4"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Teléfono:</td>
            <td>
                <asp:TextBox ID="telefonotb" runat="server" Width="170px" Enabled="False" 
                    CssClass="style4"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Dirección:</td>
            <td>
                <asp:TextBox ID="direcciontb" runat="server" 
                    Width="170px" Enabled="False" CssClass="style4"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Correo electrónico:</td>
            <td>
                <asp:TextBox ID="emailtb" runat="server" Width="170px" Enabled="False" CssClass="style4" 
                    ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td style="text-align: right">
                <asp:Button ID="actualizarbtn" runat="server" Text="Actualizar" 
                    CssClass="style4" />
                <span class="style4">&nbsp;
                </span>
                <asp:Button ID="cancelarbtn" runat="server" Text="Cancelar" 
                    onclick="cancelarbtn_Click" CssClass="style4" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
