#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a command in the environment.
    [Guid("5FE10FB0-91A1-4E55-BAAA-ECCAE5CCEB94")]
    //[TypeLibType(4160)]
    public interface Command
    {
        // Summary:
        //     Sets or gets the list of keystrokes used to invoke the command.
        //
        // Returns:
        //     A System.Runtime.InteropServices.UnmanagedType.SafeArray of objects.
        [DispId(9)]
        object Bindings { get; set; }
        //
        // Summary:
        //     Gets the EnvDTE.Commands collection containing the EnvDTE.Command object.
        //
        // Returns:
        //     A EnvDTE.Commands collection.
        [DispId(2)]
        Commands Collection { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(3)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the GUID for the given object.
        //
        // Returns:
        //     A string representing the command group GUID used to represent the command.
        [DispId(4)]
        string Guid { get; }
        //
        // Summary:
        //     Gets the ID within a command group GUID used to represent the command.
        //
        // Returns:
        //     An integer representing the command ID.
        [DispId(5)]
        int ID { get; }
        //
        // Summary:
        //     Gets a value indicating whether or not the EnvDTE.Command is currently enabled.
        //
        // Returns:
        //     A Boolean value indicating true if the command is currently enabled; otherwise,
        //     false.
        [DispId(6)]
        bool IsAvailable { get; }
        //
        // Summary:
        //     Gets the localized name of the command.
        //
        // Returns:
        //     A string representing the localized name of the command.
        [DispId(1)]
        string LocalizedName { get; }
        //
        // Summary:
        //     Gets the name of the object.
        //
        // Returns:
        //     A string representing the name of the object.
        [DispId(0)]
        string Name { get; }

        // Summary:
        //     Creates a persistent command bar control for the command.
        //
        // Parameters:
        //   Owner:
        //     Required. A Microsoft.VisualStudio.CommandBars.CommandBar object to which
        //     the new command bar control is to be added.
        //
        //   Position:
        //     Optional. The index position, starting at one, in the command bar to place
        //     the new control.
        //
        // Returns:
        //     A Microsoft.VisualStudio.CommandBars.CommandBarControl object.
        [DispId(7)]
        object AddControl(object Owner, int Position = 1);
        //
        // Summary:
        //     Removes a named command that was created with the EnvDTE.Commands.AddNamedCommand(EnvDTE.AddIn,System.String,System.String,System.String,System.Boolean,System.Int32,System.Object[]@,System.Int32)
        //     method.
        [DispId(8)]
        void Delete();
    }
}
