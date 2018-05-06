<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Tareas.aspx.cs" Inherits="Proyecto.Web.Views.Tareas.Tareas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <div class="card mx-auto mt-5">
            <div class="card-header">Crear Tareas</div>
            <div class="card-body">
                <%-- FILA 1 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <h1>
                                <b>Informacion sobre la tarea</b>
                                <asp:Label runat="server" ID="lblOpcion" Visible="false"></asp:Label>
                            </h1>
                        </div>
                    </div>
                </div>
                <%-- FILA 2 --%>
                <div class="form-group">
                    <div class="form-row">
                         <div class="col-md-4">
                            <asp:Label runat="server" ID="lblCodigo" Text="Codigo de la tarea"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtCodigo" runat="server"
                                TargetControlID="txtCodigo"
                                WatermarkText="Codigo Tarea" />
                        </div>
                        <div class="col-md-4">
                            <asp:Label runat="server" ID="lblTitularTarea" Text="Titular de la tarea"></asp:Label>
                            <asp:TextBox runat="server" ID="txtTitularTarea" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtTitularTarea" runat="server"
                                TargetControlID="txtTitularTarea"
                                WatermarkText="Titular Tarea" />
                        </div>
                        <div class="col-md-4">
                            <asp:Label runat="server" ID="lblAsunto" Text="Asunto"></asp:Label>
                            <asp:TextBox runat="server" ID="txtAsunto" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtAsunto" runat="server"
                                TargetControlID="txtAsunto"
                                WatermarkText="Asunto" />
                        </div>
                    </div>
                </div>
                <%-- FILA 3 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblFechaVencimiento" Text="Fecha de vencimiento"></asp:Label>
                            <asp:TextBox runat="server" ID="txtFechaVencimiento" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtFechaVencimiento" runat="server"
                                TargetControlID="txtFechaVencimiento"
                                WatermarkText="Fecha Vencimiento" />
                            <ajaxToolkit:CalendarExtender ID="ceFechaVencimiento" runat="server" TargetControlID="txtFechaVencimiento" Format="yyyy-MM-dd" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblContacto" Text="Contacto"></asp:Label>
                            <asp:TextBox runat="server" ID="txtContacto" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtContacto" runat="server"
                                TargetControlID="txtContacto"
                                WatermarkText="Contacto" />
                        </div>
                    </div>
                </div>
                <%-- FILA 4 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblCuenta" Text="Cuenta"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCuenta" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtCuenta" runat="server"
                                TargetControlID="txtCuenta"
                                WatermarkText="Cuenta" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblEstado" Text="Estado"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlEstadoTarea" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <%-- FILA 5 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblPrioridad" Text="Prioridad"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlPrioridad" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblEnviarMensaje" Text="Enviar Mensaje">
                                <asp:CheckBox runat="server" ID="chkEnviarMensaje" CssClass="form-control"></asp:CheckBox>
                            </asp:Label>
                        </div>
                    </div>
                </div>
                <%-- FILA 6 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblRepetir" Text="Repetir">
                                <asp:CheckBox runat="server" ID="chkRepetir" CssClass="form-control"></asp:CheckBox>
                            </asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblDescripcion" Text="Descripcion"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtDescripcion" runat="server"
                                TargetControlID="txtDescripcion"
                                WatermarkText="Descripcion" />
                        </div>
                    </div>
                </div>
                <%-- FILA 7 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                            <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                        </div>
                    </div>
                </div>
                <%-- FILA 8 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <h3>
                                <b>Resultados</b>
                            </h3>
                        </div>
                    </div>
                </div>
                <%-- FILA 9 --%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:GridView runat="server" ID="gvwDatos" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowCommand="gvwDatos_RowCommand">
                                <AlternatingRowStyle BackColor="#DCDCDC" />
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("inCodigo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Titular" DataField="stTitular" />
                                    <asp:BoundField HeaderText="Asunto" DataField="stAsunto" />
                                    <asp:BoundField HeaderText="Fecha vencimiento" DataField="stFechaVencimiento" />
                                    <asp:BoundField HeaderText="Contacto" DataField="stContacto" />
                                    <asp:BoundField HeaderText="Cuenta" DataField="stCuenta" />
                                    <asp:BoundField HeaderText="Estado tarea" DataField="obclsEstadoTareas.stDescripcion" />
                                    <asp:BoundField HeaderText="Prioridad" DataField="obclsPrioridad.stDescripcion" />
                                    <asp:BoundField HeaderText="Enviar mensaje" DataField="stEnviarMensaje" />
                                    <asp:BoundField HeaderText="Repetir" DataField="stRepetir" />
                                    <asp:BoundField HeaderText="Descripcion" DataField="stDescripcion" />
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lblCodigoEstadoTarea" Text='<%# Bind("obclsEstadoTareas.inCodigo") %>'></asp:Label>
                                            <asp:Label runat="server" ID="lblCodigoPrioridad" Text='<%# Bind("obclsPrioridad.inCodigo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Modificar">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="ibModificar" runat="server" ImageUrl="~/Resources/Images/Edit.gif" CommandName="Modificar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Eliminar">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="ibEliminar" runat="server" ImageUrl="~/Resources/Images/remover.gif" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField>
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
