﻿using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp;

namespace Roflcopter.Plugin
{
    [ZoneMarker]
    public class ZoneMarker :
        IRequire<ILanguageCSharpZone>,
        IRequire<DaemonZone>
    {
    }
}
