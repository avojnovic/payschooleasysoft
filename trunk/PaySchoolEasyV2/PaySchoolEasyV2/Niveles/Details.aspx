<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ControlObjects.Niveles.Details" %>
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
                        <asp:Label ID="Label1" runat="server" Text="Descripción:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtDescripcion"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtDescripcion" Width="100%" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label2" runat="server" Text="Edad Minima:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtEdadMinima"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtEdadMinima" Width="100%" runat="server"></asp:TextBox>
                        <act:MaskedEditExtender ID="MaskedEditExtender3" runat="server" TargetControlID="TxtEdadMinima" Mask="99" MaskType="Number" />
                    </td>
                </tr>
                  <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label3" runat="server" Text="Edad Maxima:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtEdadMaxima"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtEdadMaxima" Width="100%" runat="server"></asp:TextBox>
                        <act:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="TxtEdadMaxima" Mask="99" MaskType="Number" />
                    </td>
                </tr>
              <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label4" runat="server" Text="Descuento:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtDescuento"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtDescuento" Width="100%" runat="server"></asp:TextBox>
                        <act:MaskedEditExtender ID="MaskedEditExtender4" runat="server" TargetControlID="TxtDescuento" Mask="9999.99" MaskType="Number" />
                    </td>
                </tr>
             <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label5" runat="server" Text="Recargo Primer Vencimiento:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtRecargoPrimerVencimiento"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtRecargoPrimerVencimiento" Width="100%" runat="server"></asp:TextBox>
                        <act:MaskedEditExtender ID="MaskedEditExtender2" runat="server" TargetControlID="TxtRecargoPrimerVencimiento" Mask="9999.99" MaskType="Number" />
                    </td>
                </tr>
                <tr>
                    <td align="left" style="width: 100px;">
                        <asp:Label ID="Label6" runat="server" Text="Recargo Segundo Vencimiento:" Font-Names="Calibri"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtRecargoSegundoVencimiento"
                            Display="Dynamic" ErrorMessage="*" SetFocusOnError="true" ValidationGroup="add" />
                    </td>
                    <td style="width: 200px;">
                        <asp:TextBox ID="TxtRecargoSegundoVencimiento" Width="100%" runat="server"></asp:TextBox>
                        <act:MaskedEditExtender ID="MaskedEditExtender5" runat="server" TargetControlID="TxtRecargoSegundoVencimiento" Mask="9999.99" MaskType="Number" />
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <br />
                        <asp:ImageButton ID="BtnGuardar" Width="32px" Height="32px" ImageUrl="~/Images/Save.png"
                            runat="server" ValidationGroup="add" OnClick="BtnGuardar_Click" ToolTip="Guardar" />
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
