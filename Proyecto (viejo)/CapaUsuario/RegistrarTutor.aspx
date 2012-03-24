<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarTutor.aspx.cs" Inherits="UI.RegistrarTutor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            font-family: "Lucida Console";
            font-size: 10pt;
        }
        .style2
        {
            width: 351px;
            text-align: right;
        }
        .style3
        {
            width: 351px;
            text-align: right;
            height: 26px;
            font-size: 8pt;
        }
        .style4
        {
            height: 26px;
        }
        .style5
        {
            font-size: 8pt;
        }
        .style6
        {
            width: 351px;
            text-align: right;
            font-size: 8pt;
        }
        .style7
        {
            width: 351px;
            text-align: right;
            font-size: 8pt;
            height: 27px;
        }
        .style8
        {
            height: 27px;
        }
    </style>
</head>
<body>
    <p style="font-family: 'Lucida Console'; font-weight: 700; text-align: center; color: #FFFFFF; background-color: #3366FF">
        REGISTRAR TUTOR</p>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style6">
                    Nombre de usuario (correo electronico):</td>
                <td>
                    <asp:TextBox ID="emailtb" runat="server" CssClass="style5" AutoPostBack="True" 
                        ontextchanged="emailtb_TextChanged" Width="160px" CausesValidation="True"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="emailrfv" runat="server" 
                        ControlToValidate="emailtb" ErrorMessage="*"></asp:RequiredFieldValidator>
                    &nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="emailtb" ErrorMessage="Correo electrónico inválido" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br class="style5" />
                    <asp:Label ID="nodisponiblelb" runat="server" style="color: #FF0000" 
                        Text="Correo electronico no disponible" Visible="False" CssClass="style5"></asp:Label>
                    <br class="style5" />
                    <asp:Label ID="disponiblelb" runat="server" 
                        style="color: #33CC33; " Text="Correo electronico disponible" 
                        Visible="False" CssClass="style5"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="comprobar" runat="server" Text="Comprobar Disponibilidad" 
                        CssClass="style5" CausesValidation="False" 
                        onclick="comprobar_Click" />
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Contraseña:</td>
                <td>
                    <asp:TextBox ID="contraseñatb" runat="server" TextMode="Password" 
                        CssClass="style5" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="contrasñearfv" runat="server" 
                        ControlToValidate="contraseñatb" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Confirmar contraseña:</td>
                <td>
                    <asp:TextBox ID="confcontraseñatb" runat="server" TextMode="Password" 
                        CssClass="style5" Width="159px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="confcontrarfv" runat="server" 
                        ControlToValidate="confcontraseñatb" ErrorMessage="*"></asp:RequiredFieldValidator>
&nbsp;<br />
                <asp:Label ID="contnocoincidenRFV" runat="server" 
                    style="color: #FF0000; font-family: 'Lucida Console'; " 
                    Text="Las contraseñas no coinciden" Visible="False" 
                    CssClass="style6"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    DNI:</td>
                <td class="style8">
                    <asp:TextBox ID="dnitb" runat="server" CssClass="style5" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="dnirfv" runat="server" 
                        ControlToValidate="dnitb" ErrorMessage="*"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;
                    <asp:Label ID="dniInvalidolb" runat="server" ForeColor="Red" 
                        Text="DNI inválido" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Apellido:</td>
                <td>
                    <asp:TextBox ID="apellidotb" runat="server" CssClass="style5" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="apellidorfv" runat="server" 
                        ControlToValidate="apellidotb" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Nombre:</td>
                <td class="style4">
                    <asp:TextBox ID="nombretb" runat="server" CssClass="style5" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="nombrerfv" runat="server" 
                        ControlToValidate="nombretb" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Teléfono:</td>
                <td>
                    <asp:TextBox ID="telefonotb" runat="server" CssClass="style5" Height="20px" 
                        Width="160px" CausesValidation="True"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="telefonorfv" runat="server" 
                        ControlToValidate="telefonotb" ErrorMessage="*"></asp:RequiredFieldValidator>
                &nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="telefonotb" 
                        ErrorMessage="Solo se admiten caracteres numéricos." SetFocusOnError="True" 
                        ValidationExpression="\d+"></asp:RegularExpressionValidator>
                </td>
            </tr>
           
            <tr>
                <td class="style6">
                    Dirección: </td>
                <td>
                    <asp:TextBox ID="direcciontb" runat="server" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="direccionrfv" runat="server" 
                        ControlToValidate="direcciontb" ErrorMessage="*"></asp:RequiredFieldValidator>
                &nbsp;
                </td>
            </tr>
           
            <tr class="style5">
                <td class="style2">
                    &nbsp;</td>
                <td style="text-align: right">
                    <asp:Label ID="Label1" runat="server" style="text-align: right; color: #FF0000" 
                        Text="Los campos * son requeridos" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:Label ID="usuarioRegistradolb" runat="server" ForeColor="Red" 
                        Text="El usuario ya se encuentra registrado." Visible="False"></asp:Label>
                </td>
                <td style="text-align: right">
                    <asp:Button ID="aceptarbtn" runat="server" onclick="aceptarbtn_Click" 
                        Text="Aceptar" CssClass="style5" />
                    <span class="style5">&nbsp;
                    </span>
                    <asp:Button ID="cancelarbtn" runat="server" onclick="cancelarbtn_Click" 
                        Text="Cancelar" CssClass="style5" CausesValidation="False" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
