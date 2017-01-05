﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
    <link type="text/css"rel="stylesheet" href="Content/bootstrap.css" />
</head>
     <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Consulta de Clientes</h3>
                <br />

                <asp:GridView ID="gridClientes" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#99ff99">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Código" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>
                                
                <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
            </div>

        </div>
        
    </div>
    </form>
</body>
</html>
