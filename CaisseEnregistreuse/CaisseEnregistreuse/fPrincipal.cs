using System.Diagnostics;

namespace CaisseEnregistreuse
{
    public partial class fPrincipal : Form
    {
        private FactureModel m_factureModel;

        private decimal MontantTotal { get; set; }

        public fPrincipal()
        {
            this.m_factureModel = new FactureModel();
            this.MontantTotal = 0;
            InitializeComponent();
        }

        private void bSimuler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                MessageBox.Show("Vous devez entrer une description", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                LigneFactureModel ligneFactureModel = new LigneFactureModel()
                {
                    Description = tbDescription.Text,
                    PrixUnitaire = nudPrix.Value,
                    Quantite = nudQuantite.Value
                };

                this.m_factureModel.AjouterLigneFactureModel(ligneFactureModel);

                this.tbDescription.Text = "";
                this.nudPrix.Value = 0;
                this.nudQuantite.Value = 0;
            }
        }

        private void fPrincipal_Load(object sender, EventArgs e)
        {
            this.dgvArticles.ColumnCount = 4;
            this.dgvArticles.Columns[0].Name = "Description";
            this.dgvArticles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvArticles.Columns[1].Name = "Quantité";
            this.dgvArticles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvArticles.Columns[2].Name = "Prix Unitaire";
            this.dgvArticles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvArticles.Columns[3].Name = "Total";
            this.dgvArticles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            fClient formClient = new fClient(m_factureModel);
            formClient.Show(this);

            new ObservateurFactureModel(m_factureModel, fme =>
            {
                if (fme.Type == FactureModelEventType.AJOUT_LIGNE)
                {
                    if (fme.LigneFactureModel is null)
                    {
                        throw new InvalidOperationException(nameof(fme.LigneFactureModel));
                    }

                    LigneFactureModel lfm = fme.LigneFactureModel;

                    this.MontantTotal += lfm.Total;
                    this.tbTotal.Text = MontantTotal.ToString() + " $";

                    string[] ligne = new string[]
                    {
                        lfm.Description,
                        lfm.Quantite.ToString(),
                        lfm.PrixUnitaire.ToString() + " $",
                        lfm.Total.ToString() + " $"
                    };

                    this.dgvArticles.Rows.Add(ligne);
                }
            });

            new ObservateurFactureModel(m_factureModel, fme =>
            {
                if (fme.Type == FactureModelEventType.NOUVELLE)
                {
                    this.MontantTotal = 0;
                    this.tbTotal.Text = MontantTotal.ToString() + " $";
                    this.dgvArticles.Rows.Clear();
                }
            });
        }

        private void bPayer_Click(object sender, EventArgs e)
        {
            this.m_factureModel.NouvelleFacture();
        }
    }
}