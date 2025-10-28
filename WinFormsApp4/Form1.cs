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

                textBoxWynik.Text = $"??czna obj?to?? p?ynu: {laczna} ml\n" +
                                    $"Obj?to?? czystej substancji: {czysta:F2} ml";
            }
            catch
            {
                MessageBox.Show("Wprowad? poprawne dane liczbowe!", "B??d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
