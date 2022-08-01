using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    internal interface IEventEnabledMeasuringDevice: IMeasuringDevice
    {
        event EventHandler NewMeasurementTaken;

    }
}
