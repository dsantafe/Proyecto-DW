$(document).ready(function () {
    $("#btnGuardarIncidencia").click(function () {
        GuardarIncidencia();
    });
});

function GuardarIncidencia() {

    if ($("#txtIdentificacion").val() == "") {
        alert("Ingrese identificación");
        return;
    }

    $.ajax({
        data: {
            "Identificacion": $("#txtIdentificacion").val(),
            "PrimerNombre": $("#txtPrimerNombre").val(),
            "SegundoNombre": $("#txtSegundoNombre").val(),
            "PrimerApellido": $("#txtPrimerApellido").val(),
            "SegundoApellido": $("#txtSegundoApellido").val(),
            "Direccion": $("#txtDireccion").val(),
            "Telefono": $("#txtTelefono").val(),
            "Correo": $("#txtCorreo").val(),
            "EstadoIncidencia.Id": $("#ddlEstadoIncidencia").val(),
            "TipoIncidencia.Id": $("#ddlTipoIncidencia").val(),
        },
        type: "POST",
        dataType: "json",
        url: "/Incidencia/Create",
        success: function (data) {
            alertify.success(data.Mensaje);
        },
        error: function (jqXHR, error, errorThrown) {
            var responseTitle = $(jqXHR.responseText).filter('title').get(0);
            alertify.error($(responseTitle).text());
        }
    });

    $("#NuevoIncidencia").modal('hide');
};