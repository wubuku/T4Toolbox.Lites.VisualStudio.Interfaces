#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a project in the integrated development environment (IDE).
    [Guid("866311E6-C887-4143-9833-645F5B93F6F1")]
    //[TypeLibType(4160)]
    public interface Project
    {
        // Summary:
        //     Gets the EnvDTE.CodeModel object for the project.
        //
        // Returns:
        //     A EnvDTE.CodeModel object.
        [DispId(217)]
        CodeModel CodeModel { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Projects collection containing the EnvDTE.Project object
        //     supporting this property.
        //
        // Returns:
        //     A EnvDTE.Projects collection.
        [DispId(123)]
        Projects Collection { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ConfigurationManager object for this EnvDTE.Project .
        //
        // Returns:
        //     A EnvDTE.ConfigurationManager object.
        [DispId(213)]
        ConfigurationManager ConfigurationManager { get; }
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
        //     Gets the Extender category ID (CATID) for the object.
        //
        // Returns:
        //     A string representing the CATID of the object in GUID form.
        [DispId(208)]
        string ExtenderCATID { get; }
        //
        // Summary:
        //     Gets a list of available Extenders for the object.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(207)]
        object ExtenderNames { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(109)]
        string FileName { get; }
        //
        // Summary:
        //     Gets the full path and name of the EnvDTE.Project object's file.
        //
        // Returns:
        //     A string representing the full path and name of the EnvDTE.Project object's
        //     file.
        [DispId(209)]
        string FullName { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Globals object containing add-in values that may be saved
        //     in the solution (.sln) file, the project file, or in the user's profile data.
        //
        // Returns:
        //     A EnvDTE.Globals object.
        [DispId(214)]
        Globals Globals { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(110)]
        bool IsDirty { get; set; }
        //
        // Summary:
        //     Gets a GUID string indicating the kind or type of the object.
        //
        // Returns:
        //     A GUID string representing the type of object.
        [DispId(201)]
        string Kind { get; }
        //
        // Summary:
        //     Gets or sets the name of the object.
        //
        // Returns:
        //     A string representing the name of the object.
        [DispId(0)]
        string Name { get; set; }
        //
        // Summary:
        //     Gets an interface or object that can be accessed by name at run time.
        //
        // Returns:
        //     An object.
        [DispId(205)]
        object Object { get; }
        //
        // Summary:
        //     Gets a EnvDTE.ProjectItem object for the nested project in the host project.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(216)]
        ProjectItem ParentProjectItem { get; }
        //
        // Summary:
        //     Gets a EnvDTE.ProjectItems collection for the EnvDTE.Project object.
        //
        // Returns:
        //     A EnvDTE.ProjectItems collection.
        [DispId(202)]
        ProjectItems ProjectItems { get; }
        //
        // Summary:
        //     Gets a collection of all properties that pertain to the EnvDTE.Project object.
        //
        // Returns:
        //     A EnvDTE.Properties collection.
        [DispId(203)]
        Properties Properties { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the object has not been modified
        //     since last being saved or opened.
        //
        // Returns:
        //     A Boolean value indicating true (default) if the object has not been modified
        //     since last being saved or opened; false if otherwise.
        [DispId(210)]
        bool Saved { get; set; }
        //
        // Summary:
        //     Gets a unique string value that allows you to differentiate between similarly
        //     named projects.
        //
        // Returns:
        //     A string representing a unique value that is used to differentiate between
        //     similarly named projects.
        [DispId(204)]
        string UniqueName { get; }

        // Summary:
        //     Removes the project from the current solution.
        [DispId(218)]
        void Delete();
        [DispId(206)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
        //
        // Summary:
        //     Saves the project or project item.
        //
        // Parameters:
        //   FileName:
        //     Optional. The name in which to save the project or project item.
        [DispId(215)]
        void Save(string FileName = "");
        //
        // Summary:
        //     Saves the solution, project, or project item.
        //
        // Parameters:
        //   NewFileName:
        //     Required. The file name with which to save the solution, project, or project
        //     item. If the file exists, it is overwritten.
        [DispId(127)]
        void SaveAs(string NewFileName);
    }
}
