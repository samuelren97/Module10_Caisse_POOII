using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse
{
    public class FactureModelEvent
    {
        public FactureModelEventType Type { get; set; }

        public LigneFactureModel? LigneFactureModel { get; set; }

        private FactureModel m_factureModel;
        public FactureModel FactureModel
        {
            get { return m_factureModel; }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                this.m_factureModel = value;
            }
        }
    }
}
