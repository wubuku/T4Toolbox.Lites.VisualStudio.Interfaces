#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents options for changing text to lowercase or uppercase.
    [Guid("98A2F403-007B-41F8-9A18-87ADDEF1760F")]
    public enum vsCaseOptions
    {
        // Summary:
        //     Change selected text to lowercase.
        vsCaseOptionsLowercase = 1,
        //
        // Summary:
        //     Change selected text to uppercase.
        vsCaseOptionsUppercase = 2,
        //
        // Summary:
        //     Capitalize the first letter of each word of the selected text.
        vsCaseOptionsCapitalize = 3,
    }
}
