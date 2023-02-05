#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents an item in a project.
    [Guid("0B48100A-473E-433C-AB8F-66B9739AB620")]
    //[TypeLibType(4160)]
    public interface ProjectItem
    {
        // Summary:
        //     Gets the EnvDTE.ProjectItems collection containing the EnvDTE.ProjectItem
        //     object supporting this property.
        //
        // Returns:
        //     A EnvDTE.ProjectItems collection.
        [DispId(54)]
        ProjectItems Collection { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ConfigurationManager object for this EnvDTE.ProjectItem.
        //
        // Returns:
        //     A EnvDTE.ConfigurationManager object.
        [DispId(116)]
        ConfigurationManager ConfigurationManager { get; }
        //
        // Summary:
        //     Gets the project hosting the EnvDTE.ProjectItem.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(121)]
        Project ContainingProject { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Document associated with the item, if one exists.
        //
        // Returns:
        //     A EnvDTE.Document object.
        [DispId(119)]
        Document Document { get; }
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
        [DispId(111)]
        string ExtenderCATID { get; }
        //
        // Summary:
        //     Gets a list of available Extenders for the object.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(110)]
        object ExtenderNames { get; }
        //
        // Summary:
        //     Gets the EnvDTE.FileCodeModel object for the project item.
        //
        // Returns:
        //     A EnvDTE.FileCodeModel object.
        [DispId(117)]
        FileCodeModel FileCodeModel { get; }
        //
        // Summary:
        //     Gets the number of files associated with a EnvDTE.ProjectItem.
        //
        // Returns:
        //     A short integer indicating the number of files associated with a EnvDTE.ProjectItem.
        [DispId(13)]
        short FileCount { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(10)]
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
        //     Gets an object that can be accessed by name at run time.
        //
        // Returns:
        //     An object that can be accessed by name at run time.
        [DispId(108)]
        object Object { get; }
        //
        // Summary:
        //     Gets a EnvDTE.ProjectItems for the object.
        //
        // Returns:
        //     A EnvDTE.ProjectItems collection.
        [DispId(203)]
        ProjectItems ProjectItems { get; }
        //
        // Summary:
        //     Gets a collection of all properties that pertain to the object.
        //
        // Returns:
        //     A EnvDTE.Properties collection.
        [DispId(56)]
        Properties Properties { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether or not the object has been modified
        //     since last being saved or opened.
        //
        // Returns:
        //     A Boolean value indicating true (default) if the object has not been modified
        //     since last being saved or opened; false if otherwise.
        [DispId(113)]
        bool Saved { get; set; }
        //
        // Summary:
        //     If the project item is the root of a subproject, then the EnvDTE.ProjectItem.SubProject
        //     property returns the EnvDTE.Project object for the subproject.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(120)]
        Project SubProject { get; }

        // Summary:
        //     Removes the item from its project and its storage.
        [DispId(122)]
        void Delete();
        //
        // Summary:
        //     Expands the view of Solution Explorer to show project items.
        [DispId(107)]
        void ExpandView();
        [DispId(109)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
        [DispId(11)]
        string get_FileNames(short index);
        [DispId(204)]
        bool get_IsOpen(string ViewKind = "{FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF}");
        //
        // Summary:
        //     Opens the EnvDTE.ProjectItem in the specified view.
        //
        // Parameters:
        //   ViewKind:
        //     Required. A EnvDTE.Constants. vsViewKind indicating the type of view to use.
        //
        // Returns:
        //     A EnvDTE.Window object.
        [DispId(205)]
        Window Open(string ViewKind = "{00000000-0000-0000-0000-000000000000}");
        //
        // Summary:
        //     Removes the project item from the collection.
        [DispId(206)]
        void Remove();
        //
        // Summary:
        //     Saves the project or project item.
        //
        // Parameters:
        //   FileName:
        //     Optional. The name with which to save the project or project item.
        [DispId(118)]
        void Save(string FileName = "");
        //
        // Summary:
        //     Saves the project item.
        //
        // Parameters:
        //   NewFileName:
        //     Required. The file name with which to save the solution, project, or project
        //     item. If the file exists, it is overwritten.
        //
        // Returns:
        //     A Boolean value indicating true if the project item was saved; otherwise,
        //     false.
        [DispId(12)]
        bool SaveAs(string NewFileName);
    }
}
