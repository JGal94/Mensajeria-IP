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
            lblEstado = this.lblEstado;

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

            String[,] mtx = codificar.codificacion(linAc);
            int da = 0;
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    da++;
                    textBoxCh.Text += mtx[i, j].ToString() + "\t";
                    Console.WriteLine("Hola");
                }

            }

            //Thread hilo = new Thread(() => envmatriz(codificar.codificacion(linAc)));

        }
        private void envmatriz(String[,] matriz)
        {
            try
            {
                TcpClient cliente = new TcpClient();
                cliente.Connect(Dato.Ip, Dato.Puerto);

                using (NetworkStream stream = cliente.GetStream())
                using (BinaryWriter escritor = new BinaryWriter(stream))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            escritor.Write(matriz[i, j]);

                        }
                    }
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
                lblEstado.Text = mensaje;
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
                Dato.Clave = Int32.Parse(textBoxCl.Text);

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

                            int[,] matriz = new int[2, 2];
                            for (int i = 0; i < 2; i++)
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    matriz[i, j] = lector.ReadInt32();
                                }
                                dec.Decode(matriz);
                            }


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
