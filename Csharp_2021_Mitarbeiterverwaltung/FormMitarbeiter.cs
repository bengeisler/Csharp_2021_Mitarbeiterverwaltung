using System.Linq;
using System.Windows.Forms;
using System;

namespace Csharp_2021_Mitarbeiterverwaltung
{
	public partial class FormMitarbeiter : Form
	{
		// Eigenschaft zum Datenaustausch
		public Mitarbeiter MitarbeiterInBearbeitung;

		// Context zum Zugriff auf die Datenbank
		MitarbeiterverwaltungContext ctx = new MitarbeiterverwaltungContext();
		// Binding Source zur Datenbindung der ComboBox an die Tabelle "Abteilung"
		// der Datenbank
		BindingSource bs = new BindingSource();
		public FormMitarbeiter()
		{
			InitializeComponent();
		}

		private void FormMitarbeiter_Load(object sender, System.EventArgs e)
		{
			// BindingSource an Datenbank binden
			bs.DataSource = ctx.Abteilungs.ToList();

			// Datenbindung der ComboBox einstellen
			cmBoxAbteilung.DataSource = bs.DataSource;
			cmBoxAbteilung.DisplayMember = "Bezeichnung";
			cmBoxAbteilung.ValueMember = "AbteilungsNr";

			// Eigenschaften des MitarbeitersInBearbeitung auslesen und 
			// Steuerelemente damit befüllen
			txtAdresse.Text = MitarbeiterInBearbeitung.Adresse;
			txtName.Text = MitarbeiterInBearbeitung.Name;
			txtOrt.Text = MitarbeiterInBearbeitung.Ort;
			txtPersonalnummer.Text = MitarbeiterInBearbeitung.PersonalNr.ToString();
			txtPlz.Text = MitarbeiterInBearbeitung.PLZ;
			txtStellenbezeichnung.Text = MitarbeiterInBearbeitung.Stellenbezeichnung;
			txtTelefonnummer.Text = MitarbeiterInBearbeitung.Telefon;
			txtVorname.Text = MitarbeiterInBearbeitung.Vorname;
			cmBoxAbteilung.SelectedValue = MitarbeiterInBearbeitung.AbteilungsNr;
		}

		private void btnSpeichern_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Benutzereingaben prüfen
				if (txtAdresse.Text == "")
					throw new ArgumentException("Die Adresse darf nicht leer sein.");
				if (txtName.Text == "")
					throw new ArgumentException("Der Name darf nicht leer sein.");
				if (txtOrt.Text == "")
					throw new ArgumentException("Der Ort darf nicht leer sein.");
				if (txtPlz.Text == "")
					throw new ArgumentException("Die PLZ darf nicht leer sein.");
				if (!int.TryParse(txtPlz.Text, out int plz))
					throw new ArgumentException("Die PLZ muss eine gültige Zahl sein.");
				if (txtPlz.Text.Length != 5)
					throw new ArgumentException("Die PLZ muss fünfstellig sein.");
				if (txtStellenbezeichnung.Text == "")
					throw new ArgumentException("Die Stellenbezeichnung darf nicht leer sein.");
				if (txtTelefonnummer.Text == "")
					throw new ArgumentException("Die Telefonnummer darf nicht leer sein.");
				if (txtVorname.Text == "")
					throw new ArgumentException("Der Vorname darf nicht leer sein.");

				// Eigenschaften des Mitarbeiters in Bearbeitung zuweisen
				MitarbeiterInBearbeitung.Name = txtName.Text;
				MitarbeiterInBearbeitung.Vorname = txtVorname.Text;
				MitarbeiterInBearbeitung.Stellenbezeichnung = txtStellenbezeichnung.Text;
				MitarbeiterInBearbeitung.Ort = txtOrt.Text;
				MitarbeiterInBearbeitung.PLZ = txtPlz.Text;
				MitarbeiterInBearbeitung.Adresse = txtAdresse.Text;
				MitarbeiterInBearbeitung.Telefon = txtTelefonnummer.Text;
				MitarbeiterInBearbeitung.AbteilungsNr =
					(int)cmBoxAbteilung.SelectedValue;

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
	}
}
