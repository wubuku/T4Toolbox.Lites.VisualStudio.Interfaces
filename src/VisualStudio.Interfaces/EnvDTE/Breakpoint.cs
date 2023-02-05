#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     The EnvDTE.Breakpoint object contains the properties and methods used to
    //     programmatically manipulate a EnvDTE.Breakpoint.
    [Guid("11C5114C-BB00-11D2-8AD1-00C04F79E479")]
    //[TypeLibType(4160)]
    public interface Breakpoint
    {
        // Summary:
        //     Gets a collection of objects contained within this code construct.
        //
        // Returns:
        //     A EnvDTE.Breakpoints collection.
        [DispId(203)]
        Breakpoints Children { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Breakpoints collection
        //
        // Returns:
        //     A EnvDTE.Breakpoints collection.
        [DispId(202)]
        Breakpoints Collection { get; }
        //
        // Summary:
        //     Specifies the condition for the breakpoint.
        //
        // Returns:
        //     A string representing the breakpoint condition for the property.
        [DispId(109)]
        string Condition { get; }
        //
        // Summary:
        //     Indicates whether the condition type will break the program execution when
        //     true or break when changed.
        //
        // Returns:
        //     A EnvDTE.dbgBreakpointConditionType value.
        [DispId(108)]
        dbgBreakpointConditionType ConditionType { get; }
        //
        // Summary:
        //     Indicates the number of times a breakpoint has been hit during the active
        //     debugging session.
        //
        // Returns:
        //     An integer representing the number of times this breakpoint has been hit
        //     during this debugging session.
        [DispId(115)]
        int CurrentHits { get; }
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
        //     Sets or gets the enabled state of this EnvDTE.Breakpoint object.
        //
        // Returns:
        //     A Boolean value representing whether this T:EnvDTE.Breakpoint object is enabled
        //     or not.
        [DispId(113)]
        bool Enabled { get; set; }
        //
        // Summary:
        //     Gets the name of the file that contains the breakpoint or a declaration of
        //     the parent object.
        //
        // Returns:
        //     A string representing a file name.
        [DispId(105)]
        string File { get; }
        //
        // Summary:
        //     Indicates the character location within a line in a file for a file breakpoint.
        //
        // Returns:
        //     An integer that represents the character location within a line in a file
        //     that contains the breakpoint.
        [DispId(107)]
        int FileColumn { get; }
        //
        // Summary:
        //     Indicates the line location within a file for a breakpoint.
        //
        // Returns:
        //     An integer that represents the line number in the source code, measured from
        //     the start of the function, at which the breakpoint is set.
        [DispId(106)]
        int FileLine { get; }
        //
        // Summary:
        //     Indicates the column offset from the name of a function breakpoint.
        //
        // Returns:
        //     An integer value representing the column offset from the name of a function
        //     breakpoint.
        [DispId(104)]
        int FunctionColumnOffset { get; }
        //
        // Summary:
        //     Indicates the line offset from the name of a function breakpoint.
        //
        // Returns:
        //     An integer value representing the line offset from the name of a function
        //     breakpoint.
        [DispId(103)]
        int FunctionLineOffset { get; }
        //
        // Summary:
        //     Gets the name of the function where the breakpoint is set.
        //
        // Returns:
        //     A string that represents the name of the function.
        [DispId(102)]
        string FunctionName { get; }
        //
        // Summary:
        //     Gets the hit count target for any type of breakpoint. Interpreted based on
        //     the hit count type.
        //
        // Returns:
        //     An integer value representing the hit count target for any type of breakpoint.
        [DispId(112)]
        int HitCountTarget { get; }
        //
        // Summary:
        //     Describes how to interpret a hit count.
        //
        // Returns:
        //     A EnvDTE.dbgHitCountType value.
        [DispId(111)]
        dbgHitCountType HitCountType { get; }
        //
        // Summary:
        //     Gets the language associated with the name or conditional breakpoint.
        //
        // Returns:
        //     A EnvDTE.CodeModelLanguageConstants constant.
        [DispId(110)]
        string Language { get; }
        //
        // Summary:
        //     Indicates the location type this breakpoint represents.
        //
        // Returns:
        //     A EnvDTE.dbgBreakpointLocationType value.
        [DispId(101)]
        dbgBreakpointLocationType LocationType { get; }
        //
        // Summary:
        //     Sets or gets the name of the Breakpoint.
        //
        // Returns:
        //     A string representing the name of the Breakpoint.
        [DispId(0)]
        string Name { get; set; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Breakpoint object.
        //
        // Returns:
        //     A EnvDTE.Breakpoint object.
        [DispId(201)]
        Breakpoint Parent { get; }
        //
        // Summary:
        //     Gets a reference to a EnvDTE.Program object.
        //
        // Returns:
        //     A reference to a EnvDTE.Program object.
        [DispId(116)]
        Program Program { get; }
        //
        // Summary:
        //     Sets or gets a user-defined string identifying the Breakpoint.
        //
        // Returns:
        //     A string value representing the Breakpoint.
        [DispId(114)]
        string Tag { get; set; }
        //
        // Summary:
        //     Gets a constant indicating the EnvDTE.Breakpoint type.
        //
        // Returns:
        //     A EnvDTE.dbgBreakpointType constant, specifying the type of breakpoint.
        [DispId(100)]
        dbgBreakpointType Type { get; }

        // Summary:
        //     Deletes the breakpoint.
        [DispId(1)]
        void Delete();
        //
        // Summary:
        //     Resets the current number of hits.
        [DispId(300)]
        void ResetHitCount();
    }
}
