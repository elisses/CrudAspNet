﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            try
            {
                //pegando as informações do campo texto
                Pessoa p = new Pessoa();
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;

                PessoaDAL d = new PessoaDAL();
                d.Gravar(p);//gravando a pessoa

                lblMensagem.Text = "Cliente " + p.Nome + " Cadastrado com sucesso!";

                txtNome.Text = "";
                txtEndereco.Text = "";
                txtEmail.Text = "";
                            
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }

        }
    }
}