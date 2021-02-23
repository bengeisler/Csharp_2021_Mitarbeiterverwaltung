
namespace Csharp_2021_Mitarbeiterverwaltung
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtVorname = new System.Windows.Forms.TextBox();
			this.txtNachname = new System.Windows.Forms.TextBox();
			this.btnMitarbeiterInAbteilungÜbernehmen = new System.Windows.Forms.Button();
			this.btnAlleAnzeigen = new System.Windows.Forms.Button();
			this.btnNachNachnameSortieren = new System.Windows.Forms.Button();
			this.btnNachVornameSortieren = new System.Windows.Forms.Button();
			this.btnFiltern = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtAbteilungsbezeichnung = new System.Windows.Forms.TextBox();
			this.txtAbteilungsnummer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAbteilungLöschen = new System.Windows.Forms.Button();
			this.btnAbteilungBearbeiten = new System.Windows.Forms.Button();
			this.btnAbteilungHinzufügen = new System.Windows.Forms.Button();
			this.mitarbeiterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.mitarbeiterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.mitarbeiterDataGridView = new System.Windows.Forms.DataGridView();
			this.abteilungDataGridView = new System.Windows.Forms.DataGridView();
			this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.abteilungBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingNavigator)).BeginInit();
			this.mitarbeiterBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.abteilungDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.abteilungBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mitarbeiterDataGridView);
			this.groupBox1.Controls.Add(this.txtVorname);
			this.groupBox1.Controls.Add(this.txtNachname);
			this.groupBox1.Controls.Add(this.btnMitarbeiterInAbteilungÜbernehmen);
			this.groupBox1.Controls.Add(this.btnAlleAnzeigen);
			this.groupBox1.Controls.Add(this.btnNachNachnameSortieren);
			this.groupBox1.Controls.Add(this.btnNachVornameSortieren);
			this.groupBox1.Controls.Add(this.btnFiltern);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1248, 361);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mitarbeiter";
			// 
			// txtVorname
			// 
			this.txtVorname.Location = new System.Drawing.Point(110, 291);
			this.txtVorname.Name = "txtVorname";
			this.txtVorname.Size = new System.Drawing.Size(183, 20);
			this.txtVorname.TabIndex = 16;
			// 
			// txtNachname
			// 
			this.txtNachname.Location = new System.Drawing.Point(110, 266);
			this.txtNachname.Name = "txtNachname";
			this.txtNachname.Size = new System.Drawing.Size(183, 20);
			this.txtNachname.TabIndex = 15;
			// 
			// btnMitarbeiterInAbteilungÜbernehmen
			// 
			this.btnMitarbeiterInAbteilungÜbernehmen.Location = new System.Drawing.Point(628, 264);
			this.btnMitarbeiterInAbteilungÜbernehmen.Name = "btnMitarbeiterInAbteilungÜbernehmen";
			this.btnMitarbeiterInAbteilungÜbernehmen.Size = new System.Drawing.Size(171, 48);
			this.btnMitarbeiterInAbteilungÜbernehmen.TabIndex = 13;
			this.btnMitarbeiterInAbteilungÜbernehmen.Text = "Mitarbeiter in ausgewählte Abteilung übernehmen";
			this.btnMitarbeiterInAbteilungÜbernehmen.UseVisualStyleBackColor = true;
			this.btnMitarbeiterInAbteilungÜbernehmen.Click += new System.EventHandler(this.btnMitarbeiterInAbteilungÜbernehmen_Click);
			// 
			// btnAlleAnzeigen
			// 
			this.btnAlleAnzeigen.Location = new System.Drawing.Point(205, 318);
			this.btnAlleAnzeigen.Name = "btnAlleAnzeigen";
			this.btnAlleAnzeigen.Size = new System.Drawing.Size(88, 23);
			this.btnAlleAnzeigen.TabIndex = 12;
			this.btnAlleAnzeigen.Text = "Alle anzeigen";
			this.btnAlleAnzeigen.UseVisualStyleBackColor = true;
			this.btnAlleAnzeigen.Click += new System.EventHandler(this.btnAlleAnzeigen_Click);
			// 
			// btnNachNachnameSortieren
			// 
			this.btnNachNachnameSortieren.Location = new System.Drawing.Point(350, 264);
			this.btnNachNachnameSortieren.Name = "btnNachNachnameSortieren";
			this.btnNachNachnameSortieren.Size = new System.Drawing.Size(165, 23);
			this.btnNachNachnameSortieren.TabIndex = 11;
			this.btnNachNachnameSortieren.Text = "Nach Nachname sortieren";
			this.btnNachNachnameSortieren.UseVisualStyleBackColor = true;
			this.btnNachNachnameSortieren.Click += new System.EventHandler(this.btnNachNachnameSortieren_Click);
			// 
			// btnNachVornameSortieren
			// 
			this.btnNachVornameSortieren.Location = new System.Drawing.Point(350, 289);
			this.btnNachVornameSortieren.Name = "btnNachVornameSortieren";
			this.btnNachVornameSortieren.Size = new System.Drawing.Size(165, 23);
			this.btnNachVornameSortieren.TabIndex = 10;
			this.btnNachVornameSortieren.Text = "Nach Vorname sortieren";
			this.btnNachVornameSortieren.UseVisualStyleBackColor = true;
			this.btnNachVornameSortieren.Click += new System.EventHandler(this.btnNachVornameSortieren_Click);
			// 
			// btnFiltern
			// 
			this.btnFiltern.Location = new System.Drawing.Point(110, 317);
			this.btnFiltern.Name = "btnFiltern";
			this.btnFiltern.Size = new System.Drawing.Size(75, 23);
			this.btnFiltern.TabIndex = 9;
			this.btnFiltern.Text = "Filtern";
			this.btnFiltern.UseVisualStyleBackColor = true;
			this.btnFiltern.Click += new System.EventHandler(this.btnFiltern_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Vorname";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 269);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nachname";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.abteilungDataGridView);
			this.groupBox2.Controls.Add(this.txtAbteilungsbezeichnung);
			this.groupBox2.Controls.Add(this.txtAbteilungsnummer);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.btnAbteilungLöschen);
			this.groupBox2.Controls.Add(this.btnAbteilungBearbeiten);
			this.groupBox2.Controls.Add(this.btnAbteilungHinzufügen);
			this.groupBox2.Location = new System.Drawing.Point(12, 414);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1248, 391);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Abteilungen";
			// 
			// txtAbteilungsbezeichnung
			// 
			this.txtAbteilungsbezeichnung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abteilungBindingSource, "Bezeichnung", true));
			this.txtAbteilungsbezeichnung.Enabled = false;
			this.txtAbteilungsbezeichnung.Location = new System.Drawing.Point(209, 243);
			this.txtAbteilungsbezeichnung.Name = "txtAbteilungsbezeichnung";
			this.txtAbteilungsbezeichnung.Size = new System.Drawing.Size(219, 20);
			this.txtAbteilungsbezeichnung.TabIndex = 8;
			// 
			// txtAbteilungsnummer
			// 
			this.txtAbteilungsnummer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abteilungBindingSource, "AbteilungsNr", true));
			this.txtAbteilungsnummer.Enabled = false;
			this.txtAbteilungsnummer.Location = new System.Drawing.Point(137, 243);
			this.txtAbteilungsnummer.Name = "txtAbteilungsnummer";
			this.txtAbteilungsnummer.Size = new System.Drawing.Size(62, 20);
			this.txtAbteilungsnummer.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 246);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ausgewählte Abteilung:";
			// 
			// btnAbteilungLöschen
			// 
			this.btnAbteilungLöschen.Location = new System.Drawing.Point(12, 348);
			this.btnAbteilungLöschen.Name = "btnAbteilungLöschen";
			this.btnAbteilungLöschen.Size = new System.Drawing.Size(166, 23);
			this.btnAbteilungLöschen.TabIndex = 5;
			this.btnAbteilungLöschen.Text = "Abteilung löschen";
			this.btnAbteilungLöschen.UseVisualStyleBackColor = true;
			this.btnAbteilungLöschen.Click += new System.EventHandler(this.btnAbteilungLöschen_Click);
			// 
			// btnAbteilungBearbeiten
			// 
			this.btnAbteilungBearbeiten.Location = new System.Drawing.Point(12, 318);
			this.btnAbteilungBearbeiten.Name = "btnAbteilungBearbeiten";
			this.btnAbteilungBearbeiten.Size = new System.Drawing.Size(166, 23);
			this.btnAbteilungBearbeiten.TabIndex = 4;
			this.btnAbteilungBearbeiten.Text = "Abteilung bearbeiten";
			this.btnAbteilungBearbeiten.UseVisualStyleBackColor = true;
			this.btnAbteilungBearbeiten.Click += new System.EventHandler(this.btnAbteilungBearbeiten_Click);
			// 
			// btnAbteilungHinzufügen
			// 
			this.btnAbteilungHinzufügen.Location = new System.Drawing.Point(12, 289);
			this.btnAbteilungHinzufügen.Name = "btnAbteilungHinzufügen";
			this.btnAbteilungHinzufügen.Size = new System.Drawing.Size(166, 23);
			this.btnAbteilungHinzufügen.TabIndex = 3;
			this.btnAbteilungHinzufügen.Text = "Abteilung hinzufügen";
			this.btnAbteilungHinzufügen.UseVisualStyleBackColor = true;
			this.btnAbteilungHinzufügen.Click += new System.EventHandler(this.btnAbteilungHinzufügen_Click);
			// 
			// mitarbeiterBindingNavigator
			// 
			this.mitarbeiterBindingNavigator.AddNewItem = null;
			this.mitarbeiterBindingNavigator.BindingSource = this.mitarbeiterBindingSource;
			this.mitarbeiterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.mitarbeiterBindingNavigator.DeleteItem = null;
			this.mitarbeiterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mitarbeiterBindingNavigatorSaveItem});
			this.mitarbeiterBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.mitarbeiterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.mitarbeiterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.mitarbeiterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.mitarbeiterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.mitarbeiterBindingNavigator.Name = "mitarbeiterBindingNavigator";
			this.mitarbeiterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.mitarbeiterBindingNavigator.Size = new System.Drawing.Size(1274, 25);
			this.mitarbeiterBindingNavigator.TabIndex = 6;
			this.mitarbeiterBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
			this.bindingNavigatorCountItem.Text = "von {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Löschen";
			// 
			// mitarbeiterBindingNavigatorSaveItem
			// 
			this.mitarbeiterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.mitarbeiterBindingNavigatorSaveItem.Enabled = false;
			this.mitarbeiterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mitarbeiterBindingNavigatorSaveItem.Image")));
			this.mitarbeiterBindingNavigatorSaveItem.Name = "mitarbeiterBindingNavigatorSaveItem";
			this.mitarbeiterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.mitarbeiterBindingNavigatorSaveItem.Text = "Daten speichern";
			// 
			// mitarbeiterDataGridView
			// 
			this.mitarbeiterDataGridView.AllowUserToAddRows = false;
			this.mitarbeiterDataGridView.AllowUserToDeleteRows = false;
			this.mitarbeiterDataGridView.AutoGenerateColumns = false;
			this.mitarbeiterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mitarbeiterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
			this.mitarbeiterDataGridView.DataSource = this.mitarbeiterBindingSource;
			this.mitarbeiterDataGridView.Location = new System.Drawing.Point(12, 19);
			this.mitarbeiterDataGridView.Name = "mitarbeiterDataGridView";
			this.mitarbeiterDataGridView.ReadOnly = true;
			this.mitarbeiterDataGridView.Size = new System.Drawing.Size(1230, 220);
			this.mitarbeiterDataGridView.TabIndex = 16;
			// 
			// abteilungDataGridView
			// 
			this.abteilungDataGridView.AllowUserToAddRows = false;
			this.abteilungDataGridView.AllowUserToDeleteRows = false;
			this.abteilungDataGridView.AutoGenerateColumns = false;
			this.abteilungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.abteilungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
			this.abteilungDataGridView.DataSource = this.abteilungBindingSource;
			this.abteilungDataGridView.Location = new System.Drawing.Point(12, 17);
			this.abteilungDataGridView.Name = "abteilungDataGridView";
			this.abteilungDataGridView.ReadOnly = true;
			this.abteilungDataGridView.Size = new System.Drawing.Size(1230, 220);
			this.abteilungDataGridView.TabIndex = 8;
			// 
			// mitarbeiterBindingSource
			// 
			this.mitarbeiterBindingSource.DataSource = typeof(Csharp_2021_Mitarbeiterverwaltung.Mitarbeiter);
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "AbteilungsNr";
			this.dataGridViewTextBoxColumn10.HeaderText = "AbteilungsNr";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Bezeichnung";
			this.dataGridViewTextBoxColumn11.HeaderText = "Bezeichnung";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// abteilungBindingSource
			// 
			this.abteilungBindingSource.DataSource = typeof(Csharp_2021_Mitarbeiterverwaltung.Abteilung);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonalNr";
			this.dataGridViewTextBoxColumn1.HeaderText = "PersonalNr";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "AbteilungsNr";
			this.dataGridViewTextBoxColumn2.HeaderText = "AbteilungsNr";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn3.HeaderText = "Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Vorname";
			this.dataGridViewTextBoxColumn4.HeaderText = "Vorname";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Stellenbezeichnung";
			this.dataGridViewTextBoxColumn5.HeaderText = "Stellenbezeichnung";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresse";
			this.dataGridViewTextBoxColumn6.HeaderText = "Adresse";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "PLZ";
			this.dataGridViewTextBoxColumn7.HeaderText = "PLZ";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Ort";
			this.dataGridViewTextBoxColumn8.HeaderText = "Ort";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefon";
			this.dataGridViewTextBoxColumn9.HeaderText = "Telefon";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1274, 807);
			this.Controls.Add(this.mitarbeiterBindingNavigator);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Mitarbeiterverwaltung";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingNavigator)).EndInit();
			this.mitarbeiterBindingNavigator.ResumeLayout(false);
			this.mitarbeiterBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.abteilungDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.abteilungBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtVorname;
		private System.Windows.Forms.TextBox txtNachname;
		private System.Windows.Forms.Button btnMitarbeiterInAbteilungÜbernehmen;
		private System.Windows.Forms.Button btnAlleAnzeigen;
		private System.Windows.Forms.Button btnNachNachnameSortieren;
		private System.Windows.Forms.Button btnNachVornameSortieren;
		private System.Windows.Forms.Button btnFiltern;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtAbteilungsbezeichnung;
		private System.Windows.Forms.TextBox txtAbteilungsnummer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAbteilungLöschen;
		private System.Windows.Forms.Button btnAbteilungBearbeiten;
		private System.Windows.Forms.Button btnAbteilungHinzufügen;
		private System.Windows.Forms.DataGridView mitarbeiterDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
		private System.Windows.Forms.BindingNavigator mitarbeiterBindingNavigator;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton mitarbeiterBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView abteilungDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.BindingSource abteilungBindingSource;
	}
}

