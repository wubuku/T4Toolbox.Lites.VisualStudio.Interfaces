#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Important   Do not use this object for new applications. It has been superseded
    //     by the EnvDTE80.Process2 object, which we recommend instead. However, this
    //     object will continue to work in existing code.
    [Guid("6A38D87C-BBA0-11D2-8AD1-00C04F79E479")]
    //[TypeLibType(4160)]
    public interface Program
    {
        //// Summary:
        ////     Gets the collection that contains the object that supports this property
        ////     or is contained in this code construct. Returns null for an object that is
        ////     not obtained from a collection.
        ////
        //// Returns:
        ////     A EnvDTE.Programs collection.
        //[DispId(202)]
        //Programs Collection { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(200)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets whether a program is being debugged when this property is called.
        //
        // Returns:
        //     The Boolean value, true, if the program is being debugged; otherwise, false.
        [DispId(102)]
        bool IsBeingDebugged { get; }
        //
        // Summary:
        //     Gets the name of the object.
        //
        // Returns:
        //     A string that represents the name of the Program object.
        [DispId(0)]
        string Name { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Program object.
        //
        // Returns:
        //     A EnvDTE.Debugger object.
        [DispId(201)]
        Debugger Parent { get; }
        ////
        //// Summary:
        ////     Gets the process by which this program is managed.
        ////
        //// Returns:
        ////     A EnvDTE.Process object.
        //[DispId(100)]
        //Process Process { get; }
        ////
        //// Summary:
        ////     Gets the collection of threads that are being managed by this program.
        ////
        //// Returns:
        ////     A EnvDTE.Threads collection.
        //[DispId(101)]
        //Threads Threads { get; }
    }
}
