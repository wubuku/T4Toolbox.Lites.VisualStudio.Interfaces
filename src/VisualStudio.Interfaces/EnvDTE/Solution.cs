#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents all projects and solution-wide properties in the integrated development
    //     environment (IDE). Use this object for functionality and refer to EnvDTE._Solution
    //     for documentation.
    //[CoClass(typeof(SolutionClass))]
    [Guid("26F6CC4B-7A48-4E4D-8AF5-9E960232E05F")]
    public interface Solution : _Solution
    {
    }
}
