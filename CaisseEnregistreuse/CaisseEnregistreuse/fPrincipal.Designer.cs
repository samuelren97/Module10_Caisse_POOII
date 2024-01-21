namespace CaisseEnregistreuse
{
    partial class fPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lArticles = new Label();
            dgvArticles = new DataGridView();
            lTotal = new Label();
            tbTotal = new TextBox();
            gbScanner = new GroupBox();
            bSimuler = new Button();
            nudPrix = new NumericUpDown();
            lPrix = new Label();
            nudQuantite = new NumericUpDown();
            lQuantite = new Label();
            tbDescription = new TextBox();
            lDescription = new Label();
            bPayer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            gbScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).BeginInit();
            SuspendLayout();
            // 
            // lArticles
            // 
            lArticles.AutoSize = true;
            lArticles.Location = new Point(10, 7);
            lArticles.Name = "lArticles";
            lArticles.Size = new Size(49, 15);
            lArticles.TabIndex = 0;
            lArticles.Text = "Articles:";
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(12, 28);
            dgvArticles.Margin = new Padding(3, 2, 3, 2);
            dgvArticles.Name = "dgvArticles";
            dgvArticles.ReadOnly = true;
            dgvArticles.RowHeadersWidth = 51;
            dgvArticles.RowTemplate.Height = 29;
            dgvArticles.Size = new Size(713, 242);
            dgvArticles.TabIndex = 1;
            // 
            // lTotal
            // 
            lTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lTotal.AutoSize = true;
            lTotal.Location = new Point(577, 277);
            lTotal.Name = "lTotal";
            lTotal.Size = new Size(32, 15);
            lTotal.TabIndex = 2;
            lTotal.Text = "Total";
            // 
            // tbTotal
            // 
            tbTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbTotal.Enabled = false;
            tbTotal.Location = new Point(615, 274);
            tbTotal.Margin = new Padding(3, 2, 3, 2);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(110, 23);
            tbTotal.TabIndex = 3;
            tbTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // gbScanner
            // 
            gbScanner.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbScanner.Controls.Add(bSimuler);
            gbScanner.Controls.Add(nudPrix);
            gbScanner.Controls.Add(lPrix);
            gbScanner.Controls.Add(nudQuantite);
            gbScanner.Controls.Add(lQuantite);
            gbScanner.Controls.Add(tbDescription);
            gbScanner.Controls.Add(lDescription);
            gbScanner.Location = new Point(10, 330);
            gbScanner.Margin = new Padding(3, 2, 3, 2);
            gbScanner.Name = "gbScanner";
            gbScanner.Padding = new Padding(3, 2, 3, 2);
            gbScanner.Size = new Size(713, 76);
            gbScanner.TabIndex = 4;
            gbScanner.TabStop = false;
            gbScanner.Text = "Simulateur scanner";
            // 
            // bSimuler
            // 
            bSimuler.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bSimuler.Location = new Point(626, 46);
            bSimuler.Margin = new Padding(3, 2, 3, 2);
            bSimuler.Name = "bSimuler";
            bSimuler.Size = new Size(82, 22);
            bSimuler.TabIndex = 6;
            bSimuler.Text = "Simuler";
            bSimuler.UseVisualStyleBackColor = true;
            bSimuler.Click += bSimuler_Click;
            // 
            // nudPrix
            // 
            nudPrix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudPrix.Location = new Point(628, 17);
            nudPrix.Margin = new Padding(3, 2, 3, 2);
            nudPrix.Name = "nudPrix";
            nudPrix.Size = new Size(80, 23);
            nudPrix.TabIndex = 5;
            // 
            // lPrix
            // 
            lPrix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lPrix.AutoSize = true;
            lPrix.Location = new Point(594, 20);
            lPrix.Name = "lPrix";
            lPrix.Size = new Size(27, 15);
            lPrix.TabIndex = 4;
            lPrix.Text = "Prix";
            // 
            // nudQuantite
            // 
            nudQuantite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudQuantite.Location = new Point(522, 17);
            nudQuantite.Margin = new Padding(3, 2, 3, 2);
            nudQuantite.Name = "nudQuantite";
            nudQuantite.Size = new Size(53, 23);
            nudQuantite.TabIndex = 3;
            // 
            // lQuantite
            // 
            lQuantite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lQuantite.AutoSize = true;
            lQuantite.Location = new Point(459, 19);
            lQuantite.Name = "lQuantite";
            lQuantite.Size = new Size(53, 15);
            lQuantite.TabIndex = 2;
            lQuantite.Text = "Quantite";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(89, 17);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(302, 23);
            tbDescription.TabIndex = 1;
            // 
            // lDescription
            // 
            lDescription.AutoSize = true;
            lDescription.Location = new Point(10, 20);
            lDescription.Name = "lDescription";
            lDescription.Size = new Size(67, 15);
            lDescription.TabIndex = 0;
            lDescription.Text = "Description";
            // 
            // bPayer
            // 
            bPayer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bPayer.Location = new Point(648, 302);
            bPayer.Name = "bPayer";
            bPayer.Size = new Size(75, 23);
            bPayer.TabIndex = 5;
            bPayer.Text = "Payer";
            bPayer.UseVisualStyleBackColor = true;
            bPayer.Click += bPayer_Click;
            // 
            // fPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 415);
            Controls.Add(bPayer);
            Controls.Add(gbScanner);
            Controls.Add(tbTotal);
            Controls.Add(lTotal);
            Controls.Add(dgvArticles);
            Controls.Add(lArticles);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(752, 454);
            Name = "fPrincipal";
            Text = "Écran principal";
            Load += fPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            gbScanner.ResumeLayout(false);
            gbScanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lArticles;
        private DataGridView dgvArticles;
        private Label lTotal;
        private TextBox tbTotal;
        private GroupBox gbScanner;
        private TextBox tbDescription;
        private Label lDescription;
        private Label lQuantite;
        private NumericUpDown nudQuantite;
        private Label lPrix;
        private NumericUpDown nudPrix;
        private Button bSimuler;
        private Button bPayer;
    }
}