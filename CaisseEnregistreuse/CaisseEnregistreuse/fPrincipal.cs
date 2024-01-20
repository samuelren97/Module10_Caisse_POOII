namespace CaisseEnregistreuse
{
    public partial class fPrincipal : Form
    {
        private FactureModel m_factureModel;

        public fPrincipal()
        {
            this.m_factureModel = new FactureModel();
            InitializeComponent();
        }

        private void bSimuler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                // TODO: Handle user error
            }

            LigneFactureModel ligneFactureModel = new LigneFactureModel()
            {
                Description = tbDescription.Text,
                PrixUnitaire = nudPrix.Value,
                Quantite = nudQuantite.Value
            };

            this.m_factureModel.AjouterLigneFactureModel(ligneFactureModel);
        }

        private void fPrincipal_Load(object sender, EventArgs e)
        {
            new ObservateurFactureModel(m_factureModel, fme =>
            {
                if ()
            });
        }
    }
}