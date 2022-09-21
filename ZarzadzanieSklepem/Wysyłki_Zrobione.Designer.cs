namespace ZarzadzanieSklepem
{
    partial class Wysyłki_Zrobione
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
            this.wysylkiZrobioneListBox = new System.Windows.Forms.ListBox();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.zapiszTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.komunikatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wysylkiZrobioneListBox
            // 
            this.wysylkiZrobioneListBox.FormattingEnabled = true;
            this.wysylkiZrobioneListBox.Location = new System.Drawing.Point(47, 27);
            this.wysylkiZrobioneListBox.Name = "wysylkiZrobioneListBox";
            this.wysylkiZrobioneListBox.Size = new System.Drawing.Size(488, 381);
            this.wysylkiZrobioneListBox.TabIndex = 0;
            // 
            // zapiszButton
            // 
            this.zapiszButton.Location = new System.Drawing.Point(404, 414);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(131, 31);
            this.zapiszButton.TabIndex = 1;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            // 
            // zapiszTextBox
            // 
            this.zapiszTextBox.Location = new System.Drawing.Point(47, 424);
            this.zapiszTextBox.Name = "zapiszTextBox";
            this.zapiszTextBox.Size = new System.Drawing.Size(204, 20);
            this.zapiszTextBox.TabIndex = 2;
            this.zapiszTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zapiszTextBox_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // komunikatLabel
            // 
            this.komunikatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.komunikatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikatLabel.Location = new System.Drawing.Point(126, 252);
            this.komunikatLabel.Name = "komunikatLabel";
            this.komunikatLabel.Size = new System.Drawing.Size(387, 63);
            this.komunikatLabel.TabIndex = 3;
            this.komunikatLabel.Text = "Komunikat";
            // 
            // Wysyłki_Zrobione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.komunikatLabel);
            this.Controls.Add(this.zapiszTextBox);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.wysylkiZrobioneListBox);
            this.Name = "Wysyłki_Zrobione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wysyłki_Zrobione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wysylkiZrobioneListBox;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.TextBox zapiszTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label komunikatLabel;
    }
}