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
    //     Contains all EnvDTE.Document objects in the environment, each representing
    //     an open document.
    [Guid("9E2CF3EA-140F-413E-BD4B-7D46740CD2F4")]
    //[TypeLibType(4160)]
    public interface Documents : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.Documents collection.
        //
        // Returns:
        //     An integer value indicating the number of objects in the EnvDTE.Documents
        //     collection.
        [DispId(3)]
        int Count { get; }
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
        //     Gets the immediate parent object of a EnvDTE.Documents collection.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(101)]
        DTE Parent { get; }

        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   Kind:
        //     The kind of document.
        //
        // Returns:
        //     The document.
        [DispId(4)]
        //[TypeLibFunc(64)]
        Document Add(string Kind);
        //
        // Summary:
        //     Closes all open documents in the environment and optionally saves them.
        //
        // Parameters:
        //   Save:
        //     Optional. A EnvDTE.vsSaveChanges constant representing how to react to changes
        //     made to documents.
        [DispId(5)]
        void CloseAll(vsSaveChanges Save = vsSaveChanges.vsSaveChangesPrompt);
        //
        // Summary:
        //     Returns an enumerator for items in the collection.
        //
        // Returns:
        //     An enumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns an indexed member of a EnvDTE.Documents collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the item to return.
        //
        // Returns:
        //     A EnvDTE.Document object.
        [DispId(0)]
        Document Item(object index);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   PathName:
        //     The path of the file.
        //
        //   Kind:
        //     The kind of file.
        //
        //   ReadOnly:
        //     Whether or not the file is read-only.
        //
        // Returns:
        //     The document.
        [DispId(7)]
        //[TypeLibFunc(64)]
        Document Open(string PathName, string Kind = "Auto", bool ReadOnly = false);
        //
        // Summary:
        //     Saves all documents currently open in the environment.
        [DispId(6)]
        void SaveAll();
    }
}
