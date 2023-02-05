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
    //     Represents all projects and solution-wide properties in the integrated development
    //     environment (IDE). Refer to EnvDTE.Solution for this functionality. Do not
    //     instantiate from this class.
    [Guid("26F6CC4B-7A48-4E4D-8AF5-9E960232E05F")]
    //[TypeLibType(4160)]
    public interface _Solution : IEnumerable
    {
        // Summary:
        //     Gets an EnvDTE.AddIns collection, which contains all currently available
        //     add-ins associated with the solution.
        //
        // Returns:
        //     An EnvDTE.AddIns collection.
        [DispId(32)]
        AddIns AddIns { get; }
        //
        // Summary:
        //     Gets a value indicating the number of objects in the collection.
        //
        // Returns:
        //     The number of objects in the collection.
        [DispId(12)]
        int Count { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(10)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the Extender category ID (CATID) for the object.
        //
        // Returns:
        //     A GUID representing the CATID of the object.
        [DispId(35)]
        string ExtenderCATID { get; }
        //
        // Summary:
        //     Gets a list of available Extenders for the object.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(34)]
        object ExtenderNames { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The file name.
        [DispId(13)]
        string FileName { get; }
        //
        // Summary:
        //     Gets the full path and name of the object's file.
        //
        // Returns:
        //     The full path and name of the object's file.
        [DispId(28)]
        string FullName { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Globals that contains add-in values that may be saved in
        //     the solution (.sln) file, the project file, or in the user's profile data.
        //
        // Returns:
        //     A EnvDTE.Globals object.
        [DispId(31)]
        Globals Globals { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     true if the solution is dirty; otherwise, false.
        [DispId(22)]
        bool IsDirty { get; set; }
        //
        // Summary:
        //     Determines if a solution is open.
        //
        // Returns:
        //     true if a solution is open; otherwise, false.
        [DispId(36)]
        bool IsOpen { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE._Solution.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(11)]
        DTE Parent { get; }
        //
        // Summary:
        //     Gets a collection of the projects currently in the solution.
        //
        // Returns:
        //     A EnvDTE.Projects collection.
        [DispId(41)]
        Projects Projects { get; }
        //
        // Summary:
        //     Gets a collection of all properties that pertain to the EnvDTE._Solution.
        //
        // Returns:
        //     A EnvDTE.Properties collection.
        [DispId(19)]
        Properties Properties { get; }
        //
        // Summary:
        //     Returns true if the object has not been modified since last being saved or
        //     opened.
        //
        // Returns:
        //     A Boolean value indicating true (default) if the object has not been modified
        //     since last being saved or opened; false if otherwise.
        [DispId(29)]
        bool Saved { get; set; }
        //
        // Summary:
        //     Gets the EnvDTE.SolutionBuild object for the solution, which represents the
        //     root of the build automation model at the solution level.
        //
        // Returns:
        //     A EnvDTE.SolutionBuild object.
        [DispId(38)]
        SolutionBuild SolutionBuild { get; }

        // Summary:
        //     Adds a project to the solution, based on a project file already stored in
        //     the system.
        //
        // Parameters:
        //   FileName:
        //     Required. The full path and file name of the project file.
        //
        //   Exclusive:
        //     Optional. Indicates whether the project loads in the current solution or
        //     its own; true if the current solution is closed and the project is added
        //     to a new solution, false if the project is added to the existing open solution.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(16)]
        Project AddFromFile(string FileName, bool Exclusive = false);
        //
        // Summary:
        //     Copies an existing project file, and any items or subdirectories it contains,
        //     to the specified location and adds it to the solution.
        //
        // Parameters:
        //   FileName:
        //     Required. The full path and file name with extension of the template project
        //     file.
        //
        //   Destination:
        //     Required. The full path of the directory in which to copy the contents of
        //     FileName.
        //
        //   ProjectName:
        //     Required. The name of the project file in the destination directory. This
        //     should include the extension. The name displayed is derived from ProjectName.
        //
        //   Exclusive:
        //     Optional. Indicates whether the project loads in the current solution or
        //     its own; true if the current solution is closed and the project is added
        //     to a new solution, false if the project is added to the existing open solution.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(15)]
        Project AddFromTemplate(string FileName, string Destination, string ProjectName, bool Exclusive = false);
        //
        // Summary:
        //     Closes the current solution.
        //
        // Parameters:
        //   SaveFirst:
        //     Indicates whether to save the solution before closing it; true if the solution
        //     should be saved prior to closing it, false if not.
        [DispId(18)]
        void Close(bool SaveFirst = false);
        //
        // Summary:
        //     Creates an empty solution in the specified directory with the specified name.
        //
        // Parameters:
        //   Destination:
        //     Required. The directory in which to create the .sln and .suo (solution) files.
        //
        //   Name:
        //     Required. The name to display in Solution Explorer. This is also the base
        //     name of the .sln and .suo files.
        [DispId(40)]
        void Create(string Destination, string Name);
        //
        // Summary:
        //     Locates an item in a project.
        //
        // Parameters:
        //   FileName:
        //     Required. The name of the project item.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(42)]
        ProjectItem FindProjectItem(string FileName);
        [DispId(33)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
        [DispId(26)]
        string get_TemplatePath(string ProjectType);
        //
        // Summary:
        //     Returns an enumeration for items in a collection.
        //
        // Returns:
        //     An enumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns a EnvDTE.Project object in a EnvDTE.Projects collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.Project object to return.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(0)]
        Project Item(object index);
        //
        // Summary:
        //     Opens the solution in the specified view.
        //
        // Parameters:
        //   FileName:
        //     Required. The filename of the file to open.
        [DispId(17)]
        void Open(string FileName);
        //
        // Summary:
        //     Returns the location of project item templates for the specified project
        //     type.
        //
        // Parameters:
        //   ProjectKind:
        //     Required. The EnvDTE.Constants.vsProjectKind* project template representing
        //     the project type.
        //
        // Returns:
        //     The path to the templates of the given project type.
        [DispId(43)]
        string ProjectItemsTemplatePath(string ProjectKind);
        //
        // Summary:
        //     Removes the specified project from the solution.
        //
        // Parameters:
        //   proj:
        //     Required. The project to remove from the solution.
        [DispId(25)]
        void Remove(Project proj);
        //
        // Summary:
        //     Saves the solution.
        //
        // Parameters:
        //   FileName:
        //     Required. The filename in which to save the solution. If the file exists,
        //     it is overwritten.
        [DispId(14)]
        void SaveAs(string FileName);
    }
}
