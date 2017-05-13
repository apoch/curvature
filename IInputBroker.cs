using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    public interface IInputBroker
    {
        double GetInputValue(InputAxis axis);
        double GetInputValue(InputAxis axis, Scenario.Context context);
        void RefreshInputs();
    }
}
