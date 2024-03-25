using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace Gramip
{
    public partial class Form1 : Form
    {
        data Dato = new data();
        Label lblEstado;


        public Form1()
        {
            InitializeComponent();
            lblEstado = new Label();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Codificacion codificar = new Codificacion();

            String linAc = textBoxNo.Text + ": " + textBoxMe.Text;
            textBoxCh.Text += linAc + "\r\n";
            textBoxMe.Text = "";

            
            
            Thread hilo = new Thread(() => envmatriz(codificar.codificacion(linAc, Dato.Clave)));

        }
        private void envmatriz(byte [] matriz)
        {
            try
            {
                TcpClient cliente = new TcpClient();
                cliente.Connect(Dato.Ip, Dato.Puerto);

                using (NetworkStream stream = cliente.GetStream())
                using (BinaryWriter escritor = new BinaryWriter(stream))
                {
                    // Escribe la longitud del array
                    escritor.Write(matriz.Length);
                    // Escribe los bytes de la matriz
                    escritor.Write(matriz);

                }
                cliente.Close();
                interfazact("matriz enviada con exito");

            }

            catch (IOException ex)
            {
                Console.Write(ex);
                interfazact("algo");

            }

        }
        private void interfazact(String mensaje)
        {


            if (lblEstado.InvokeRequired)
            {
                lblEstado.Invoke(new Action<string>(interfazact), mensaje);
            }
            else
            {
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Dato.Puerto = Int32.Parse(textBoxPu.Text);
                Dato.Ip = textBoxIp.Text;
                Dato.Clave = textBoxCl.Text;

                SvInicio();
            }
            catch (Exception ex)
            {

            }

        }

        private void SvInicio()
        {
            Thread hiloSv = new Thread(SVEscucha);
            hiloSv.Start();
        }

        private void SVEscucha()
        {
            try
            {
                TcpListener Sv = new TcpListener(IPAddress.Any, Dato.Puerto);
                Sv.Start();

                while (true)
                {
                    Decodificacion dec = new Decodificacion();
                    using (TcpClient Cliente = Sv.AcceptTcpClient())
                    {
                        Console.WriteLine("Cliente conectado desde: " + ((IPEndPoint)Cliente.Client.RemoteEndPoint).Address);

                        using (NetworkStream stream = Cliente.GetStream())
                        using (BinaryReader lector = new BinaryReader(stream))
                        {
                            int longitud = lector.ReadInt32();

                            // Lee los bytes de la matriz
                            byte[] matriz = lector.ReadBytes(longitud);
                            textBoxCh.Text += dec.Decode(matriz, Dato.Clave) + "\r\n";

                        }
                    }


                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error en el servidor: {ex.Message}");
            }
        }




        private void textBoxCh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
