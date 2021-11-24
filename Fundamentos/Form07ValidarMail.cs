using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form07ValidarMail : Form
    {
        public Form07ValidarMail()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            String email = this.txtEmail.Text;
            if (email.Contains("@") == false)
            {
                this.lblrespuesta.Text = "No existe @";
            }else if (email.StartsWith("@") == true || email.EndsWith("@") == true)
            {
                this.lblrespuesta.Text = "@ inicio o final del mail";
            }else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblrespuesta.Text = "Existe más de una @";
            }else if (email.IndexOf(".") == -1)
            {
                this.lblrespuesta.Text = "Debe existir un punto";
            }else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblrespuesta.Text = "Debe existir un punto después de @";
            }
            else
            {
                //paco@gmail.com
                int ultimopunto = email.LastIndexOf(".") + 1;
                string dominio = email.Substring(ultimopunto);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblrespuesta.Text = "Email Correcto!!!";
                }
                else
                {
                    this.lblrespuesta.Text = "El dominio debe ser de 2 a 4 caracteres";
                }
            }
        }
    }
}
