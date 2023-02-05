#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     The top-level object in the Visual Studio automation object model. Refer
    //     to EnvDTE._DTE for this functionality. Do not instantiate from this class.
    [Guid("04A72314-32E9-48E2-9B87-A63603454F3E")]
    //[TypeLibType(4160)]
    public interface _DTE
    {
        // Summary:
        //     Gets the active document.
        //
        // Returns:
        //     A EnvDTE.Document object.
        [DispId(221)]
        Document ActiveDocument { get; }
        //
        // Summary:
        //     Gets an array of currently selected projects.
        //
        // Returns:
        //     An array of currently selected projects.
        [DispId(237)]
        object ActiveSolutionProjects { get; }
        //
        // Summary:
        //     Returns the currently active window, or the top-most window if no others
        //     are active.
        //
        // Returns:
        //     A EnvDTE.Window object. Returns Nothing if no windows are open.
        [DispId(205)]
        Window ActiveWindow { get; }
        //
        // Summary:
        //     Gets the EnvDTE.AddIns collection, which contains all currently available
        //     Add-ins.
        //
        // Returns:
        //     A EnvDTE.AddIns collection.
        [DispId(200)]
        AddIns AddIns { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The DTE object.
        [DispId(240)]
        DTE Application { get; }
        //
        // Summary:
        //     Gets a reference to the development environment's command bars.
        //
        // Returns:
        //     A Microsoft.VisualStudio.CommandBars.CommandBars object.
        [DispId(108)]
        object CommandBars { get; }
        //
        // Summary:
        //     Gets a string representing the command line arguments.
        //
        // Returns:
        //     A string representing the command line arguments.
        [DispId(214)]
        string CommandLineArguments { get; }
        //
        // Summary:
        //     Returns the EnvDTE.Commands collection.
        //
        // Returns:
        //     A EnvDTE.Commands collection.
        [DispId(210)]
        Commands Commands { get; }
        //
        // Summary:
        //     Gets a EnvDTE.ContextAttributes collection which allows automation clients
        //     to add new attributes to the current selected items in the Dynamic Help window
        //     and provide contextual help for the additional attributes.
        //
        // Returns:
        //     A EnvDTE.ContextAttributes collection.
        [DispId(241)]
        ContextAttributes ContextAttributes { get; }
        //
        // Summary:
        //     Gets the debugger objects.
        //
        // Returns:
        //     A EnvDTE.Debugger object.
        [DispId(244)]
        Debugger Debugger { get; }
        //
        // Summary:
        //     Gets the display mode, either MDI or Tabbed Documents.
        //
        // Returns:
        //     A EnvDTE.vsDisplay constant representing the display mode.
        [DispId(208)]
        vsDisplay DisplayMode { get; set; }
        //
        // Summary:
        //     Gets the collection of open documents in the development environment.
        //
        // Returns:
        //     A EnvDTE.Documents collection.
        [DispId(220)]
        Documents Documents { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(217)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets a description of the edition of the environment.
        //
        // Returns:
        //     A string representing the description of the environment edition.
        [DispId(246)]
        string Edition { get; }
        //
        // Summary:
        //     Gets a reference to the EnvDTE.Events object.
        //
        // Returns:
        //     A EnvDTE.Events object.
        [DispId(111)]
        Events Events { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The file name.
        [DispId(10)]
        string FileName { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Find object that represents global text find operations.
        //
        // Returns:
        //     A EnvDTE.Find object.
        [DispId(229)]
        Find Find { get; }
        //
        // Summary:
        //     Gets the full path and name of the object's file.
        //
        // Returns:
        //     A string representing the full path and name of the object's file.
        [DispId(226)]
        string FullName { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Globals object that contains Add-in values that may be saved
        //     in the solution (.sln) file, the project file, or in the user's profile data.
        //
        // Returns:
        //     A EnvDTE.Globals object.
        [DispId(223)]
        Globals Globals { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ItemOperations object.
        //
        // Returns:
        //     An EnvDTE.ItemOperations object.
        [DispId(233)]
        ItemOperations ItemOperations { get; }
        //
        // Summary:
        //     Gets the ID of the locale in which the development environment is running.
        //
        // Returns:
        //     An integer value representing the ID of the locale in which the development
        //     environment is running.
        [DispId(218)]
        int LocaleID { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Macros object.
        //
        // Returns:
        //     A EnvDTE.Macros object.
        [DispId(236)]
        Macros Macros { get; }
        //
        // Summary:
        //     Gets the root of the Macros IDE's automation model.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(238)]
        DTE MacrosIDE { get; }
        //
        // Summary:
        //     Gets a EnvDTE.Window object representing the main development environment
        //     window.
        //
        // Returns:
        //     A EnvDTE.Window object.
        [DispId(204)]
        Window MainWindow { get; }
        ////
        //// Summary:
        ////     Gets the mode of the development environment, either debug or design.
        ////
        //// Returns:
        ////     A EnvDTE.vsIDEMode value.
        //[DispId(230)]
        //vsIDEMode Mode { get; }
        //
        // Summary:
        //     Sets or gets the name of the EnvDTE._DTE object.
        //
        // Returns:
        //     A string representing the name of the EnvDTE._DTE object.
        [DispId(0)]
        string Name { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ObjectExtenders object.
        //
        // Returns:
        //     A EnvDTE.ObjectExtenders object.
        [DispId(228)]
        ObjectExtenders ObjectExtenders { get; }
        //
        // Summary:
        //     Gets a string with the path to the root of the Visual Studio registry settings.
        //
        // Returns:
        //     A string representing the path to the root of the Visual Studio registry
        //     settings.
        [DispId(239)]
        string RegistryRoot { get; }
        ////
        //// Summary:
        ////     Gets a collection containing the items currently selected in the environment.
        ////
        //// Returns:
        ////     A EnvDTE.SelectedItems collection.
        //[DispId(213)]
        //SelectedItems SelectedItems { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Solution object that represents all open projects in the
        //     current instance of the environment and allows access to the build objects.
        //
        // Returns:
        //     A EnvDTE.Solution object.
        [DispId(209)]
        Solution Solution { get; }
        ////
        //// Summary:
        ////     Gets a EnvDTE.SourceControl object that allows you to manipulate the source
        ////     code control state of the file behind the object.
        ////
        //// Returns:
        ////     A EnvDTE.SourceControl object.
        //[DispId(242)]
        //SourceControl SourceControl { get; }
        ////
        //// Summary:
        ////     Gets the EnvDTE.StatusBar object, representing the status bar on the main
        ////     development environment window.
        ////
        //// Returns:
        ////     A EnvDTE.StatusBar object.
        //[DispId(225)]
        //StatusBar StatusBar { get; }
        //
        // Summary:
        //     Gets or sets whether UI should be displayed during the execution of automation
        //     code.
        //
        // Returns:
        //     A Boolean value indicating True if the UI is suppressed, False if not.
        [DispId(243)]
        bool SuppressUI { get; set; }
        ////
        //// Summary:
        ////     Gets the global EnvDTE.UndoContext object.
        ////
        //// Returns:
        ////     A EnvDTE.UndoContext object.
        //[DispId(235)]
        //UndoContext UndoContext { get; }
        //
        // Summary:
        //     Sets or gets a value indicating whether the environment was launched by a
        //     user or by automation.
        //
        // Returns:
        //     true if the environment is running under user control; otherwise, false.
        [DispId(227)]
        bool UserControl { get; set; }
        //
        // Summary:
        //     Gets the host application's version number.
        //
        // Returns:
        //     The host application's version number.
        [DispId(100)]
        string Version { get; }
        ////
        //// Summary:
        ////     Gets the EnvDTE.WindowConfigurations collection, representing all available
        ////     window configurations.
        ////
        //// Returns:
        ////     A EnvDTE.WindowConfigurations collection.
        //[DispId(219)]
        //WindowConfigurations WindowConfigurations { get; }
        ////
        //// Summary:
        ////     Gets a EnvDTE.Windows collection containing the windows that display in the
        ////     object.
        ////
        //// Returns:
        ////     A EnvDTE.Windows collection.
        //[DispId(110)]
        //Windows Windows { get; }

        // Summary:
        //     Executes the specified command.
        //
        // Parameters:
        //   CommandName:
        //     Required. The name of the command to invoke.
        //
        //   CommandArgs:
        //     Optional. A string containing the same arguments you would supply if you
        //     were invoking the command from the Command window. If a string is supplied,
        //     it is passed to the command line as the command's first argument and is parsed
        //     to form the various arguments for the command. This is similar to how commands
        //     are invoked in the Command window.
        [DispId(222)]
        void ExecuteCommand(string CommandName, string CommandArgs = "");
        [DispId(216)]
        //[TypeLibFunc(64)]
        bool get_IsOpenFile(string ViewKind, string FileName);
        [DispId(212)]
        Properties get_Properties(string Category, string Page);
        //
        // Summary:
        //     Gets an interface or object that is late-bound to the EnvDTE.DTE object and
        //     can be accessed by name at run time.
        //
        // Parameters:
        //   Name:
        //     Required. The name of the object to retrieve.
        //
        // Returns:
        //     An interface or object that is late-bound to the EnvDTE.DTE object.
        [DispId(211)]
        object GetObject(string Name);
        //
        // Summary:
        //     Runs a wizard with the supplied parameters.
        //
        // Parameters:
        //   VSZFile:
        //     Required. The .Vsz (wizard) file containing the information required to launch
        //     the wizard.
        //
        //   ContextParams:
        //     Required. The parameters for the wizard. The first parameter is a GUID that
        //     uniquely identifies the launch context as distinct from Add Item or Add Project
        //     or a custom GUID. The remaining arguments are user-defined and their number
        //     and values depend on the wizard.Wizards (or templates) that come with Visual
        //     Studio — such as Visual Basic Windows Application or Visual C# Console Application—have
        //     a required set of context parameters that you must pass to them. For details
        //     on these, see ContextParams Enum. Wizards that you create can have more or
        //     less parameters.
        //
        // Returns:
        //     A EnvDTE.wizardResult object.
        //[DispId(232)]
        //wizardResult LaunchWizard(string VSZFile, ref object[] ContextParams);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   ViewKind:
        //     The kind of view.
        //
        //   FileName:
        //     The name of the file.
        //
        // Returns:
        //     The window in which the file is open.
        [DispId(215)]
        //[TypeLibFunc(64)]
        Window OpenFile(string ViewKind, string FileName);
        //
        // Summary:
        //     Closes the environment.
        [DispId(207)]
        void Quit();
        //
        // Summary:
        //     Returns the computed path to the satellite DLL when given the installation
        //     directory for an Add-in or wizard and the file name of the DLL containing
        //     localized resources.
        //
        // Parameters:
        //   Path:
        //     Required. Specifies the full path to the directory where the Add-in or wizard
        //     is installed.
        //
        //   Name:
        //     Required. The filename for the satellite DLL, such as "MyAddinUI.DLL."
        //
        // Returns:
        //     A string representing the computed path to the satellite DLL.
        [DispId(245)]
        string SatelliteDllPath(string Path, string Name);
    }
}
