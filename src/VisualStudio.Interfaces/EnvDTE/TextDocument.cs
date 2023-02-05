#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a text file open in the editor.
    [Guid("CB218890-1382-472B-9118-782700C88115")]
    //[TypeLibType(4160)]
    public interface TextDocument
    {
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(150)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets a EnvDTE.TextPoint object that is the location of the end of the document.
        //
        // Returns:
        //     A EnvDTE.TextPoint object.
        [DispId(133)]
        TextPoint EndPoint { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The size of the indent.
        [DispId(135)]
        int IndentSize { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     A vsCMLanguage constant.
        [DispId(137)]
        string Language { get; set; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.TextDocument object.
        //
        // Returns:
        //     A EnvDTE.Document object.
        [DispId(151)]
        Document Parent { get; }
        //
        // Summary:
        //     Gets an object representing the current selection on the EnvDTE.TextDocument
        //     object.
        //
        // Returns:
        //     A EnvDTE.TextSelection object.
        [DispId(1)]
        TextSelection Selection { get; }
        //
        // Summary:
        //     Gets the EnvDTE.TextPoint object representing the beginning of the text document,
        //     or the first displayed character of the pane.
        //
        // Returns:
        //     A EnvDTE.TextPoint object.
        [DispId(132)]
        TextPoint StartPoint { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The tab size.
        [DispId(140)]
        int TabSize { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     A EnvDTE.CodeTypeRef object.
        [DispId(145)]
        string Type { get; }

        // Summary:
        //     Removes all unnamed bookmarks in the text document.
        [DispId(122)]
        void ClearBookmarks();
        //
        // Summary:
        //     Creates an EnvDTE.EditPoint object at the specified location and returns
        //     it. The default location is the beginning of the document.
        //
        // Parameters:
        //   TextPoint:
        //     Optional. A EnvDTE.TextPoint object to copy. If a value is supplied to TextPoint,
        //     then the new point is at the same Line and EnvDTE.EditPoint.LineCharOffset
        //     as TextPoint.
        //
        // Returns:
        //     A EnvDTE.EditPoint object.
        [DispId(131)]
        EditPoint CreateEditPoint(TextPoint TextPoint = null);
        //
        // Summary:
        //     Indicates whether or not the indicated text was found in the text document
        //     and creates unnamed bookmarks wherever matching text is found.
        //
        // Parameters:
        //   Pattern:
        //     Required. The text pattern to find.
        //
        //   vsFindOptionsValue:
        //     Optional. A EnvDTE.vsFindOptions constant that specifies the search text
        //     options.
        //
        // Returns:
        //     A Boolean value true if the marked text was found in the text document, otherwise
        //     returns false.
        [DispId(124)]
        bool MarkText(string Pattern, int vsFindOptionsValue = 0);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(134)]
        //[TypeLibFunc(64)]
        void PrintOut();
        ////
        //// Summary:
        ////     Replaces matching text throughout an entire text document.
        ////
        //// Parameters:
        ////   Pattern:
        ////     Required. The string to find.
        ////
        ////   Replace:
        ////     Required. The text to replace each occurrence of Pattern.
        ////
        ////   vsFindOptionsValue:
        ////     Optional. A EnvDTE.vsFindOptions constant indicating the behavior of EnvDTE.TextDocument.ReplacePattern(System.String,System.String,System.Int32,EnvDTE.TextRanges@),
        ////     such as how to search, where to begin the search, whether to search forward
        ////     or backward, and whether the search is case-sensitive.
        ////
        ////   Tags:
        ////     Optional. A EnvDTE.TextRanges collection. If the matched text pattern is
        ////     a regular expression and contains tagged subexpressions, then Tags contains
        ////     a collection of EnvDTE.EditPoint objects, one for each tagged subexpression.
        ////
        //// Returns:
        ////     A Boolean value.
        //[DispId(128)]
        //bool ReplacePattern(string Pattern, string Replace, int vsFindOptionsValue = 0, ref TextRanges Tags = null);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   FindText:
        //     The text to find.
        //
        //   ReplaceText:
        //     The text with which to replace the found text.
        //
        //   vsFindOptionsValue:
        //     The find options.
        //
        // Returns:
        //     A Boolean value.
        [DispId(144)]
        //[TypeLibFunc(64)]
        bool ReplaceText(string FindText, string ReplaceText, int vsFindOptionsValue = 0);
    }
}
