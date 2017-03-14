using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    interface IInputBroker
    {
        double GetInputValue(InputAxis axis);
        void RefreshInputs();
    }
}
