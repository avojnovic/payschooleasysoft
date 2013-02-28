<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DarDeBaja.aspx.cs" Inherits="ControlObjects.Incripciones.DarDeBaja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <br />
    

  <asp:Label ID="LblMensaje" Font-Names="Calibri" Font-Size="Small" ForeColor="Red" runat="server"></asp:Label>
  <br />
  <br />
  <br />
  <br />
<asp:Button ID="BtnDarDeBaja" runat="server" Text="Ejecutar proceso de eliminación de inscripciones" OnClick="BtnDarDeBaja_Click" />
</asp:Content>
