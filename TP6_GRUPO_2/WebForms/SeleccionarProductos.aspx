<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_Grupo_2_V1.WebForms.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:GridView ID="gvProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gvProductos_PageIndexChanging" PageSize="14" AutoGenerateSelectButton="True" OnSelectedIndexChanging="gvProductos_SelectedIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="Id Producto">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre Producto">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Id Proveedor">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_IdProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Precio Unitario">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_PrecioUnitario" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlInicio" runat="server" NavigateUrl="~/WebForms/Ejercicio2.aspx">Volver a Inicio</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
