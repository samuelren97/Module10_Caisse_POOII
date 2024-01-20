namespace CaisseEnregistreuse
{
    partial class fClient
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
            tbSaisie = new TextBox();
            SuspendLayout();
            // 
            // tbSaisie
            // 
            tbSaisie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSaisie.Location = new Point(12, 12);
            tbSaisie.Name = "tbSaisie";
            tbSaisie.Size = new Size(717, 27);
            tbSaisie.TabIndex = 0;
            // 
            // fClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 52);
            Controls.Add(tbSaisie);
            MinimumSize = new Size(756, 99);
            Name = "fClient";
            Text = "Écran client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSaisie;
    }
}