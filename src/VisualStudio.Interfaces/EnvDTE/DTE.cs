#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     The top-level object in the Visual Studio automation object model. Use this
    //     object for functionality and refer to EnvDTE._DTE for this object’s documentation.
    //[CoClass(typeof(DTEClass))]
    [Guid("04A72314-32E9-48E2-9B87-A63603454F3E")]
    public interface DTE : _DTE
    {
    }
}
