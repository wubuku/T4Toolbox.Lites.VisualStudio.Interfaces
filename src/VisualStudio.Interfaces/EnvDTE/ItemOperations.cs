#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Object for performing common file actions.
    [Guid("D5DBE57B-C074-4E95-B015-ABEEAA391693")]
    //[TypeLibType(4160)]
    public interface ItemOperations
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
        //     Gets the immediate parent object of an EnvDTE.ItemOperations object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(2)]
        DTE Parent { get; }
        ////
        //// Summary:
        ////     Gets all unsaved files and allows the user to save one or more of them.
        ////
        //// Returns:
        ////     A EnvDTE.vsPromptResult value describing the user's action after displaying
        ////     a dialog box.
        //[DispId(9)]
        //vsPromptResult PromptToSave { get; }

        // Summary:
        //     Adds an existing item to the current project.
        //
        // Parameters:
        //   FileName:
        //     Required. The full path and file name of the item to be added.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(6)]
        ProjectItem AddExistingItem(string FileName);
        //
        // Summary:
        //     Adds a new item to the current project.
        //
        // Parameters:
        //   Item:
        //     Optional. The virtual path to the item based on either the UI resource string
        //     (defined in the Remarks section below) or occasionally as displayed in the
        //     contents of the New File dialog box in "category\templatename" format. Category
        //     comes from the left pane of the dialog box and templatename from the right
        //     pane. For example, to add a new HTML file to a Visual Basic project, you
        //     would use "General\HTML Page." See the Remarks section for more information.
        //
        //   Name:
        //     Optional. The display name to use for the item when it is added to a project.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(7)]
        ProjectItem AddNewItem(string Item = @"General\Text File", string Name = "");
        //
        // Summary:
        //     Indicates whether or not the specified saved file is currently open in the
        //     specified view.
        //
        // Parameters:
        //   FileName:
        //     Required. The absolute path to the specified saved file. If the file has
        //     just been created but not yet saved, then EnvDTE.ItemOperations.IsFileOpen(System.String,System.String)
        //     returns false.
        //
        //   ViewKind:
        //     Optional. A EnvDTE.Constants.vsViewKind* constant representing the type of
        //     view in which the saved file is currently open.
        //
        // Returns:
        //     A Boolean value indicating true if the file is open in the specified view,
        //     false if not.
        [DispId(5)]
        bool IsFileOpen(string FileName, string ViewKind = "{FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF}");
        ////
        //// Summary:
        ////     Goes to the given URL.
        ////
        //// Parameters:
        ////   URL:
        ////     Optional. URL of the file to open. If URL is not specified, the default home
        ////     page is opened. The default value of URL is "".
        ////
        ////   Options:
        ////     Optional. A EnvDTE.vsNavigateOptions constant that determines whether the
        ////     browsed content displays in an external Web browser window or in a new window.
        ////
        //// Returns:
        ////     A EnvDTE.Window object.
        //[DispId(8)]
        //Window Navigate(string URL = "", vsNavigateOptions Options = vsNavigateOptions.vsNavigateOptionsDefault);
        //
        // Summary:
        //     Creates a file as though you invoked a New File command in the integrated
        //     development environment (IDE).
        //
        // Parameters:
        //   Item:
        //     Required. The virtual path to the item based on the tree nodes from the left
        //     pane of the dialog box and the item name from the right pane.
        //
        //   Name:
        //     Optional. The name you type in the Default Name box in the dialog box. This
        //     name also becomes the suggested Save As name when you save the document.
        //
        //   ViewKind:
        //     Optional. A EnvDTE.ConstantsvsViewKind* constant specifying the type of view
        //     in which to create the file.
        //
        // Returns:
        //     A EnvDTE.Window object.
        [DispId(4)]
        Window NewFile(string Item = @"General\Text File", string Name = "", string ViewKind = "{00000000-0000-0000-0000-000000000000}");
        //
        // Summary:
        //     Opens a file as though you invoked an Open File command in the integrated
        //     development environment (IDE).
        //
        // Parameters:
        //   FileName:
        //     Required. The full path and name of the file to be opened.
        //
        //   ViewKind:
        //     Optional. A EnvDTE.ConstantsvsViewKind* constant specifying the type of view
        //     in which to create the file.
        //
        // Returns:
        //     A EnvDTE.Window object.
        [DispId(3)]
        Window OpenFile(string FileName, string ViewKind = "{00000000-0000-0000-0000-000000000000}");
    }
}
