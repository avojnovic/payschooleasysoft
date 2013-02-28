<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Importar.aspx.cs" Inherits="ControlObjects.Pagos.Importar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <center>
        <asp:Panel runat="server" ID="panel1" Visible="true" Width="600px" Style="background-color: #DDDDDD">
           <asp:FileUpload id="FileUploadControl" runat="server"  /><asp:FileUpload />
         <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
         <br />
         <asp:Label ID="LblMensaje" Font-Names="Calibri" Font-Size="Small" ForeColor="Red"
        runat="server"></asp:Label>
        </asp:Panel>
        </center>
        <act:RoundedCornersExtender ID="RoundedCornersExtender2" runat="server" TargetControlID="panel1"
            Radius="8" Color="#DDDDDD" Corners="All" Enabled="true" />
</asp:Content>
