namespace ZarzadzanieSklepem
{
    partial class PROprogramform
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Szybkość");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Wygoda");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Użytkowość");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Kompatybilność");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("ProProgram", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            this.logowanieLabel = new System.Windows.Forms.Label();
            this.uzytkownikLabel = new System.Windows.Forms.Label();
            this.hasloLabel = new System.Windows.Forms.Label();
            this.zalogujButton = new System.Windows.Forms.Button();
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.wyborUzytkownikComboBox = new System.Windows.Forms.ComboBox();
            this.zamknijButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.hasloDataSet = new ZarzadzanieSklepem.HasloDataSet();
            this.passyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passyTableAdapter = new ZarzadzanieSklepem.HasloDataSetTableAdapters.passyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hasloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logowanieLabel
            // 
            this.logowanieLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.logowanieLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logowanieLabel.Location = new System.Drawing.Point(93, 24);
            this.logowanieLabel.Name = "logowanieLabel";
            this.logowanieLabel.Size = new System.Drawing.Size(209, 31);
            this.logowanieLabel.TabIndex = 0;
            this.logowanieLabel.Text = "Logowanie";
            this.logowanieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uzytkownikLabel
            // 
            this.uzytkownikLabel.AutoSize = true;
            this.uzytkownikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uzytkownikLabel.Location = new System.Drawing.Point(12, 65);
            this.uzytkownikLabel.Name = "uzytkownikLabel";
            this.uzytkownikLabel.Size = new System.Drawing.Size(76, 13);
            this.uzytkownikLabel.TabIndex = 1;
            this.uzytkownikLabel.Text = "Uzytkownik:";
            // 
            // hasloLabel
            // 
            this.hasloLabel.AutoSize = true;
            this.hasloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLabel.Location = new System.Drawing.Point(12, 110);
            this.hasloLabel.Name = "hasloLabel";
            this.hasloLabel.Size = new System.Drawing.Size(45, 13);
            this.hasloLabel.TabIndex = 2;
            this.hasloLabel.Text = "Hasło:";
            // 
            // zalogujButton
            // 
            this.zalogujButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.zalogujButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalogujButton.Location = new System.Drawing.Point(142, 129);
            this.zalogujButton.Name = "zalogujButton";
            this.zalogujButton.Size = new System.Drawing.Size(115, 38);
            this.zalogujButton.TabIndex = 3;
            this.zalogujButton.Text = "Zaloguj się";
            this.zalogujButton.UseVisualStyleBackColor = false;
            this.zalogujButton.Click += new System.EventHandler(this.zalogujButton_Click);
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.Location = new System.Drawing.Point(142, 103);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.PasswordChar = '*';
            this.hasloTextBox.Size = new System.Drawing.Size(121, 20);
            this.hasloTextBox.TabIndex = 4;
            // 
            // wyborUzytkownikComboBox
            // 
            this.wyborUzytkownikComboBox.FormattingEnabled = true;
            this.wyborUzytkownikComboBox.Items.AddRange(new object[] {
            "World\'s Best Boss",
            "Pracownik"});
            this.wyborUzytkownikComboBox.Location = new System.Drawing.Point(142, 62);
            this.wyborUzytkownikComboBox.Name = "wyborUzytkownikComboBox";
            this.wyborUzytkownikComboBox.Size = new System.Drawing.Size(121, 21);
            this.wyborUzytkownikComboBox.TabIndex = 5;
            this.wyborUzytkownikComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zamknijButton
            // 
            this.zamknijButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.zamknijButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknijButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zamknijButton.Location = new System.Drawing.Point(328, 144);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(75, 23);
            this.zamknijButton.TabIndex = 6;
            this.zamknijButton.Text = "Zamknij";
            this.zamknijButton.UseVisualStyleBackColor = false;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(269, 12);
            this.treeView1.Name = "treeView1";
            treeNode26.Name = "Szybkość";
            treeNode26.Text = "Szybkość";
            treeNode27.Name = "Węzeł3";
            treeNode27.Text = "Wygoda";
            treeNode28.Name = "Węzeł5";
            treeNode28.Text = "Użytkowość";
            treeNode29.Name = "Węzeł6";
            treeNode29.Text = "Kompatybilność";
            treeNode30.Name = "Węzeł0";
            treeNode30.Text = "ProProgram";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(134, 111);
            this.treeView1.TabIndex = 7;
            // 
            // hasloDataSet
            // 
            this.hasloDataSet.DataSetName = "HasloDataSet";
            this.hasloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passyBindingSource
            // 
            this.passyBindingSource.DataMember = "passy";
            this.passyBindingSource.DataSource = this.hasloDataSet;
            // 
            // passyTableAdapter
            // 
            this.passyTableAdapter.ClearBeforeFill = true;
            // 
            // PROprogramform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(406, 179);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.zamknijButton);
            this.Controls.Add(this.wyborUzytkownikComboBox);
            this.Controls.Add(this.hasloTextBox);
            this.Controls.Add(this.zalogujButton);
            this.Controls.Add(this.hasloLabel);
            this.Controls.Add(this.uzytkownikLabel);
            this.Controls.Add(this.logowanieLabel);
            this.Name = "PROprogramform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRO program - Logowanie";
            this.Load += new System.EventHandler(this.PROprogramform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hasloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logowanieLabel;
        private System.Windows.Forms.Label uzytkownikLabel;
        private System.Windows.Forms.Label hasloLabel;
        private System.Windows.Forms.Button zalogujButton;
        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.ComboBox wyborUzytkownikComboBox;
        private System.Windows.Forms.Button zamknijButton;
        private System.Windows.Forms.TreeView treeView1;
        private HasloDataSet hasloDataSet;
        private System.Windows.Forms.BindingSource passyBindingSource;
        private HasloDataSetTableAdapters.passyTableAdapter passyTableAdapter;
    }
}

