#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a location of text in a text document.
    [Guid("7F59E94E-4939-40D2-9F7F-B7651C25905D")]
    //[TypeLibType(4160)]
    public interface TextPoint
    {
        // Summary:
        //     Gets the one-based character offset from the beginning of the document to
        //     the EnvDTE.TextPoint object.
        //
        // Returns:
        //     An integer value indicating the one-based character offset from the beginning
        //     of the document to the EnvDTE.TextPoint object.
        [DispId(13)]
        int AbsoluteCharOffset { get; }
        //
        // Summary:
        //     Gets whether the object is at the end of the document.
        //
        // Returns:
        //     A Boolean value indicating true if you are at the end of the document; false
        //     if otherwise.
        [DispId(21)]
        bool AtEndOfDocument { get; }
        //
        // Summary:
        //     Gets whether or not object is at the end of a line.
        //
        // Returns:
        //     A Boolean value indicating true if you are at the end of a line; false if
        //     otherwise.
        [DispId(23)]
        bool AtEndOfLine { get; }
        //
        // Summary:
        //     Gets whether or not the object is at the beginning of the document.
        //
        // Returns:
        //     A Boolean true if you are at the start of a document; false if otherwise.
        [DispId(22)]
        bool AtStartOfDocument { get; }
        //
        // Summary:
        //     Gets whether or not the object is at the beginning of a line.
        //
        // Returns:
        //     A Boolean value indicating True if you are at the start of a line; False
        //     if otherwise.
        [DispId(24)]
        bool AtStartOfLine { get; }
        //
        // Summary:
        //     Gets the number of the current displayed column containing the EnvDTE.TextPoint
        //     object.
        //
        // Returns:
        //     An integer value indicating the number of the current displayed column containing
        //     the EnvDTE.TextPoint object.
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
        //     An integer value indicating the character offset of the object.
        [DispId(12)]
        int LineCharOffset { get; }
        //
        // Summary:
        //     Gets the number of characters in a line containing the object, excluding
        //     the new line character.
        //
        // Returns:
        //     An integer value indicating the number of characters in a line containing
        //     the EnvDTE.TextPoint object, excluding the new line character.
        [DispId(25)]
        int LineLength { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.TextPoint object.
        //
        // Returns:
        //     A EnvDTE.TextDocument object.
        [DispId(2)]
        TextDocument Parent { get; }

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
        ////     Returns whether the value of the given point object's EnvDTE.TextPoint.AbsoluteCharOffset
        ////     property is equal to that of the calling EnvDTE.TextPoint object.
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
        //     Indicates whether or not the value of the calling object's EnvDTE.TextPoint.AbsoluteCharOffset
        //     property is greater than that of the given point object.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint object to compare to the calling point object.
        //
        // Returns:
        //     A Boolean value indicating true if Point has a smaller EnvDTE.TextPoint.AbsoluteCharOffset
        //     property value compared to the calling point object's EnvDTE.TextPoint.AbsoluteCharOffset
        //     property.
        [DispId(33)]
        bool GreaterThan(TextPoint Point);
        //
        // Summary:
        //     Indicates whether or not the value of the called object's EnvDTE.TextPoint.AbsoluteCharOffset
        //     property is less than that of the given object.
        //
        // Parameters:
        //   Point:
        //     Required. A EnvDTE.TextPoint to compare to the calling point object.
        //
        // Returns:
        //     A Boolean value indicating true if Point has a greater EnvDTE.TextPoint.AbsoluteCharOffset
        //     property value compared to the calling point object's EnvDTE.TextPoint.AbsoluteCharOffset
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
