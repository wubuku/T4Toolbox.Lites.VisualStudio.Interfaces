#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a code element or construct in a source file.
    [Guid("0CFBC2B6-0D4E-11D3-8997-00C04F688DDE")]
    //[TypeLibType(4160)]
    public interface CodeElement
    {
        // Summary:
        //     Returns a collection of objects contained within this EnvDTE.CodeElement.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(8)]
        CodeElements Children { get; }
        //
        // Summary:
        //     Gets the EnvDTE.CodeElements collection containing the CodeElement that supports
        //     this property.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(2)]
        CodeElements Collection { get; }
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
        //     Gets the text point that is the location of the end of the code item.
        //
        // Returns:
        //     A EnvDTE.TextPoint object.
        [DispId(11)]
        TextPoint EndPoint { get; }
        //
        // Summary:
        //     Gets the Extender category ID (CATID) for the object.
        //
        // Returns:
        //     A string representing the Extender category ID (CATID) for the object.
        [DispId(14)]
        string ExtenderCATID { get; }
        //
        // Summary:
        //     Gets a list of available Extenders for the object.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(12)]
        object ExtenderNames { get; }
        //
        // Summary:
        //     Gets a fully-qualified name of the specified code element.
        //
        // Returns:
        //     A string containing a fully-qualified name of the specified code element.
        [DispId(3)]
        string FullName { get; }
        ////
        //// Summary:
        ////     Gets the capabilities of the code model.
        ////
        //// Returns:
        ////     A EnvDTE.vsCMInfoLocation constant value.
        //[DispId(7)]
        //vsCMInfoLocation InfoLocation { get; }
        //
        // Summary:
        //     Indicates whether or not a EnvDTE.CodeType object can be obtained from the
        //     EnvDTE.CodeElement object.
        //
        // Returns:
        //     A Boolean value indicating whether or not a EnvDTE.CodeType object can be
        //     obtained from the EnvDTE.CodeElement object.
        [DispId(6)]
        bool IsCodeType { get; }
        ////
        //// Summary:
        ////     Gets an enumeration that defines the type of object.
        ////
        //// Returns:
        ////     A EnvDTE.vsCMElement value.
        //[DispId(5)]
        //vsCMElement Kind { get; }
        //
        // Summary:
        //     Gets the programming language that is used to author the code.
        //
        // Returns:
        //     A string representing a EnvDTE.CodeModelLanguageConstants constant.
        [DispId(9)]
        string Language { get; }
        //
        // Summary:
        //     Sets or gets the name of the object.
        //
        // Returns:
        //     A string representing the name of the EnvDTE.CodeElement object.
        [DispId(0)]
        string Name { get; set; }
        //
        // Summary:
        //     Gets the EnvDTE.ProjectItem object associated with the EnvDTE.CodeElement
        //     object.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(4)]
        ProjectItem ProjectItem { get; }
        //
        // Summary:
        //     Gets a EnvDTE.TextPoint object that defines the beginning of the code item.
        //
        // Returns:
        //     A EnvDTE.TextPoint object.
        [DispId(10)]
        TextPoint StartPoint { get; }

        [DispId(13)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
        ////
        //// Summary:
        ////     Returns a EnvDTE.TextPoint object that marks the end of the code element
        ////     definition.
        ////
        //// Parameters:
        ////   Part:
        ////     Optional. A EnvDTE.vsCMPart constant specifying the portion of the code to
        ////     retrieve.
        ////
        //// Returns:
        ////     A EnvDTE.TextPoint object.
        //[DispId(16)]
        ////[TypeLibFunc(1024)]
        //TextPoint GetEndPoint(vsCMPart Part = vsCMPart.vsCMPartWholeWithAttributes);
        ////
        //// Summary:
        ////     Returns a EnvDTE.TextPoint object that marks the beginning of the code element
        ////     definition.
        ////
        //// Parameters:
        ////   Part:
        ////     Optional. A EnvDTE.vsCMPart constant specifying the portion of the code to
        ////     retrieve.
        ////
        //// Returns:
        ////     A EnvDTE.TextPoint object.
        //[DispId(15)]
        ////[TypeLibFunc(1024)]
        //TextPoint GetStartPoint(vsCMPart Part = vsCMPart.vsCMPartWholeWithAttributes);
    }
}
