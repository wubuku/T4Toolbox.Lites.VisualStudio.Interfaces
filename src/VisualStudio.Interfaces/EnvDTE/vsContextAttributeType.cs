#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Specifies the type of new attribute.
    [Guid("410202E1-B83A-41DD-AAB0-8C0029FE9435")]
    public enum vsContextAttributeType
    {
        // Summary:
        //     A filter attribute.
        vsContextAttributeFilter = 1,
        //
        // Summary:
        //     A search keyword.
        vsContextAttributeLookup = 2,
        //
        // Summary:
        //     An F1 keyword. This is a higher priority than a search keyword. Only one
        //     F1 keyword is allowed per collection.
        vsContextAttributeLookupF1 = 3,
    }
}
