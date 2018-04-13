<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="Proyecto.Web.Views.CrearCuenta.CrearCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Crear Cuenta</title>
    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="../../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet" />
    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
</head>
<body class="bg-dark">

    <div class="container">
        <div class="card mx-auto mt-5">
            <div class="card-header">
                Crear Cuenta
            </div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblLogin" Text="Email"></asp:Label>
                                <asp:TextBox runat="server" ID="txtLogin" TextMode="Email" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtLogin" ForeColor="Red" ValidationGroup="ValidarCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblPassword" Text="Password"></asp:Label>
                                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtPassword" ForeColor="Red" ValidationGroup="ValidarCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblConfirmarPassword" Text="Confirmar password"></asp:Label>
                                <asp:TextBox runat="server" ID="txtConfirmarPassword" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvConfrmarPassword" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtConfirmarPassword" ForeColor="Red" ValidationGroup="ValidarCuenta"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="cvConfirmarPassword" runat="server" ErrorMessage="Password no coincide" ControlToValidate="txtConfirmarPassword" ControlToCompare="txtPassword" ForeColor="Red"></asp:CompareValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblImagen" Text="Subir imagen"></asp:Label>
                                <asp:FileUpload runat="server" ID="fuImagen" CssClass="form-control"></asp:FileUpload>
                                <asp:RequiredFieldValidator ID="rfvImagen" runat="server" ErrorMessage="Campo requerido" ControlToValidate="fuImagen" ForeColor="Red" ValidationGroup="ValidarCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>                   
                    
                    <div class="text-center">
                        <asp:Button runat="server" OnClick="btnCrear_Click" ID ="btnCrear" Text="Crear cuenta" CssClass="btn btn-primary btn-block" ValidationGroup="ValidarCuenta" />
                        <a href="../Login/Login.aspx" class="d-block small mt-3">Iniciar Sesion</a>
                    </div>
                </form>
            </div>
        </div>
    </div>

</body>
</html>
