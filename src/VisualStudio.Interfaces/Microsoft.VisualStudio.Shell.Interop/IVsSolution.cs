namespace Microsoft.VisualStudio.Shell.Interop
{
    // [System.Runtime.InteropServices.ComConversionLoss]
    // [System.Runtime.InteropServices.Guid("7F7CD0DB-91EF-49DC-9FA9-02D128515DD4")]
    // [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVsSolution
    {
        /// Returns the project in the solution, given a unique name.
        int GetProjectOfUniqueName (string pszUniqueName, out Microsoft.VisualStudio.Shell.Interop.IVsHierarchy ppHierarchy);
    }
}