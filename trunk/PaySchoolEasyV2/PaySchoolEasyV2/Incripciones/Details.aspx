<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ControlObjects.Incripciones.Details" %>
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
                        <asp:Label ID="Label7" runat="server" Text="Fecha Inscripción:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtFecIns"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtFecIns" Width="90%" runat="server" onKeyPress = "javascript: return false;" onPaste = "javascript: return false;"></asp:TextBox>
                        <asp:ImageButton ID="btnCalendar" runat="server" ImageUrl="~/Images/Calendar.png" />
                        <act:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TxtFecIns" Format="dd/MM/yyyy"
                            PopupButtonID="btnCalendar" />
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label8" runat="server" Text="Alumno:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbAlumno" Width="100%" runat="server" />
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


