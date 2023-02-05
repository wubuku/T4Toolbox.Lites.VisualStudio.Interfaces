#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents the type of build configuration.
    [Guid("612256BD-7BA2-45C4-B60F-7B2AE42F96C3")]
    public enum vsConfigurationType
    {
        // Summary:
        //     A project configuration
        vsConfigurationTypeProject = 1,
        //
        // Summary:
        //     A project item configuration
        vsConfigurationTypeProjectItem = 2,
    }
}
