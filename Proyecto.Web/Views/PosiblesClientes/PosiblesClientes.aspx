<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="ContentHeader" ContentPlaceHolderID="header" runat="server">   
    
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <div class="mx-auto mt-5">
        <%-- PRIMERA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h1>
                        <b>Posibles Clientes</b>
                        <asp:Label runat="server" ID="lblOpcion" Visible="false"></asp:Label>
                    </h1>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblIdentificacion" Text="Identificacion"></asp:Label>
                    <asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblEmpresa" Text="Empresa"></asp:Label>
                    <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtSegundoNombre" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <%-- SEGUNDA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblPrimerApellido" Text="Primer apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPrimerApellido" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblSegundoApellido" Text="Segundo apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtSegundoApellido" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblDireccion" Text="Direccion"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblTelefono" Text="Telefono"></asp:Label>
                    <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <%-- TERCERA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <%-- CUARTA SECCION --%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>
        <%-- QUINTA SECCION --%>
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
                <div class="col-md-12" style="overflow: auto">
                    <asp:GridView runat="server"
                        ID="gvwDatos"
                        Width="100%"
                        AutoGenerateColumns="False"
                        EmptyDataText="No se encontraron registros" 
                        BackColor="White" 
                        BorderColor="#999999" 
                        BorderStyle="None" 
                        BorderWidth="1px" CellPadding="3" GridLines="Vertical"
                        OnRowCommand="gvwDatos_RowCommand">

                        <AlternatingRowStyle BackColor="#DCDCDC" />

                        <Columns>
                            <%-- REPRESENTACION DE DATOS EN CONTROLES WEB --%>
                            <asp:TemplateField HeaderText="Identificacion">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblIdentificacion" Text='<%# Bind("clieIdentificacion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%-- REPRESENTACION DE DATOS EN CELDAS --%>
                            <asp:BoundField HeaderText="Empresa" DataField="clieEmpresa" />
                            <asp:BoundField HeaderText="Primer nombre" DataField="cliePrimerNombre" />
                            <asp:BoundField HeaderText="Segundo nombre" DataField="clieSegundoNombre" />
                            <asp:BoundField HeaderText="Primer apellido" DataField="cliePrimerApellido" />
                            <asp:BoundField HeaderText="Segundo apellido" DataField="clieSegundoApellido" />
                            <asp:BoundField HeaderText="Direccion" DataField="clieDireccion" />
                            <asp:BoundField HeaderText="Telefono" DataField="clieTelefono" />
                            <asp:BoundField HeaderText="Correo" DataField="clieCorreo" />

                            <%-- EDITAR --%>
                            <asp:TemplateField HeaderText="Editar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ibEditar" runat="server" ImageUrl="~/Resources/Images/Edit.gif"
                                        CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center"/>
                            </asp:TemplateField>

                            <%-- ELIMINAR --%>
                            <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ibEliminar" runat="server" ImageUrl="~/Resources/Images/remover.gif"
                                        CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center"/>
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
</asp:Content>
