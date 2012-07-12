using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tresenraya.domain;

namespace tresenraya.ui
{
    public partial class FormTablero : Form
    {
        Tablero tablero = new Tablero();
        ButtonFicha[,] buttonFicha = new ButtonFicha[3, 3];

        public FormTablero()
        {
            InitializeComponent();
            pictureBoxLineasDivisorias.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            añadir_botones();
            this.pictureBoxLineasDivisorias.SendToBack();
        }

        private void añadir_botones()
        {
            for (byte i = 0; i < 3; i++)
                for (byte j = 0; j < 3; j++)
                {
                    ButtonFicha bf = crear_boton(i, j, 139 + (150 * i), 78 + 127 * j, tablero.GetFicha(i, j));
                    buttonFicha[i, j] = bf;
                    this.Controls.Add(bf);
                }
        }

        private ButtonFicha crear_boton(byte x, byte y, int posx, int posy, Fichas? ficha)
        {
            ButtonFicha boton = new ButtonFicha
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Papyrus", 48F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Size = new Size(90, 90),
                TabIndex = 2,
                UseVisualStyleBackColor = false,
                Name = "button" + x + y,
                Location = new Point(posx, posy),
            };
            boton.Click += new System.EventHandler(buttonFicha_Click);
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            boton.Posicion = new Posicion(x, y);
            boton.Text = getStringFicha(ficha);

            return boton;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.FromArgb(255, 255, 255, 255));
            pen.Width = 5;
            g.DrawLine(pen, 140, 10, 140, 400);
            g.DrawLine(pen, 280, 10, 280, 400);
            g.DrawLine(pen, 10, 120, 400, 120);
            g.DrawLine(pen, 10, 253, 400, 253);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFicha_Click(object sender, EventArgs e)
        {
            ButtonFicha bf = (ButtonFicha)sender;
            tablero.AddFicha(TurnoFicha, bf.Posicion.Fila, bf.Posicion.Columna);
            refreshTablero();
        }

        private void refreshTablero()
        {
            for (byte i = 0; i < 3; i++)
                for (byte j = 0; j < 3; j++)
                    buttonFicha[i, j].Text = getStringFicha(tablero.GetFicha(i, j));
        }

        //TODO: Cambiar esto...
        private string getStringFicha(Fichas? ficha)
        {
            if (ficha == null) return string.Empty;

            if (ficha == Fichas.Aspa) return "X";

            return "O";
        }

        //TODO: Esto es para simular el turno mientras no está construido
        private Fichas _fichaTurno = Fichas.Aspa;
        private Fichas TurnoFicha
        {
            get
            {
                if (_fichaTurno == Fichas.Aspa)
                {
                    _fichaTurno = Fichas.Circulo;
                    return Fichas.Aspa;
                }

                _fichaTurno = Fichas.Aspa;
                return Fichas.Circulo;
            }
        }

        private void buttonNuevaPartida_Click(object sender, EventArgs e)
        {
            tablero=new Tablero();
            refreshTablero();
        }
    }
}
