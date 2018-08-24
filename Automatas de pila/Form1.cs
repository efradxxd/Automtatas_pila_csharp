using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas_de_pila
{
    public partial class Form1 : Form
    {
        Stack<char> pila = new Stack<char>();
        Stack<char> letras = new Stack<char>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbL1.Checked = false;
            lblP1.Text = "";
            lblP2.Text = "";
            lblP3.Text = "";
            lblP4.Text = "";
            lblP5.Text = "";
            lblP6.Text = "";
        }

        private void rbL1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbL1.Checked)
            {
                pbL1.Visible = true;
                pbL2.Visible = false;
                pbL3.Visible = false;
                lblP1.Text = "";
                lblP2.Text = "";
                lblP3.Text = "";
                lblP4.Text = "";
                lblP5.Text = "";
                lblP6.Text = "";
            }
            else if (rbL2.Checked)
            {
                pbL2.Visible = !false;
                pbL1.Visible = !true;
                pbL3.Visible = false;
                lblP1.Text = "";
                lblP2.Text = "";
                lblP3.Text = "";
                lblP4.Text = "";
                lblP5.Text = "";
                lblP6.Text = "";
            }
            else if (rbL3.Checked)
            {
                pbL3.Visible = !false;
                pbL2.Visible = false;
                pbL1.Visible = !true;
                lblP1.Text = "";
                lblP2.Text = "";
                lblP3.Text = "";
                lblP4.Text = "";
                lblP5.Text = "";
                lblP6.Text = "";
            }

        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            if (rbL1.Checked)
            {
                //lblP1.Text = txtP1.Text != "" ? Automata1(txtP1.Text).ToString() : "✘";
                //lblP2.Text = txtP2.Text != "" ? Automata1(txtP2.Text).ToString() : "✘";
                //lblP3.Text = txtP3.Text != "" ? Automata1(txtP3.Text).ToString() : "✘";
                //lblP4.Text = txtP4.Text != "" ? Automata1(txtP4.Text).ToString() : "✘";
                //lblP5.Text = txtP5.Text != "" ? Automata1(txtP5.Text).ToString() : "✘";
                //lblP6.Text = txtP6.Text != "" ? Automata1(txtP6.Text).ToString() : "✘";

                lblP1.Text = txtP1.Text = Automata1(txtP1.Text).ToString();
                lblP2.Text = txtP2.Text != "" ? Automata1(txtP2.Text).ToString() : "✘";
                lblP3.Text = txtP3.Text != "" ? Automata1(txtP3.Text).ToString() : "✘";
                lblP4.Text = txtP4.Text != "" ? Automata1(txtP4.Text).ToString() : "✘";
                lblP5.Text = txtP5.Text != "" ? Automata1(txtP5.Text).ToString() : "✘";
                lblP6.Text = txtP6.Text != "" ? Automata1(txtP6.Text).ToString() : "✘";
            }
            else if (rbL2.Checked)
            {
                lblP1.Text = Automata2(txtP1.Text).ToString();
                lblP2.Text = Automata2(txtP2.Text).ToString();
                lblP3.Text = Automata2(txtP3.Text).ToString();
                lblP4.Text = Automata2(txtP4.Text).ToString();
                lblP5.Text = Automata2(txtP5.Text).ToString();
                lblP6.Text = Automata2(txtP6.Text).ToString();
            }
            else if (rbL3.Checked)
            {
                lblP1.Text = txtP1.Text != "" ? Automata3(txtP1.Text).ToString() : "✘";
                lblP2.Text = txtP2.Text != "" ? Automata3(txtP2.Text).ToString() : "✘";
                lblP3.Text = txtP3.Text != "" ? Automata3(txtP3.Text).ToString() : "✘";
                lblP4.Text = txtP4.Text != "" ? Automata3(txtP4.Text).ToString() : "✘";
                lblP5.Text = txtP5.Text != "" ? Automata3(txtP5.Text).ToString() : "✘";
                lblP6.Text = txtP6.Text != "" ? Automata3(txtP6.Text).ToString() : "✘";
            }
        }

        private char Automata1(string palabra)
        {
            char resultado = '\0';
            for (int i = palabra.Length - 1; i >= 0; i--)
                letras.Push(palabra[i]);
                
            pila.Push('Z');
            
            while (pila.Count>0 && resultado!= '✘')
            {
                try
                {
                    if (letras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                    {
                        letras.Pop();
                        pila.Pop();
                        pila.Push('A');
                    }
                    else if (letras.Peek().Equals('a') && pila.Peek().Equals('A'))
                    {
                        letras.Pop();
                        pila.Pop();
                        pila.Push('A');
                        pila.Push('A');
                    }
                    else if (letras.Peek().Equals('b') && pila.Peek().Equals('A'))
                    {
                        letras.Pop();
                        pila.Pop();
                    }
                    else
                    {
                        resultado = '✘';
                    }
                }catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    resultado = '✘';
                }
            }

            if (pila.Count == 0 && letras.Count == 0)
            {
                resultado = '✔';
            }
            else
            {
                resultado = '✘';
            }
                
            pila.Clear();
            letras.Clear();

            return resultado;
        }

        private char Automata2(string palabra)
        {
            char resultado = '\0';
            if (palabra.Length>0)
            {
                for (int i = palabra.Length - 1; i >= 0; i--)
                    letras.Push(palabra[i]);
            }
            else
            {
                letras.Push('\0');
            }
            

            pila.Push('Z');

            while (pila.Count > 0 && resultado != '✘')
            {
                try
                {
                    if (letras.Peek().Equals('\0') && pila.Peek().Equals('Z'))
                    {
                        letras.Pop();
                        pila.Pop();
                    }
                    else if (letras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                    {
                        letras.Pop();
                        pila.Pop();
                        pila.Push('A');
                    }
                    else if (letras.Peek().Equals('a') && pila.Peek().Equals('A'))
                    {
                        letras.Pop();
                        pila.Pop();
                        pila.Push('A');
                        pila.Push('A');
                    }
                    else if (letras.Peek().Equals('b') && pila.Peek().Equals('A'))
                    {
                        letras.Pop();
                        pila.Pop();
                    }
                    else
                    {
                        resultado = '✘';
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    resultado = '✘';
                }
            }

            if (pila.Count == 0 && letras.Count == 0)
            {
                resultado = '✔';
            }
            else
            {
                resultado = '✘';
            }

            pila.Clear();
            letras.Clear();

            return resultado;
        }

        private char Automata3(string palabra)
        {
            char resultado = '\0';
            for (int i = palabra.Length - 1; i >= 0; i--)
                letras.Push(palabra[i]);

            pila.Push('Z');

            while (pila.Count > 0 && resultado != '✘')
            {
                try
                {
                    if (letras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                    {
                        letras.Pop();
                        pila.Pop();
                        pila.Push('A');
                        pila.Push('A');
                    }
                    else if (letras.Peek().Equals('a') && pila.Peek().Equals('A'))
                    {
                        letras.Pop();
                        pila.Pop();
                        pila.Push('A');
                        pila.Push('A');
                        pila.Push('A');
                    }
                    else if (letras.Peek().Equals('b') && pila.Peek().Equals('A'))
                    {
                        letras.Pop();
                        pila.Pop();
                    }
                    else
                    {
                        resultado = '✘';
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    resultado = '✘';
                }
            }

            if (pila.Count == 0 && letras.Count == 0)
            {
                resultado = '✔';
            }
            else
            {
                resultado = '✘';
            }

            pila.Clear();
            letras.Clear();

            return resultado;
        }
    }
}
