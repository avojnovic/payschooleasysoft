<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagarMatriculaCuota.aspx.cs" Inherits="UI.PagarMatriculaCuota" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
            color: #FFFFFF;
            font-weight: bold;
            font-family: "Lucida Console";
            background-color: #3366FF;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            text-align: right;
            font-family: "Lucida Console";
            width: 364px;
            font-size: 8pt;
        }
        .style4
        {
            text-align: right;
        }
        .style5
        {
            font-size: 8pt;
        }
    </style>
</head>
<body>
    <p class="style1">
        PAGAR MATRICULA/CUOTA</p>
    <form id="form1" runat="server">
    <div>
    
        <table class="style2">
            <tr>
                <td class="style3">
                    DNI:&nbsp;</td>
                <td>
                    <asp:DropDownList ID="dniddl" runat="server" Height="22px" Width="170px" 
                        Enabled="False" CssClass="style5">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Apellido:</td>
                <td>
                    <asp:TextBox ID="apellidotb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Nombre:</td>
                <td>
                    <asp:TextBox ID="nombretb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Nro de Matrícula:</td>
                <td>
                    <asp:TextBox ID="nromatriculatb" runat="server" Width="170px" Enabled="False" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Factura pago de:</td>
                <td>
                    <asp:DropDownList ID="facturapagodeddl" runat="server" Height="22px" 
                        Width="170px" CssClass="style5">
                        <asp:ListItem Value="false">Matricula</asp:ListItem>
                        <asp:ListItem Value="true">Cuota</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Correspond. al mes:</td>
                <td>
                    <asp:DropDownList ID="correspondalmesddl" runat="server" Height="22px" 
                        Width="170px" CssClass="style5">
                        <asp:ListItem Value="1">Enero</asp:ListItem>
                        <asp:ListItem Value="2">Febrero</asp:ListItem>
                        <asp:ListItem Value="3">Marzo</asp:ListItem>
                        <asp:ListItem Value="4">Abril</asp:ListItem>
                        <asp:ListItem Value="5">Mayo</asp:ListItem>
                        <asp:ListItem Value="6">Junio</asp:ListItem>
                        <asp:ListItem Value="7">Julio</asp:ListItem>
                        <asp:ListItem Value="8">Agosto</asp:ListItem>
                        <asp:ListItem Value="9">Septiembre</asp:ListItem>
                        <asp:ListItem Value="10">Octubre</asp:ListItem>
                        <asp:ListItem Value="11">Noviembre</asp:ListItem>
                        <asp:ListItem Value="12">Diciembre</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Fecha de Emisión:</td>
                <td>
                    <asp:TextBox ID="fechaemisiontb" runat="server" Enabled="False" Height="22px" 
                        Width="170px" CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td class="style3">
                    Fecha de 1er Vencimiento:</td>
                <td>
                    <asp:TextBox ID="fechavenc1tb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td class="style3">
                    Fecha de 2do Vencimiento:</td>
                <td>
                    <asp:TextBox ID="fechavenc2tb" runat="server" Width="170px" Enabled="False" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <img src="Imagenes/Codigo%20de%20barras.jpg" 
                        style="width: 110px; height: 49px; float: left" class="style5" /></td>
            </tr>
            <tr>
                <td class="style3">
                    Sub-Total:</td>
                <td>
                    <asp:TextBox ID="subtotaltb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Descuento:</td>
                <td>
                    <asp:TextBox ID="descuentotb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Total:</td>
                <td>
                    <asp:TextBox ID="totaltb" runat="server" Enabled="False" Width="170px" 
                        CssClass="style5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Button ID="enviarbtn" runat="server" Text="Enviar a e-mail" 
                        CssClass="style5" />
                    <span class="style5">&nbsp;
                    </span>
                    <asp:Button ID="imprimirbtn" runat="server" Text="Imprimir" CssClass="style5" />
                    <span class="style5">&nbsp;
                    </span>
                    <asp:Button ID="cancelarbtn" runat="server" onclick="cancelarbtn_Click" 
                        Text="Cancelar" CssClass="style5" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
