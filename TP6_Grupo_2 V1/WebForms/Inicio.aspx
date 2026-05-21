<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_2.WebForms.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <style>
            .Link {
                    display: inline-block;
                text-decoration: none;
                text-align: center;
                background: linear-gradient(135deg, #7b0000, #ff2f2f, #ff6b6b);
                color: midnightblue;
                font-size: 15px;
                font-weight: bold;
                letter-spacing: 1px;
                padding: 10px 28px;
                border-radius: 25px;
                border: none;
                box-shadow: 0px 4px 15px rgba(255, 47, 47, 0.4);
                transition: all 0.3s ease;
            }
                .Link:hover{
                    background: linear-gradient(135deg, #ff6b6b, #ff2f2f, #7b0000);
                    box-shadow: 0px 6px 20px rgba(255, 47, 47, 0.7);
                    transform: translateY(-2px);
                    color: white;
                }
        </style>
        <div>
            <table>
                <tr>
                    <td><h1>Grupo N°2</h1></td>
                </tr>
            </table>
        </div>
        <div>
            <table>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="hlEjercicio1" runat="server" CssClass="Link" NavigateUrl="~/WebForms/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="hlEjercicio2" runat="server" CssClass="Link">Ejercicio 2</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
