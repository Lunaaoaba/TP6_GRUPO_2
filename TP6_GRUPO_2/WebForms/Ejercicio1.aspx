<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP6_GRUPO_2.WebForms.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
             <tr>
                 <td>
                     <h1>Productos</h1>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvProductos" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
