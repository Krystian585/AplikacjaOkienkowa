namespace ZarzadzanieSklepem
{
    partial class Gra
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
            this.czasGry = new System.Windows.Forms.Timer(this.components);
            this.odswiezanieTimer = new System.Windows.Forms.Timer(this.components);
            this.punktyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // czasGry
            // 
            this.czasGry.Interval = 500;
            this.czasGry.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // punktyLabel
            // 
            this.punktyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punktyLabel.Location = new System.Drawing.Point(219, -1);
            this.punktyLabel.Name = "punktyLabel";
            this.punktyLabel.Size = new System.Drawing.Size(319, 50);
            this.punktyLabel.TabIndex = 0;
            this.punktyLabel.Text = "punkciory";
            this.punktyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ZarzadzanieSklepem.Properties.Resources.kosmos1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 690);
            this.Controls.Add(this.punktyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Gra";
            this.Text = "Gra";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Gra_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gra_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gra_KeyUp);
            this.Resize += new System.EventHandler(this.Gra_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer czasGry;
        private System.Windows.Forms.Timer odswiezanieTimer;
        private System.Windows.Forms.Label punktyLabel;
    }
}