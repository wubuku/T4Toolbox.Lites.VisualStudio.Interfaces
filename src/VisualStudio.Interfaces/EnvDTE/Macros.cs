#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents the Visual Studio macro recorder.
    [Guid("F9F99155-6D4D-49B1-AD63-C78C3E8A5916")]
    //[TypeLibType(4160)]
    public interface Macros
    {
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(1)]
        DTE DTE { get; }
        //
        // Summary:
        //     Returns whether the macro recorder is currently recording actions. This property
        //     should not be used from within a macro.
        //
        // Returns:
        //     A Boolean value of true indicates that the macro recorder is currently recording
        //     actions; false indicates that it is not.
        [DispId(3)]
        bool IsRecording { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Macros object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(2)]
        DTE Parent { get; }

        // Summary:
        //     Writes the line of code to the macro being recorded. This method should not
        //     be used from within a macro.
        //
        // Parameters:
        //   Code:
        //     Required. The line of code to add to the macro.
        [DispId(4)]
        void EmitMacroCode(string Code);
        //
        // Summary:
        //     Pauses the macro recorder so that no code is written to the macro currently
        //     being recorded. This method should not be used from within a macro.
        [DispId(5)]
        void Pause();
        //
        // Summary:
        //     Resumes macro recording if it has been paused. This method should not be
        //     used from within a macro.
        [DispId(6)]
        void Resume();
    }
}
