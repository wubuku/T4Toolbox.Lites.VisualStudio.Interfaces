#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Provides access to view-based editing operations and selected text.
    [Guid("1FA0E135-399A-4D2C-A4FE-D21E2480F921")]
    //[TypeLibType(4160)]
    public interface TextSelection
    {
        // Summary:
        //     Gets the current endpoint of the selection.
        //
        // Returns:
        //     A EnvDTE.VirtualPoint object.
        [DispId(4)]
        VirtualPoint ActivePoint { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The anchor column
        [DispId(5)]
        int AnchorColumn { get; }
        //
        // Summary:
        //     Gets the origin point of the selection.
        //
        // Returns:
        //     A EnvDTE.VirtualPoint object.
        [DispId(3)]
        VirtualPoint AnchorPoint { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The bottom line.
        [DispId(6)]
        int BottomLine { get; }
        //
        // Summary:
        //     Gets the point at the end of the selection.
        //
        // Returns:
        //     A EnvDTE.VirtualPoint object.
        [DispId(7)]
        VirtualPoint BottomPoint { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The current column.
        [DispId(8)]
        int CurrentColumn { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The current line.
        [DispId(9)]
        int CurrentLine { get; }
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
        //     Gets whether the active point is equal to the bottom point.
        //
        // Returns:
        //     A Boolean value indicating True if the selected text's active end is at a
        //     greater absolute character offset than the anchor in the text document, False
        //     if not.
        [DispId(11)]
        bool IsActiveEndGreater { get; }
        //
        // Summary:
        //     Gets whether the anchor point is equal to the active point.
        //
        // Returns:
        //     A Boolean value indicating True if the anchor point is equal to the active
        //     point, False if not.
        [DispId(10)]
        bool IsEmpty { get; }
        ////
        //// Summary:
        ////     Sets or gets a value determining whether dragging the mouse selects in stream
        ////     or block mode.
        ////
        //// Returns:
        ////     A EnvDTE.vsSelectionMode constant.
        //[DispId(55)]
        //vsSelectionMode Mode { get; set; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.TextSelection object.
        //
        // Returns:
        //     A EnvDTE.TextDocument object.
        [DispId(2)]
        TextDocument Parent { get; }
        //
        // Summary:
        //     Sets or gets the selected text.
        //
        // Returns:
        //     A string representing the selected text.
        [DispId(0)]
        string Text { get; set; }
        ////
        //// Summary:
        ////     Gets the text pane that contains the selected text.
        ////
        //// Returns:
        ////     A EnvDTE.TextPane object.
        //[DispId(54)]
        //TextPane TextPane { get; }
        ////
        //// Summary:
        ////     Gets a EnvDTE.TextRanges collection with one EnvDTE.TextRange object for
        ////     each line or partial line in the selection.
        ////
        //// Returns:
        ////     A EnvDTE.TextRanges collection.
        //[DispId(56)]
        //TextRanges TextRanges { get; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Returns:
        //     The top line.
        [DispId(13)]
        int TopLine { get; }
        //
        // Summary:
        //     Gets the top end of the selection.
        //
        // Returns:
        //     A EnvDTE.VirtualPoint object.
        [DispId(14)]
        VirtualPoint TopPoint { get; }

        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   Count:
        //     The number of spaces.
        [DispId(80)]
        //[TypeLibFunc(64)]
        void Backspace(int Count = 1);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(81)]
        //[TypeLibFunc(64)]
        void Cancel();
        //
        // Summary:
        //     Changes the case of the selected text.
        //
        // Parameters:
        //   How:
        //     Required. A EnvDTE.vsCaseOptions constant representing the text to insert.
        [DispId(15)]
        void ChangeCase(vsCaseOptions How);
        //
        // Summary:
        //     Moves the object the specified number of characters to the left.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is False.
        //
        //   Count:
        //     Optional. Represents the number of characters to move to the left. The default
        //     is 1.
        [DispId(16)]
        void CharLeft(bool Extend = false, int Count = 1);
        //
        // Summary:
        //     Moves the object the specified number of characters to the right.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        //
        //   Count:
        //     Optional. Represents the number of characters to move to the right. The default
        //     is 1.
        [DispId(17)]
        void CharRight(bool Extend = false, int Count = 1);
        //
        // Summary:
        //     Clears any unnamed bookmarks in the current text buffer line.
        [DispId(18)]
        void ClearBookmark();
        //
        // Summary:
        //     Collapses the selected text to the active point.
        [DispId(19)]
        void Collapse();
        //
        // Summary:
        //     Copies the selected text to the clipboard.
        [DispId(20)]
        void Copy();
        //
        // Summary:
        //     Copies the selected text to the clipboard and deletes it from its original
        //     location.
        [DispId(21)]
        void Cut();
        //
        // Summary:
        //     Deletes the selected text.
        //
        // Parameters:
        //   Count:
        //     Optional. Represents the number of characters to delete.
        [DispId(23)]
        void Delete(int Count = 1);
        //
        // Summary:
        //     Deletes a specified number of characters to the left of the active point.
        //
        // Parameters:
        //   Count:
        //     Optional. Represents the number of characters to delete.
        [DispId(24)]
        void DeleteLeft(int Count = 1);
        //
        // Summary:
        //     Deletes the empty characters (white space) horizontally or vertically around
        //     the current location in the text buffer.
        //
        // Parameters:
        //   Direction:
        //     Optional. A EnvDTE.vsWhitespaceOptions constant that determines how and where
        //     to remove empty spaces.
        [DispId(25)]
        void DeleteWhitespace(vsWhitespaceOptions Direction = vsWhitespaceOptions.vsWhitespaceOptionsHorizontal);
        //
        // Summary:
        //     Inserts text, overwriting the existing text.
        //
        // Parameters:
        //   Text:
        //     Required. Represents the text to insert.
        [DispId(57)]
        void DestructiveInsert(string Text);
        //
        // Summary:
        //     Moves the object to the end of the document.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        [DispId(28)]
        void EndOfDocument(bool Extend = false);
        //
        // Summary:
        //     Moves the object to the end of the current line.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        [DispId(26)]
        void EndOfLine(bool Extend = false);
        ////
        //// Summary:
        ////     Searches for the given pattern from the active point to the end of the document.
        ////
        //// Parameters:
        ////   Pattern:
        ////     Required. The text to find.
        ////
        ////   vsFindOptionsValue:
        ////     One of the EnvDTE.vsFindOptions values.
        ////
        ////   Tags:
        ////     Optional. If the matched pattern is a regular expression containing tagged
        ////     subexpressions, then the Tags argument contains a collection of EnvDTE.TextRange
        ////     objects, one for each tagged subexpression.
        ////
        //// Returns:
        ////     A Boolean value indicating true if the pattern is found, false if not.
        //[DispId(30)]
        //bool FindPattern(string Pattern, int vsFindOptionsValue = 0, ref TextRanges Tags = null);
        //
        // Summary:
        //     Searches for the given text from the active point to the end of the document.
        //
        // Parameters:
        //   Pattern:
        //     Required. The text to find.
        //
        //   vsFindOptionsValue:
        //     Optional. A EnvDTE.vsFindOptions constant indicating the search options to
        //     use.
        //
        // Returns:
        //     A Boolean value indicating true if the text is found, false if not.
        [DispId(70)]
        bool FindText(string Pattern, int vsFindOptionsValue = 0);
        //
        // Summary:
        //     Moves to the beginning of the indicated line and selects the line if requested.
        //
        // Parameters:
        //   Line:
        //     Required. The line number to go to, beginning at one.
        //
        //   Select:
        //     Optional. Indicates whether the target line should be selected. The default
        //     is false.
        [DispId(32)]
        void GotoLine(int Line, bool Select = false);
        //
        // Summary:
        //     Indents the selected lines by the given number of indentation levels.
        //
        // Parameters:
        //   Count:
        //     Optional. The number of display indent levels to indent each line in the
        //     selected text. The default is 1.
        [DispId(33)]
        void Indent(int Count = 1);
        //
        // Summary:
        //     Inserts the given string at the current insertion point.
        //
        // Parameters:
        //   Text:
        //     The text to insert.
        //
        //   vsInsertFlagsCollapseToEndValue:
        //     One of the EnvDTE.vsInsertFlags values indicating how to insert the text.
        [DispId(35)]
        void Insert(string Text, int vsInsertFlagsCollapseToEndValue = 1);
        //
        // Summary:
        //     Inserts the contents of the specified file at the current location in the
        //     buffer.
        //
        // Parameters:
        //   File:
        //     Required. The name of the file to insert into the text buffer.
        [DispId(61)]
        void InsertFromFile(string File);
        //
        // Summary:
        //     Moves the insertion point of the text selection down the specified number
        //     of lines.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the line in which the insertion point is moved
        //     is highlighted. The default is false.
        //
        //   Count:
        //     Optional. Indicates how many lines down to move the insertion point. The
        //     default value is 1.
        [DispId(36)]
        void LineDown(bool Extend = false, int Count = 1);
        //
        // Summary:
        //     Moves the insertion point of the text selection up the specified number of
        //     lines.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the line in which the insertion point is moved
        //     is highlighted. The default is false.
        //
        //   Count:
        //     Optional. Indicates how many lines up to move the insertion point. The default
        //     is 1.
        [DispId(37)]
        void LineUp(bool Extend = false, int Count = 1);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   Line:
        //     The line number.
        //
        //   Column:
        //     The column number.
        //
        //   Extend:
        //     true if the move is extended, otherwise false.
        [DispId(82)]
        //[TypeLibFunc(64)]
        void MoveTo(int Line, int Column, bool Extend = false);
        //
        // Summary:
        //     Moves the active point to the given 1-based absolute character offset.
        //
        // Parameters:
        //   Offset:
        //     Required. A character index from the start of the document, starting at one
        //
        //   Extend:
        //     Optional. Default = false. A Boolean value to extend the current selection.
        //     If Extend is true, then the active end of the selection moves to the location
        //     while the anchor end remains where it is. Otherwise, both ends are moved
        //     to the specified location. This argument applies only to the EnvDTE.TextSelection
        //     object.
        [DispId(40)]
        void MoveToAbsoluteOffset(int Offset, bool Extend = false);
        //
        // Summary:
        //     Moves the active point to the indicated display column.
        //
        // Parameters:
        //   Line:
        //     Required. A EnvDTE.vsGoToLineOptions constant representing the line offset,
        //     starting at one, from the beginning of the buffer.
        //
        //   Column:
        //     Required. Represents the virtual display column, starting at one, that is
        //     the new column location.
        //
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        [DispId(58)]
        void MoveToDisplayColumn(int Line, int Column, bool Extend = false);
        //
        // Summary:
        //     Moves the active point to the given position.
        //
        // Parameters:
        //   Line:
        //     Required. The line number to move to, beginning at one. Line may also be
        //     one of the constants from EnvDTE.vsGoToLineOptions.
        //
        //   Offset:
        //     Required. The character index position in the line, starting at one.
        //
        //   Extend:
        //     Optional. Default = false. A Boolean value to extend the current selection.
        //     If Extend is true, then the active end of the selection moves to the location,
        //     while the anchor end remains where it is. Otherwise, both ends are moved
        //     to the specified location. This argument applies only to the EnvDTE.TextSelection
        //     object.
        [DispId(39)]
        void MoveToLineAndOffset(int Line, int Offset, bool Extend = false);
        //
        // Summary:
        //     Moves the active point to the given position.
        //
        // Parameters:
        //   Point:
        //     Required. The location in which to move the character.
        //
        //   Extend:
        //     Optional. Default = false. Determines whether to extend the current selection.
        //     If Extend is true, then the active end of the selection moves to the location,
        //     while the anchor end remains where it is. Otherwise, both ends are moved
        //     to the specified location. This argument applies only to the EnvDTE.TextSelection
        //     object.
        [DispId(38)]
        void MoveToPoint(TextPoint Point, bool Extend = false);
        //
        // Summary:
        //     Inserts a line break character at the active point.
        //
        // Parameters:
        //   Count:
        //     Optional. Represents the number of NewLine characters to insert.
        [DispId(41)]
        void NewLine(int Count = 1);
        //
        // Summary:
        //     Moves to the location of the next bookmark in the document.
        //
        // Returns:
        //     A Boolean value indicating true if the insertion point moves to the next
        //     bookmark, false if otherwise.
        [DispId(43)]
        bool NextBookmark();
        //
        // Summary:
        //     Creates an outlining section based on the current selection.
        [DispId(72)]
        void OutlineSection();
        //
        // Summary:
        //     Fills the current line in the buffer with empty characters (white space)
        //     to the given column.
        //
        // Parameters:
        //   Column:
        //     Required. The number of columns to pad, starting at one.
        [DispId(45)]
        void PadToColumn(int Column);
        //
        // Summary:
        //     Moves the active point a specified number of pages down in the document,
        //     scrolling the view.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        //
        //   Count:
        //     Optional. Represents the number of pages to move down. The default value
        //     is 1.
        [DispId(60)]
        void PageDown(bool Extend = false, int Count = 1);
        //
        // Summary:
        //     Moves the active point a specified number of pages up in the document, scrolling
        //     the view.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        //
        //   Count:
        //     Optional. Represents the number of pages to move up. The default value is
        //     1.
        [DispId(59)]
        void PageUp(bool Extend = false, int Count = 1);
        //
        // Summary:
        //     Inserts the clipboard contents at the current location.
        [DispId(22)]
        void Paste();
        //
        // Summary:
        //     Moves the text selection to the location of the previous bookmark in the
        //     document.
        //
        // Returns:
        //     A Boolean true if the text selection moves to a previous bookmark, false
        //     if not.
        [DispId(44)]
        bool PreviousBookmark();
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
        ////     Optional. A EnvDTE.vsFindOptions constant indicating the behavior of EnvDTE.TextSelection.ReplacePattern(System.String,System.String,System.Int32,EnvDTE.TextRanges@),
        ////     such as how to search, where to begin the search, whether to search forward
        ////     or backward, and the case sensitivity.
        ////
        ////   Tags:
        ////     Optional. A EnvDTE.TextRanges collection. If the matched text pattern is
        ////     a regular expression and contains tagged subexpressions, then Tags contains
        ////     a collection of EnvDTE.EditPoint objects, one for each tagged subexpression.
        ////
        //// Returns:
        ////     A Boolean value.
        //[DispId(31)]
        //bool ReplacePattern(string Pattern, string Replace, int vsFindOptionsValue = 0, ref TextRanges Tags = null);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   Pattern:
        //     The pattern to find.
        //
        //   Replace:
        //     The string with which to replace the found text.
        //
        //   vsFindOptionsValue:
        //     The find flags.
        //
        // Returns:
        //     true if the text was replaced, otherwise false.
        [DispId(71)]
        //[TypeLibFunc(64)]
        bool ReplaceText(string Pattern, string Replace, int vsFindOptionsValue = 0);
        //
        // Summary:
        //     Selects the entire document.
        [DispId(47)]
        void SelectAll();
        //
        // Summary:
        //     Selects the line containing the active point.
        [DispId(48)]
        void SelectLine();
        //
        // Summary:
        //     Sets an unnamed bookmark on the current line in the buffer.
        [DispId(42)]
        void SetBookmark();
        //
        // Summary:
        //     Formats the selected lines of text based on the current language.
        [DispId(46)]
        void SmartFormat();
        //
        // Summary:
        //     Moves the insertion point to the beginning of the document.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the text between the current location of the
        //     insertion point and the beginning of the document is highlighted or not.
        //     The default value is false.
        [DispId(29)]
        void StartOfDocument(bool Extend = false);
        ////
        //// Summary:
        ////     Moves the object to the beginning of the current line.
        ////
        //// Parameters:
        ////   Where:
        ////     Optional. A EnvDTE.vsStartOfLineOptions constant representing where the line
        ////     starts.
        ////
        ////   Extend:
        ////     Optional. Determines whether the moved text is collapsed or not. The default
        ////     is false.
        //[DispId(27)]
        //void StartOfLine(vsStartOfLineOptions Where = vsStartOfLineOptions.vsStartOfLineOptionsFirstColumn, bool Extend = false);
        //
        // Summary:
        //     Exchanges the position of the active and the anchor points.
        [DispId(49)]
        void SwapAnchor();
        //
        // Summary:
        //     Converts spaces to tabs in the selection according to your tab settings.
        [DispId(50)]
        void Tabify();
        //
        // Summary:
        //     Removes indents from the selected text by the number of indentation levels
        //     given.
        //
        // Parameters:
        //   Count:
        //     Optional. The number of display indent levels to remove from each line in
        //     the selected text. The default is 1.
        [DispId(34)]
        void Unindent(int Count = 1);
        //
        // Summary:
        //     Converts tabs to spaces in the selection according to the user's tab settings.
        [DispId(51)]
        void Untabify();
        //
        // Summary:
        //     Moves the selected text left the specified number of words.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        //
        //   Count:
        //     Optional. Represents the number of words to move left. The default value
        //     is 1.
        [DispId(52)]
        void WordLeft(bool Extend = false, int Count = 1);
        //
        // Summary:
        //     Moves the selected text right the specified number of words.
        //
        // Parameters:
        //   Extend:
        //     Optional. Determines whether the moved text is collapsed or not. The default
        //     is false.
        //
        //   Count:
        //     Optional. Represents the number of words to move right. The default value
        //     is 1.
        [DispId(53)]
        void WordRight(bool Extend = false, int Count = 1);
    }
}
