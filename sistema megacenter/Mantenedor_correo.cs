using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//importar using correo
using System.Net.Mail;
using System.Net.Mime;
using System.Diagnostics;


namespace sistema_megacenter
{
    public partial class Mantenedor_correo : Form
    {
        private string To;
        private string Subject;
        private string Body;
        private MailMessage mail;
        private Attachment Data;
        //public SmtpClient client = new SmtpClient();
        //public MailMessage msge = new MailMessage();
        //public System.Net.NetworkCredential smtpcred = new System.Net.NetworkCredential("camilo.gbustos@gmail.com","militox24");
        Gestion_perfil perfil = new Gestion_perfil();
        Gestion_Correo correo = new Gestion_Correo();
        string nombreusuario, apellidousuario, urlimagen, rutusuario, usuariologueado, correologueado;
        public Mantenedor_correo(string nombre, string apellido,string  url,string  rut,string usuario,string correo)
        {
            InitializeComponent();
            nombreusuario = nombre;
            apellidousuario = apellido;
            urlimagen = url;
            rutusuario = rut;
            usuariologueado = usuario;
            correologueado = correo;
        }
       

        private void btbuscararchivocorreo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
           // abririmagen.Filter = "Archivos JPEG(*.jpg)|* .jpg";
            abririmagen.InitialDirectory = "C:\\Users\\kmilo\\Documents";
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                string directory = abririmagen.FileName;
                txtarchivocorreo.Text = abririmagen.FileName;
            }
        }
        //public void enviarcorreo(string emisor,string receptor,string asunto,string archivo,string mensaje)
        //{
        //    try
        //    {
        //        client.Host = "smtp.gmail.com";
        //        client.Port = 587;
        //        client.UseDefaultCredentials = false;
        //        client.Credentials = smtpcred;
        //        client.EnableSsl = true;
        //        MailAddress to = new MailAddress(emisor);
        //        MailAddress from = new MailAddress(receptor);

        //        msge.Subject = asunto;
        //        msge.Body = mensaje;
        //        msge.From = from;
        //        msge.To.Add(to);
        //        // enviar correo
        //        client.Send(msge);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "error");
        //    }
        //}
        private void btbuscarcorreo_Click(object sender, EventArgs e)
        {
            Mantenedor_Buscar_Correo buscar=new Mantenedor_Buscar_Correo();
            buscar.ShowDialog();
            txtdestinatariocorreo.Text = buscar.correousuario;
        }


        private void btenviarcorreo_Click(object sender, EventArgs e)
        {
            string errores = "Usted tiene los siguientes errore\n";
            Boolean estado = false;
            if(txtdestinatariocorreo.Text==""){
                errores = errores + "Debes ingresar el destinatario\n";
                estado = true;
            }
            if(txtasuntocorreo.Text==""){
                errores = errores + "Debes ingresar el asunto\n";
                estado = true;
            }
            if(txtmensajecorreo.Text==""){
                errores = errores + "Debes ingresar el mensaje\n";
                estado = true;
            }
            if (estado == true)
            {
                MessageBox.Show(errores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet verificavendedor = perfil.buscar_correo_vendedor(txtdestinatariocorreo.Text);
                DataSet verificaadministrador = perfil.buscar_correo_Administrador(txtdestinatariocorreo.Text);
                if (verificavendedor.Tables["Vendedor"].Rows.Count > 0 || verificaadministrador.Tables["Administrador"].Rows.Count > 0)
                {
                
                    correo.guardar_mensaje(correologueado,txtdestinatariocorreo.Text,txtasuntocorreo.Text,txtarchivocorreo.Text,txtmensajecorreo.Text);
                    MessageBox.Show("Operación realizada con exito","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtdestinatariocorreo.Clear();
                    txtasuntocorreo.Clear();
                    txtarchivocorreo.Clear();
                    txtmensajecorreo.Clear();
                }
                else
                {
                    string servidor = "smtp.gmail.com";
                    if (!(txtdestinatariocorreo.Text.Trim() == ""))
                    {
                        To = txtdestinatariocorreo.Text;
                        Subject = txtasuntocorreo.Text;
                        Body = txtmensajecorreo.Text;
                        mail = new MailMessage();
                        mail.To.Add(new MailAddress(this.To));
                        mail.From = new MailAddress("" + correologueado + "");
                        mail.Subject = Subject;
                        mail.Body = Body;
                        mail.IsBodyHtml = false;
                        SmtpClient cliente = new SmtpClient(servidor);
                        if (!(txtarchivocorreo.Text.Trim() == ""))
                        {
                            Data = new Attachment(txtarchivocorreo.Text, MediaTypeNames.Text.Xml);
                            mail.Attachments.Add(Data);
                        }
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential("camilo.gbustos@gmail.com", "militox24");
                        cliente.EnableSsl = true;
                        cliente.Send(mail);
                        MessageBox.Show("mensaje enviado");
                    }
                }

            }
        }

        private void cargaenviarcorreo_Click(object sender, EventArgs e)
        {
            gbredactarcorreo.Visible = true;
            gbmismensajes.Visible =false;
            gbdetallemensaje.Visible = false;
        }

        private void btcargaenviarcorreo_Click(object sender, EventArgs e)
        {
            gbredactarcorreo.Visible = false;
            gbmismensajes.Visible = true;
            grillacorreos.DataSource = correo.rescata_correos(correologueado);
            grillacorreos.DataMember = "Correo";
        }
        
        private void btvolvermismensajes_Click(object sender, EventArgs e)
        {
            gbmismensajes.Visible = true;
            gbdetallemensaje.Visible = false;
            gbdetallemensaje.Visible = false;
            
        }

        private void btverarchivo_Click(object sender, EventArgs e)
        {
       
            Process.Start(txtarchivoverdetalle.Text);
            
        }
        private void grillacorreos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                gbmismensajes.Visible = false;
                gbdetallemensaje.Visible = true;
                txtemisorverdetalle.Text = grillacorreos[2, e.RowIndex].Value.ToString();
                txtasuntoverdetalle.Text = grillacorreos[3, e.RowIndex].Value.ToString();
                txtarchivoverdetalle.Text = grillacorreos[4, e.RowIndex].Value.ToString();
                txtmensajeverdetalle.Text = grillacorreos[5, e.RowIndex].Value.ToString();
                if (txtarchivoverdetalle.Text == "")
                {
                    btverarchivo.Visible = true;
                }
            }

            if(e.ColumnIndex==0){
                correo.Eliminar_Mensaje(grillacorreos[3,e.RowIndex].Value.ToString());
                MessageBox.Show("Correo Eliminado Correctamente","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                grillacorreos.DataSource = correo.rescata_correos(correologueado);
                grillacorreos.DataMember = "Correo";
            }
          
            
        }
    }
}
