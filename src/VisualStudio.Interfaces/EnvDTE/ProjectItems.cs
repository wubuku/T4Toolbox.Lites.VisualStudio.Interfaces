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
    //     Contains EnvDTE.ProjectItem objects, each representing items in the project.
    [Guid("8E2F1269-185E-43C7-8899-950AD2769CCF")]
    //[TypeLibType(4160)]
    public interface ProjectItems : IEnumerable
    {
        // Summary:
        //     Gets the project hosting the project item or items.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(205)]
        Project ContainingProject { get; }
        //
        // Summary:
        //     Gets a value indicating the number of objects in the collection.
        //
        // Returns:
        //     An integer value indicating the number of objects in the collection.
        [DispId(10)]
        int Count { get; }
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
        //     Gets an enumeration indicating the type of object.
        //
        // Returns:
        //     A EnvDTE.vsCMElement value.
        [DispId(201)]
        string Kind { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.ProjectItems collection.
        //
        // Returns:
        //     An object.
        [DispId(2)]
        object Parent { get; }

        // Summary:
        //     Creates a new folder in Solution Explorer.
        //
        // Parameters:
        //   Name:
        //     Required. The name of the folder node in Solution Explorer.
        //
        //   Kind:
        //     Optional. The type of folder to add.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(206)]
        ProjectItem AddFolder(string Name, string Kind = "{6BB5F8EF-4483-11D3-8BCF-00C04F8EC28C}");
        //
        // Summary:
        //     Adds one or more EnvDTE.ProjectItem objects from a directory to the EnvDTE.ProjectItems
        //     collection.
        //
        // Parameters:
        //   Directory:
        //     Required. The directory from which to add the project item.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(204)]
        ProjectItem AddFromDirectory(string Directory);
        //
        // Summary:
        //     Adds a project item from a file that is installed in a project directory
        //     structure.
        //
        // Parameters:
        //   FileName:
        //     Required. The file name of the item to add as a project item.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(202)]
        ProjectItem AddFromFile(string FileName);
        //
        // Summary:
        //     Copies a source file and adds it to the project.
        //
        // Parameters:
        //   FilePath:
        //     Required. The path and file name of the project item to be added.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(207)]
        ProjectItem AddFromFileCopy(string FilePath);
        //
        // Summary:
        //     Creates a new project item from an existing item template file and adds it
        //     to the project.
        //
        // Parameters:
        //   FileName:
        //     Required. The full path and file name of the template project file.
        //
        //   Name:
        //     Required. The file name to use for the new project item.
        //
        // Returns:
        //     A null reference.
        [DispId(203)]
        ProjectItem AddFromTemplate(string FileName, string Name);
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
        //     Returns a EnvDTE.ProjectItem object in a EnvDTE.ProjectItems collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.ProjectItem object to return.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(0)]
        ProjectItem Item(object index);
    }
}
