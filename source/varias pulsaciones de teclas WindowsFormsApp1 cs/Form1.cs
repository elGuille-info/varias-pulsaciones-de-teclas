//-----------------------------------------------------------------------------
// Detectar varias pulsaciones de teclas (ejemplo de C#)            (01/Oct/20)
// Proyecto para .NET Framework 4.8
//
// Válido para simples pulsaciones al estilo Ctrl+B
// o de varias teclas seguidas: Ctrl+K, Ctrl+L
//
// Para ejemplo de artículo en http://www.elguillemola.com:
//
//
// (c) Guillermo (elGuille) Som, 2020
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varias_pulsaciones_de_teclas_WindowsFormsApp1_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Centrar el formulario
            this.CenterToScreen();

            // Detectar todas las pulsaciones en el formulario
            this.KeyPreview = true;

            // mostrar las teclas que se quieren detectar
            txtTeclasDetectar.Text = @"Simples:
Ctrl+B
Ctrl+Shift+V

Dobles:
Shift+Alt+L, Shift+Alt+S
Ctrl+K, Ctrl+C
Ctrl+K, Ctrl+U
Ctrl+K, Ctrl+L
Ctrl+K, Ctrl+K";
        }

        // Para doble pulsación de teclas
        private int CtrlK;
        private int CtrlC;
        private int CtrlU;
        private int CtrlL;
        private int ShiftAltL;
        private int ShiftAltS;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Comprobaciones para Ctrl+Shift

            // esta de forma simple
            if (e.Control && e.Shift)
            {
                if (e.KeyCode == Keys.V)
                {
                    e.Handled = true;

                    //MostrarRecortes();
                    txtPulsadas.Text = "Capturada: Ctrl+Shift+V\r\n" + txtPulsadas.Text;
                }
            }
            
            // Estas son con varias combinaciones

            // Comprobaciones para Shift+Alt
            else if (e.Shift && e.Alt)
            {
                // si se ha pulsado Shift+Alt+L
                if (e.KeyCode == Keys.L)
                {
                    e.Handled = true;

                    ShiftAltL += 1;
                }
                // si se ha pulsado Shift+Alt+S
                else if (e.KeyCode == Keys.S)
                {
                    e.Handled = true;

                    ShiftAltS += 1;
                }
                // Si se ha pulsado Shitf+Alt+S, Shift+Alt+L
                // (en cualquier orden)
                if (ShiftAltL == 1 && ShiftAltS == 1)
                {
                    e.Handled = true;

                    //ClasificarSeleccion();
                    txtPulsadas.Text = "Capturada: Shift+Alt+L, Shift+Alt+S\r\n" + txtPulsadas.Text;
                }
            }

            // Comprobaciones para solo la tecla Ctrl (sin Shift ni Alt)
            else if (e.Control && !e.Shift && !e.Alt)
            {
                // Solo se ha pulsado la tecla Ctrl
                // comprobar el resto de combinaciones

                // Forma simple si se ha pulsado Ctrl+B
                if (e.KeyCode == Keys.B)
                {
                    e.Handled = true;

                    // Esta solo es para detectar
                    // la combinación 'simple' de Ctrl+B
                    // No es necesario llevar la cuenta de las pulsaciones
                    txtPulsadas.Text = "Capturada: Ctrl+B\r\n" + txtPulsadas.Text;
                }

                else if (e.KeyCode == Keys.K)
                {
                    e.Handled = true;

                    CtrlK += 1;
                    txtPulsadas.Text = "Ctrl+K - " + txtPulsadas.Text;
                }
                else if (e.KeyCode == Keys.C)
                {
                    e.Handled = true;

                    CtrlC += 1;
                    txtPulsadas.Text = "Ctrl+C - " + txtPulsadas.Text;
                }
                else if (e.KeyCode == Keys.U)
                {
                    e.Handled = true;

                    CtrlU += 1;
                    txtPulsadas.Text = "Ctrl+U - " + txtPulsadas.Text;
                }
                else if (e.KeyCode == Keys.L)
                {
                    e.Handled = true;

                    CtrlL += 1;
                    txtPulsadas.Text = "Ctrl+L - " + txtPulsadas.Text;
                }

                // Si se ha pulsado Ctrl+K, CtrlC
                if (CtrlK == 1 && CtrlC == 1)
                {
                    e.Handled = true;

                    // Ctrl+K, Ctrl+C
                    CtrlK = 0;
                    CtrlC = 0;
                    //PonerComentarios(richTextBoxCodigo);
                    txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+C\r\n" + txtPulsadas.Text;
                }

                // Si se ha pulsado Ctrl+K, Ctrl+U
                else if (CtrlK == 1 && CtrlU == 1)
                {
                    e.Handled = true;

                    // Ctrl+K, Ctrl+U
                    CtrlK = 0;
                    CtrlU = 0;
                    //QuitarComentarios(richTextBoxCodigo);
                    txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+U\r\n" + txtPulsadas.Text;
                }

                // Si se ha pulsado Ctrl+K, Ctrl+L
                else if (CtrlK == 1 && CtrlL == 1)
                {
                    e.Handled = true;

                    // Ctrl+K, Ctrl+L
                    CtrlK = 0;
                    CtrlL = 0;
                    // preguntar
                    //buttonEditorMarcadorQuitarTodos.PerformClick();
                    txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+L\r\n" + txtPulsadas.Text;
                }

                // Si se ha pulsado Ctrl+K, Ctrl+K
                else if (CtrlK == 2)
                {
                    e.Handled = true;

                    // Ctrl+K, Ctrl+K
                    CtrlK = 0;
                    //MarcadorPonerQuitar();

                    txtPulsadas.Text = "Capturada: Ctrl+K, Ctrl+K\r\n" + txtPulsadas.Text;
                }
            }
            else
            {
                txtPulsadas.Text = $"\r\nNo es una de las teclas comprobadas: {e.KeyCode} +\r\n"+
                                   $"    Ctrl: {e.Control}, Shift: {e.Shift}, Alt: {e.Alt}\r\n" + txtPulsadas.Text;

                CtrlK = 0;
                CtrlC = 0;
                CtrlU = 0;
                ShiftAltL = 0;
                ShiftAltS = 0;

                // Otras pulsaciones
                // No están detectadas explícitamente
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPulsadas.Clear();

        }

    } // end class
} // end namespace
