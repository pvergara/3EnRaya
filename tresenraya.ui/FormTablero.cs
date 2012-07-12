using System;
using System.Drawing;
using System.Windows.Forms;
using tresenraya.domain;

namespace tresenraya.ui
{
    public partial class FormTablero : Form
    {
        public FormTablero()
        {
            InitializeComponent();
            pictureBoxLineasDivisorias.Paint += PictureBox1Paint;
            AñadirBotones();
            this.pictureBoxLineasDivisorias.SendToBack();
        }

        private void AñadirBotones()
        {
            for (byte i = 0; i < 3; i++)
                for (byte j = 0; j < 3; j++)
                {
                    var posicion = new Posicion(i, j);
                    tablero.AddFicha(TurnoFicha, posicion);
                    ButtonFicha bf = CrearBoton(i, j, 139 + (150 * i), 78 + 127 * j, tablero.GetFicha(posicion));
                    buttonFicha[i, j] = bf;
                    this.Controls.Add(bf);
                }
        }

        private ButtonFicha CrearBoton(byte x, byte y, int posx, int posy, Fichas? ficha)
        {
            var boton = new ButtonFicha
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Papyrus", 48F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Size = new Size(90, 90),
                TabIndex = 2,
                UseVisualStyleBackColor = false,
                Name = "button" + x + y,
                Location = new Point(posx, posy),
            };
            boton.Click += ButtonFichaClick;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            boton.Posicion = new Posicion(x, y);
            boton.Text = GetStringFicha(ficha);

            return boton;
        }

        private static void PictureBox1Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            var g = e.Graphics;

            var pen = new Pen(Color.FromArgb(255, 255, 255, 255)) {Width = 5};
            g.DrawLine(pen, 140, 10, 140, 400);
            g.DrawLine(pen, 280, 10, 280, 400);
            g.DrawLine(pen, 10, 120, 400, 120);
            g.DrawLine(pen, 10, 253, 400, 253);
        }

        private void ButtonSalirClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFichaClick(object sender, EventArgs e)
        {
            var bf = (ButtonFicha)sender;
            var posicion = new Posicion((byte) bf.Posicion.Fila, (byte) bf.Posicion.Columna);
            tablero.AddFicha(TurnoFicha, posicion);
            refreshTablero();
        }

        //TODO: Cambiar esto...
        private static string GetStringFicha(Fichas? ficha)
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

        private void ButtonNuevaPartidaClick(object sender, EventArgs e)
        {
            tablero=new Tablero();
            refreshTablero();
        }
    }
}
