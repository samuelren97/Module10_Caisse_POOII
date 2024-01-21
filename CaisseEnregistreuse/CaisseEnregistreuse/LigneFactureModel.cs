using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse
{
    public class LigneFactureModel
    {
        public string Description
        {
            get;
            set;
        }

        private decimal m_quantite; 
        public decimal Quantite
        {
            get
            {
                return this.m_quantite;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                this.m_quantite = value;
            }
        }

        private decimal m_prixUnitaire;
        public decimal PrixUnitaire
        {
            get
            {
                return this.m_prixUnitaire;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                this.m_prixUnitaire = value;
            }
        }
        
        public decimal Total
        {
            get
            {
                return this.PrixUnitaire * this.Quantite;
            }
        }

        public override string ToString()
        {
            return this.Description + "       " + this.Quantite.ToString() + 
                " @ " + this.PrixUnitaire.ToString() + " $";
        }
    }
}
