using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductorConsumidor.Clases;

namespace ProductorConsumidor
{
    public partial class Form1 : Form
    {
        const int MAX_CONT = 35;
        const int SIZE = 20;

        bool[] Cont = new bool[MAX_CONT];
        bool Busy = false;

        Random rand = new Random();

        clsActor Productor;
        clsActor Consumidor;

        public Form1()
        {
            InitializeComponent();

            Productor = new clsActor("Dormido", rand.Next(3, 10));
            Consumidor = new clsActor("Dormido", rand.Next(3, 10));

            for (int i = 0; i < MAX_CONT; i++)
            {
                Cont[i] = false;
            }
            timer1.Start();
        }

        private void DrawContainer()
        {
            Graphics g = pnlContainer.CreateGraphics();
            Pen p = new Pen(Color.Black);
            SolidBrush sb;
            int x = 0;
            for (int i = 0; i < MAX_CONT; i++)
            {
                if (Cont[i] == false)
                {
                    sb = new SolidBrush(Color.Red);
                }
                else
                {
                    sb = new SolidBrush(Color.Green);
                }

                pnlContainer.CreateGraphics().FillRectangle(sb, x, 0, SIZE, pnlContainer.Size.Height);
                pnlContainer.CreateGraphics().DrawRectangle(p, x , 0, SIZE, pnlContainer.Size.Height);
                x += SIZE;
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawContainer();
        }

        private void Process()
        {

            if (Productor.Tiempo == 0)
            {
                if (Productor.Estatus == "Trabajando")
                {
                    Productor.Estatus = "Dormido";
                    Productor.Tiempo = rand.Next(3, 10);
                    Busy = false;
                }
                else if (Busy)
                {
                    Productor.Estatus = "Esperando";
                }
                else
                {
                    Productor.Estatus = "Trabajando";
                    Busy = true;
                    Productor.Tiempo = rand.Next(3, 10);
                }
            }
            else if(Productor.Estatus == "Trabajando")
            {
                if (Cont[Productor.Indice] == true)
                {
                    Productor.Estatus = "Dormido";
                    Productor.Tiempo = rand.Next(3, 10);
                    Busy = false;
                }
                else
                {
                    Cont[Productor.Indice++] = true;
                    Productor.Tiempo--;
                    if (Productor.Indice >= MAX_CONT)
                    {
                        Productor.Indice = 0;
                    }
                }
            }

            if (Consumidor.Tiempo == 0)
            {
                if (Consumidor.Estatus == "Trabajando")
                {
                    Consumidor.Estatus = "Dormido";
                    Consumidor.Tiempo = rand.Next(3, 10);
                    Busy = false;
                }
                else if (Busy)
                {
                    Consumidor.Estatus = "Esperando";
                }
                else
                {
                    Consumidor.Estatus = "Trabajando";
                    Busy = true;
                    Consumidor.Tiempo = rand.Next(3, 10);
                }
            }
            else if (Consumidor.Estatus == "Trabajando")
            {
                if(Cont[Consumidor.Indice] == false)
                {
                    Consumidor.Estatus = "Dormido";
                    Consumidor.Tiempo = rand.Next(3, 10);
                    Busy = false;
                }
                else
                {
                    Cont[Consumidor.Indice++] = false;
                    Consumidor.Tiempo--;
                    if (Consumidor.Indice >= MAX_CONT)
                    {
                        Consumidor.Indice = 0;
                    }
                }
            }

            if (Productor.Estatus == "Dormido")
            {
                Productor.Tiempo--;
            }

            if (Consumidor.Estatus == "Dormido")
            {
                Consumidor.Tiempo--;
            }

            SetLabels();
            DrawContainer();
        }

        private void SetLabels()
        {
            if(lblPEstatus.Text != Productor.Estatus)
            {
                lblPEstatusAnt.Text = lblPEstatus.Text;
            }
            lblPEstatus.Text = Productor.Estatus;
            lblPTiempo.Text = Productor.Tiempo.ToString();
            lblPPos.Text = Productor.Indice.ToString();

            if (lblCEstatus.Text != Consumidor.Estatus)
            {
                lblCEstatusAnt.Text = lblCEstatus.Text;
            }
            lblCEstatus.Text = Consumidor.Estatus;
            lblCTiempo.Text = Consumidor.Tiempo.ToString();
            lblCPos.Text = Consumidor.Indice.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process();
        }
    }
}
