namespace VSLangProj
{
    //[System.Runtime.InteropServices.Guid("B8758EE4-0553-4BC9-8432-440449D35C14")]
    public interface References : System.Collections.IEnumerable
    {
        [System.Runtime.InteropServices.DispId(6)]
        Reference Add(string bstrPath);
    }
}