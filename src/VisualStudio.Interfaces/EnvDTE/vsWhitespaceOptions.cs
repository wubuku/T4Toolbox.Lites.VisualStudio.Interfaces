#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Determines how and where to remove white space.
    [Guid("BBDFCFE4-4C68-4736-B991-F85FA955D585")]
    public enum vsWhitespaceOptions
    {
        // Summary:
        //     Default. Deletes white space only on the current line in the buffer.
        vsWhitespaceOptionsHorizontal = 0,
        //
        // Summary:
        //     Deletes white space above and below the current line in the buffer.
        vsWhitespaceOptionsVertical = 1,
    }
}
