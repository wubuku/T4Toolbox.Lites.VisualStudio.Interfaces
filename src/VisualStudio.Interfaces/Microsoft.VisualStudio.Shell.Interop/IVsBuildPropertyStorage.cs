namespace Microsoft.VisualStudio.Shell.Interop 
{
    public interface IVsBuildPropertyStorage 
    {
        int GetItemAttribute (uint item, string pszAttributeName, out string pbstrAttributeValue);
        int GetPropertyValue (string pszPropName, string pszConfigName, uint storage, out string pbstrPropValue);
        int RemoveProperty (string pszPropName, string pszConfigName, uint storage);
        int SetItemAttribute (uint item, string pszAttributeName, string pszAttributeValue);
        int SetPropertyValue (string pszPropName, string pszConfigName, uint storage, string pszPropValue);
    }

}