<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizarAlumno.aspx.cs" Inherits="UI.ActualizarAlumno" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
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
            width: 344px;
            text-align: right;
            font-family: "Lucida Console";
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
        ACTUALIZAR ALUMNO</p>
    <form id="form1" runat="server">
    <div>
    
        <table class="style2">
            <tr>
                <td class="style3">
                    Numero de Matrícula:</td>
                <td>
                    <asp:TextBox ID="nromatriculatb" runat="server" Width="170px" CssClass="style4"></asp:TextBox>
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
                    DNI:</td>
                <td>
                    <asp:TextBox ID="dnitb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Apellido:</td>
                <td>
                    <asp:TextBox ID="apellidotb" runat="server" 
                        Width="170px" Enabled="False" CssClass="style4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Nombre:</td>
                <td>
                    <asp:TextBox ID="nombretb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Fecha de Nacimiento:</td>
                <td>
                    <asp:TextBox ID="fechanacimientotb" runat="server" Enabled="False" 
                        Width="170px" CssClass="style4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Nivel:</td>
                <td>
                    <asp:TextBox ID="niveltb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style4"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Curso:</td>
                <td>
                    <asp:TextBox ID="cursotb" runat="server" Enabled="False" Width="170px" 
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
                <td style="text-align: right">
                    <asp:Button ID="actualizarbtn" runat="server" Text="Actualizar" 
                        onclick="actualizarbtn_Click" CssClass="style4" />
                    <span class="style4">&nbsp;
                    </span>
                    <asp:Button ID="cancelarbtn" runat="server" Text="Cancelar" 
                        onclick="cancelarbtn_Click" CssClass="style4" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>