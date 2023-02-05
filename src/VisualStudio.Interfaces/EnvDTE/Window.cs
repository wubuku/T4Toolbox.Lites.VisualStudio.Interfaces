#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     The EnvDTE.Window object represents a window in the environment.
    [Guid("0BEAB46B-4C07-4F94-A8D7-1626020E4E53")]
    //[TypeLibType(4160)]
    public interface Window
    {
        // Summary:
        //     Gets or sets whether the tool window is able to be hidden.
        //
        // Returns:
        //     true if the tool window can be hidden; otherwise, false.
        [DispId(136)]
        bool AutoHides { get; set; }
        //
        // Summary:
        //     Gets or sets the title of the window.
        //
        // Returns:
        //     The title of the window.
        [DispId(0)]
        string Caption { get; set; }
        ////
        //// Summary:
        ////     Gets the collection containing the EnvDTE.Window object supporting this property.
        ////
        //// Returns:
        ////     A EnvDTE.Windows collection.
        //[DispId(2)]
        //Windows Collection { get; }
        //
        // Summary:
        //     Gets a EnvDTE.ContextAttributes collection which allows automation clients
        //     to add new attributes to the current selected items in the Dynamic Help window
        //     and provide contextual help for the additional attributes.
        //
        // Returns:
        //     A EnvDTE.ContextAttributes collection.
        [DispId(139)]
        ContextAttributes ContextAttributes { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Document object associated with the item, if one exists.
        //
        // Returns:
        //     A EnvDTE.Document object.
        [DispId(128)]
        Document Document { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(127)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets or sets a value indicating the dimensions of the window in pixels.
        //
        // Returns:
        //     The height dimension of the window in pixels.
        [DispId(107)]
        int Height { get; set; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The window handle.
        [DispId(120)]
        int HWnd { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the tool window is floating over
        //     other windows.
        //
        // Returns:
        //     true if the window is floating over other windows; otherwise, false.
        [DispId(135)]
        bool IsFloating { get; set; }
        //
        // Summary:
        //     Gets a string indicating the type of window.
        //
        // Returns:
        //     A string representing the type of window.
        [DispId(121)]
        string Kind { get; }
        //
        // Summary:
        //     Gets or sets the distance between the internal left edge of an object and
        //     the left edge of its container.
        //
        // Returns:
        //     The distance between the internal left edge of an object and the left edge
        //     of its container.
        [DispId(101)]
        int Left { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the tool window can be docked with
        //     other tool windows.
        //
        // Returns:
        //     true if the window can be docked with other windows; otherwise, false.
        [DispId(130)]
        bool Linkable { get; set; }
        //
        // Summary:
        //     Gets a EnvDTE.Window object representing the window frame containing the
        //     window.
        //
        // Returns:
        //     A EnvDTE.Window object.
        [DispId(117)]
        Window LinkedWindowFrame { get; }
        ////
        //// Summary:
        ////     Gets a collection of all linked windows contained in the linked window frame.
        ////
        //// Returns:
        ////     A EnvDTE.LinkedWindows collection.
        //[DispId(116)]
        //LinkedWindows LinkedWindows { get; }
        //
        // Summary:
        //     Gets an object that can be accessed by name at run time.
        //
        // Returns:
        //     An object.
        [DispId(123)]
        object Object { get; }
        //
        // Summary:
        //     Gets the type of the EnvDTE.Window object, which is a GUID string representing
        //     the tool contained in the window.
        //
        // Returns:
        //     A string containing a GUID representing the tool contained in the window.
        [DispId(122)]
        string ObjectKind { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Project object associated with the EnvDTE.Window object.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(126)]
        Project Project { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ProjectItem object associated with the EnvDTE.Window object.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(125)]
        ProjectItem ProjectItem { get; }
        //
        // Summary:
        //     Gets an object representing the current selection on the EnvDTE.Window object.
        //
        // Returns:
        //     An object representing the current selection on the EnvDTE.Window object.
        [DispId(129)]
        object Selection { get; }
        //
        // Summary:
        //     Gets or sets the distance between the internal top edge of an object and
        //     the top edge of its container.
        //
        // Returns:
        //     The distance between the internal top edge of an object and the top edge
        //     of its container.
        [DispId(103)]
        int Top { get; set; }
        ////
        //// Summary:
        ////     Microsoft Internal Use Only.
        ////
        //// Returns:
        ////     The type.
        //[DispId(112)]
        //vsWindowType Type { get; }
        //
        // Summary:
        //     Gets or sets the visibility of a window.
        //
        // Returns:
        //     true if the window is visible; otherwise, false.
        [DispId(106)]
        bool Visible { get; set; }
        //
        // Summary:
        //     Gets or sets the width of the window in character units.
        //
        // Returns:
        //     The width of the window in character units.
        [DispId(105)]
        int Width { get; set; }
        ////
        //// Summary:
        ////     Gets or sets the state, such as minimized, normal, and so forth, of the window.
        ////
        //// Returns:
        ////     A EnvDTE.vsWindowState constant.
        //[DispId(109)]
        //vsWindowState WindowState { get; set; }

        // Summary:
        //     Moves the focus to the current item.
        [DispId(131)]
        void Activate();
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   lWindowHandle:
        //     The window handle.
        [DispId(119)]
        //[TypeLibFunc(65)]
        void Attach(int lWindowHandle);
        //
        // Summary:
        //     Closes the open document and optionally saves it, or closes and destroys
        //     the window.
        //
        // Parameters:
        //   SaveChanges:
        //     Optional. A EnvDTE.vsSaveChanges constant that determines whether to save
        //     an item or items.
        [DispId(132)]
        void Close(vsSaveChanges SaveChanges = vsSaveChanges.vsSaveChangesNo);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(118)]
        //[TypeLibFunc(65)]
        void Detach();
        [DispId(124)]
        //[TypeLibFunc(64)]
        object get_DocumentData(string bstrWhichData = "");
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(111)]
        //[TypeLibFunc(64)]
        void SetFocus();
        ////
        //// Summary:
        ////     Microsoft Internal Use Only.
        ////
        //// Parameters:
        ////   eKind:
        ////     The window type.
        //[DispId(113)]
        ////[TypeLibFunc(65)]
        //void SetKind(vsWindowType eKind);
        //
        // Summary:
        //     Allows setting objects to be active in the Properties window when this window
        //     is active.
        //
        // Parameters:
        //   Objects:
        //     Required. An array of objects for the Properties window.
        [DispId(133)]
        void SetSelectionContainer(ref object[] Objects);
        //
        // Summary:
        //     Sets the picture to display in a tool window.
        //
        // Parameters:
        //   Picture:
        //     The picture to place into the tool window.
        [DispId(138)]
        void SetTabPicture(object Picture);
    }
}
