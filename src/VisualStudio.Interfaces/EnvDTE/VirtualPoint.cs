#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Allows you to manipulate text beyond the right margin (left margin in bidirectional
    //     Windows) of the text document.
    [Guid("42320454-626C-4DD0-9ECB-357C4F1966D8")]
    //[TypeLibType(4160)]
    public interface VirtualPoint : TextPoint
    {
        // Summary:
        //     Gets the one-based character offset from the beginning of the document to
        //     the object.
        //
        // Returns:
        //     An integer value indicating the one-based character offset from the beginning
        //     of the document to the object.
        [DispId(13)]
        int AbsoluteCharOffset { get; }
        //
        // Summary:
        //     Returns true if the object is at the end of the document.
        //
        // Returns:
        //     A Boolean value indicating true if you are at the end of the document; false
        //     if otherwise.
        [DispId(21)]
        bool AtEndOfDocument { get; }
        //
        // Summary:
        //     Returns true if the object is at the end of a line.
        //
        // Returns:
        //     A Boolean value indicating true if you are at the end of a line; false if
        //     otherwise.
        [DispId(23)]
        bool AtEndOfLine { get; }
        //
        // Summary:
        //     Returns true if the object is at the beginning of the document.
        //
        // Returns:
        //     A Boolean value indicating true if you are at the start of a document; false
        //     if otherwise.
        [DispId(22)]
        bool AtStartOfDocument { get; }
        //
        // Summary:
        //     Returns true if the object is at the beginning of a line.
        //
        // Returns:
        //     A Boolean value indicating true if you are at the start of a line; false
        //     if otherwise.
        [DispId(24)]
        bool AtStartOfLine { get; }
        //
        // Summary:
        //     Gets the number of the current displayed column containing the object.
        //
        // Returns:
        //     An integer value indicating the number of the current displayed column containing
        //     the object.
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
        //     Gets the line number of the object.
        //
        // Returns:
        //     An integer value indicating the line number of the object.
        [DispId(11)]
        int Line { get; }
        //
        // Summary:
        //     Gets the character offset of the object.
        //
        // Returns:
        //     An integer value indicating the character offset of the EnvDTE.VirtualPoint
        //     object.
        [DispId(12)]
        int LineCharOffset { get; }
        //
        // Summary:
        //     Gets the number of characters in a line containing the object, excluding
        //     the new line character.
        //
        // Returns:
        //     An integer value indicating the number of characters in a line containing
        //     the EnvDTE.VirtualPoint object, excluding the new line character.
        [DispId(25)]
        int LineLength { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.VirtualPoint object.
        //
        // Returns:
        //     A EnvDTE.TextDocument object.
        [DispId(2)]
        TextDocument Parent { get; }
        //
        // Summary:
        //     Gets the column index of a virtual point in virtual space.
        //
        // Returns:
        //     An integer value indicating the column index of a virtual point in virtual
        //     space.
        [DispId(101)]
        int VirtualCharOffset { get; }
        //
        // Summary:
        //     Gets the display column of the current position.
        //
        // Returns:
        //     An integer value indicating the display column of the current position.
        [DispId(102)]
        int VirtualDisplayColumn { get; }

        // Summary:
        //     Creates and returns an EnvDTE.EditPoint object at the location of the calling
        //     object.
        //
        // Returns:
        //     An EnvDTE.EditPoint object.
        [DispId(34)]
        EditPoint CreateEditPoint();
        ////
        //// Summary:
        ////     Returns whether the value of the given EnvDTE.TextPoint object's EnvDTE.TextPoint.AbsoluteCharOffset
        ////     property is equal to that of the calling EnvDTE.VirtualPoint object.
        ////
        //// Parameters:
        ////   Point:
        ////     Required. A EnvDTE.TextPoint object to compare to the calling point object.
        ////
        //// Returns:
        ////     A Boolean value indicating true if Point has the same EnvDTE.TextPoint.AbsoluteCharOffset
        ////     property value as the calling point object.
        //[DispId(31)]
        //bool EqualTo(TextPoint Point);
        //[DispId(51)]
        //CodeElement get_CodeElement(vsCMElement Scope);
        //
        // Summary:
        //     Returns whether the value of the calling object's EnvDTE.VirtualPoint.AbsoluteCharOffset
        //     property is greater than that of the given point object.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint to compare to the calling point object.
        //
        // Returns:
        //     A Boolean value indicating true if Point has a smaller EnvDTE.TextPoint.AbsoluteCharOffset
        //     property value compared to the calling point object's EnvDTE.VirtualPoint.AbsoluteCharOffset
        //     property.
        [DispId(33)]
        bool GreaterThan(TextPoint Point);
        //
        // Summary:
        //     Returns whether the value of the called object's EnvDTE.VirtualPoint.AbsoluteCharOffset
        //     property is less than that of the given object.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint to compare to the calling point object.
        //
        // Returns:
        //     A Boolean value indicating true if Point has a greater EnvDTE.TextPoint.AbsoluteCharOffset
        //     property value compared to the calling point object's EnvDTE.VirtualPoint.AbsoluteCharOffset
        //     property.
        [DispId(32)]
        bool LessThan(TextPoint Point);
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
        ////     A Boolean value indicating true if the span of text fits within the current
        ////     code editor, false if not.
        //[DispId(50)]
        //bool TryToShow(vsPaneShowHow How = vsPaneShowHow.vsPaneShowCentered, object PointOrCount = Type.Missing);
    }
}
