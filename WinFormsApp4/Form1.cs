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
                double percent = double.Parse(textBoxPercent.Text);
                int ilosc = int.Parse(textBoxIlosc.Text);

                // ✅ Проверка процента (новая логика)
                if (percent < 0 || percent > 100)
                {
                    MessageBox.Show("Błąd: procentowa zawartość musi być w zakresie 0–100%.",
                                    "Niepoprawna wartość",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                SolutionCalculator calc = new SolutionCalculator(pojemnosc, percent, ilosc);
                double laczna = calc.ObliczLacznaObjetosc();
                double czysta = calc.ObliczObjetoscSubstancji();

                labelWynikLaczna.Text = $"{laczna} ml";
                labelWynikCzysta.Text = $"{czysta} ml";
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane! Upewnij się, że pola są wypełnione liczbami.",
                                "Błąd",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
}
