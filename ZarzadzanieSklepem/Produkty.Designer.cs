namespace ZarzadzanieSklepem
{
    partial class Produkty
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zapiszDoPlikuButton = new System.Windows.Forms.Button();
            this.nazwaPlikuTextBox = new System.Windows.Forms.TextBox();
            this.komunikatLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nrZamowieniaTextBox = new System.Windows.Forms.TextBox();
            this.zapiszNrZamowieniaButton = new System.Windows.Forms.Button();
            this.aktualneZamowienieLabel = new System.Windows.Forms.Label();
            this.wyrobioneZamowieniaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 
            // zapiszDoPlikuButton
            // 
            this.zapiszDoPlikuButton.Location = new System.Drawing.Point(562, 510);
            this.zapiszDoPlikuButton.Name = "zapiszDoPlikuButton";
            this.zapiszDoPlikuButton.Size = new System.Drawing.Size(135, 45);
            this.zapiszDoPlikuButton.TabIndex = 0;
            this.zapiszDoPlikuButton.Text = "Zapisz";
            this.zapiszDoPlikuButton.UseVisualStyleBackColor = true;
            this.zapiszDoPlikuButton.Click += new System.EventHandler(this.zapiszDoPlikuButton_Click);
            // 
            // nazwaPlikuTextBox
            // 
            this.nazwaPlikuTextBox.Location = new System.Drawing.Point(562, 484);
            this.nazwaPlikuTextBox.Name = "nazwaPlikuTextBox";
            this.nazwaPlikuTextBox.Size = new System.Drawing.Size(135, 20);
            this.nazwaPlikuTextBox.TabIndex = 1;
            // 
            // komunikatLabel
            // 
            this.komunikatLabel.BackColor = System.Drawing.Color.Lime;
            this.komunikatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikatLabel.Location = new System.Drawing.Point(12, 524);
            this.komunikatLabel.Name = "komunikatLabel";
            this.komunikatLabel.Size = new System.Drawing.Size(516, 31);
            this.komunikatLabel.TabIndex = 2;
            this.komunikatLabel.Text = "komunikat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aktualnie pracujesz nad zamowieniem nr:";
            // 
            // nrZamowieniaTextBox
            // 
            this.nrZamowieniaTextBox.Location = new System.Drawing.Point(565, 44);
            this.nrZamowieniaTextBox.Name = "nrZamowieniaTextBox";
            this.nrZamowieniaTextBox.Size = new System.Drawing.Size(132, 20);
            this.nrZamowieniaTextBox.TabIndex = 4;
            // 
            // zapiszNrZamowieniaButton
            // 
            this.zapiszNrZamowieniaButton.Location = new System.Drawing.Point(565, 70);
            this.zapiszNrZamowieniaButton.Name = "zapiszNrZamowieniaButton";
            this.zapiszNrZamowieniaButton.Size = new System.Drawing.Size(135, 45);
            this.zapiszNrZamowieniaButton.TabIndex = 5;
            this.zapiszNrZamowieniaButton.Text = "Zapisz";
            this.zapiszNrZamowieniaButton.UseVisualStyleBackColor = true;
            this.zapiszNrZamowieniaButton.Click += new System.EventHandler(this.zapiszNrZamowieniaButton_Click);
            // 
            // aktualneZamowienieLabel
            // 
            this.aktualneZamowienieLabel.AutoSize = true;
            this.aktualneZamowienieLabel.Location = new System.Drawing.Point(33, 14);
            this.aktualneZamowienieLabel.Name = "aktualneZamowienieLabel";
            this.aktualneZamowienieLabel.Size = new System.Drawing.Size(109, 13);
            this.aktualneZamowienieLabel.TabIndex = 6;
            this.aktualneZamowienieLabel.Text = "Aktualne Zamowienie";
            // 
            // wyrobioneZamowieniaButton
            // 
            this.wyrobioneZamowieniaButton.BackColor = System.Drawing.Color.Red;
            this.wyrobioneZamowieniaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyrobioneZamowieniaButton.Location = new System.Drawing.Point(537, 173);
            this.wyrobioneZamowieniaButton.Name = "wyrobioneZamowieniaButton";
            this.wyrobioneZamowieniaButton.Size = new System.Drawing.Size(160, 54);
            this.wyrobioneZamowieniaButton.TabIndex = 7;
            this.wyrobioneZamowieniaButton.Text = "Wyrobione Zamowienia";
            this.wyrobioneZamowieniaButton.UseVisualStyleBackColor = false;
            this.wyrobioneZamowieniaButton.Click += new System.EventHandler(this.wyrobioneZamowieniaButton_Click);
            // 
            // Produkty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.wyrobioneZamowieniaButton);
            this.Controls.Add(this.aktualneZamowienieLabel);
            this.Controls.Add(this.zapiszNrZamowieniaButton);
            this.Controls.Add(this.nrZamowieniaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.komunikatLabel);
            this.Controls.Add(this.nazwaPlikuTextBox);
            this.Controls.Add(this.zapiszDoPlikuButton);
            this.Name = "Produkty";
            this.Text = "Produkty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button zapiszDoPlikuButton;
        private System.Windows.Forms.TextBox nazwaPlikuTextBox;
        private System.Windows.Forms.Label komunikatLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zapiszNrZamowieniaButton;
        private System.Windows.Forms.TextBox nrZamowieniaTextBox;
        private System.Windows.Forms.Label aktualneZamowienieLabel;
        private System.Windows.Forms.Button wyrobioneZamowieniaButton;
    }
}