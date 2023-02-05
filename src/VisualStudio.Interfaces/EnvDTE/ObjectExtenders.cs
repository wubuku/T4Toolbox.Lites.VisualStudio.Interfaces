#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Object that provides access to Automation Extenders.
    [Guid("8D0AA9CC-8465-42F3-AD6E-DFDE28CCC75D")]
    //[TypeLibType(4160)]
    public interface ObjectExtenders
    {
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(1)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.ObjectExtenders object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(2)]
        DTE Parent { get; }

        // Summary:
        //     Gets all CATIDs for the current selection.
        //
        // Returns:
        //     An object containing an automation-compliant array of GUID-valued strings.
        [DispId(7)]
        object GetContextualExtenderCATIDs();
        //
        // Summary:
        //     Gets an Extender for the given object under the specified category.
        //
        // Parameters:
        //   ExtenderCATID:
        //     Required. The Extender's CATID.
        //
        //   ExtenderName:
        //     Required. The Extender's name.
        //
        //   ExtendeeObject:
        //     Required. Represents the Extendee object instance.
        //
        // Returns:
        //     An Extender.
        [DispId(5)]
        object GetExtender(string ExtenderCATID, string ExtenderName, object ExtendeeObject);
        //
        // Summary:
        //     Gets all Extenders for the given object under the specified category.
        //
        // Parameters:
        //   ExtenderCATID:
        //     Required. The specified Extender CATID.
        //
        //   ExtendeeObject:
        //     Required. Represents the Extendee object instance.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(6)]
        object GetExtenderNames(string ExtenderCATID, object ExtendeeObject);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   ExtenderCATID:
        //     The CATID of the extender.
        //
        //   ExtenderName:
        //     The name of the extender.
        //
        // Returns:
        //     The localized name of the extender.
        [DispId(8)]
        //[TypeLibFunc(64)]
        string GetLocalizedExtenderName(string ExtenderCATID, string ExtenderName);
        ////
        //// Summary:
        ////     Registers an Extender Provider for a specific Extender category.
        ////
        //// Parameters:
        ////   ExtenderCATID:
        ////     Required. The Extender CATID.
        ////
        ////   ExtenderName:
        ////     Required. The Extender name. This is the programmatic name for the Extender
        ////     and is used in the call to EnvDTE.ObjectExtenders.GetExtender(System.String,System.String,System.Object).
        ////
        ////   ExtenderProvider:
        ////     Required. The Extender Provider which implements the EnvDTE.IExtenderProvider
        ////     interface.
        ////
        ////   LocalizedName:
        ////     Optional. The localized display name for the Extender.
        ////
        //// Returns:
        ////     An integer-valued cookie that identifies the registration. This cookie must
        ////     be passed back during EnvDTE.ObjectExtenders.UnregisterExtenderProvider(System.Int32).
        //[DispId(3)]
        //int RegisterExtenderProvider(string ExtenderCATID, string ExtenderName, IExtenderProvider ExtenderProvider, string LocalizedName = "");
        ////
        //// Summary:
        ////     Registers an Extender Provider for an IUnknown-based Extender category.
        ////
        //// Parameters:
        ////   ExtenderCATID:
        ////     Required. The Extender CATID.
        ////
        ////   ExtenderName:
        ////     Required. The Extender name. This is the programmatic name for the Extender
        ////     and is used in the call to EnvDTE.ObjectExtenders.GetExtender(System.String,System.String,System.Object).
        ////
        ////   ExtenderProvider:
        ////     Required. The Extender Provider which implements the EnvDTE.IExtenderProviderUnk
        ////     interface.
        ////
        ////   LocalizedName:
        ////     Optional. The localized display name for the Extender.
        ////
        //// Returns:
        ////     An integer-valued cookiethat identifies the registration. This cookie must
        ////     be passed back during EnvDTE.ObjectExtenders.UnregisterExtenderProvider(System.Int32).
        //[DispId(9)]
        //int RegisterExtenderProviderUnk(string ExtenderCATID, string ExtenderName, IExtenderProviderUnk ExtenderProvider, string LocalizedName = "");
        //
        // Summary:
        //     Unregister a previously registered Extender Provider.
        //
        // Parameters:
        //   Cookie:
        //     Required. The cookie identifying the Extender. This is the cookie returned
        //     to the Extender Provider when it calls the EnvDTE.ObjectExtenders.RegisterExtenderProvider(System.String,System.String,EnvDTE.IExtenderProvider,System.String)
        //     method.
        [DispId(4)]
        void UnregisterExtenderProvider(int Cookie);
    }
}
