#region 程序集 Microsoft.VisualStudio.Interop, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\PublicAssemblies\Microsoft.VisualStudio.Interop.dll
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System.Runtime.InteropServices;

namespace EnvDTE
{
    [Guid("B1AB3125-0744-4B46-AA7A-8902E36D2E15")]
    public abstract class Constants
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsDocumentKindText = "{8E7B96A8-E33D-11D0-A6D5-00C04FB67F6A}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsDocumentKindHTML = "{C76D83F8-A489-11D0-8195-00A0C91BBEE3}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsDocumentKindResource = "{00000000-0000-0000-0000-000000000000}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsDocumentKindBinary = "{25834150-CD7E-11D0-92DF-00A0C9138C45}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsViewKindPrimary = "{00000000-0000-0000-0000-000000000000}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsViewKindAny = "{FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsViewKindDebugging = "{7651A700-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsViewKindCode = "{7651A701-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsViewKindDesigner = "{7651A702-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsViewKindTextView = "{7651A703-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindTaskList = "{4A9B7E51-AA16-11D0-A8C5-00A0C921A4D2}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindToolbox = "{B1E99781-AB81-11D0-B683-00AA00A3EE26}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindCallStack = "{0504FF91-9D61-11D0-A794-00A0C9110051}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindThread = "{E62CE6A0-B439-11D0-A79D-00A0C9110051}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindLocals = "{4A18F9D0-B838-11D0-93EB-00A0C90F2734}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindAutoLocals = "{F2E84780-2AF1-11D1-A7FA-00A0C9110051}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindWatch = "{90243340-BD7A-11D0-93EF-00A0C90F2734}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindProperties = "{EEFA5220-E298-11D0-8F78-00A0C9110057}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindSolutionExplorer = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindOutput = "{34E76E81-EE4A-11D0-AE2E-00A0C90FFFC3}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindObjectBrowser = "{269A02DC-6AF8-11D3-BDC4-00C04F688E50}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindMacroExplorer = "{07CD18B4-3BA1-11D2-890A-0060083196C6}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindDynamicHelp = "{66DBA47C-61DF-11D2-AA79-00C04F990343}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindClassView = "{C9C0AE26-AA77-11D2-B3F0-0000F87570EE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindResourceView = "{2D7728C2-DE0A-45b5-99AA-89B609DFDE73}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindDocumentOutline = "{25F7E850-FFA1-11D0-B63F-00A0C922E851}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindServerExplorer = "{74946827-37A0-11D2-A273-00C04F8EF4FF}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindCommandWindow = "{28836128-FC2C-11D2-A433-00C04F72D18A}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindFindSymbol = "{53024D34-0EF5-11D3-87E0-00C04F7971A5}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindFindSymbolResults = "{68487888-204A-11D3-87EB-00C04F7971A5}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindFindReplace = "{CF2DDC32-8CAD-11D2-9302-005345000000}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindFindResults1 = "{0F887920-C2B6-11D2-9375-0080C747D9A0}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindFindResults2 = "{0F887921-C2B6-11D2-9375-0080C747D9A0}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindMainWindow = "{9DDABE98-1D02-11D3-89A1-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindLinkedWindowFrame = "{9DDABE99-1D02-11D3-89A1-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWindowKindWebBrowser = "{E8B06F52-6D01-11D2-AA7D-00C04F990343}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWizardAddSubProject = "{0F90E1D2-4999-11D1-B6D1-00A0C90F2744}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWizardAddItem = "{0F90E1D1-4999-11D1-B6D1-00A0C90F2744}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsWizardNewProject = "{0F90E1D0-4999-11D1-B6D1-00A0C90F2744}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectKindMisc = "{66A2671D-8FB5-11D2-AA7E-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemsKindMisc = "{66A2671E-8FB5-11D2-AA7E-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemKindMisc = "{66A2671F-8FB5-11D2-AA7E-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectKindUnmodeled = "{67294A52-A4F0-11D2-AA88-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectKindSolutionItems = "{66A26720-8FB5-11D2-AA7E-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemsKindSolutionItems = "{66A26721-8FB5-11D2-AA7E-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemKindSolutionItems = "{66A26722-8FB5-11D2-AA7E-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectsKindSolution = "{96410B9F-3542-4A14-877F-BC7227B51D3B}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsAddInCmdGroup = "{1E58696E-C90F-11D2-AAB2-00C04F688DDE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextSolutionBuilding = "{ADFC4E60-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextDebugging = "{ADFC4E61-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextFullScreenMode = "{ADFC4E62-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextDesignMode = "{ADFC4E63-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextNoSolution = "{ADFC4E64-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextEmptySolution = "{ADFC4E65-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextSolutionHasSingleProject = "{ADFC4E66-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextSolutionHasMultipleProjects = "{93694FA0-0397-11D1-9F4E-00A0C911004F}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextMacroRecording = "{04BBF6A5-4697-11D2-890E-0060083196C6}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsContextMacroRecordingToolbar = "{85A70471-270A-11D2-88F9-0060083196C6}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsMiscFilesProjectUniqueName = "<MiscFiles>";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsSolutionItemsProjectUniqueName = "<SolnItems>";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemKindPhysicalFile = "{6BB5F8EE-4483-11D3-8BCF-00C04F8EC28C}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemKindPhysicalFolder = "{6BB5F8EF-4483-11D3-8BCF-00C04F8EC28C}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemKindVirtualFolder = "{6BB5F8F0-4483-11D3-8BCF-00C04F8EC28C}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsProjectItemKindSubProject = "{EA6618E8-6E24-4528-94BE-6889FE16485C}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_vk_Primary = "{00000000-0000-0000-0000-000000000000}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_vk_Debugging = "{7651A700-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_vk_Code = "{7651A701-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_vk_Designer = "{7651A702-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_vk_TextView = "{7651A703-06E5-11D1-8EBD-00A0C90F26EA}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_TaskList = "{4A9B7E51-AA16-11D0-A8C5-00A0C921A4D2}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_Toolbox = "{B1E99781-AB81-11D0-B683-00AA00A3EE26}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_CallStackWindow = "{0504FF91-9D61-11D0-A794-00A0C9110051}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_ThreadWindow = "{E62CE6A0-B439-11D0-A79D-00A0C9110051}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_LocalsWindow = "{4A18F9D0-B838-11D0-93EB-00A0C90F2734}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_AutoLocalsWindow = "{F2E84780-2AF1-11D1-A7FA-00A0C9110051}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_WatchWindow = "{90243340-BD7A-11D0-93EF-00A0C90F2734}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_ImmedWindow = "{98731960-965C-11D0-A78F-00A0C9110051}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_PropertyBrowser = "{EEFA5220-E298-11D0-8F78-00A0C9110057}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_SProjectWindow = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_OutputWindow = "{34E76E81-EE4A-11D0-AE2E-00A0C90FFFC3}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_ObjectBrowser = "{269A02DC-6AF8-11D3-BDC4-00C04F688E50}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_ContextWindow = "{66DBA47C-61DF-11D2-AA79-00C04F990343}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_wk_ClassView = "{C9C0AE26-AA77-11D2-B3F0-0000F87570EE}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_GUID_AddItemWizard = "{0F90E1D1-4999-11D1-B6D1-00A0C90F2744}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsext_GUID_NewProjectWizard = "{0F90E1D0-4999-11D1-B6D1-00A0C90F2744}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsCPP = "C/C++";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsHTML_IE3 = "HTML - IE 3.0";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsHTML_RFC1866 = "HTML 2.0 (RFC 1866)";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsFortran_Fixed = "Fortran Fixed";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsFortran_Free = "Fortran Free";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsJava = "Java";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsVBSMacro = "VBS Macro";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string dsIDL = "ODL/IDL";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsCATIDSolution = "{52AEFF70-BBD8-11d2-8598-006097C68E81}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsCATIDSolutionBrowseObject = "{A2392464-7C22-11d3-BDCA-00C04F688E50}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsCATIDMiscFilesProject = "{610d4612-d0d5-11d2-8599-006097c68e81}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsCATIDMiscFilesProjectItem = "{610d4613-d0d5-11d2-8599-006097c68e81}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsCATIDGenericProject = "{610d4616-d0d5-11d2-8599-006097c68e81}";

        [MarshalAs(UnmanagedType.LPStr)]
        public const string vsCATIDDocument = "{610d4611-d0d5-11d2-8599-006097c68e81}";
    }
}