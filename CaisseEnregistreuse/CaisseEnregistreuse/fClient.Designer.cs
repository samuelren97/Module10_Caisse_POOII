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
            tbDescription = new TextBox();
            SuspendLayout();
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Enabled = false;
            tbDescription.Location = new Point(10, 9);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(628, 23);
            tbDescription.TabIndex = 0;
            // 
            // fClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 45);
            Controls.Add(tbDescription);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(664, 84);
            Name = "fClient";
            Text = "Écran client";
            Load += fClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescription;
    }
}