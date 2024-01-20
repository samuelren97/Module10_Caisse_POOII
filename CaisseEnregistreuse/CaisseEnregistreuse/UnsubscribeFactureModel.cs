using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse
{
    public class UnsubscribeFactureModel : IDisposable
    {
        private IObserver<FactureModelEvent> m_observateur;
        private List<IObserver<FactureModelEvent>> m_observateurs;

        public UnsubscribeFactureModel(List<IObserver<FactureModelEvent>> p_observateurs, IObserver<FactureModelEvent> p_observateur)
        {
            if (p_observateurs is null)
            {
                throw new ArgumentNullException(nameof(p_observateurs));
            }
            if (p_observateur is null)
            {
                throw new ArgumentNullException(nameof (p_observateur));
            }

            this.m_observateur = p_observateur;
            this.m_observateurs = p_observateurs;
        }

        public void Dispose()
        {
            this.m_observateurs.Remove(this.m_observateur);
        }
    }
}
