#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Supports general text EnvDTE.Find operations in the environment for documents
    //     and files.
    [Guid("40D4B9B6-739B-4965-8D65-692AEC692266")]
    //[TypeLibType(4160)]
    public interface Find
    {
        //// Summary:
        ////     Gets or sets how to find, such as find next match, find all, replace and
        ////     find, and so forth.
        ////
        //// Returns:
        ////     A EnvDTE.vsFindAction constant representing the type of find action to take.
        //[DispId(3)]
        //vsFindAction Action { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the search is performed backwards
        //     from the current position.
        //
        // Returns:
        //     true if search is performed backwards; otherwise, false.
        [DispId(8)]
        bool Backwards { get; set; }
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
        //     Gets or sets the file extension for the files to be searched.
        //
        // Returns:
        //     The file extension for the files to be searched.
        [DispId(15)]
        string FilesOfType { get; set; }
        //
        // Summary:
        //     Gets or sets the text or pattern to find.
        //
        // Returns:
        //     The text or pattern to find.
        [DispId(4)]
        string FindWhat { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether or not modified documents remain
        //     open after a Replace operation.
        //
        // Returns:
        //     true means the modified document was kept open; false means the modified
        //     document was closed.
        [DispId(10)]
        bool KeepModifiedDocumentsOpen { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the search is case-sensitive.
        //
        // Returns:
        //     true means the search was case-sensitive; false means the search was not
        //     case-sensitive.
        [DispId(5)]
        bool MatchCase { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether hidden text is included in the search.
        //
        // Returns:
        //     true means the search was performed in hidden text; false means the search
        //     was not performed in hidden text.
        [DispId(7)]
        bool MatchInHiddenText { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the search matches whole words only.
        //
        // Returns:
        //     true means the search matched entire words only; false means the search matched
        //     partial as well as entire words.
        [DispId(6)]
        bool MatchWholeWord { get; set; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Find object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(2)]
        DTE Parent { get; }
        ////
        //// Summary:
        ////     Gets or sets the syntax used to specify the search pattern.
        ////
        //// Returns:
        ////     A EnvDTE.vsFindPatternSyntax constant representing the type of syntax used
        ////     for the search pattern.
        //[DispId(11)]
        //vsFindPatternSyntax PatternSyntax { get; set; }
        //
        // Summary:
        //     Gets or sets the replacement text for a replacement operation.
        //
        // Returns:
        //     The text to be used in the replacement operation.
        [DispId(12)]
        string ReplaceWith { get; set; }
        ////
        //// Summary:
        ////     Gets or sets the location where the results are shown in a bulk search operation.
        ////
        //// Returns:
        ////     A EnvDTE.vsFindResultsLocation constant.
        //[DispId(16)]
        //vsFindResultsLocation ResultsLocation { get; set; }
        //
        // Summary:
        //     Gets or sets a list of directories to use for a find-in-files operation.
        //
        // Returns:
        //     The search paths to use for a Find-in-files operation.
        [DispId(14)]
        string SearchPath { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether subfolders are included in a Search
        //     operation.
        //
        // Returns:
        //     true if the search includes subfolders; otherwise, false. The default is
        //     true.
        [DispId(9)]
        bool SearchSubfolders { get; set; }
        ////
        //// Summary:
        ////     Gets or sets the target of the search operation, such as all open docs, files,
        ////     the active document, and so forth.
        ////
        //// Returns:
        ////     A EnvDTE.vsFindTarget constant that indicates the target for the search operation,
        ////     such as the current document or files on disk (or, find-in-files).
        //[DispId(13)]
        //vsFindTarget Target { get; set; }

        //// Summary:
        ////     Performs a search based on the options set for the EnvDTE.Find object.
        ////
        //// Returns:
        ////     A EnvDTE.vsFindResult constant.
        //[DispId(17)]
        //vsFindResult Execute();
        //
        // Summary:
        //     Performs a Find or Replacement operation based on the arguments to the method,
        //     without affecting the options set for the EnvDTE.Find.
        //
        // Parameters:
        //   Action:
        //     Required. A EnvDTE.vsFindAction constant that indicates the search action
        //     to take.
        //
        //   FindWhat:
        //     Optional. The pattern to search for. The default is "".
        //
        //   vsFindOptionsValue:
        //     Optional. A bit field indicating several aspects of the search to perform.For
        //     matching, you can supply EnvDTE.vsFindOptions.vsFindOptionsMatchCase, EnvDTE.vsFindOptions.vsFindOptionsMatchWholeWord,
        //     or EnvDTE.vsFindOptions.vsFindOptionsMatchInHiddenText.Flags that can be
        //     turned on for files, project, and solution targets are EnvDTE.vsFindOptions.vsFindOptionsSearchSubfolders
        //     and EnvDTE.vsFindOptions.vsFindOptionsKeepModifiedDocumentsOpen.Flags for
        //     the EnvDTE.Find.FindWhat property syntax are EnvDTE.vsFindOptions.vsFindOptionsRegularExpression
        //     and EnvDTE.vsFindOptions.vsFindOptionsWildcards. If neither of these is supplied,
        //     then EnvDTE.Find.FindWhat is matched literally.vsFindOptionsValue defaults
        //     to all flags turned off.
        //
        //   ReplaceWith:
        //     Optional. A string with which to replace the matched text when Action is
        //     set to EnvDTE.vsFindAction.vsFindActionReplace or EnvDTE.vsFindAction.vsFindActionReplaceAll.
        //     Default value is "".
        //
        //   Target:
        //     Optional. A EnvDTE.vsFindTarget constant that indicates the target for the
        //     search operation, such as the current document or find-in-files.
        //
        //   SearchPath:
        //     Optional. A semicolon-separated list of directories and file names to search.
        //     The default value is "".
        //
        //   FilesOfType:
        //     Optional. A semicolon-separated list of file types to include in the search.
        //     Other file types encountered in the specified targets are ignored. The default
        //     value is "", meaning all files are searched.
        //
        //   ResultsLocation:
        //     Optional. A EnvDTE.vsFindResultsLocation constant. There are two possible
        //     results lists where EnvDTE.Find results can display. You can perform two
        //     searches without overwriting the results of the first search. Using ResultsLocation,
        //     you can determine the result list in which to place the EnvDTE.Find results.
        //
        // Returns:
        ////     A EnvDTE.vsFindResult constant.
        //[DispId(0)]
        //vsFindResult FindReplace(vsFindAction Action, string FindWhat, int vsFindOptionsValue = 0, string ReplaceWith = "", vsFindTarget Target = vsFindTarget.vsFindTargetCurrentDocument, string SearchPath = "", string FilesOfType = "", vsFindResultsLocation ResultsLocation = vsFindResultsLocation.vsFindResults1);
    }
}
