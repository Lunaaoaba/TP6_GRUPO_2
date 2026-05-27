<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_Grupo_2_V1.WebForms.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Css/Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Inicio</h1>
            <asp:HyperLink ID="HlSeleccionarProductos" runat="server" NavigateUrl="~/WebForms/SeleccionarProductos.aspx" >Seleccionar Productos</asp:HyperLink><br />
            <asp:LinkButton ID="lbEliminarProducto" runat="server"  OnClick="lbEliminarProducto_Click">Eliminar Productos Seleccionados</asp:LinkButton><br />
            <asp:HyperLink ID="HlMostrarProductos" runat="server" NavigateUrl="~/WebForms/MostrarProductos.aspx">Mostrar Productos</asp:HyperLink>
        </div>
        <div>
            <table>
                <tr>
                    <td>
                        <br />
                        </br>
                        <asp:HyperLink ID="hlInicio" runat="server" NavigateUrl="~/WebForms/Inicio.aspx">Volver al Inicio.Aspx</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>