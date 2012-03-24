<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPpalTutor.aspx.cs" Inherits="UI.PaginaPpalTutor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
            font-family: "Lucida Console";
            font-weight: bold;
            color: #FFFFFF;
            background-color: #3366FF;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 180px;
        }
        .style4
        {
            font-size: 8pt;
        }
        .style5
        {
            width: 180px;
            font-size: 8pt;
        }
    </style>
</head>
<body>
    <p class="style1">
        MENÚ TUTOR</p>
    <form id="form1" runat="server">
    <div style="text-align: right; font-family: 'Lucida Console'">
    
        <asp:LinkButton ID="cerrarsesionlbtn" runat="server" 
            onclick="cerrarsesionlbtn_Click" CssClass="style4">Cerrar Sesión</asp:LinkButton>
    
    </div>
    <table class="style2">
        <tr>
            <td class="style5" style="text-align: right">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="cambiarcontraseñalbtn" runat="server" 
                    onclick="cambiarcontraseñalbtn_Click" 
                    style="font-family: 'Lucida Console'" CssClass="style4">Cambiar contraseña</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="inscribiralumnolbtn" runat="server" 
                    style="font-family: 'Lucida Console'" onclick="inscribiralumnolbtn_Click" 
                    CssClass="style4">Inscribir Alumno</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="pagarlbtn" runat="server" 
                    style="font-family: 'Lucida Console'" onclick="pagarlbtn_Click" 
                    CssClass="style4">Pagar Matricula/Cuota</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
