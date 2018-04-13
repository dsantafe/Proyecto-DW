<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Proyecto.Web.Views.Index.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-3">
                <h1><b>Bienvenido</b></h1>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-3">
                <asp:Image runat="server" Height="150px" Width="150px" ID="iCuenta" />
            </div>
        </div>
    </div>
</asp:Content>
