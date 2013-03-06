<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ControlObjects.Niveles.Index" %>
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
   
            <asp:BoundField DataField="Id" HeaderText="ID" HeaderStyle-Font-Names="calibri" ReadOnly="True"/>
             <asp:BoundField DataField="Descripcion" HeaderText="Descripción" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="EdadMinima" HeaderText="Edad Minima" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="EdadMaxima" HeaderText="Edad Maxima" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="Descuento" HeaderText="Descuento" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="RecargoPrimerVencimiento" HeaderText="Recargo Primer Vencimiento" HeaderStyle-Font-Names="calibri"/>
            <asp:BoundField DataField="RecargoSegundoVencimiento" HeaderText="Recargo Segundo Vencimiento" HeaderStyle-Font-Names="calibri"/>

            
            <asp:TemplateField ItemStyle-Width="25px">
                <ItemTemplate>
                    <a href="Details.aspx?id=<%# Eval("Id") %>">
                        <img alt="Abrir" src="../images/File-Open-icon.png" border="0" width="16px" height="16px" />
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <SelectedRowStyle BackColor="Silver" HorizontalAlign="Center" VerticalAlign="Middle" />
        <HeaderStyle BackColor="Silver" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</asp:Content>
