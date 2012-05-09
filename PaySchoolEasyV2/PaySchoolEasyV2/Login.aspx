<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PaySchoolEasyV2.Login" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h1 style="border-bottom: 1px solid #FF0000; font-size: 15pt;">
        <asp:Label ID="LblTitulo" runat="server" Font-Bold="True" Font-Size="XX-Large"   Text=""></asp:Label>
  </h1>

  
    <br />
    <br />
    <center>
      <div id="content">
      
      <asp:Panel runat="server" ID="panel1" Visible="true"  width="350px">
            <table width="350px" cellpadding="0" cellspacing="0" style="background-color:#DDDDDD; color:Black; font-size:10pt " border="0">
            <tr>
                <td align="left">
                     &nbsp &nbsp<asp:Label ID="LblUsuario" runat="server" Text="Usuario:"></asp:Label>
                </td>
                <td align="left">
                     <asp:TextBox ID="TxtUsuario" runat="server" Width="200px"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td align="left">
                     &nbsp &nbsp<asp:Label ID="LblPass" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td  align="left">
                     <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td align="center" colspan="2">
                    <br />

             
                   <asp:Button ID="BtnIniciar" runat="server" onclick="BtnIniciar_Click" Text="Iniciar Sesión"></asp:Button>

                     
                </td>
            </tr>
             <tr>
                <td align="center" colspan="2">
                    <br />
                    <asp:Label ID="TxtAviso" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
         </asp:Panel>
         <act:RoundedCornersExtender ID="RoundedCornersExtender2" runat="server" TargetControlID="panel1" Radius="8" Color="#DDDDDD" Corners="All" Enabled="true"> </act:RoundedCornersExtender>
    </div>
    <br />
    <br />


</asp:Content>
