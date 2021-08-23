<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="clienteASP_para_el_WS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WS cliente ASP para el servicio de operaciones matemáticas básicas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nro1:<asp:TextBox ID="txtNro1" runat="server"></asp:TextBox>
        </div>
        Nro2:<asp:TextBox ID="txtNro2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSuma" runat="server" OnClick="btnSuma_Click" Text="Suma" />
            <asp:Button ID="btnResta" runat="server" OnClick="btnResta_Click" Text="Resta" />
            <asp:Button ID="btnMultiplicacion" runat="server" OnClick="btnMultiplicacion_Click" Text="Multiplicacion" />
            <asp:Button ID="btnDivision" runat="server" OnClick="btnDivision_Click" Text="Division" />
            <asp:Button ID="btnFact" runat="server" OnClick="btnFact_Click" Text="Factorial" />
        </p>
        <asp:Button ID="btnPotencia" runat="server" OnClick="btnPotencia_Click" Text="Potencia" />
        <asp:Button ID="btnSeno" runat="server" OnClick="btnSeno_Click" Text="Seno" />
        <asp:Button ID="btnTangente" runat="server" OnClick="btnTangente_Click" Text="Tangente" />
        <asp:Button ID="btnInversa" runat="server" OnClick="btnInversa_Click" Text="Inversa" />
        <asp:Button ID="btnRaizC" runat="server" OnClick="btnRaizC_Click" Text="Raiz cu" />
        <asp:Button ID="btnRaizN" runat="server" OnClick="btnRaizN_Click" Text="Raiz N" />
        <p>
            <asp:TextBox ID="txtRespuesta" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
