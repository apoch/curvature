using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    public interface IInputBroker
    {
        double GetInputValue(Consideration consideration);
        double GetInputValue(Consideration consideration, Scenario.Context context);
        void RefreshInputs();
    }
}
