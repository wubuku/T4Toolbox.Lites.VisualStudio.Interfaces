#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents the mode of the integrated development environment (IDE).
    [Guid("B638B3E3-C98B-4F59-9D05-105A620529F9")]
    public enum vsIDEMode
    {
        // Summary:
        //     The IDE is in Design mode.
        vsIDEModeDesign = 1,
        //
        // Summary:
        //     The IDE is in Debug mode.
        vsIDEModeDebug = 2,
    }
}
