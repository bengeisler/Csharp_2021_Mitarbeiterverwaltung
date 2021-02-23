
namespace Csharp_2021_Mitarbeiterverwaltung
{
	partial class FormMitarbeiter
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmBoxAbteilung = new System.Windows.Forms.ComboBox();
			this.btnAbbrechen = new System.Windows.Forms.Button();
			this.btnSpeichern = new System.Windows.Forms.Button();
			this.txtTelefonnummer = new System.Windows.Forms.TextBox();
			this.txtOrt = new System.Windows.Forms.TextBox();
			this.txtPlz = new System.Windows.Forms.TextBox();
			this.txtAdresse = new System.Windows.Forms.TextBox();
			this.txtStellenbezeichnung = new System.Windows.Forms.TextBox();
			this.txtVorname = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPersonalnummer = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmBoxAbteilung
			// 
			this.cmBoxAbteilung.FormattingEnabled = true;
			this.cmBoxAbteilung.Location = new System.Drawing.Point(131, 35);
			this.cmBoxAbteilung.Name = "cmBoxAbteilung";
			this.cmBoxAbteilung.Size = new System.Drawing.Size(187, 21);
			this.cmBoxAbteilung.TabIndex = 41;
			// 
			// btnAbbrechen
			// 
			this.btnAbbrechen.Location = new System.Drawing.Point(243, 244);
			this.btnAbbrechen.Name = "btnAbbrechen";
			this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
			this.btnAbbrechen.TabIndex = 40;
			this.btnAbbrechen.Text = "Abbrechen";
			this.btnAbbrechen.UseVisualStyleBackColor = true;
			// 
			// btnSpeichern
			// 
			this.btnSpeichern.Location = new System.Drawing.Point(15, 244);
			this.btnSpeichern.Name = "btnSpeichern";
			this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
			this.btnSpeichern.TabIndex = 39;
			this.btnSpeichern.Text = "Speichern";
			this.btnSpeichern.UseVisualStyleBackColor = true;
			this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
			// 
			// txtTelefonnummer
			// 
			this.txtTelefonnummer.Location = new System.Drawing.Point(131, 210);
			this.txtTelefonnummer.Name = "txtTelefonnummer";
			this.txtTelefonnummer.Size = new System.Drawing.Size(187, 20);
			this.txtTelefonnummer.TabIndex = 38;
			// 
			// txtOrt
			// 
			this.txtOrt.Location = new System.Drawing.Point(131, 185);
			this.txtOrt.Name = "txtOrt";
			this.txtOrt.Size = new System.Drawing.Size(187, 20);
			this.txtOrt.TabIndex = 37;
			// 
			// txtPlz
			// 
			this.txtPlz.Location = new System.Drawing.Point(131, 160);
			this.txtPlz.Name = "txtPlz";
			this.txtPlz.Size = new System.Drawing.Size(187, 20);
			this.txtPlz.TabIndex = 36;
			// 
			// txtAdresse
			// 
			this.txtAdresse.Location = new System.Drawing.Point(131, 135);
			this.txtAdresse.Name = "txtAdresse";
			this.txtAdresse.Size = new System.Drawing.Size(187, 20);
			this.txtAdresse.TabIndex = 35;
			// 
			// txtStellenbezeichnung
			// 
			this.txtStellenbezeichnung.Location = new System.Drawing.Point(131, 110);
			this.txtStellenbezeichnung.Name = "txtStellenbezeichnung";
			this.txtStellenbezeichnung.Size = new System.Drawing.Size(187, 20);
			this.txtStellenbezeichnung.TabIndex = 34;
			// 
			// txtVorname
			// 
			this.txtVorname.Location = new System.Drawing.Point(131, 85);
			this.txtVorname.Name = "txtVorname";
			this.txtVorname.Size = new System.Drawing.Size(187, 20);
			this.txtVorname.TabIndex = 33;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(131, 60);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(187, 20);
			this.txtName.TabIndex = 32;
			// 
			// txtPersonalnummer
			// 
			this.txtPersonalnummer.Enabled = false;
			this.txtPersonalnummer.Location = new System.Drawing.Point(131, 10);
			this.txtPersonalnummer.Name = "txtPersonalnummer";
			this.txtPersonalnummer.Size = new System.Drawing.Size(187, 20);
			this.txtPersonalnummer.TabIndex = 31;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 213);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Telefonnummer:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 163);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 29;
			this.label8.Text = "PLZ:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 188);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "Ort:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Stellenbezeichnung:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Adresse:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Vorname:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Abteilung:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Personalnummer:";
			// 
			// FormMitarbeiter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 282);
			this.Controls.Add(this.cmBoxAbteilung);
			this.Controls.Add(this.btnAbbrechen);
			this.Controls.Add(this.btnSpeichern);
			this.Controls.Add(this.txtTelefonnummer);
			this.Controls.Add(this.txtOrt);
			this.Controls.Add(this.txtPlz);
			this.Controls.Add(this.txtAdresse);
			this.Controls.Add(this.txtStellenbezeichnung);
			this.Controls.Add(this.txtVorname);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtPersonalnummer);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormMitarbeiter";
			this.Text = "Mitarbeiter hinzufügen / bearbeiten";
			this.Load += new System.EventHandler(this.FormMitarbeiter_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmBoxAbteilung;
		private System.Windows.Forms.Button btnAbbrechen;
		private System.Windows.Forms.Button btnSpeichern;
		private System.Windows.Forms.TextBox txtTelefonnummer;
		private System.Windows.Forms.TextBox txtOrt;
		private System.Windows.Forms.TextBox txtPlz;
		private System.Windows.Forms.TextBox txtAdresse;
		private System.Windows.Forms.TextBox txtStellenbezeichnung;
		private System.Windows.Forms.TextBox txtVorname;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPersonalnummer;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}