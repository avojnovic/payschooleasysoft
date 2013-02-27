<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Confirmar.aspx.cs" Inherits="ControlObjects.Incripciones.Confirmar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:GridView ID="GridView1" Font-Names="calibri" runat="server" AutoGenerateColumns="False"
        GridLines="None" AllowPaging="true" HorizontalAlign="Center" Width="100%" PageSize="30"
        CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"
        OnPageIndexChanging="GridView1_PageIndexChanging"
        OnRowCommand="GridView1_RowCommand"
        >
        <PagerSettings PageButtonCount="5" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="lblId" Font-Names="calibri" runat="server" Text='<%#Eval("Id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="alumnoNombre" HeaderText="Alumno" HeaderStyle-Font-Names="calibri" />
            <asp:BoundField DataField="alumnoMatricula" HeaderText="Matricula" HeaderStyle-Font-Names="calibri" />
            <asp:BoundField DataField="CursoDescripcion" HeaderText="Curso" HeaderStyle-Font-Names="calibri" />
            <asp:BoundField DataField="NivelDescripcion" HeaderText="Nivel" HeaderStyle-Font-Names="calibri" />
            <asp:BoundField DataField="FechaInscripción" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha Inscripción"
                HeaderStyle-Font-Names="calibri" />
            <asp:BoundField DataField="StatusInscripto" HeaderText="Inscripto" HeaderStyle-Font-Names="calibri" />
            <asp:BoundField DataField="StatusEspera" HeaderText="En lista de Espera" HeaderStyle-Font-Names="calibri" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="BtnConfirmar" Width="16px" Height="16px" ImageUrl="~/Images/save.png"
                        runat="server" ToolTip="Confirmar Inscripción" CommandName="Confirmar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="BtnBorrar" Width="16px" Height="16px" ImageUrl="~/Images/Trash.png"
                        runat="server" ToolTip="Borrar Inscripción" CommandName="Borrar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <SelectedRowStyle BackColor="Silver" HorizontalAlign="Center" VerticalAlign="Middle" />
        <HeaderStyle BackColor="Silver" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</asp:Content>
