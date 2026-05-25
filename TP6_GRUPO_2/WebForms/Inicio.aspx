<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_2.WebForms.Inicio" %>

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
            <table class="marco">
                <tr>
                    <td><h1 class="nomargen">Grupo N°2</h1></td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="hlEjercicio1" runat="server" CssClass="Link" NavigateUrl="~/WebForms/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="hlEjercicio2" runat="server" CssClass="Link" NavigateUrl="~/WebForms/Ejercicio2.aspx">Ejercicio 2</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
