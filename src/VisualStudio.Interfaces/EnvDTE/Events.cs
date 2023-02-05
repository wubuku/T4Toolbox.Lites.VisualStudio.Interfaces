#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Allows access to all events in the extensibility model. Events may also be
    //     exposed from specific objects within the extensibility model.
    [Guid("134170F8-93B1-42DD-9F89-A2AC7010BA07")]
    //[TypeLibType(4160)]
    public interface Events
    {
        // Summary:
        //     Gets the EnvDTE.BuildEvents object, which provides events for solution builds.
        //
        // Returns:
        //     A EnvDTE.BuildEvents object.
        [DispId(303)]
        BuildEvents BuildEvents { get; }
        //
        // Summary:
        //     Gets the object that provides events from the debugger.
        //
        // Returns:
        //     A EnvDTE.DebuggerEvents object.
        [DispId(312)]
        DebuggerEvents DebuggerEvents { get; }
        //
        // Summary:
        //     Gets the EnvDTE.DTEEvents that provides events for the development environment.
        //
        // Returns:
        //     A EnvDTE.DTEEvents object.
        [DispId(308)]
        DTEEvents DTEEvents { get; }
        //
        // Summary:
        //     Gets the EnvDTE.FindEvents for the Find operation.
        //
        // Returns:
        //     A EnvDTE.FindEvents object.
        //[DispId(306)]
        //FindEvents FindEvents { get; }
        ////
        //// Summary:
        ////     Gets the EnvDTE.ProjectItemsEvents for the solution.
        ////
        //// Returns:
        ////     A EnvDTE.ProjectItemsEvents object.
        //[DispId(311)]
        //ProjectItemsEvents MiscFilesEvents { get; }
        ////
        //// Summary:
        ////     Gets the EnvDTE.SelectionEvents for the selection.
        ////
        //// Returns:
        ////     A EnvDTE.SelectionEvents object.
        //[DispId(301)]
        //SelectionEvents SelectionEvents { get; }
        ////
        //// Summary:
        ////     Gets the EnvDTE.SolutionEvents object for the solution.
        ////
        //// Returns:
        ////     A EnvDTE.SolutionEvents object.
        //[DispId(302)]
        //SolutionEvents SolutionEvents { get; }
        ////
        //// Summary:
        ////     Gets the EnvDTE.ProjectItemsEvents object for the solution.
        ////
        //// Returns:
        ////     A EnvDTE.ProjectItemsEvents object.
        //[DispId(310)]
        //ProjectItemsEvents SolutionItemsEvents { get; }

        //[DispId(205)]
        //object get_CommandBarEvents(object CommandBarControl);
        //[DispId(300)]
        //CommandEvents get_CommandEvents(string Guid = "{00000000-0000-0000-0000-000000000000}", int ID = 0);
        //[DispId(309)]
        //DocumentEvents get_DocumentEvents(Document Document = null);
        //[DispId(305)]
        //OutputWindowEvents get_OutputWindowEvents(string Pane = "");
        //[DispId(307)]
        //TaskListEvents get_TaskListEvents(string Filter = "");
        //[DispId(313)]
        //TextEditorEvents get_TextEditorEvents(TextDocument TextDocumentFilter = null);
        //[DispId(304)]
        //WindowEvents get_WindowEvents(Window WindowFilter = null);
        

        // Summary:
        //     Gets an interface or object that is late-bound to the EnvDTE.DTE object and
        //     can be accessed by name at run time.
        //
        // Parameters:
        //   Name:
        //     Required. The name of the object to retrieve.
        //
        // Returns:
        //     An object.
        [DispId(314)]
        object GetObject(string Name);
    }
}
