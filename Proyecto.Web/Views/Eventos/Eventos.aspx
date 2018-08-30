<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="Proyecto.Web.Views.Eventos.Eventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />

    <div class="container">
        <div class="card mx-auto mt-5">
            <div class="card-header">Crear Eventos</div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <h3>
                                <b>Resultados</b>
                            </h3>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:GridView runat="server" ID="gvwDatos" EmptyDataText="No se encontraron registros" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                                <AlternatingRowStyle BackColor="#DCDCDC" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("CODIGO") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Nombre" DataField="NOMBRE" />

                                    <asp:BoundField HeaderText="Ubicacion" DataField="UBICACION" />
                                    <asp:BoundField HeaderText="Participantes" DataField="PARTICIPANTES" />
                                    <asp:BoundField HeaderText="Todo el dia" DataField="TODO_DIA" />
                                    <asp:BoundField HeaderText="Fecha" DataField="FECHA" />
                                    <asp:BoundField HeaderText="Relacionado con" DataField="RELACIONADO_CON.DESCRIPCION" />
                                    <asp:BoundField HeaderText="Descripcion" DataField="DESCRIPCION" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#000065" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
