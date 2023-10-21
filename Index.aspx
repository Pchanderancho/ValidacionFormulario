<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RegistroLoginAjax.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src ="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.5.0.min.js"></script>
    <script src ="funciones.js"></script>
    <script>
        $(document).ready(function () {
            $("#btnReg").click(function (e) {
                e.preventDefault();
            })
        });
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Rut:<asp:TextBox ID="txtRut" runat="server"></asp:TextBox><br />
            Nombre:<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            Apellido:<asp:TextBox ID="txtApellido" runat="server"></asp:TextBox><br />
            Clave:<asp:TextBox ID="txtClave" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnReg" runat="server" Text="Registrar" OnClientClick="registro()" />
        </div>
    </form>
</body>
</html>
