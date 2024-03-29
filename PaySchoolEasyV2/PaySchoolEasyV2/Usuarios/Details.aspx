﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ControlObjects.Usuarios.Details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <br />
    <br />
    <asp:Label ID="LblMensaje" Font-Names="Calibri" Font-Size="Small" ForeColor="Red" runat="server"></asp:Label>
    <br />
    <center>
        <asp:Panel runat="server" ID="panel1" Visible="true" Width="600px" Style="background-color: #DDDDDD">
            <table style="width: 500px;" border="0" cellspacing="0">

                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label2" runat="server" Text="Nombre Usuario (Email):" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtNombreUsuario"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                       </td>      
                    <td align="left" style="width: 200px;"  >
                        <asp:TextBox ID="TxtNombreUsuario" Width="180px" runat="server"></asp:TextBox>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                     ErrorMessage="Email Erroneo" ControlToValidate="TxtNombreUsuario" SetFocusOnError="True"
                     ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                 
                    </td>

                </tr>
                   <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label8" runat="server" Text="Contraseña:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtContrasena"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtContrasena"  Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label1" runat="server" Text="DNI:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtDNI"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtDNI" Width="100%" runat="server"></asp:TextBox>
                        <act:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="TxtDNI" Mask="99999999" MaskType="Number" />
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label4" runat="server" Text="Apellido:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtApellido"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtApellido" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label7" runat="server" Text="Nombre:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtNombre"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtNombre" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
               
                  <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label5" runat="server" Text="Teléfono:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtTelefono"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtTelefono" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label6" runat="server" Text="Dirección:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtDireccion"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtDireccion" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>



                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label3" runat="server" Text="Nivel:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbTipo" Width="100%" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <br />
                        <asp:ImageButton ID="BtnGuardar" Width="32px" Height="32px" ImageUrl="~/Images/Save.png"
                            runat="server" ValidationGroup="add" OnClick="BtnGuardar_Click" ToolTip="Guardar" />
                        <asp:ImageButton ID="BtnBorrar" Width="32px" Height="32px" ImageUrl="~/Images/Trash.png"
                            runat="server" OnClick="BtnBorrar_Click" ToolTip="Borrar" />
                        <asp:ImageButton ID="BtnSalir" Width="32px" Height="32px" ImageUrl="~/Images/return.png"
                            runat="server" OnClick="BtnSalir_Click" ToolTip="Salir" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </center>
    <act:RoundedCornersExtender ID="RoundedCornersExtender2" runat="server" TargetControlID="panel1"
        Radius="8" Color="#DDDDDD" Corners="All" Enabled="true" />
</asp:Content>
