using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse
{
    public class ObservateurFactureModel : IObserver<FactureModelEvent>
    {
        private Action<FactureModelEvent> m_action;

        public ObservateurFactureModel(FactureModel p_factureModel, Action<FactureModelEvent> p_action)
        {
            if (p_factureModel is null)
            {
                throw new ArgumentNullException(nameof(p_factureModel));
            }
            if (p_action is null)
            {
                throw new ArgumentNullException(nameof(p_action));
            }
            p_factureModel.Subscribe(this);
            this.m_action = p_action;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(FactureModelEvent p_event)
        {
            this.m_action(p_event);
        }
    }
}
