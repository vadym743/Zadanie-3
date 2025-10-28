using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double pojemnosc = double.Parse(textBoxPojemnosc.Text);
                double procent = double.Parse(textBoxProcent.Text);
                int liczba = int.Parse(textBoxLiczba.Text);

                SolutionCalculator calc = new SolutionCalculator(pojemnosc, procent, liczba);

                double laczna = calc.ObliczLacznaObjetosc();
                double czysta = calc.ObliczCzystaSubstancje();

                textBoxWynik.Text = $"Łączna objętość płynu: {laczna} ml\n" +
                                    $"Objętość czystej substancji: {czysta:F2} ml";
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne dane liczbowe!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
