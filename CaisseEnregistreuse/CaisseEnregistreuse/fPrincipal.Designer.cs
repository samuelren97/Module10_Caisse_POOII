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
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            gbScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).BeginInit();
            SuspendLayout();
            // 
            // lArticles
            // 
            lArticles.AutoSize = true;
            lArticles.Location = new Point(12, 9);
            lArticles.Name = "lArticles";
            lArticles.Size = new Size(61, 20);
            lArticles.TabIndex = 0;
            lArticles.Text = "Articles:";
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(12, 32);
            dgvArticles.Name = "dgvArticles";
            dgvArticles.ReadOnly = true;
            dgvArticles.RowHeadersWidth = 51;
            dgvArticles.RowTemplate.Height = 29;
            dgvArticles.Size = new Size(815, 322);
            dgvArticles.TabIndex = 1;
            // 
            // lTotal
            // 
            lTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lTotal.AutoSize = true;
            lTotal.Location = new Point(654, 363);
            lTotal.Name = "lTotal";
            lTotal.Size = new Size(42, 20);
            lTotal.TabIndex = 2;
            lTotal.Text = "Total";
            // 
            // tbTotal
            // 
            tbTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbTotal.Enabled = false;
            tbTotal.Location = new Point(702, 360);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 3;
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
            gbScanner.Location = new Point(12, 390);
            gbScanner.Name = "gbScanner";
            gbScanner.Size = new Size(815, 97);
            gbScanner.TabIndex = 4;
            gbScanner.TabStop = false;
            gbScanner.Text = "Simulateur scanner";
            // 
            // bSimuler
            // 
            bSimuler.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bSimuler.Location = new Point(715, 62);
            bSimuler.Name = "bSimuler";
            bSimuler.Size = new Size(94, 29);
            bSimuler.TabIndex = 6;
            bSimuler.Text = "Simuler";
            bSimuler.UseVisualStyleBackColor = true;
            bSimuler.Click += bSimuler_Click;
            // 
            // nudPrix
            // 
            nudPrix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudPrix.Location = new Point(718, 23);
            nudPrix.Name = "nudPrix";
            nudPrix.Size = new Size(91, 27);
            nudPrix.TabIndex = 5;
            // 
            // lPrix
            // 
            lPrix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lPrix.AutoSize = true;
            lPrix.Location = new Point(679, 26);
            lPrix.Name = "lPrix";
            lPrix.Size = new Size(33, 20);
            lPrix.TabIndex = 4;
            lPrix.Text = "Prix";
            // 
            // nudQuantite
            // 
            nudQuantite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudQuantite.Location = new Point(597, 23);
            nudQuantite.Name = "nudQuantite";
            nudQuantite.Size = new Size(61, 27);
            nudQuantite.TabIndex = 3;
            // 
            // lQuantite
            // 
            lQuantite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lQuantite.AutoSize = true;
            lQuantite.Location = new Point(525, 25);
            lQuantite.Name = "lQuantite";
            lQuantite.Size = new Size(66, 20);
            lQuantite.TabIndex = 2;
            lQuantite.Text = "Quantite";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(102, 23);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(344, 27);
            tbDescription.TabIndex = 1;
            // 
            // lDescription
            // 
            lDescription.AutoSize = true;
            lDescription.Location = new Point(11, 26);
            lDescription.Name = "lDescription";
            lDescription.Size = new Size(85, 20);
            lDescription.TabIndex = 0;
            lDescription.Text = "Description";
            // 
            // fPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 491);
            Controls.Add(gbScanner);
            Controls.Add(tbTotal);
            Controls.Add(lTotal);
            Controls.Add(dgvArticles);
            Controls.Add(lArticles);
            MinimumSize = new Size(857, 538);
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
    }
}