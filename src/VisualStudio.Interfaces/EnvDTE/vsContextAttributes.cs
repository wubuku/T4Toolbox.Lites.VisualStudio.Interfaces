#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents context attributes.
    [Guid("59286EDC-D580-4E22-96C9-44D15B6148CC")]
    public enum vsContextAttributes
    {
        // Summary:
        //     Global context attribute
        vsContextAttributesGlobal = 1,
        //
        // Summary:
        //     Window context attribute
        vsContextAttributesWindow = 2,
        //
        // Summary:
        //     High-priority context attribute
        vsContextAttributesHighPriority = 3,
    }
}
