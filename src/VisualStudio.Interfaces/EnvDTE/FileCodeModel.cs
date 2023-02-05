#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Allows access to programmatic constructs in a source file.
    [Guid("ED1A3F99-4477-11D3-89BF-00C04F688DDE")]
    //[TypeLibType(4160)]
    public interface FileCodeModel
    {
        // Summary:
        //     Gets a collection of code elements.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(4)]
        CodeElements CodeElements { get; }
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
        //     Gets the programming language used to author the code.
        //
        // Returns:
        //     A EnvDTE.CodeModelLanguageConstants constant.
        [DispId(3)]
        string Language { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.FileCodeModel object.
        //
        // Returns:
        //     A EnvDTE.ProjectItem object.
        [DispId(2)]
        ProjectItem Parent { get; }

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
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddAttribute(System.String,System.String,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeAttribute object.
        //[DispId(12)]
        //CodeAttribute AddAttribute(string Name, string Value, object Position = Type.Missing);
        ////
        //// Summary:
        ////     Creates a new class code construct and inserts the code in the correct location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the class.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddClass(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        ////   Bases:
        ////     Optional. Default = 0. A SafeArray of fully qualified type names or EnvDTE.CodeClass
        ////     objects from which the new class inherits its implementations.
        ////
        ////   ImplementedInterfaces:
        ////     Optional. Default = 0. A SafeArray of fully qualified type names or EnvDTE.CodeInterface
        ////     objects, each representing an interface that the new class promises to implement.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeClass object.
        //[DispId(8)]
        //CodeClass AddClass(string Name, object Position = Type.Missing, object Bases = Type.Missing, object ImplementedInterfaces = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new delegate code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the delegate to add.
        ////
        ////   Type:
        ////     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        ////     function returns. This can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        ////     constant, or a fully qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddDelegate(System.String,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeDelegate object.
        //[DispId(15)]
        //CodeDelegate AddDelegate(string Name, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new enumeration code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the enum to add.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddEnum(System.String,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        ////   Bases:
        ////     Optional. Default = Nothing. A variant that holds a SafeArray of fully qualified
        ////     type names or EnvDTE.CodeType objects that specify the underlying type of
        ////     the new enumeration.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeEnum object.
        //[DispId(14)]
        //CodeEnum AddEnum(string Name, object Position = Type.Missing, object Bases = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new function code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new function.
        ////
        ////   Kind:
        ////     Required. The EnvDTE.vsCMFunction constant indicating the type of function,
        ////     such as a property-get, a method, and so forth.
        ////
        ////   Type:
        ////     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        ////     function returns. This can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        ////     constant, or a fully qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddFunction(System.String,EnvDTE.vsCMFunction,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeFunction object.
        //[DispId(10)]
        //CodeFunction AddFunction(string Name, vsCMFunction Kind, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new interface code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new interface.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddInterface(System.String,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        ////   Bases:
        ////     Optional. Default value is Nothing. A variant that holds a SafeArray of fully
        ////     qualified type names or EnvDTE.CodeInterface objects from which the new interface
        ////     derives.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeInterface object.
        //[DispId(9)]
        //CodeInterface AddInterface(string Name, object Position = Type.Missing, object Bases = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new namespace code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new namespace.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddNamespace(System.String,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeNamespace object.
        ////[DispId(7)]
        ////CodeNamespace AddNamespace(string Name, object Position = Type.Missing);
        ////
        //// Summary:
        ////     Creates a new structure code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new structure.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddStruct(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        ////   Bases:
        ////     Required. Default value is Nothing. A variant that holds a SafeArray of fully
        ////     qualified type names or EnvDTE.CodeInterface objects from which the new interface
        ////     derives.
        ////
        ////   ImplementedInterfaces:
        ////     Required. Default value is Nothing. A SafeArray of fully qualified type names
        ////     or EnvDTE.CodeInterface objects, each representing interfaces that the new
        ////     class promises to implement.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeStruct object.
        //[DispId(13)]
        //CodeStruct AddStruct(string Name, object Position = Type.Missing, object Bases = Type.Missing, object ImplementedInterfaces = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new variable code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new variable.
        ////
        ////   Type:
        ////     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        ////     function returns. This can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        ////     constant, or a fully qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.FileCodeModel.AddVariable(System.String,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeVariable object.
        //[DispId(11)]
        //CodeVariable AddVariable(string Name, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Returns a code element at a specific location in a source file.
        ////
        //// Parameters:
        ////   Point:
        ////     Required. A EnvDTE.TextPoint object representing the editor location for
        ////     which you want a code element.
        ////
        ////   Scope:
        ////     Required. A EnvDTE.vsCMElement value representing the code element of the
        ////     specified type that contains the editor location.
        ////
        //// Returns:
        ////     A EnvDTE.CodeElement object.
        //[DispId(5)]
        //CodeElement CodeElementFromPoint(TextPoint Point, vsCMElement Scope);
        //
        // Summary:
        //     Removes the specified code element from the source file.
        //
        // Parameters:
        //   Element:
        //     Required. A EnvDTE.CodeElement object or the name of a code element to remove
        //     from the source code.
        [DispId(16)]
        void Remove(object Element);
    }
}
