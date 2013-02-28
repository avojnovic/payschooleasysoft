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
                        <asp:TextBox ID="TxtFecIns" Width="100%" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
             <%--   <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label8" runat="server" Text="Alumno:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbAlumno" Width="100%" runat="server" />
                    </td>
                </tr>--%>
               
            </table>
        </asp:Panel>
        <br />
        <asp:Panel runat="server" ID="panel2" Visible="true" Width="600px" Style="background-color: #DDDDDD">
            <table style="width: 500px;" border="0" cellspacing="0">
                <tr >
                  <td align="left" style="width: 100px;">
                        <asp:Label ID="Label9" runat="server" Visible="false" Text="Buscar Alumno:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td align="left" >
                        <asp:TextBox ID="TxtSearch" Visible="false" runat="server"></asp:TextBox>
                        <asp:Button ID="BtnSearch" Visible="false" OnClick="BtnSearch_Click" runat="server" Text="Buscar" />
                    </td>
                </tr>

                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label11" runat="server" Text="Alumnos Registrados:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbAlumnos" Width="100%" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CmbAlumnos_OnSelectedIndexChanged" />
                    </td>
                </tr>

               <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label8" runat="server" Text="Matricula:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtIdAlumno"  Enabled="false" Width="100%" runat="server"></asp:TextBox>
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
                        <asp:TextBox ID="TxtApellido" ReadOnly="true" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label5" runat="server" Text="Fecha Nacimiento:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtFecNac"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td align="left" style="width: 200px;">
                        <asp:TextBox ID="TxtFecNac" Width="90%" runat="server" onKeyPress = "javascript: return false;" onPaste = "javascript: return false;"></asp:TextBox>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Calendar.png" />
                        <act:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TxtFecNac" Format="dd/MM/yyyy"
                            PopupButtonID="ImageButton1" />
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label3" runat="server" Text="Nivel:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td align="left" style="width: 200px;">
                        <asp:DropDownList ID="CmbNivel" Width="90%" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CmbNivel_OnSelectedIndexChanged" />
                          <asp:ImageButton ID="Btn_Niveles" Width="16px" Height="16px" ImageUrl="~/Images/refresh.png"
                            runat="server" OnClick="Btn_Niveles_Click" ToolTip="Obtener Niveles" />
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label10" runat="server" Text="Curso:" Font-Names="Calibri"></asp:Label>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="CmbCurso"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbCurso" Width="100%" runat="server" />
                    </td>
                </tr>
              
            </table>
        </asp:Panel>
        <br />
         <asp:Panel runat="server" ID="panel3" Visible="true" Width="600px" Style="background-color: #DDDDDD">
            <table style="width: 500px;" border="0" cellspacing="0">
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
        <act:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="panel2"
        Radius="8" Color="#DDDDDD" Corners="All" Enabled="true" />
        <act:RoundedCornersExtender ID="RoundedCornersExtender3" runat="server" TargetControlID="panel3"
        Radius="8" Color="#DDDDDD" Corners="All" Enabled="true" />
</asp:Content>


