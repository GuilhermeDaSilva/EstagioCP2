using Estagio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio
{
    class Controle
    {
        public bool taok;
        public String mensagem = "";
        public bool cadastrar(String matricula, String nome, String disciplina, Int32 cargah, Boolean coord)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            taok = loginDao.cadastrar(matricula, nome, disciplina, cargah, coord);
            return taok;
        }

        
    }
}
