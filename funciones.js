function registro() {
    var rut = $("#txtRut").val();
    var nombre = $("#txtNombre").val();
    var apellido = $("#txtApellido").val();
    var clave = $("txtClave").val();

    $.ajax({
        url: "registro.aspx",
        data: { rut: rut, name: nombre, ape: apellido, pass: clave },
        type: "post",
        success: function (data) {
            if (data.substring(0, 10) === "registrado") {
                alert("Registrado correctamente");
                location.href = "login.aspx";
            }
            else
                alert("Error al registrar");
        },
        error: function (data) {
            console.log("Error: " +data);
        }
    });
}

function login() {
    var rut = $("#txtRut").val();
    var clave = $("#txtClave").val();

    $.ajax({
        url: "validar.aspx",  
        type: "post",
        data: { rut: rut, pass: clave },
        success: function (data) {
            if (data.substring(0, 5) == "exito") {
                alert("Login correcto");
                location.href = "home.aspx";
            }
            else
                alert("Rut o clave incorrecto");
        },
        error: function (data) {
            console.log("Error: "+data);
        }
    });
}