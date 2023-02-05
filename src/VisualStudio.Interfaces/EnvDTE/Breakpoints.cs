#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Provides a list of pending breakpoints.
    [Guid("25968106-BAFB-11D2-8AD1-00C04F79E479")]
    //[TypeLibType(4160)]
    public interface Breakpoints : IEnumerable
    {
        // Summary:
        //     Returns a value indicating the number of EnvDTE.Breakpoint objects in the
        //     EnvDTE.Breakpoints collection.
        //
        // Returns:
        //     An integer value representing the number of EnvDTE.Breakpoint objects in
        //     the collection.
        [DispId(3)]
        int Count { get; }
        //
        // Summary:
        //     Returns the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(1)]
        DTE DTE { get; }
        //
        // Summary:
        //     Returns the parent EnvDTE.Debugger object of a given EnvDTE.Breakpoints collection.
        //
        // Returns:
        //     A EnvDTE.Debugger object.
        [DispId(2)]
        Debugger Parent { get; }

        // Summary:
        //     Creates and enables a new breakpoint.
        //
        // Parameters:
        //   Function:
        //     Optional. A function breakpoint. The name of the function on which the breakpoint
        //     is set.
        //
        //   File:
        //     Optional. A file breakpoint. The name and optional path of the file in which
        //     the breakpoint is set.
        //
        //   Line:
        //     Optional. A file breakpoint. The source-code line number, measured from the
        //     start of the function, at which the breakpoint is set. If this value is 1,
        //     the breakpoint is set at the start of the function.
        //
        //   Column:
        //     Optional. A file breakpoint. The character at which the breakpoint is set.
        //     In most cases, you can leave this value set to 1, which sets the breakpoint
        //     at the start of the line.
        //
        //   Condition:
        //     Optional. The breakpoint EnvDTE.Breakpoint.Condition. Use with ConditionType.
        //
        //   ConditionType:
        //     Optional. The condition type. A EnvDTE.dbgBreakpointConditionType value.
        //     Use with Condition.
        //
        //   Language:
        //     Optional. The programming language in which the function is written.
        //
        //   Data:
        //     Optional. A data breakpoint. If the breakpoint is set on a variable, you
        //     can specify the name of the variable. You can use the context operator to
        //     specify a variable outside the current scope.
        //
        //   DataCount:
        //     Optional. A data breakpoint. If the breakpoint is set on a variable, and
        //     if the variable is an array or dereferenced pointer, this value specifies
        //     the number of elements to watch.
        //
        //   Address:
        //     Optional. An address breakpoint. The memory address where the breakpoint
        //     is set, in decimal or hexadecimal format.
        //
        //   HitCount:
        //     Optional. The Hit Count property for the breakpoint. If you specify no hit
        //     count, program execution breaks each time the breakpoint is hit. If you specify
        //     a hit count, program execution breaks only on the specified number of hits.
        //
        //   HitCountType:
        //     Optional. The hit count type. A EnvDTE.dbgHitCountType value.
        //
        // Returns:
        //     A EnvDTE.Breakpoints collection.
        [DispId(4)]
        Breakpoints Add(string Function = "", string File = "", int Line = 1, int Column = 1, string Condition = "", dbgBreakpointConditionType ConditionType = dbgBreakpointConditionType.dbgBreakpointConditionTypeWhenTrue, string Language = "", string Data = "", int DataCount = 1, string Address = "", int HitCount = 0, dbgHitCountType HitCountType = dbgHitCountType.dbgHitCountTypeNone);
        //
        // Summary:
        //     Gets an enumerator.
        //
        // Returns:
        //     An enumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns a EnvDTE.Breakpoint object in a EnvDTE.Breakpoints collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.Breakpoint object to return.
        //
        // Returns:
        //     A EnvDTE.Breakpoint object.
        [DispId(0)]
        Breakpoint Item(object index);
    }
}
