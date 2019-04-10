using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductorConsumidor
{
    public partial class Form1 : Form
    {
        const int MAX_CONT = 35;
        const int SIZE = 20;

        bool[] Cont = new bool[MAX_CONT];

        bool Busy = false;

        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < MAX_CONT; i++)
            {
                Cont[i] = false;
            }

            DrawContainer();
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
            System.Threading.Thread.Sleep(1000);
        }
    }
}
