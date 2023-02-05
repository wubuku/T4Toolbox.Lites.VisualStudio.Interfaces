#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a document in the environment open for editing.
    [Guid("63EB5C39-CA8F-498E-9A66-6DD4A27AC95B")]
    //[TypeLibType(4160)]
    public interface Document
    {
        // Summary:
        //     Gets the currently active window, or the topmost window if no others are
        //     active. Returns Nothing if no windows are open.
        //
        // Returns:
        //     A EnvDTE.Window object.
        [DispId(102)]
        Window ActiveWindow { get; }
        //
        // Summary:
        //     Gets the collection containing the EnvDTE.Document object.
        //
        // Returns:
        //     A EnvDTE.Documents collection.
        [DispId(101)]
        Documents Collection { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(100)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the Extender category ID (CATID) for the object.
        //
        // Returns:
        //     A string GUID representing the CATID.
        [DispId(135)]
        string ExtenderCATID { get; }
        //
        // Summary:
        //     Gets a list of available Extenders for the object.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(134)]
        object ExtenderNames { get; }
        //
        // Summary:
        //     Gets the full path and name of the object's file.
        //
        // Returns:
        //     A string representing the full path and name of the object's file.
        [DispId(103)]
        string FullName { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(142)]
        int IndentSize { get; }
        //
        // Summary:
        //     Gets a GUID string indicating the kind or type of the object.
        //
        // Returns:
        //     A GUID string indicating the kind or type of object.
        [DispId(141)]
        string Kind { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(144)]
        string Language { get; set; }
        //
        // Summary:
        //     Gets the name of the EnvDTE.Document.
        //
        // Returns:
        //     A string representing the file name of the EnvDTE.Document without the path.
        [DispId(0)]
        string Name { get; }
        //
        // Summary:
        //     Gets the path, without file name, for the directory containing the document.
        //
        // Returns:
        //     A string representing the path, without file name, for the directory containing
        //     the document.
        [DispId(105)]
        string Path { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ProjectItem object associated with the EnvDTE.Document object.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(110)]
        ProjectItem ProjectItem { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(106)]
        bool ReadOnly { get; set; }
        //
        // Summary:
        //     Returns true if the object has not been modified since last being saved or
        //     opened.
        //
        // Returns:
        //     A Boolean value indicating true (default) if the object has not been modified
        //     since last being saved or opened; false if otherwise.
        [DispId(107)]
        bool Saved { get; set; }
        //
        // Summary:
        //     Gets an object representing the current selection on the EnvDTE.Document.
        //
        // Returns:
        //     An object representing the current selection on the EnvDTE.Document.
        [DispId(131)]
        object Selection { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(147)]
        int TabSize { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(149)]
        string Type { get; }
        ////
        //// Summary:
        ////     Gets a EnvDTE.Windows collection containing the windows that display in the
        ////     object.
        ////
        //// Returns:
        ////     A EnvDTE.Windows collection.
        //[DispId(109)]
        //Windows Windows { get; }

        // Summary:
        //     Moves the focus to the current item.
        [DispId(121)]
        void Activate();
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(122)]
        //[TypeLibFunc(64)]
        void ClearBookmarks();
        //
        // Summary:
        //     Closes the open document and optionally saves it, or closes and destroys
        //     the window.
        //
        // Parameters:
        //   Save:
        //     Optional. A EnvDTE.vsSaveChanges constant that determines whether to save
        //     an item or items.
        [DispId(123)]
        void Close(vsSaveChanges Save = vsSaveChanges.vsSaveChangesPrompt);
        [DispId(133)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   Pattern:
        //     The text pattern.
        //
        //   Flags:
        //     The flags.
        [DispId(124)]
        //[TypeLibFunc(64)]
        bool MarkText(string Pattern, int Flags = 0);
        //
        // Summary:
        //     Creates a new window in which to view the document.
        //
        // Returns:
        //     A EnvDTE.Window object.
        [DispId(125)]
        Window NewWindow();
        //
        // Summary:
        //     Returns an interface or object that can be accessed at run time by name.
        //
        // Parameters:
        //   ModelKind:
        //     Optional. The type of data model. The only values used are "TextDocument"
        //     and "Document".
        //
        // Returns:
        //     An object.
        [DispId(132)]
        object Object(string ModelKind = "");
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(126)]
        //[TypeLibFunc(64)]
        void PrintOut();
        //
        // Summary:
        //     Re-executes the last action that was undone by the EnvDTE.Document.Undo()
        //     method or the user.
        //
        // Returns:
        //     A Boolean value indicating true if there is an undo action to redo, false
        //     if not.
        [DispId(127)]
        bool Redo();
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   FindText:
        //     The text to find.
        //
        //   ReplaceText:
        //     The replacement text.
        //
        //   Flags:
        //     Flags from EnvDTE.vsFindOptions.
        //
        // Returns:
        //     true if the text was replaced, otherwise false.
        [DispId(21)]
        //[TypeLibFunc(64)]
        bool ReplaceText(string FindText, string ReplaceText, int Flags = 0);
        //
        // Summary:
        //     Saves the document.
        //
        // Parameters:
        //   FileName:
        //     Optional. The name in which to save the document. Defaults to the path associated
        //     with this document. That is, if an empty string is passed, the document is
        //     saved with its current name.
        //
        // Returns:
        //     A EnvDTE.vsSaveStatus constant indicating whether or not the save was successful.
        [DispId(129)]
        vsSaveStatus Save(string FileName = "");
        //
        // Summary:
        //     Reverses the action last performed by the user in the document.
        //
        // Returns:
        //     A Boolean value indicating true if the last action can be reversed, false
        //     if not.
        [DispId(128)]
        bool Undo();
    }
}
