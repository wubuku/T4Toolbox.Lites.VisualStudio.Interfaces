#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Determines how to save an item or items.
    [Guid("AAE3FAE8-8AFC-11D2-ADEE-00C04F7971C3")]
    public enum vsSaveChanges
    {
        // Summary:
        //     If changes were made, saves the document.
        vsSaveChangesYes = 1,
        //
        // Summary:
        //     If changes were made, does not save the document.
        vsSaveChangesNo = 2,
        //
        // Summary:
        //     If changes were made, prompts the user to save the document.
        vsSaveChangesPrompt = 3,
    }
}
