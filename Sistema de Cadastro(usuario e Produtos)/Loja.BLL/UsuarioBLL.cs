using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL;
using Loja.DTO;

namespace Loja.BLL
{
    public class UsuarioBLL
    {
        public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                return new UsuarioDAL().cargaUsuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereUsuario(usuario_DTO USU)
        {
            /*Insere usuario será criado na DAL*/
            try
            {
                return new UsuarioDAL().insereUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InsereUsuario(usuario_DTO USU)
        {
            /*Insere usuario será criado na DAL*/
            try
            {
                return new UsuarioDAL().insereUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int editaUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL().editaUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int deletaUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL().deletaUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
    

