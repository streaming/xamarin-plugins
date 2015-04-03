﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geofence.Plugin.Abstractions
{
    public interface IGeofenceListener
    {
       void OnMonitoringStarted(GeofenceCircularRegion region);
       void OnMonitoringStopped();
       void OnMonitoringStopped(string identifier);
       void OnRegionStateChanged(GeofenceResult result);
       void OnError(String error);
    }
}