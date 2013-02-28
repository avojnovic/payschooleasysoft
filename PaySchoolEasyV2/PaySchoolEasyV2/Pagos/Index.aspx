<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ControlObjects.Pagos.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <asp:GridView ID="GridView1" Font-Names="calibri" runat="server" AutoGenerateColumns="False"
        GridLines="None" AllowPaging="true" HorizontalAlign="Center" Width="100%" PageSize="30"
        CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"
        OnPageIndexChanging="GridView1_PageIndexChanging">
        <PagerSettings PageButtonCount="5" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Nro Pago" HeaderStyle-Font-Names="calibri" ReadOnly="True"/>
            <asp:BoundField DataField="FacturaNumero" HeaderText="Nro Factura" HeaderStyle-Font-Names="calibri" ReadOnly="True"/>
            <asp:BoundField DataField="FacturaFechaEmision" HeaderText="Fecha Emisión" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="CuotaDescripcion" HeaderText="Cuota" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="MatriculaDescripcion" HeaderText="Matricula" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="StatusConfirmado" HeaderText="Confirmado" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="FechaDePago" DataFormatString="{0:dd/MM/yyyy}"  HeaderText="Fecha de Pago" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="AlumnoDescripcion" HeaderText="Alumno" HeaderStyle-Font-Names="calibri" />
            
        </Columns>
        <SelectedRowStyle BackColor="Silver" HorizontalAlign="Center" VerticalAlign="Middle" />
        <HeaderStyle BackColor="Silver" Font-Bold="True" ForeColor="White" />
    </asp:GridView>

</asp:Content>
