using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace sistema_megacenter
{
    public partial class Recupera_Contraseña_2 : Form
    {
        string preguntasecreta;
        string respuestasecreta;
        string rutlogueado;
        string correologueado;
        string usuariologueo;
        private string Destinatario;
        private string Asunto;
        private string Body;
        private MailMessage mail;
        string nombreusuario;
        public Recupera_Contraseña_2(string pregunta, string respuesta, string correo, string rut,string usuario,string nombres)
        {
            InitializeComponent();
            preguntasecreta = pregunta;
            respuestasecreta = respuesta;
            correologueado = correo;
            rutlogueado = rut;
            usuariologueo = usuario;
            nombreusuario = nombres;

        }
        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (Rbpreguntasecreta.Checked == false && Rbcorreoelectronico.Checked == false)
            {
                MessageBox.Show("Debes seleccionar una opción de recuperación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Rbpreguntasecreta.Checked == true)
                {
                  
                    Mantenedor_Pregunta_Secreta pregunta = new Mantenedor_Pregunta_Secreta(preguntasecreta, respuestasecreta, rutlogueado,usuariologueo);
                    this.Close();
                    pregunta.Show();
                } if (Rbcorreoelectronico.Checked == true)
                {
                    try
                    {
                        Mantenedor_Envio_Correo correo = new Mantenedor_Envio_Correo(correologueado, usuariologueo);
                        string servidor = "smtp.gmail.com";
                        string correoprueba = "camilo.gbustos@gmail.com";
                        Destinatario = correoprueba;
                        Asunto = "Recupración Clave Ingreso ";
                        int clave = new Random().Next(1000, 100000);
                        Body = "Estimado(a):" + nombreusuario + " " + "su nueva contraseña es " + clave + "";
                        mail = new MailMessage();
                        mail.To.Add(new MailAddress(this.Destinatario));
                        mail.From = new MailAddress("camilo.gbustos@gmail.com");
                        mail.Subject = Asunto;
                        mail.Body = Body;
                        mail.IsBodyHtml = false;
                        SmtpClient cliente = new SmtpClient(servidor);
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential("camilo.gbustos@gmail.com", "militox24");
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.Send(mail);
                        this.Hide();
                        correo.Show();
                    }catch{
                        MessageBox.Show("no se envio el mensaje");
                    }
                   
                    
                }
            }
        }
    }
}
