using System.Linq;
using testePratico.Model;

namespace testePratico.DAL
{
    public class LoginDAL
    {
        public static Usuario buscarUsuario(string pNome, string pSenha)
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                Usuario user = conn.Usuarios.Where(u => u.Login == pNome.Trim() && u.Senha == pSenha.Trim()).Select(x => x).FirstOrDefault();
                return user;
            }
            catch
            {
                return null;
            }
        }
    }
}
