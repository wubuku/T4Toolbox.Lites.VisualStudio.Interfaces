#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     An object defining a variable construct in a source file.
    [Guid("0CFBC2BA-0D4E-11D3-8997-00C04F688DDE")]
    //[TypeLibType(4160)]
    public interface CodeVariable
    {
        // Summary:
        //     Defines the access modifier of this item.
        //
        // Returns:
        //     A EnvDTE.vsCMAccess value.
        [DispId(36)]
        vsCMAccess Access { get; set; }
        //
        // Summary:
        //     Gets a collection of all of the attributes for the parent object.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(38)]
        CodeElements Attributes { get; }
        //
        // Summary:
        //     Gets a collection of objects contained within this EnvDTE.CodeVariable.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(8)]
        CodeElements Children { get; }
        //
        // Summary:
        //     Gets the collection containing the EnvDTE.CodeVariable object supporting
        //     this property.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(2)]
        CodeElements Collection { get; }
        //
        // Summary:
        //     Gets or sets the comment associated with the code element.
        //
        // Returns:
        //     A string representing the comment associated with the code element.
        [DispId(40)]
        string Comment { get; set; }
        //
        // Summary:
        //     Gets or sets the document comment for the current code model element.
        //
        // Returns:
        //     A string representing the document comment.
        [DispId(39)]
        string DocComment { get; set; }
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
        //     Gets the edit point that is the location of the end of the code item.
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
        //     A string GUID representing the CATID.
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
        //     Gets the full path and name of the EnvDTE.CodeVariable object's file.
        //
        // Returns:
        //     A string representing the full path name of the EnvDTE.CodeVariable object's
        //     file.
        [DispId(3)]
        string FullName { get; }
        ////
        //// Summary:
        ////     Gets the capabilities of the code model object.
        ////
        //// Returns:
        ////     A EnvDTE.vsCMInfoLocation constant value.
        //[DispId(7)]
        //vsCMInfoLocation InfoLocation { get; }
        //
        // Summary:
        //     Sets or gets an object defining the initialization code for an element.
        //
        // Returns:
        //     An object defining the initialization expression for the code variable.
        [DispId(33)]
        object InitExpression { get; set; }
        //
        // Summary:
        //     Gets whether a EnvDTE.CodeType object can be obtained from this object.
        //
        // Returns:
        //     A Boolean value indicating true if a EnvDTE.CodeType object can be obtained,
        //     otherwise returns false.
        [DispId(6)]
        bool IsCodeType { get; }
        //
        // Summary:
        //     Gets or sets whether or not the item is a constant.
        //
        // Returns:
        //     A Boolean value indicating true if the item is a constant; false otherwise.
        [DispId(37)]
        bool IsConstant { get; set; }
        //
        // Summary:
        //     Sets or gets whether or not the item is statically defined, that is, whether
        //     the item is common to all instances of this object type or only to this object
        //     specifically.
        //
        // Returns:
        //     A Boolean value indicating true if the method is shared; false if otherwise.
        [DispId(42)]
        bool IsShared { get; set; }
        ////
        //// Summary:
        ////     Gets an enumeration indicating the type of object.
        ////
        //// Returns:
        ////     A EnvDTE.vsCMElement value.
        //[DispId(5)]
        //vsCMElement Kind { get; }
        //
        // Summary:
        //     Gets the programming language used to author the code.
        //
        // Returns:
        //     A EnvDTE.CodeModelLanguageConstants constant.
        [DispId(9)]
        string Language { get; }
        //
        // Summary:
        //     Sets or gets the name of the object.
        //
        // Returns:
        //     A string representing the name of the object.
        [DispId(0)]
        string Name { get; set; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.CodeVariable object.
        //
        // Returns:
        //     A parent object.
        [DispId(31)]
        object Parent { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ProjectItem object associated with the EnvDTE.CodeVariable
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
        ////
        //// Summary:
        ////     Sets or gets an object representing the programmatic type.
        ////
        //// Returns:
        ////     A EnvDTE.CodeTypeRef object.
        //[DispId(35)]
        //CodeTypeRef Type { get; set; }

        //// Summary:
        ////     Creates a new attribute code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new attribute.
        ////
        ////   Value:
        ////     Required. The value of the attribute, which may be a list of parameters for
        ////     a parameterized property, separated by commas.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeVariable.AddAttribute(System.String,System.String,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeAttribute object.
        //[DispId(41)]
        //CodeAttribute AddAttribute(string Name, string Value, object Position = Type.Missing);
        [DispId(13)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
        [DispId(34)]
        //[TypeLibFunc(1024)]
        string get_Prototype(int Flags = 0);
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
        ////[DispId(16)]
        //////[TypeLibFunc(1024)]
        ////TextPoint GetEndPoint(vsCMPart Part = vsCMPart.vsCMPartWholeWithAttributes);
        ////
        //// Summary:
        ////     Returns a EnvDTE.TextPoint object that defines the beginning of the code
        ////     element definition.
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
