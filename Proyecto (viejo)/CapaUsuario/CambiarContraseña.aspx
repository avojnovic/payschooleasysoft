<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="UI.CambiarContraseña" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
            color: #FFFFFF;
            font-family: "Lucida Console";
            font-weight: bold;
            background-color: #3366FF;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            text-align: right;
            font-size: 8pt;
            font-family: "Lucida Console";
        }
        .style4
        {
            font-family: "Lucida Console";
            font-size: 8pt;
        }
        .style5
        {
            text-align: right;
            font-family: "Lucida Console";
            font-size: 8pt;
            background-color: #FFFFFF;
        }
        .style6
        {
            font-size: 8pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    
        CAMBIAR CONTRASEÑA</div>
    <table class="style2">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Contraseña:
            </td>
            <td>
                <asp:TextBox ID="contraseña" runat="server" 
                    meta:resourcekey="contraseñaResource1" CssClass="style4" 
                    TextMode="Password" Width="170px"></asp:TextBox>
                <br class="style6" />
                <asp:Label ID="contincorrectaRFV" runat="server" 
                    style="color: #FF0000; font-family: 'Lucida Console'; " 
                    Text="Contraseña Incorrecta!" Visible="False" CssClass="style6"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style5">
                Nueva Contraseña:
            </td>
            <td style="font-size: 8pt">
                <asp:TextBox ID="nuevacontraseña" runat="server" 
                    meta:resourcekey="nuevacontraseñaResource1" TextMode="Password" 
                    Width="170px" CssClass="style6"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style3">
                Confirmar Contraseña:
            </td>
            <td>
                <asp:TextBox ID="confirmarcontraseña" runat="server" 
                    meta:resourcekey="confirmarcontraseñaResource1" style="margin-bottom: 0px" 
                    Width="170px" TextMode="Password" CssClass="style6"></asp:TextBox>
                <br class="style6" />
                <asp:Label ID="contnocoincidenRFV" runat="server" 
                    style="color: #FF0000; font-family: 'Lucida Console'; " 
                    Text="Las nuevas contraseñas no coinciden" Visible="False" 
                    CssClass="style6"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td style="text-align: right">
                <asp:Button ID="aceptarbtn" runat="server" meta:resourcekey="Button1Resource1" 
                    onclick="aceptarbtn_Click" Text="Aceptar" CssClass="style6" />
                <span class="style6">&nbsp;
                </span>
                <asp:Button ID="cancelarbtn" runat="server" onclick="cancelarbtn_Click" 
                    Text="Cancelar" CssClass="style6" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
