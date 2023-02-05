using System;

namespace Microsoft.VisualStudio.OLE.Interop
{
    [System.Runtime.InteropServices.Guid("6D5140C1-7436-11CE-8034-00AA006009FA")]
    [System.Runtime.InteropServices.InterfaceType(1)]
    public interface IServiceProvider
    {
        int QueryService (ref Guid guidService, ref Guid riid, out IntPtr ppvObject);
    }
}