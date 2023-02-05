#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Allows you to manipulate text as data in text buffers.
    [Guid("C1FFE800-028B-4475-A907-14F51F19BB7D")]
    //[TypeLibType(4160)]
    public interface EditPoint : TextPoint
    {
        // Summary:
        //     Gets the one-based character offset of the EnvDTE.EditPoint object.
        //
        // Returns:
        //     The one-based character offset from the beginning of the document to the
        //     EnvDTE.EditPoint object.
        [DispId(13)]
        int AbsoluteCharOffset { get; }
        //
        // Summary:
        //     Gets a value indicating whether or not the object is at the end of the document.
        //
        // Returns:
        //     true if you are at the end of the document; otherwise, false.
        [DispId(21)]
        bool AtEndOfDocument { get; }
        //
        // Summary:
        //     Gets a value indicating whether or not the object is at the end of a line.
        //
        // Returns:
        //     true if you are at the end of a line; otherwise, false.
        [DispId(23)]
        bool AtEndOfLine { get; }
        //
        // Summary:
        //     Gets a value indicating whether or not the object is at the beginning of
        //     the document.
        //
        // Returns:
        //     true if you are at the start of a document; otherwise, false.
        [DispId(22)]
        bool AtStartOfDocument { get; }
        //
        // Summary:
        //     Gets a value indicating whether or not the EnvDTE.EditPoint object is at
        //     the beginning of a line.
        //
        // Returns:
        //     true if you are at the start of a line; otherwise, False if otherwise.
        [DispId(24)]
        bool AtStartOfLine { get; }
        //
        // Summary:
        //     Gets the number of the column number of the EnvDTE.EditPoint object.
        //
        // Returns:
        //     The number of the currently displayed column containing the EnvDTE.EditPoint
        //     object.
        [DispId(14)]
        int DisplayColumn { get; }
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
        //     Gets the EnvDTE.EditPoint object's line number.
        //
        // Returns:
        //     The line number of the EnvDTE.EditPoint object.
        [DispId(11)]
        int Line { get; }
        //
        // Summary:
        //     Gets the character offset of the EnvDTE.EditPoint object.
        //
        // Returns:
        //     An integer value indicating the character offset of the EnvDTE.EditPoint
        //     object.
        [DispId(12)]
        int LineCharOffset { get; }
        //
        // Summary:
        //     Gets the number of characters in a line.
        //
        // Returns:
        //     The number of characters in a line containing the EnvDTE.EditPoint object,
        //     excluding the new line character.
        [DispId(25)]
        int LineLength { get; }
        //
        // Summary:
        //     Gets the immediate parent object of the EnvDTE.EditPoint object.
        //
        // Returns:
        //     A EnvDTE.TextDocument object.
        [DispId(2)]
        TextDocument Parent { get; }

        // Summary:
        //     Changes the case of the selected text.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Either a EnvDTE.TextPoint object or a number of characters.
        //
        //   How:
        //     Required. A EnvDTE.vsCaseOptions constant indicating the case of the text.
        [DispId(165)]
        void ChangeCase(object PointOrCount, vsCaseOptions How);
        //
        // Summary:
        //     Moves the edit point the specified number of characters to the left.
        //
        // Parameters:
        //   Count:
        //     Optional. The number of characters to move to the left. The default is 1
        //     character.
        [DispId(101)]
        void CharLeft(int Count = 1);
        //
        // Summary:
        //     Moves the edit point the specified number of characters to the right.
        //
        // Parameters:
        //   Count:
        //     Optional. The number of characters to move to the right. The default is one
        //     character.
        [DispId(102)]
        void CharRight(int Count = 1);
        //
        // Summary:
        //     Clears any unnamed bookmarks in the current text buffer line.
        [DispId(122)]
        void ClearBookmark();
        //
        // Summary:
        //     Copies the specified range of text to the clipboard.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Either a EnvDTE.TextPoint object or a number of characters.
        //
        //   Append:
        //     Optional. Indicates whether to append the selected text to the clipboard.
        //     The default is false.
        [DispId(136)]
        void Copy(object PointOrCount, bool Append = false);
        //
        // Summary:
        //     Creates and returns an EnvDTE.EditPoint object at the location of the calling
        //     object.
        //
        // Returns:
        //     A EnvDTE.EditPoint object.
        [DispId(34)]
        EditPoint CreateEditPoint();
        //
        // Summary:
        //     Copies the specified range of text to the clipboard and deletes it from the
        //     document.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Either a EnvDTE.TextPoint object or a number of characters.
        //
        //   Append:
        //     Optional. Indicates whether to append the selected text to the clipboard.
        //     The default is false.
        [DispId(137)]
        void Cut(object PointOrCount, bool Append = false);
        //
        // Summary:
        //     Deletes the specified range of text.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Represents either a EnvDTE.TextPoint object or a number of characters.
        [DispId(135)]
        void Delete(object PointOrCount);
        //
        // Summary:
        //     Deletes the empty characters (white space) horizontally or vertically around
        //     the current location in the text buffer.
        //
        // Parameters:
        //   Direction:
        //     Optional. A EnvDTE.vsWhitespaceOptions constant that determines how and where
        //     to remove empty spaces.
        [DispId(166)]
        void DeleteWhitespace(vsWhitespaceOptions Direction = vsWhitespaceOptions.vsWhitespaceOptionsHorizontal);
        //
        // Summary:
        //     Moves the edit point to the end of the document.
        [DispId(105)]
        void EndOfDocument();
        //
        // Summary:
        //     Moves the edit point to the end of the current line in the buffer.
        [DispId(103)]
        void EndOfLine();
        //
        // Summary:
        //     Returns a value indicating whether the value of the given point object's
        //     EnvDTE.EditPoint.AbsoluteCharOffset is equal to that of the calling EnvDTE.EditPoint
        //     object.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint object to compare to the calling EnvDTE.EditPoint
        //     point object.
        //
        // Returns:
        //     true if Point has the same EnvDTE.TextPoint.AbsoluteCharOffset property value
        //     as the calling EnvDTE.EditPoint point object; otherwise, false.
        [DispId(31)]
        bool EqualTo(TextPoint Point);
        ////
        //// Summary:
        ////     Finds a given matching pattern in the selected text.
        ////
        //// Parameters:
        ////   Pattern:
        ////     Required. The text you want to find.
        ////
        ////   vsFindOptionsValue:
        ////     Optional. A EnvDTE.vsFindOptions constant indicating the type of search to
        ////     perform. The EnvDTE.vsFindOptions.vsFindOptionsMatchInHiddenText constant
        ////     value does not apply to this method because EnvDTE.EditPoint.FindPattern(System.String,System.Int32,EnvDTE.EditPoint@,EnvDTE.TextRanges@)
        ////     searches all text, including hidden text.
        ////
        ////   EndPoint:
        ////     Optional. An EnvDTE.EditPoint object representing the point that is to be
        ////     moved to the end of the matched pattern.
        ////
        ////   Tags:
        ////     Optional. If the matched pattern is a regular expression containing tagged
        ////     subexpressions, then the Tags argument contains a collection of EnvDTE.TextRange
        ////     objects, one for each tagged subexpression.
        ////
        //// Returns:
        ////     true if the pattern is found; otherwise, false.
        //[DispId(151)]
        //bool FindPattern(string Pattern, int vsFindOptionsValue = 0, ref EditPoint EndPoint = null, ref TextRanges Tags = null);
        //[DispId(51)]
        //CodeElement get_CodeElement(vsCMElement Scope);
        //
        // Summary:
        //     Gets a string representing the text between two given lines.
        //
        // Parameters:
        //   Start:
        //     Optional. The last line number to include the text.
        //
        //   ExclusiveEnd:
        //     Required. The first line number to include the text.
        //
        // Returns:
        //     The text between two given lines.
        [DispId(173)]
        string GetLines(int Start, int ExclusiveEnd);
        //
        // Summary:
        //     Gets the text between the current location and the specified location in
        //     the buffer.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Either a EnvDTE.TextPoint object or a number of characters.
        //
        // Returns:
        //     A string of text located between the current location and the specified location
        //     in the buffer.
        [DispId(134)]
        string GetText(object PointOrCount);
        //
        // Summary:
        //     Returns whether the value of the EnvDTE.EditPoint object's EnvDTE.EditPoint.AbsoluteCharOffset
        //     property is greater than that of the given EnvDTE.TextPoint object.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint to compare to the calling point object.
        //
        // Returns:
        //     true if Point has a smaller EnvDTE.TextPoint.AbsoluteCharOffset property
        //     value compared to the calling EnvDTE.EditPoint object's EnvDTE.EditPoint.AbsoluteCharOffset
        //     property; otherwise, false.
        [DispId(33)]
        bool GreaterThan(TextPoint Point);
        //
        // Summary:
        //     Indents the selected lines by the given number of indentation levels.
        //
        // Parameters:
        //   Point:
        //     Optional. A EnvDTE.TextPoint object endpoint for indentation. The default
        //     is the current line in the buffer, causing the current line in the buffer
        //     to be indented.
        //
        //   Count:
        //     Optional. The number of displayed columns to indent the lines. The default
        //     value is 1.
        [DispId(161)]
        void Indent(TextPoint Point = null, int Count = 1);
        //
        // Summary:
        //     Inserts the given string at the edit point's current position in the buffer.
        //
        // Parameters:
        //   Text:
        //     Required. The text to insert into the text buffer. Must be a Unicode string.
        [DispId(132)]
        void Insert(string Text);
        //
        // Summary:
        //     Inserts the contents of the specified file at the current location in the
        //     buffer.
        //
        // Parameters:
        //   File:
        //     Required. The name of the file to insert into the text buffer.
        [DispId(133)]
        void InsertFromFile(string File);
        //
        // Summary:
        //     Returns whether the value of the called EnvDTE.EditPoint object's EnvDTE.EditPoint.AbsoluteCharOffset
        //     is less than that of the given EnvDTE.TextPoint object.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint to compare to the calling point object.
        //
        // Returns:
        //     A Boolean value indicating true if Point has a greater EnvDTE.TextPoint.AbsoluteCharOffset
        //     property value compared to the calling point object's EnvDTE.EditPoint.AbsoluteCharOffset
        //     property.
        [DispId(32)]
        bool LessThan(TextPoint Point);
        //
        // Summary:
        //     Moves the edit point down the specified number of lines.
        //
        // Parameters:
        //   Count:
        //     Optional. The number of lines to move the edit point. The default is 1.
        [DispId(110)]
        void LineDown(int Count = 1);
        //
        // Summary:
        //     Moves the edit point up the specified number of lines.
        //
        // Parameters:
        //   Count:
        //     Optional. The number of lines to move the edit point. The default is 1.
        [DispId(109)]
        void LineUp(int Count = 1);
        //
        // Summary:
        //     Moves the active point to the given 1-based absolute character offset.
        //
        // Parameters:
        //   Offset:
        //     Required. A character index from the start of the document, beginning at
        //     one.
        [DispId(172)]
        void MoveToAbsoluteOffset(int Offset);
        //
        // Summary:
        //     Moves the document to the specified line and character offset position in
        //     that line.
        //
        // Parameters:
        //   Line:
        //     Required. The line number, starting at one. Line may also be one of the constants
        //     from EnvDTE.vsGoToLineOptions.
        //
        //   Offset:
        //     Required. The character index position in the line, starting at one.
        [DispId(171)]
        void MoveToLineAndOffset(int Line, int Offset);
        //
        // Summary:
        //     Moves the active point to the given position.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint object representing the location in which to
        //     move the character.
        [DispId(170)]
        void MoveToPoint(TextPoint Point);
        //
        // Summary:
        //     Moves to the location of the next bookmark in the document.
        //
        // Returns:
        //     true if the insertion point moves to the next bookmark; otherwise, false.
        [DispId(123)]
        bool NextBookmark();
        //
        // Summary:
        //     Creates an outlining section based on an edit point and the given text point
        //     or value.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Either a EnvDTE.TextPoint object or an integer representing the
        //     number of characters.
        [DispId(167)]
        void OutlineSection(object PointOrCount);
        //
        // Summary:
        //     Fills the current line in the buffer with empty characters (white space)
        //     to the given column.
        //
        // Parameters:
        //   Column:
        //     Required. The number of columns to pad, starting at one.
        [DispId(131)]
        void PadToColumn(int Column);
        //
        // Summary:
        //     Inserts the clipboard contents at the current location.
        [DispId(138)]
        void Paste();
        //
        // Summary:
        //     Moves the edit point to the location of the previous bookmark in the document.
        //
        // Returns:
        //     A Boolean value indicating true if the edit point moves to a previous bookmark,
        //     false if not.
        [DispId(124)]
        bool PreviousBookmark();
        //
        // Summary:
        //     Returns a value indicating whether any of the specified range contains read-only
        //     text.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Either a EnvDTE.TextPoint object or a number of characters.
        //
        // Returns:
        //     true if the selection contains read-only text; otherwise, false.
        [DispId(139)]
        bool ReadOnly(object PointOrCount);
        ////
        //// Summary:
        ////     Finds a pattern in the specified range of text and replaces it with the specified
        ////     text.
        ////
        //// Parameters:
        ////   Point:
        ////     Required. The endpoint of the specified range of text. The edit point and
        ////     Point are the boundaries for replacement.
        ////
        ////   Pattern:
        ////     Required. The string to find.
        ////
        ////   Replace:
        ////     Required. The replacement string for Pattern.
        ////
        ////   vsFindOptionsValue:
        ////     Optional. A EnvDTE.vsFindOptions constant indicating the type of search to
        ////     perform.
        ////
        ////   Tags:
        ////     Optional. If the matched pattern is a regular expression containing tagged
        ////     sub-expressions, then Tags contains a collection of EnvDTE.TextRange objects,
        ////     one for each tagged subexpression.
        ////
        //// Returns:
        ////     true if replacement occurs successfully; otherwise, false.
        //[DispId(152)]
        //bool ReplacePattern(TextPoint Point, string Pattern, string Replace, int vsFindOptionsValue = 0, ref TextRanges Tags = null);
        //
        // Summary:
        //     Replaces the selected text with the given text.
        //
        // Parameters:
        //   PointOrCount:
        //     Required. Either a EnvDTE.TextPoint object or an integer that determines
        //     the text to replace.
        //
        //   Text:
        //     Required. The text to insert.
        //
        //   Flags:
        //     Required. A EnvDTE.vsEPReplaceTextOptions constant representing an editor
        //     action.
        [DispId(164)]
        void ReplaceText(object PointOrCount, string Text, int Flags);
        //
        // Summary:
        //     Sets an unnamed bookmark on the current line in the buffer.
        [DispId(121)]
        void SetBookmark();
        //
        // Summary:
        //     Formats the specified range of text based on the current language.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint object representing the end of the specified
        //     range of text.
        [DispId(163)]
        void SmartFormat(TextPoint Point);
        //
        // Summary:
        //     Moves the object to the beginning of the document.
        [DispId(106)]
        void StartOfDocument();
        //
        // Summary:
        //     Moves the edit point to the beginning of the current line in the buffer.
        [DispId(104)]
        void StartOfLine();
        ////
        //// Summary:
        ////     Attempts to display the text point's location.
        ////
        //// Parameters:
        ////   How:
        ////     Optional. A EnvDTE.vsPaneShowHow constant that determines how the code is
        ////     displayed.
        ////
        ////   PointOrCount:
        ////     Optional. The endpoint of the selected range of text to be displayed. It
        ////     can be either a EnvDTE.TextPoint or an integer.
        ////
        //// Returns:
        ////     true if the span of text fits within the current code editor; otherwise,
        ////     false.
        //[DispId(50)]
        //bool TryToShow(vsPaneShowHow How = vsPaneShowHow.vsPaneShowCentered, object PointOrCount = Type.Missing);
        //
        // Summary:
        //     Removes the indent characters from the selected lines by the given number
        //     of indentation levels.
        //
        // Parameters:
        //   Point:
        //     Optional. The endpoint. Defaults to the endpoint, causing the current line
        //     in the buffer to be outdented. The default value is one indentation level.
        //
        //   Count:
        //     Optional. The number of display columns to indent each line. The default
        //     is 1.
        [DispId(162)]
        void Unindent(TextPoint Point = null, int Count = 1);
        //
        // Summary:
        //     Moves the object the specified number of words to the left.
        //
        // Parameters:
        //   Count:
        //     Optional. Specifies how many words to move the edit point to the left of
        //     its current position in the buffer.
        [DispId(107)]
        void WordLeft(int Count = 1);
        //
        // Summary:
        //     Moves the object the specified number of words to the right.
        //
        // Parameters:
        //   Count:
        //     Optional. The number of words to move the edit point to the right of its
        //     current position in the buffer.
        [DispId(108)]
        void WordRight(int Count = 1);
    }
}
