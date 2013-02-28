<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Pagar.aspx.cs" Inherits="ControlObjects.Pagos.Pagar" %>
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
                        <asp:Label ID="Label4" runat="server" Text="Apellido:" Font-Names="Calibri"></asp:Label>
                     </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtApellido" ReadOnly="true" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label11" runat="server" Text="Alumno:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbAlumnos" Width="100%" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CmbAlumnos_OnSelectedIndexChanged" />
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label6" runat="server" Text="Matricula:" Font-Names="Calibri"></asp:Label>
                     </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtMatricula" ReadOnly="true" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label2" runat="server" Text="Nombre:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtNombre" ReadOnly="true" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label1" runat="server" Text="Factura Pago de:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbPagoDe" Width="100%" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CmbPagoDe_OnSelectedIndexChanged" />
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="lblCuota" runat="server" Text="Correspondiente al mes:" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td style="width: 200px;">
                        <asp:DropDownList ID="CmbCuota" Width="100%" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CmbCuota_OnSelectedIndexChanged" />
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label5" runat="server" Text="Fecha Emisión:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtFechaEmision" ReadOnly="true" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label7" runat="server" Text="Fecha 1er Vencimiento:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtVencimiento1" ReadOnly="true" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label8" runat="server" Text="Fecha 2do Vencimiento:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtVencimiento2" ReadOnly="true" Width="100%" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Image runat="server" Width="100px" Height="100px" ImageUrl="~/Images/pago-facil.png" />
                    </td>
                     <td align="left" style="width: 100px;">
                       <asp:Image ID="ImgBarCode" runat="server"  Height="100px" />
                    </td>
                </tr>
                  <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label9" runat="server" Text="SubTotal:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td >
                        <asp:TextBox ID="TxtSubTotal" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label12" runat="server" Text="Descuento %:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtDescuento" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label10" runat="server" Text="Total:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtTotal" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                    </td>
                </tr>

                  <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label3" runat="server" Text="Total desp. de 1er Venc.:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtTotal1Ven" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label13" runat="server" Text="Total desp. de 2do Venc.:" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtTotal2Ven" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                    </td>
                </tr>

             <tr>
                    <td align="center" colspan="2">
                        <br />
                        <asp:ImageButton ID="BtnPrint" Width="32px" Height="32px" ImageUrl="~/Images/print.png"
                            runat="server" ValidationGroup="add" OnClick="BtnPrint_Click" ToolTip="Imprimir" />
                            <asp:ImageButton ID="BtnEmail" Width="32px" Height="32px" ImageUrl="~/Images/Email.png"
                            runat="server" ValidationGroup="add" OnClick="BtnEmail_Click" ToolTip="Email" />
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
