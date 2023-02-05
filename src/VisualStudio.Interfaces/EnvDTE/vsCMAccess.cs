#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;

namespace EnvDTE
{
    // Summary:
    //     Used to determine how a code element may be accessed by other code.
    public enum vsCMAccess
    {
        // Summary:
        //     Element has public access.
        vsCMAccessPublic = 1,
        //
        // Summary:
        //     Element has private access.
        vsCMAccessPrivate = 2,
        //
        // Summary:
        //     Element has project access.
        vsCMAccessProject = 4,
        //
        // Summary:
        //     Element has protected access.
        vsCMAccessProtected = 8,
        //
        // Summary:
        //     Element has project or protected access.
        vsCMAccessProjectOrProtected = 12,
        //
        // Summary:
        //     Element has default access.
        vsCMAccessDefault = 32,
        //
        // Summary:
        //     Element has assembly or family access.
        vsCMAccessAssemblyOrFamily = 64,
        //
        // Summary:
        //     Element can be accessed via WithEvents.
        vsCMAccessWithEvents = 128,
    }
}
