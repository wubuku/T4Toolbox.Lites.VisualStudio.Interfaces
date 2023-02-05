#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Object representing a structure in source code.
    [Guid("B1F42511-91CD-4D3A-8B25-A317D8032B24")]
    //[TypeLibType(4160)]
    public interface CodeStruct
    {
        // Summary:
        //     Defines the access modifier of this item.
        //
        // Returns:
        //     A EnvDTE.vsCMAccess value.
        [DispId(35)]
        vsCMAccess Access { get; set; }
        //
        // Summary:
        //     Gets a collection of EnvDTE.CodeElements.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(36)]
        CodeElements Attributes { get; }
        //
        // Summary:
        //     Gets a collection of classes from which this EnvDTE.CodeStruct derives.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(33)]
        CodeElements Bases { get; }
        //
        // Summary:
        //     Gets a collection of EnvDTE.CodeElements.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(8)]
        CodeElements Children { get; }
        //
        // Summary:
        //     Gets a EnvDTE.CodeElements collection.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(2)]
        CodeElements Collection { get; }
        //
        // Summary:
        //     Gets or sets the comment associated with the EnvDTE.CodeStruct.
        //
        // Returns:
        //     A string representing the comment associated with the EnvDTE.CodeStruct.
        [DispId(38)]
        string Comment { get; set; }
        //
        // Summary:
        //     Gets a collection of objects derived from this EnvDTE.CodeStruct. Not implemented
        //     in Visual C#.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(44)]
        CodeElements DerivedTypes { get; }
        //
        // Summary:
        //     Gets or sets the document comment for the current EnvDTE.CodeStruct.
        //
        // Returns:
        //     A string representing the document comment for the current EnvDTE.CodeStruct.
        [DispId(37)]
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
        //     Gets the Extender category ID (CATID) for the object. This property is not
        //     implemented in Visual C#.
        //
        // Returns:
        //     A string in GUID format representing the CATID of the object as a string.
        [DispId(14)]
        string ExtenderCATID { get; }
        //
        // Summary:
        //     Gets a list of available Extenders for the object. This property is not implemented
        //     in Visual C#.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(12)]
        object ExtenderNames { get; }
        //
        // Summary:
        //     Gets the full path and name of the object's file.
        //
        // Returns:
        //     A string representing the full path and name of the EnvDTE.CodeStruct's file.
        [DispId(3)]
        string FullName { get; }
        //
        // Summary:
        //     Gets a collection of interfaces implemented by this EnvDTE.CodeStruct.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(61)]
        CodeElements ImplementedInterfaces { get; }
        ////
        //// Summary:
        ////     Gets the capabilities of the code model object..
        ////
        //// Returns:
        ////     A EnvDTE.vsCMInfoLocation constant value.
        //[DispId(7)]
        //vsCMInfoLocation InfoLocation { get; }
        //
        // Summary:
        //     Sets or gets whether or not an item is declared as abstract.
        //
        // Returns:
        //     A Boolean value indicating true if the item is declared as abstract; false
        //     otherwise.
        [DispId(62)]
        bool IsAbstract { get; set; }
        //
        // Summary:
        //     Gets whether a EnvDTE.CodeType object can be obtained from this object.
        //
        // Returns:
        //     A Boolean value indicating true if a EnvDTE.CodeType object can be obtained;
        //     otherwise it returns false.
        [DispId(6)]
        bool IsCodeType { get; }
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
        //     A string representing a EnvDTE.CodeModelLanguageConstants constant.
        [DispId(9)]
        string Language { get; }
        //
        // Summary:
        //     Gets a collection of EnvDTE.CodeElements contained by this EnvDTE.CodeStruct.
        //
        // Returns:
        //     A EnvDTE.CodeElements collection.
        [DispId(34)]
        CodeElements Members { get; }
        //
        // Summary:
        //     Sets or gets the name of the EnvDTE.CodeStruct.
        //
        // Returns:
        //     A string representing the name of the EnvDTE.CodeStruct
        [DispId(0)]
        string Name { get; set; }
        ////
        //// Summary:
        ////     Gets a EnvDTE.CodeNamespace object defining the parent namespace.
        ////
        //// Returns:
        ////     A EnvDTE.CodeNamespace object.
        //[DispId(32)]
        //CodeNamespace Namespace { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.CodeStruct object.
        //
        // Returns:
        //     A parent object.
        [DispId(31)]
        object Parent { get; }
        //
        // Summary:
        //     Gets the EnvDTE.ProjectItem object associated with the EnvDTE.CodeStruct
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
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddAttribute(System.String,System.String,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeAttribute object.
        //[DispId(40)]
        ////CodeAttribute AddAttribute(string Name, string Value, object Position = Type.Missing);
        ////
        //// Summary:
        ////     Adds an item to the list of inherited objects.
        ////
        //// Parameters:
        ////   Base:
        ////     Required. The class from which to derive implementation. For EnvDTE.CodeClass
        ////     objects, this is either a EnvDTE.CodeClass or a fully qualified type name.
        ////     Native Visual C++ requires the colon-separated (::) format for its fully
        ////     qualified type names. All other languages support the period-separated format.For
        ////     EnvDTE.CodeEnum objects, Base is a variant containing a fully qualified type
        ////     name or EnvDTE.CodeType object upon which the new enum is based. For C#,
        ////     this is the underlying type of enum.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddBase(System.Object,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeElement object.
        //[DispId(39)]
        //CodeElement AddBase(object Base, object Position = Type.Missing);
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
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddClass(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
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
        //[DispId(67)]
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
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddDelegate(System.String,System.Object,System.Object,EnvDTE.vsCMAccess)
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
        //[DispId(70)]
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
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddEnum(System.String,System.Object,System.Object,EnvDTE.vsCMAccess)
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
        //[DispId(69)]
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
        ////     such as a property-get or a method.
        ////
        ////   Type:
        ////     Required. A EnvDTE.vsCMTypeRef constant indicating the data type that the
        ////     function returns. This can be a EnvDTE.CodeTypeRef object, a EnvDTE.vsCMTypeRef
        ////     constant, or a fully qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddFunction(System.String,EnvDTE.vsCMFunction,System.Object,System.Object,EnvDTE.vsCMAccess,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        ////   Location:
        ////     Optional. The path and file name for the new definition. Depending on the
        ////     language, the path to the project file is either relative or absolute. The
        ////     file is added to the project if it is not already a project item. If the
        ////     file cannot be created and added to the project, then EnvDTE.CodeStruct.AddFunction(System.String,EnvDTE.vsCMFunction,System.Object,System.Object,EnvDTE.vsCMAccess,System.Object)
        ////     fails.
        ////
        //// Returns:
        ////     A EnvDTE.CodeFunction object.
        //[DispId(64)]
        //CodeFunction AddFunction(string Name, vsCMFunction Kind, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault, object Location = Type.Missing);
        ////
        //// Summary:
        ////     Adds an interface to the list of inherited objects.
        ////
        //// Parameters:
        ////   Base:
        ////     Required. The interface the class implements. This is either a EnvDTE.CodeInterface
        ////     or a fully-qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddImplementedInterface(System.Object,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        //// Returns:
        ////     A EnvDTE.CodeInterface object.
        //[DispId(63)]
        //CodeInterface AddImplementedInterface(object Base, object Position = Type.Missing);
        ////
        //// Summary:
        ////     Creates a new property code construct and inserts the code in the correct
        ////     location.
        ////
        //// Parameters:
        ////   GetterName:
        ////     Required. The name of the function that gets the property's value.
        ////
        ////   PutterName:
        ////     Required. The name of the function that sets the property.
        ////
        ////   Type:
        ////     Required. The type of property. This can be a EnvDTE.CodeTypeRef object,
        ////     a EnvDTE.vsCMTypeRef value, or a fully qualified type name.
        ////
        ////   Position:
        ////     Optional. Default = 0. The code element after which to add the new element.
        ////     If the value is a EnvDTE.CodeElement, then the new element is added immediately
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddProperty(System.String,System.String,System.Object,System.Object,EnvDTE.vsCMAccess,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. The access. A EnvDTE.vsCMAccess constant value.
        ////
        ////   Location:
        ////     Optional. The location.
        ////
        //// Returns:
        ////     A EnvDTE.CodeProperty object.
        //[DispId(66)]
        //CodeProperty AddProperty(string GetterName, string PutterName, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault, object Location = Type.Missing);
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
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddStruct(System.String,System.Object,System.Object,System.Object,EnvDTE.vsCMAccess)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
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
        //[DispId(68)]
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
        ////     after it.If the value is a Long data type, then EnvDTE.CodeStruct.AddVariable(System.String,System.Object,System.Object,EnvDTE.vsCMAccess,System.Object)
        ////     indicates the element after which to add the new element.Because collections
        ////     begin their count at 1, passing 0 indicates that the new element should be
        ////     placed at the beginning of the collection. A value of -1 means that the element
        ////     should be placed at the end.
        ////
        ////   Access:
        ////     Optional. A EnvDTE.vsCMAccess constant.
        ////
        ////   Location:
        ////     Optional. The path and file name for the new variable definition. Depending
        ////     on the language, the path to the project file is either relative or absolute.
        ////     The file is added to the project if it is not already a project item. If
        ////     the file cannot be created and added to the project, then EnvDTE.CodeStruct.AddVariable(System.String,System.Object,System.Object,EnvDTE.vsCMAccess,System.Object)
        ////     fails.
        ////
        //// Returns:
        ////     A EnvDTE.CodeVariable object.
        //[DispId(65)]
        //CodeVariable AddVariable(string Name, object Type, object Position = Type.Missing, vsCMAccess Access = vsCMAccess.vsCMAccessDefault, object Location = Type.Missing);
        [DispId(13)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
        [DispId(43)]
        bool get_IsDerivedFrom(string FullName);
        ////
        //// Summary:
        ////     Gets a EnvDTE.TextPoint object that marks the end of the code element definition.
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
        ////     Gets a EnvDTE.TextPoint object that defines the beginning of the code element
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
        //
        // Summary:
        //     Removes an object from the list of bases.
        //
        // Parameters:
        //   Element:
        //     Required. A EnvDTE.CodeElement or the name of one in the collection.
        [DispId(41)]
        void RemoveBase(object Element);
        //
        // Summary:
        //     Removes an interface from the list of implemented interfaces.
        //
        // Parameters:
        //   Element:
        //     Required. A EnvDTE.CodeElement or the name of one in the collection.
        [DispId(71)]
        void RemoveInterface(object Element);
        //
        // Summary:
        //     Removes a member code construct.
        //
        // Parameters:
        //   Element:
        //     Required. A EnvDTE.CodeElement object or the name of one in the collection.
        [DispId(42)]
        void RemoveMember(object Element);
    }
}
