<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link type="text/css"rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Cadastro de Cliete</h3>
                <br />

                Nome do Cliente:<br />
                <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite o nome"  ForeColor="Red"/>
                <br /><br />

                Endereço do Cliente:<br />
                <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="requiredEndereco" runat="server" ControlToValidate="txtEndereco" ErrorMessage="Digite o endereço"  ForeColor="Red"/>
                <br /><br />

                Email do Cliente:<br />
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email válido" Width="25%" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Digite o Email"  ForeColor="Red"/>
                <br /><br />

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" onclick="btnCadastrarCliente" />
                <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
            </div>

        </div>
        
    </div>
    </form>
</body>
</html>
