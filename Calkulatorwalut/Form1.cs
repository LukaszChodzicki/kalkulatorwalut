using System;
using System.Windows.Forms;

namespace Calkulatorwalut
{ 
public partial class Form1 : Form
{
    // Kursy wymiany walut (twardo zakodowane)
    private const double PlnToUsd = 0.22;   // 1 PLN = 0.22 USD
    private const double UsdToEur = 0.93;   // 1 USD = 0.93 EUR
    private const double UsdToChf = 0.92;   // 1 USD = 0.92 CHF
    private const double UsdToGbp = 0.82;   // 1 USD = 0.82 GBP

    public Form1()
    {
        InitializeComponent();
    }

    // Wydarzenie kliknięcia przycisku "Przelicz"
    private void btnConvert_Click(object sender, EventArgs e)
    {
        double amountInPLN;

        // Sprawdzanie, czy użytkownik wprowadził poprawną kwotę w PLN
        if (!double.TryParse(txtAmountInPLN.Text, out amountInPLN) || amountInPLN <= 0)
        {
            MessageBox.Show("Proszę wprowadzić poprawną kwotę w PLN.");
            return;
        }

        // Przeliczanie na USD
        double amountInUSD = amountInPLN * PlnToUsd;
        lblResultUSD.Text = $"Wartość w USD: {amountInUSD:F2} USD";  // Wyświetlanie wartości w USD

        // Wybór waluty docelowej z ComboBox
        string selectedCurrency = cmbCurrency.SelectedItem.ToString();
        double convertedAmount = 0;

        // Przeliczenie USD na wybraną walutę
        switch (selectedCurrency)
        {
            case "EUR":
                convertedAmount = amountInUSD * UsdToEur;
                break;
            case "CHF":
                convertedAmount = amountInUSD * UsdToChf;
                break;
            case "GBP":
                convertedAmount = amountInUSD * UsdToGbp;
                break;
            default:
                MessageBox.Show("Proszę wybrać walutę docelową.");
                return;
        }

        // Wyświetlenie końcowego wyniku
        lblResult.Text = $"Wartość w EUR: {convertedAmount:F2} {selectedCurrency}";
    }

    // Inicjalizacja formularza (ustawienie domyślnych wartości)
    private void Form1_Load(object sender, EventArgs e)
    {
        // Dodawanie walut do ComboBox
        cmbCurrency.Items.Add("EUR");
        cmbCurrency.Items.Add("CHF");
        cmbCurrency.Items.Add("GBP");
        cmbCurrency.SelectedIndex = 0;  // Domyślnie wybiera EUR

        // Wyświetlanie kursów walut
        lblRates.Text = $"Kursy wymiany walut:\n" +
                        $"1 PLN = {PlnToUsd:F2} USD\n" +
                        $"1 PLN = 0,23 EUR\n" +
                        $"1 PLN = 0,22 CHF\n" +
                        $"1 PLN = 0,19 GBP";
    }

        private void lblRates_Click(object sender, EventArgs e)
        {

        }
    }

}




