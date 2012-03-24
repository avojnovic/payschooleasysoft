<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InscribirAlumno.aspx.cs" Inherits="UI.InscribirAlumno" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "Lucida Console";
            color: #FFFFFF;
            text-align: center;
            font-weight: 700;
            background-color: #3366FF;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            font-family: "Lucida Console";
            text-align: right;
            width: 335px;
            font-size: 8pt;
        }
        .style4
        {
            font-size: 8pt;
        }
    </style>
</head>
<body>
    <p class="style1">
        INSCRIBIR ALUMNO</p>
    <form id="form1" runat="server">
    <div>
    
        <table class="style2">
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
                    <asp:TextBox ID="nombretb" runat="server" Width="170px" CssClass="style4"></asp:TextBox>
                </td>
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
                    Fecha de Nacimiento:</td>
                <td>
                    <asp:TextBox ID="fechanacimientotb" runat="server" Width="170px" 
                        CssClass="style4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Nivel:</td>
                <td>
                    <asp:DropDownList ID="nivelddl" runat="server" Enabled="False" Height="22px" 
                        Width="170px" CssClass="style4">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Curso:</td>
                <td>
                    <asp:DropDownList ID="cursoddl" runat="server" Enabled="False" Height="22px" 
                        Width="170px" CssClass="style4">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Numero de Matrícula:</td>
                <td>
                    <asp:TextBox ID="nromatriculatb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="inscribirotroalumnobtn" runat="server" 
                        Text="Inscribir otro Alumno" CssClass="style4" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td style="text-align: right">
                    <asp:Button ID="aceptarbtn" runat="server" onclick="aceptarbtn_Click" 
                        Text="Aceptar" CssClass="style4" />
                    <span class="style4">&nbsp;
                    </span>
                    <asp:Button ID="cancelarbtn" runat="server" onclick="cancelarbtn_Click" 
                        Text="Cancelar" CssClass="style4" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
