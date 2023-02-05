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
    //     Contains all of the commands in the environment, as EnvDTE.Command objects.
    [Guid("E6B96CAC-B8C7-40AE-B705-5C81878C4A9E")]
    //[TypeLibType(4160)]
    public interface Commands : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.Commands collection.
        //
        // Returns:
        //     The number of objects in the EnvDTE.Commands collection.
        [DispId(10)]
        int Count { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(1)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Commands collection.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(2)]
        DTE Parent { get; }

        // Summary:
        //     Microsoft Internal Only.
        //
        // Parameters:
        //   Guid:
        //     The GUID of the command.
        //
        //   ID:
        //     The command ID.
        //
        //   Control:
        //     The control.
        [DispId(3)]
        //[TypeLibFunc(64)]
        void Add(string Guid, int ID, ref object Control);
        ////
        //// Summary:
        ////     Creates a command bar that is saved and available the next time the environment
        ////     is started.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. A name for the new command bar.
        ////
        ////   Type:
        ////     Required. A EnvDTE.vsCommandBarType constant that determines the type of
        ////     command bar:
        ////
        ////   CommandBarParent:
        ////     Optional. An Office Microsoft.VisualStudio.CommandBars.CommandBar object
        ////     to which the new command bar is to be added. (This is required, however,
        ////     if Type is EnvDTE.vsCommandBarType.vsCommandBarTypeMenu.)
        ////
        ////   Position:
        ////     Optional. The index position, starting at one, in the command bar to place
        ////     the new command bar.
        ////
        //// Returns:
        ////     A Microsoft.VisualStudio.CommandBars.CommandBar object.
        //[DispId(12)]
        //object AddCommandBar(string Name, vsCommandBarType Type, object CommandBarParent = null, int Position = 1);
        ////
        //// Summary:
        ////     Creates a named command that is saved by the environment and made available
        ////     the next time the environment starts, even if the Add-in is not loaded on
        ////     environment startup.
        ////
        //// Parameters:
        ////   AddInInstance:
        ////     Required. The EnvDTE.AddIn Object is adding the new command.
        ////
        ////   Name:
        ////     Required. The short form of the name for your new command. EnvDTE.Commands.AddNamedCommand(EnvDTE.AddIn,System.String,System.String,System.String,System.Boolean,System.Int32,System.Object[]@,System.Int32)
        ////     uses the preface Addins.Progid. to create a unique name.
        ////
        ////   ButtonText:
        ////     Required. The name to use if the command is bound to a button that is displayed
        ////     by name rather than by icon.
        ////
        ////   Tooltip:
        ////     Required. The text displayed when a user hovers the mouse pointer over any
        ////     control bound to the new command.
        ////
        ////   MSOButton:
        ////     Required. Indicates whether the named command's button picture is an Office
        ////     picture. True = button. If MSOButton is False, then Bitmap is the ID of a
        ////     16x16 bitmap resource (but not an icon resource) in a Visual C++ resource
        ////     DLL that must reside in a folder with the language's locale identifier (1033
        ////     for English).
        ////
        ////   Bitmap:
        ////     Optional. The ID of a bitmap to display on the button.
        ////
        ////   ContextUIGUIDs:
        ////     Optional. A SafeArray of GUIDs that determines which environment contexts
        ////     (that is, debug mode, design mode, and so on) show the command. See EnvDTE.vsCommandDisabledFlags..
        ////
        //// Returns:
        ////     A EnvDTE.Command object.
        //[DispId(11)]
        //Command AddNamedCommand(AddIn AddInInstance, string Name, string ButtonText, string Tooltip, bool MSOButton, int Bitmap = 0, ref object[] ContextUIGUIDs = null, int vsCommandDisabledFlagsValue = 16);
        //
        // Summary:
        //     Returns the command GUID and ID associated with the given Microsoft.VisualStudio.CommandBars.CommandBar
        //     control.
        //
        // Parameters:
        //   CommandBarControl:
        //     Required. The Microsoft.VisualStudio.CommandBars.CommandBar control associated
        //     with the command.
        //
        //   Guid:
        //     Required. The command's GUID.
        //
        //   ID:
        //     Required. The command's ID.
        [DispId(5)]
        void CommandInfo(object CommandBarControl, out string Guid, out int ID);
        //
        // Summary:
        //     Returns an enumerator for items in the EnvDTE.Commands collection.
        //
        // Returns:
        //     An System.Collections.IEnumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns the indexed EnvDTE.Command object.
        //
        // Parameters:
        //   index:
        //     Required. An absolute index, GUID string, or the command's full name.
        //
        //   ID:
        //     Optional. The command ID in the specified command set.
        //
        // Returns:
        //     A EnvDTE.Command object.
        [DispId(0)]
        Command Item(object index, int ID = -1);
        //
        // Summary:
        //     Executes the specified command.
        //
        // Parameters:
        //   Guid:
        //     Required. The command's GUID.
        //
        //   ID:
        //     Required. The command's ID.
        //
        //   CustomIn:
        //     Required. Arguments in a SafeArray passed in from the OLECommandTarget.
        //
        //   CustomOut:
        //     Required. Arguments in a SafeArray passed out to be returned by the OLECommandTarget.
        [DispId(4)]
        void Raise(string Guid, int ID, ref object CustomIn, ref object CustomOut);
        //
        // Summary:
        //     Removes a command bar that was created with the EnvDTE.Commands.AddCommandBar(System.String,EnvDTE.vsCommandBarType,System.Object,System.Int32)
        //     method.
        //
        // Parameters:
        //   CommandBar:
        //     Required. The Microsoft.VisualStudio.CommandBars.CommandBar object to remove.
        [DispId(13)]
        void RemoveCommandBar(object CommandBar);
    }
}
