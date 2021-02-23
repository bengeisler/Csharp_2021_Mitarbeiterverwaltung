using System;
using System.Linq;
using System.Windows.Forms;

namespace Csharp_2021_Mitarbeiterverwaltung
{
	public partial class Form1 : Form
	{
		// Context-Objekt zum Zugriff auf die Datenbank anlegen
		MitarbeiterverwaltungContext ctx = new MitarbeiterverwaltungContext();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Tabelle "Mitarbeiter" mit Daten aus der Datenbank befüllen
			mitarbeiterBindingSource.DataSource = ctx.Mitarbeiters.ToList();

			// Tabelle "Abteilungen" mit Daten aus der Datenbank befüllen
			abteilungBindingSource.DataSource = ctx.Abteilungs.ToList();
		}

		private void btnFiltern_Click(object sender, System.EventArgs e)
		{
			// Filter bedeutet: DataSource der BindingSource der Tabelle(DataGridView) aktualisieren

			// mitarbeiterBindingSource.DataSource : Datenquelle für die Tabelle "Mitarbeiter"
			// => Diese Datenquelle wird über den Filter aktualisiert
			// ctx.Mitarbeiters => Alle Mitarbeiter in der Tabelle "Mitarbeiter" der Datenbank
			mitarbeiterBindingSource.DataSource = ctx.Mitarbeiters
				.Where(m => m.Name.Contains(txtNachname.Text))
				.Where(m => m.Vorname.Contains(txtVorname.Text))
				.ToList();
		}

		private void btnAlleAnzeigen_Click(object sender, System.EventArgs e)
		{
			mitarbeiterBindingSource.DataSource = ctx.Mitarbeiters.ToList();
		}

		private void btnNachNachnameSortieren_Click(object sender, System.EventArgs e)
		{
			// Sortieren: Datenquelle der BindingSource aktualisieren

			mitarbeiterBindingSource.DataSource = ctx.Mitarbeiters
				.OrderBy(m => m.Name)
				.ToList();
		}

		private void btnNachVornameSortieren_Click(object sender, System.EventArgs e)
		{
			mitarbeiterBindingSource.DataSource = ctx.Mitarbeiters
				.OrderBy(m => m.Vorname)
				.ToList();
		}

		private void btnMitarbeiterInAbteilungÜbernehmen_Click(object sender, System.EventArgs e)
		{
			// Datenbankzugriff immer in try-catch-Block!
			try
			{
				// Ausgewählten Mitarbeiter aus der Tabelle auslesen & casten
				var ausgewählterMitarbeiter = mitarbeiterBindingSource.Current as Mitarbeiter;
				if (ausgewählterMitarbeiter == null) return;

				// Alternative: Ausgewählte Abteilung auslesen
				//var ausgewählteAbteilung = abteilungBindingSource.Current as Abteilung;
				//ausgewählterMitarbeiter.AbteilungsNr = ausgewählteAbteilung.AbteilungsNr;

				// Abteilungsnummer der ausgewählten Abteilung übernehmen
				// => Diese steht in der txtAbteilungsnummer, da diese über eine Datenbindung
				// an die Abteilungsnummer der Datenquelle "Abteilung" gebunden ist
				ausgewählterMitarbeiter.AbteilungsNr = Convert.ToInt32(txtAbteilungsnummer.Text);

				// Änderungen in der Datenbank speichern
				ctx.SaveChanges();

				// Anzeige aktualisieren
				mitarbeiterBindingSource.DataSource = ctx.Mitarbeiters.ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAbteilungHinzufügen_Click(object sender, EventArgs e)
		{
			// Objekt für Formular "Abteilung hinzufügen" erstellen
			var formAbteilung = new FormAbteilung();

			// Neues Objekt "Abteilung" erstellen und an die Eigenschaft in dem
			// zweiten Formular übergeben. Über diese Eigenschaft findet der
			// Datenaustausch zwischen den Formularen statt.
			formAbteilung.AbteilungInBearbeitung = new Abteilung();

			// Formular anzeigen
			formAbteilung.ShowDialog();

			// DialogResult auswerten und Eintrag der Datenbank hinzufügen
			if (formAbteilung.DialogResult == DialogResult.OK)
			{
				// Datenbankzugriff => try-catch ist Pflicht!
				try
				{
					// Eintrag hinzufügen
					ctx.Abteilungs.Add(formAbteilung.AbteilungInBearbeitung);

					// Datenbank speichern
					ctx.SaveChanges();

					// Anzeige aktualisieren
					abteilungBindingSource.DataSource = ctx.Abteilungs.ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnAbteilungBearbeiten_Click(object sender, EventArgs e)
		{
			// Objekt für Formular "Abteilung hinzufügen" erstellen
			var formAbteilung = new FormAbteilung();

			// Eigenschaft "Abteilung in Bearbeitung" zuweisen
			formAbteilung.AbteilungInBearbeitung =
				(abteilungBindingSource.Current as Abteilung);

			// Formular anzeigen
			formAbteilung.ShowDialog();

			// DialogResult auswerten und Eintrag der Datenbank hinzufügen
			if (formAbteilung.DialogResult == DialogResult.OK)
			{
				// Datenbankzugriff => try-catch ist Pflicht!
				try
				{
					// Datenbank speichern
					ctx.SaveChanges();

					// Anzeige aktualisieren
					abteilungBindingSource.DataSource = ctx.Abteilungs.ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnAbteilungLöschen_Click(object sender, EventArgs e)
		{
			try
			{
				// Aktuelle Abteilung auslesen & casten
				var ausgewählteAbteilung = abteilungBindingSource.Current as Abteilung;
				if (ausgewählteAbteilung == null) return;

				// Prüfen, ob sich noch Mitarbeiter in der Abteilung befinden
				if (ausgewählteAbteilung.Mitarbeiters.Count > 0)
					throw new ArgumentException("Abteilung enthält noch Mitarbeiter und kann " +
						"daher nicht gelöscht werden.");

				// Abteilung löschen
				ctx.Abteilungs.Remove(ausgewählteAbteilung);

				// Speichern
				ctx.SaveChanges();

				// Anzeige aktualisieren
				abteilungBindingSource.DataSource = ctx.Abteilungs.ToList();	
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			var formMitarbeiter = new FormMitarbeiter();

			formMitarbeiter.MitarbeiterInBearbeitung = new Mitarbeiter();

			formMitarbeiter.ShowDialog();

			if (formMitarbeiter.DialogResult == DialogResult.OK) 
			{
				try
				{
					// Eintrag der Datenbank hinzufügen
					ctx.Mitarbeiters.Add(formMitarbeiter.MitarbeiterInBearbeitung);

					// Speichern
					ctx.SaveChanges();

					// Anzeige aktualisieren
					mitarbeiterBindingSource.DataSource = ctx.Mitarbeiters.ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
