using ProjCoopControleFinanceiro.Views.Usuario;
using ProjCoopControleFinanceiro.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjCoopControleFinanceiro.Model;
using System.Diagnostics;

namespace ProjCoopControleFinanceiro.Presenter
{
    internal class UsuarioPresenter
    {
        private IUsuarioView _view;
        private UsuarioRepo _repo;

        public UsuarioPresenter(IUsuarioView view)
        {
            _view = view;
            _repo = new UsuarioRepo();
        }

        public Usuario Login()
        {
            try
            {
                string condition = "usuario = @usuario AND senha = @senha";
                return _repo.getByCondition(condition, new Usuario { usuario = _view.usuario, senha = _view.senha }); ;
            }
            catch (Exception)
            {
                Util.Messages.Error("Erro ao fazer o login, tente novamente mais tarde!");
                throw;
            }
        }

        public void LimparTela()
        {
            _view.usuario = "";
            _view.senha = "";
        }

        public int Cadastro()
        {
            try
            {
                return _repo.Insert(new Usuario()
                {
                    usuario = _view.usuario,
                    senha = _view.senha
                });
            }
            catch (Exception ex)
            {
                if(ex.Message == "")
                    Util.Messages.Error("Erro ao tentar salvar as informações, tente novamente mais tarde!");
                else
                    Util.Messages.Error(ex.Message);
                throw;
            }
        }


    }
}
