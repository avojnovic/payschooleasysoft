<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPpalAdministrador.aspx.cs" Inherits="UI.Login" %>

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
        }
        .style2
        {
            width: 100%;
            font-size: 8pt;
        }
        .style3
        {
            font-family: "Lucida Console";
            color: #FFFFFF;
        }
        .style4
        {
            width: 337px;
            text-align: right;
        }
    </style>
</head>
<body>
    <p style="text-align: center; background-color: #3366FF;" class="style1">
        MENÚ ADMINISTRADOR</p>
    <form id="form1" runat="server">
    <p style="text-align: right; background-color: #FFFFFF;" class="style3">
        <asp:LinkButton ID="cerrarsesionlbtn" runat="server" 
            onclick="cerrarsesionlbtn_Click" style="text-align: right; font-size: 8pt">Cerrar Sesión</asp:LinkButton>
    </p>
    <div>
    
        <table class="style2">
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="eliminaralumnolbtn" runat="server" 
                        onclick="eliminaralumnolbtn_Click" style="font-family: 'Lucida Console'">Eliminar Alumno</asp:LinkButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="actualizaralumnolbtn" runat="server" 
                        onclick="actualizaralumnolbtn_Click1" style="font-family: 'Lucida Console'">Actualizar Alumno</asp:LinkButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="eliminartutorlbtn" runat="server" 
                        onclick="eliminartutorlbtn_Click" style="font-family: 'Lucida Console'">Eliminar Tutor</asp:LinkButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="actualizartutorlbtn" runat="server" 
                        onclick="actualizartutorlbtn_Click" style="font-family: 'Lucida Console'">Actualizar Tutor</asp:LinkButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="actualizarvaloreslbtn" runat="server" 
                        onclick="actualizarvaloreslbtn_Click" style="font-family: 'Lucida Console'">Actualizar Valores</asp:LinkButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="registrarpagorealizadolbtn" runat="server" 
                        onclick="registrarpagorealizadolbtn_Click" 
                        style="font-family: 'Lucida Console'">Registrar Pago Realizado</asp:LinkButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
