﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Details.aspx.cs" Inherits="PaySchoolEasyV2.Alumnos.Details" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="LblMensaje" Font-Names="Calibri" Font-Size="Small" ForeColor="Red"
        runat="server"></asp:Label>
    <br />
    <center>
        <asp:Panel runat="server" ID="panel1" Visible="true" Width="600px" Style="background-color: #DDDDDD">
            <table style="width: 500px;" border="0" cellspacing="0">

               <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label6" runat="server" Text="Matricula:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtMatricula" Enabled="false" ForeColor="Red" Width="100%" runat="server"></asp:TextBox>
                        <act:MaskedEditExtender ID="MaskedEditExtender2" runat="server" TargetControlID="TxtMatricula"
                            Mask="99999999" MaskType="Number" />
                    </td>
                </tr>

                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label11" runat="server" Text="Tutor:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbTutor" Width="100%" runat="server" />
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
                        <act:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="TxtDNI"
                            Mask="99999999" MaskType="Number" />
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label2" runat="server" Text="Nombre:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtNombre"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtNombre" Width="100%" runat="server"></asp:TextBox>
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
                        <asp:Label ID="Label5" runat="server" Text="Fecha Nacimiento:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtFecNac"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtFecNac" Width="90%" runat="server" onKeyPress="javascript: return false;"
                            onPaste="javascript: return false;"></asp:TextBox>
                        <asp:ImageButton ID="btnCalendar" runat="server" ImageUrl="~/Images/Calendar.png" />
                        <act:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TxtFecNac"
                            Format="dd/MM/yyyy" PopupButtonID="btnCalendar" />
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
