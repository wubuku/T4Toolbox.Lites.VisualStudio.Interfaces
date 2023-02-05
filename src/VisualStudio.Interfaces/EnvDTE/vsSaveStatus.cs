#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Indicates whether or not the save was successful.
    [Guid("8901FF7A-E6E8-4154-A505-135EE434817E")]
    public enum vsSaveStatus
    {
        // Summary:
        //     The document was saved successfully.
        vsSaveSucceeded = 1,
        //
        // Summary:
        //     The document save was canceled.
        vsSaveCancelled = 2,
    }
}
