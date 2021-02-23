
namespace Csharp_2021_Mitarbeiterverwaltung
{
	partial class FormAbteilung
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
			this.btnAbbrechen = new System.Windows.Forms.Button();
			this.btnSpeichern = new System.Windows.Forms.Button();
			this.txtAbteilungsbezeichnung = new System.Windows.Forms.TextBox();
			this.txtAbteilungsnummer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAbbrechen
			// 
			this.btnAbbrechen.Location = new System.Drawing.Point(352, 80);
			this.btnAbbrechen.Name = "btnAbbrechen";
			this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
			this.btnAbbrechen.TabIndex = 11;
			this.btnAbbrechen.Text = "Abbrechen";
			this.btnAbbrechen.UseVisualStyleBackColor = true;
			this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
			// 
			// btnSpeichern
			// 
			this.btnSpeichern.Location = new System.Drawing.Point(143, 80);
			this.btnSpeichern.Name = "btnSpeichern";
			this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
			this.btnSpeichern.TabIndex = 10;
			this.btnSpeichern.Text = "Speichern";
			this.btnSpeichern.UseVisualStyleBackColor = true;
			this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
			// 
			// txtAbteilungsbezeichnung
			// 
			this.txtAbteilungsbezeichnung.Location = new System.Drawing.Point(143, 40);
			this.txtAbteilungsbezeichnung.Name = "txtAbteilungsbezeichnung";
			this.txtAbteilungsbezeichnung.Size = new System.Drawing.Size(284, 20);
			this.txtAbteilungsbezeichnung.TabIndex = 9;
			// 
			// txtAbteilungsnummer
			// 
			this.txtAbteilungsnummer.Enabled = false;
			this.txtAbteilungsnummer.Location = new System.Drawing.Point(143, 12);
			this.txtAbteilungsnummer.Name = "txtAbteilungsnummer";
			this.txtAbteilungsnummer.Size = new System.Drawing.Size(284, 20);
			this.txtAbteilungsnummer.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Abteilungsbezeichnung:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Abteilungsnummer:";
			// 
			// FormAbteilung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 114);
			this.Controls.Add(this.btnAbbrechen);
			this.Controls.Add(this.btnSpeichern);
			this.Controls.Add(this.txtAbteilungsbezeichnung);
			this.Controls.Add(this.txtAbteilungsnummer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormAbteilung";
			this.Text = "Abteilung hinzufügen / bearbeiten";
			this.Load += new System.EventHandler(this.FormAbteilung_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAbbrechen;
		private System.Windows.Forms.Button btnSpeichern;
		private System.Windows.Forms.TextBox txtAbteilungsbezeichnung;
		private System.Windows.Forms.TextBox txtAbteilungsnummer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}