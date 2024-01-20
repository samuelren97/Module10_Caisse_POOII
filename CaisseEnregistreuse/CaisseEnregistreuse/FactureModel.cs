using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse
{
    public class FactureModel : IObservable<FactureModelEvent>
    {
        private List<IObserver<FactureModelEvent>> m_observateurs;
        
        private List<LigneFactureModel> m_lignesFacture;

        public FactureModel()
        {
            this.m_observateurs = new List<IObserver<FactureModelEvent>>();
            this.m_lignesFacture = new List<LigneFactureModel>();
        }

        public IDisposable Subscribe(IObserver<FactureModelEvent> p_observeur)
        {
            if (p_observeur is null)
            {
                throw new ArgumentNullException(nameof(p_observeur));
            }

            this.m_observateurs.Add(p_observeur);
            return new UnsubscribeFactureModel(this.m_observateurs, p_observeur);
        }

        public void AjouterLigneFactureModel(LigneFactureModel p_ligneFactureModel)
        {
            if (p_ligneFactureModel is null)
            {
                throw new ArgumentNullException(nameof (p_ligneFactureModel));
            }
            m_observateurs.ForEach(obs => obs.OnNext(new FactureModelEvent()
            {
                Type = FactureModelEventType.AJOUT_LIGNE,
                LigneFactureModel = p_ligneFactureModel,
                FactureModel = this
            }));
        }

        public void NouvelleFacture()
        {
            this.m_lignesFacture.Clear();
            this.m_observateurs.ForEach(obs => obs.OnNext(new FactureModelEvent()
            {
                Type = FactureModelEventType.NOUVELLE,
                LigneFactureModel = null,
                FactureModel = this
            }));
        }
    }
}
