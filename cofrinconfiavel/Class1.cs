using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;
using System.Windows.Forms;

namespace cofrinconfiavel
{
    internal class Cadastro
    {
        public string Email;
        public string Senha;
        
        public Cadastro (string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }
    
        public string GetEmail()
        {

            return Email;
        }
        public string SetSenha() {
            return Senha;
        }
        

    }
    
 
    }


