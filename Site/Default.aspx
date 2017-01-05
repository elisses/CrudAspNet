<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css"rel="stylesheet" href="Content/bootstrap.css" />

</head>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
     <div class="container">
         <div class="row">
             <div class="jumbotron text-center">
                    <h1>PROJETO CRUD</h1> 
                    <h1> Controle de clientes</h1>

                    Selecione a operação desejada:
                    <asp:DropDownList ID="ddlMenu" runat="server">
                        <asp:ListItem Value="0" Text="- Escolha uma opção - " />
                        <asp:ListItem Value="1" Text="Cadastrar Cliente" />
                        <asp:ListItem Value="2" Text="Consultar Cliente " />
                        <asp:ListItem Value="3" Text="Obter os dados do Cliente" />          
                    </asp:DropDownList>
                    <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" onclick="btnAcessar"/>
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>      
    
                </div>
         </div>
                
        
    </div>
    </form>
</body>
    
</html>
