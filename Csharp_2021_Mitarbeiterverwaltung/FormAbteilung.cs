using System.Windows.Forms;
using System;

namespace Csharp_2021_Mitarbeiterverwaltung
{
	public partial class FormAbteilung : Form
	{
		// Eigenschaft der Sichtbarkeit "Public", um einen Datenaustausch
		// zwischen den Formularen zu ermöglichen
		public Abteilung AbteilungInBearbeitung;
		public FormAbteilung()
		{
			InitializeComponent();
		}

		private void btnSpeichern_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Benutzereingaben prüfen
				if (txtAbteilungsbezeichnung.Text == "")
					throw new ArgumentException("Bitte Bezeichnung vergeben.");

				// Eigenschaften der Abteilung festlegen
				// Abteilungsnummer ist der Primärschlüssel! Dieser Wert wird von 
				// der Datenbank selbst vergeben
				AbteilungInBearbeitung.Bezeichnung = txtAbteilungsbezeichnung.Text;

				DialogResult = DialogResult.OK;

				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAbbrechen_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormAbteilung_Load(object sender, EventArgs e)
		{
			txtAbteilungsnummer.Text = AbteilungInBearbeitung.AbteilungsNr.ToString();
			txtAbteilungsbezeichnung.Text = AbteilungInBearbeitung.Bezeichnung;
		}
	}
}
