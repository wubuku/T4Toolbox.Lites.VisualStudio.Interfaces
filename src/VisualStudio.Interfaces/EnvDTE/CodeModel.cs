#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Allows access to programmatic constructs in a source code file.
    [Guid("0CFBC2B4-0D4E-11D3-8997-00C04F688DDE")]
    //[TypeLibType(4160)]
    public interface CodeModel
    {
        // Summary:
        //     Gets a collection of EnvDTE.CodeElements.
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
        //     Gets whether the current language is case-sensitive.
        //
        // Returns:
        //     A Boolean value indicating true if the current language is case-sensitive;
        //     false if otherwise.
        [DispId(17)]
        bool IsCaseSensitive { get; }
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
        //     Gets the immediate parent object of a EnvDTE.CodeModel object.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(2)]
        Project Parent { get; }

        //// Summary:
        ////     Creates a new attribute code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new attribute.
        ////
        ////   Location:
        ////     Required. The path and file name for the new attribute. Depending on the
        ////     language, the file name is either relative or absolute to the project file.
        ////     The file is added to the project if it is not already a project item. If
        ////     the file cannot be created and added to the project, then EnvDTE.CodeModel.AddAttribute(System.String,System.Object,System.String,System.Object)
        ////     fails.
        ////
        ////   Value:
        ////     Required. The value of the attribute, which may be a comma-separated list
        ////     of parameters for a parameterized property.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddAttribute(System.String,System.Object,System.String,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeAttribute object.
        //[DispId(14)]
        //CodeAttribute AddAttribute(string Name, object Location, string Value, object Position = Type.Missing);
        ////
        //// Summary:
        ////     Creates a new class code construct and inserts the code in the correct location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the class.
        ////
        ////   Location:
        ////     Required. The path and file name for the new class definition. Depending
        ////     on the language, the file name is either relative or absolute to the project
        ////     file. The file is added to the project if it is not already a project item.
        ////     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddClass(System.String,System.Object,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     fails.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddClass(System.String,System.Object,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        ////   Bases:
        ////     Required. Default = 0. A SafeArray of fully qualified type names or EnvDTE.CodeClass
        ////     objects from which the new class inherits its implementations.
        ////
        ////   ImplementedInterfaces:
        ////     Required. Default = 0. A SafeArray of fully qualified type names or EnvDTE.CodeInterface
        ////     objects, each representing an interface that the new class promises to implement.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeClass object.
        //[DispId(7)]
        //CodeClass AddClass(string Name, object Location, object Position = Type.Missing, object Bases = Type.Missing, object ImplementedInterfaces = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new delegate code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the delegate to add.
        ////
        ////   Location:
        ////     Required. The path and file name for the new delegate definition. Depending
        ////     on the language, the file name is either relative or absolute to the project
        ////     file. The file is added to the project if it is not already a project item.
        ////     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddDelegate(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     fails.
        ////
        ////   Type:
        ////     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        ////     function returns. This value can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        ////     constant, or a fully qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddDelegate(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeDelegate object.
        //[DispId(13)]
        //CodeDelegate AddDelegate(string Name, object Location, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new enumeration code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the enum to add.
        ////
        ////   Location:
        ////     Required. The path and file name for the new enum definition. Depending on
        ////     the language, the file name is either relative or absolute to the project
        ////     file. The file is added to the project if it is not already a project item.
        ////     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddEnum(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     fails.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddEnum(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        ////   Bases:
        ////     Optional. Default = Nothing. A variant that holds a SafeArray of fully qualified
        ////     type names or EnvDTE.CodeType objects that specify the underlying type of
        ////     the new enum.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeEnum object.
        //[DispId(12)]
        //CodeEnum AddEnum(string Name, object Location, object Position = Type.Missing, object Bases = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new function code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new function.
        ////
        ////   Location:
        ////     Required. The path and file name for the new function definition. Depending
        ////     on the language, the file name is either relative or absolute to the project
        ////     file. The file is added to the project if it is not already a project item.
        ////     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddFunction(System.String,System.Object,EnvDTE.vsCMFunction,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     fails.
        ////
        ////   Kind:
        ////     Required. The EnvDTE.vsCMFunction constant indicating the type of function,
        ////     such as whether the function is a property-get or a method.
        ////
        ////   Type:
        ////     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        ////     function returns. This can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        ////     constant, or a fully qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddFunction(System.String,System.Object,EnvDTE.vsCMFunction,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        //// Returns:
        ////     A EnvDTE.CodeFunction object.
        //[DispId(9)]
        //CodeFunction AddFunction(string Name, object Location, vsCMFunction Kind, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new interface code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the interface to add.
        ////
        ////   Location:
        ////     Required. The path and file name for the new interface definition. Depending
        ////     on the language, the file name is either relative or absolute to the project
        ////     file. The file is added to the project if it is not already a project item.
        ////     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddInterface(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     fails.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddInterface(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
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
        //[DispId(8)]
        //CodeInterface AddInterface(string Name, object Location, object Position = Type.Missing, object Bases = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Creates a new namespace code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. The name of the new namespace.
        ////
        ////   Location:
        ////     Required. The path and file name for the new namespace definition. Depending
        ////     on the language, the file name is either relative or absolute to the project
        ////     file. The file is added to the project if it is not already a project item.
        ////     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddNamespace(System.String,System.Object,System.Object)
        ////     fails.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddNamespace(System.String,System.Object,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeNamespace object.
        //[DispId(6)]
        //CodeNamespace AddNamespace(string Name, object Location, object Position = Type.Missing);
        //
        // Summary:
        //     Creates a new structure code construct and inserts the code in the correct
        //     location.
        //
        // Parameters:
        //   Name:
        //     Required. The name of the new structure.
        //
        //   Location:
        //     Required. The path and file name for the new structure definition. Depending
        //     on the language, the file name is either relative or absolute to the project
        //     file. The file is added to the project if it is not already a project item.
        //     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddStruct(System.String,System.Object,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        //     fails.
        //
        //   Position:
        //     Optional. Default = 0. The code element after which to add the new element.
        //     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        //     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddStruct(System.String,System.Object,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        //     indicates the element after which to add the new element.Because collections
        //     begin their count at 1, passing 0 indicates that the new element should be
        //     placed at the beginning of the collection. A value of -1 means that the element
        //     should be placed at the end.
        //
        //   Bases:
        //     Required. Default value is Nothing. A variant that holds a SafeArray of fully
        //     qualified type names or EnvDTE.CodeInterface objects from which the new interface
        //     derives.
        //
        //   ImplementedInterfaces:
        //     Required. Default value is Nothing. A SafeArray of fully qualified type names
        //     or EnvDTE.CodeInterface objects representing interfaces that the new class
        //     promises to implement.
        //
        //   Access:
        //     Optional. A EnvDTE.vsCMAccess constant.
        //
        // Returns:
        //     A EnvDTE.CodeStruct object.
        [DispId(11)]
        //CodeStruct AddStruct(string Name, object Location, object Position = Type.Missing, object Bases = Type.Missing, object ImplementedInterfaces = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        CodeStruct AddStruct(string Name, object Location, object Position, object Bases, object ImplementedInterfaces, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        //
        // Summary:
        //     Creates a new variable code construct and inserts the code in the correct
        //     location.
        //
        // Parameters:
        //   Name:
        //     Required. The name of the new variable.
        //
        //   Location:
        //     Optional. The path and file name for the new variable definition. Depending
        //     on the language, the file name is either relative or absolute to the project
        //     file. The file is added to the project if it is not already a project item.
        //     If the file cannot be created and added to the project, then EnvDTE.CodeModel.AddVariable(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        //     fails.
        //
        //   Type:
        //     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        //     function returns. This can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        //     constant, or a fully qualified type name.
        //
        //   Position:
        //     Optional. Default = 0. The code element after which to add the new element.
        //     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        //     after it.If the value is a Long data type, then EnvDTE.CodeModel.AddVariable(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        //     indicates the element after which to add the new element.Because collections
        //     begin their count at 1, passing 0 indicates that the new element should be
        //     placed at the beginning of the collection. A value of -1 means that the element
        //     should be placed at the end.
        //
        //   Access:
        //     Optional. A EnvDTE.vsCMAccess constant.
        //
        // Returns:
        //     A EnvDTE.CodeVariable object.
        [DispId(10)]
        //CodeVariable AddVariable(string Name, object Location, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        CodeVariable AddVariable(string Name, object Location, object Type, object Position, vsCMAccess Access = vsCMAccess.vsCMAccessDefault);
        ////
        //// Summary:
        ////     Returns a code element based on a fully qualified name.
        ////
        //// Parameters:
        ////   Name:
        ////     Required. A fully qualified symbol name, such as Namespace1.Namespace2.Class1.Member1.
        ////
        //// Returns:
        ////     A EnvDTE.CodeType object.
        //[DispId(5)]
        //CodeType CodeTypeFromFullName(string Name);
        ////
        //// Summary:
        ////     Returns a EnvDTE.CodeTypeRef object based on the data type indicator passed.
        ////
        //// Parameters:
        ////   Type:
        ////     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        ////     function returns. This can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        ////     constant, or a fully qualified type name.
        ////
        //// Returns:
        ////     A EnvDTE.CodeTypeRef object.
        //[DispId(18)]
        //CodeTypeRef CreateCodeTypeRef(object Type);
        //
        // Summary:
        //     Returns whether a specified name is a valid programmatic identifier for the
        //     current language.
        //
        // Parameters:
        //   Name:
        //     Required. The name of the identifier to check.
        //
        // Returns:
        //     A Boolean value indicating True when the identifier is valid; False when
        //     it is not, such as when it is a keyword.NoteThe values of code model elements
        //     such as classes, structs, functions, attributes, delegates, and so forth
        //     can be non-deterministic after making certain kinds of edits, meaning that
        //     their values cannot be relied upon to always remain the same. For more information,
        //     see the section Code Model Element Values Can Change in Discovering Code
        //     by Using the Code Model (Visual Basic).
        [DispId(16)]
        bool IsValidID(string Name);
        //
        // Summary:
        //     Removes the specified code element from the source file.
        //
        // Parameters:
        //   Element:
        //     Required. A EnvDTE.CodeElement object or the name of a code element to remove
        //     from the source code.
        [DispId(15)]
        void Remove(object Element);
    }
}
