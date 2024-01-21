using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaisseEnregistreuse
{
    public partial class fClient : Form
    {
        private FactureModel m_factureModel;

        public fClient(FactureModel p_factureModel)
        {
            if (p_factureModel == null)
            {
                throw new ArgumentNullException(nameof(p_factureModel));
            }

            m_factureModel = p_factureModel;
            InitializeComponent();
        }

        private void fClient_Load(object sender, EventArgs e)
        {
            afficherBienvenue();

            new ObservateurFactureModel(m_factureModel, fme =>
            {
                if (fme.Type == FactureModelEventType.AJOUT_LIGNE)
                {
                    if (fme.LigneFactureModel is null)
                    {
                        throw new InvalidOperationException(nameof(fme.LigneFactureModel));
                    }

                    tbDescription.Text = fme.LigneFactureModel.ToString();
                }
            });

            new ObservateurFactureModel(m_factureModel, fme =>
            {
                if (fme.Type == FactureModelEventType.NOUVELLE)
                {
                    afficherBienvenue();
                }
            });
        }

        private void afficherBienvenue()
        {
            tbDescription.Text = "Bienvenue";
        }
    }
}
