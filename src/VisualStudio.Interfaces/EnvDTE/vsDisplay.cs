#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents the display mode of the integrated development environment (IDE).
    [Guid("E0E643C3-5410-487A-B64E-2664A5C4AB50")]
    public enum vsDisplay
    {
        // Summary:
        //     IDE displays in MDI (multiple-document interface, where all windows are contained
        //     within the parent environment window) mode.
        vsDisplayMDI = 1,
        //
        // Summary:
        //     IDE displays in tabbed MDI mode, where multiple windows display tabbed on
        //     top of each other.
        vsDisplayMDITabs = 2,
    }
}
