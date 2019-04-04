using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFConversoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            Convert();

        }

        private void Convert()
        {
            try
            {
                lblErro.Text = string.Empty;

                if (rbDeDecimal.Checked && rbParaBinario.Checked) //DECIMAL PARA BINÁRIO
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                        txtSaida.Text = Converter.ParaBase2(int.Parse(txtEntrada.Text));
                    else
                    { Climb(); return; }
                } // DECIMAL PARA BINÁRIO

                else if (rbDeBinario.Checked && rbParaDecimal.Checked) //BINÁRIO PARA DECIMAL
                {
                    if (Converter.IsBinary(txtEntrada.Text))
                        txtSaida.Text = Converter.ParaBase10(txtEntrada.Text);
                    else
                    { Climb(); return; }
                } // BINÁRIO PARA DECIMAL

                else if (rbDeDecimal.Checked && rbParaOctal.Checked) //DECIMAL PARA OCTAL
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                        txtSaida.Text = Converter.ParaBase8(Result);
                    else
                    { Climb(); return; }
                } // DECIMAL PARA OCTAL

                else if (rbDeDecimal.Checked && rbParaHexadecimal.Checked) //DECIMAL PARA HEXADECIMAL
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                        txtSaida.Text = Converter.ParaBase16(int.Parse(txtEntrada.Text));
                    else
                    { Climb(); return; }
                } // DECIMAL PARA HEXADECIMAL

                else if (rbDeDecimal.Checked && rbParaBase5.Checked) //DECIMAL PARA BASE 5
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                        txtSaida.Text = Converter.ParaBase5(int.Parse(txtEntrada.Text));
                    else
                    { Climb(); return; }
                } // DECIMAL PARA BASE 5

                else if (rbDeBinario.Checked && rbParaOctal.Checked) //BINARIO PARA OCTAL
                {
                    if (Converter.IsBinary(txtEntrada.Text))
                        txtSaida.Text = Converter.ParaBase8(int.Parse(Converter.ParaBase10(txtEntrada.Text)));
                    else
                    { Climb(); return; }
                } // BINÁRIO PARA OCTAL

                else if (rbDeBinario.Checked && rbParaBase5.Checked) //BINARIO PARA BASE 5
                {
                    if (Converter.IsBinary(txtEntrada.Text))
                        txtSaida.Text = Converter.ParaBase5(int.Parse(Converter.ParaBase10(txtEntrada.Text)));
                    else
                    { Climb(); return; }
                } // BINÁRIO PARA BASE 5

                else if (rbDeBinario.Checked && rbParaHexadecimal.Checked) //BINARIO PARA HEXADECIMAL
                {
                    if (Converter.IsBinary(txtEntrada.Text))
                        txtSaida.Text = Converter.ParaBase16(int.Parse(Converter.ParaBase10(txtEntrada.Text)));
                    else
                    { Climb(); return; }
                } // BINÁRIO PARA HEXADECIMAL

                else if (rbDeOctal.Checked && rbParaDecimal.Checked) //OCTAL PARA DECIMAL
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.OctalParaBase10(Result.ToString());
                    }
                    else
                    { Climb(); return; }
                } // OCTAL PARA DECIMAL

                else if (rbDeBase5.Checked && rbParaDecimal.Checked) //BASE 5 PARA DECIMAL
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9") || Result.ToString().Contains("5") || Result.ToString().Contains("6") || Result.ToString().Contains("7"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.Base5ParaBase10(Result.ToString());
                    }
                    else { Climb(); return; }

                } // BASE 5 PARA DECIMAL

                else if (rbDeHexadecimal.Checked && rbParaDecimal.Checked) //HEXADECIMAL PARA DECIMAL
                {
                    txtSaida.Text = Converter.Base16ParaBase10(txtEntrada.Text);
                } // HEXADECIMAL PARA DECIMAL

                else if (rbDeOctal.Checked && rbParaBase5.Checked)
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.ParaBase5(int.Parse(Converter.OctalParaBase10(Result.ToString())));
                    }
                    else
                    { Climb(); return; }
                } // OCTAL PARA BASE 5

                else if (rbDeOctal.Checked && rbParaBinario.Checked)
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.ParaBase2(int.Parse(Converter.OctalParaBase10(Result.ToString())));
                    }
                    else
                    { Climb(); return; }
                } // OCTAL PARA BINÁRIO

                else if (rbDeOctal.Checked && rbParaHexadecimal.Checked)
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.ParaBase16(int.Parse(Converter.OctalParaBase10(Result.ToString())));
                    }
                    else
                    { Climb(); return; }
                } // OCTAL PARA HEXADECIMAL

                else if (rbDeBase5.Checked && rbParaOctal.Checked) // BASE 5 PARA OCTAL
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9") || Result.ToString().Contains("5") || Result.ToString().Contains("6") || Result.ToString().Contains("7"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.ParaBase8(int.Parse(Converter.Base5ParaBase10(Result.ToString())));
                    }
                    else { Climb(); return; }
                } // BASE 5 PARA OCTAL

                else if (rbDeBase5.Checked && rbParaHexadecimal.Checked)
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9") || Result.ToString().Contains("5") || Result.ToString().Contains("6") || Result.ToString().Contains("7"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.ParaBase16(int.Parse(Converter.Base5ParaBase10(txtEntrada.Text)));
                    }
                    else { Climb(); return; }
                } // BASE 5 PARA HEXADECIMAL

                else if (rbDeHexadecimal.Checked && rbParaBinario.Checked)
                {
                    txtSaida.Text = Converter.ParaBase2(int.Parse(Converter.Base16ParaBase10(txtEntrada.Text)));
                } // HEXADECIMAL PARA BINÁRIO

                else if (rbDeHexadecimal.Checked && rbParaOctal.Checked)
                {
                    txtSaida.Text = Converter.ParaBase8(int.Parse(Converter.Base16ParaBase10(txtEntrada.Text)));
                } // HEXADECIMAL PARA OCTAL

                else if (rbDeHexadecimal.Checked && rbParaBase5.Checked)
                {
                    txtSaida.Text = Converter.ParaBase5(int.Parse(Converter.Base16ParaBase10(txtEntrada.Text)));
                } // HEXADECIMAL PARA BASE 5

                else if (rbDeBase5.Checked && rbParaBinario.Checked)
                {
                    if (int.TryParse(txtEntrada.Text, out int Result))
                    {
                        if (Result.ToString().Contains("8") || Result.ToString().Contains("9") || Result.ToString().Contains("5") || Result.ToString().Contains("6") || Result.ToString().Contains("7"))
                        { Climb(); return; }
                        txtSaida.Text = Converter.ParaBase2(int.Parse(Converter.Base5ParaBase10(Result.ToString())));
                    }
                    else { Climb(); return; }
                } // BASE 5 PARA BINÁRIO
                
                else txtSaida.Text = txtEntrada.Text;
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
                Climb();
            }
        }

        void Climb()
        {
            txtEntrada.Text = string.Empty;
            txtSaida.Text = string.Empty;
        }

        private void rbDeBinario_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbDeDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbDeOctal_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbDeBase5_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbDeHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbParaBinario_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbParaDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbParaOctal_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbParaBase5_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbParaHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}