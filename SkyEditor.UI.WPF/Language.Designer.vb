﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class Language
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SkyEditor.UI.WPF.Language", GetType(Language).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Author.
        '''</summary>
        Public Shared ReadOnly Property Author() As String
            Get
                Return ResourceManager.GetString("Author", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Browse....
        '''</summary>
        Public Shared ReadOnly Property Browse() As String
            Get
                Return ResourceManager.GetString("Browse", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Build Progress.
        '''</summary>
        Public Shared ReadOnly Property BuildProgress() As String
            Get
                Return ResourceManager.GetString("BuildProgress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cancel.
        '''</summary>
        Public Shared ReadOnly Property Cancel() As String
            Get
                Return ResourceManager.GetString("Cancel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add _Folder.
        '''</summary>
        Public Shared ReadOnly Property ContextMenuAddFolder() As String
            Get
                Return ResourceManager.GetString("ContextMenuAddFolder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete.
        '''</summary>
        Public Shared ReadOnly Property Delete() As String
            Get
                Return ResourceManager.GetString("Delete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to delete this?.
        '''</summary>
        Public Shared ReadOnly Property DeleteItemConfirmation() As String
            Get
                Return ResourceManager.GetString("DeleteItemConfirmation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Description.
        '''</summary>
        Public Shared ReadOnly Property Description() As String
            Get
                Return ResourceManager.GetString("Description", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to close this file?  Any unsaved changes will be lost..
        '''</summary>
        Public Shared ReadOnly Property DocumentCloseConfirmation() As String
            Get
                Return ResourceManager.GetString("DocumentCloseConfirmation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Edit.
        '''</summary>
        Public Shared ReadOnly Property Edit() As String
            Get
                Return ResourceManager.GetString("Edit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to find file at &quot;{0}&quot;..
        '''</summary>
        Public Shared ReadOnly Property ErrorCantFindFileAt() As String
            Get
                Return ResourceManager.GetString("ErrorCantFindFileAt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The type &quot;{0}&quot; of the given object is not supported..
        '''</summary>
        Public Shared ReadOnly Property ErrorUnsupportedType() As String
            Get
                Return ResourceManager.GetString("ErrorUnsupportedType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extension Info.
        '''</summary>
        Public Shared ReadOnly Property ExtensionInfo() As String
            Get
                Return ResourceManager.GetString("ExtensionInfo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to File Type Selector.
        '''</summary>
        Public Shared ReadOnly Property FileTypeSelector() As String
            Get
                Return ResourceManager.GetString("FileTypeSelector", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to What type of file is this?.
        '''</summary>
        Public Shared ReadOnly Property FileTypeSelectorQuestion() As String
            Get
                Return ResourceManager.GetString("FileTypeSelectorQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sky Editor {0}{1}.
        '''</summary>
        Public Shared ReadOnly Property FormattedTitle() As String
            Get
                Return ResourceManager.GetString("FormattedTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Location.
        '''</summary>
        Public Shared ReadOnly Property Location() As String
            Get
                Return ResourceManager.GetString("Location", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sky Editor.
        '''</summary>
        Public Shared ReadOnly Property MainTitle() As String
            Get
                Return ResourceManager.GetString("MainTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add _Existing File.
        '''</summary>
        Public Shared ReadOnly Property MenuAddFile() As String
            Get
                Return ResourceManager.GetString("MenuAddFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add _Existing Project.
        '''</summary>
        Public Shared ReadOnly Property MenuAddProject() As String
            Get
                Return ResourceManager.GetString("MenuAddProject", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Create _File.
        '''</summary>
        Public Shared ReadOnly Property MenuCreateFile() As String
            Get
                Return ResourceManager.GetString("MenuCreateFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Create _Folder.
        '''</summary>
        Public Shared ReadOnly Property MenuCreateFolder() As String
            Get
                Return ResourceManager.GetString("MenuCreateFolder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Create _Project.
        '''</summary>
        Public Shared ReadOnly Property MenuCreateProject() As String
            Get
                Return ResourceManager.GetString("MenuCreateProject", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Delete.
        '''</summary>
        Public Shared ReadOnly Property MenuDelete() As String
            Get
                Return ResourceManager.GetString("MenuDelete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Development.
        '''</summary>
        Public Shared ReadOnly Property MenuDev() As String
            Get
                Return ResourceManager.GetString("MenuDev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Console.
        '''</summary>
        Public Shared ReadOnly Property MenuDevConsole() As String
            Get
                Return ResourceManager.GetString("MenuDevConsole", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Plugins.
        '''</summary>
        Public Shared ReadOnly Property MenuDevPlugins() As String
            Get
                Return ResourceManager.GetString("MenuDevPlugins", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _File.
        '''</summary>
        Public Shared ReadOnly Property MenuFile() As String
            Get
                Return ResourceManager.GetString("MenuFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _New.
        '''</summary>
        Public Shared ReadOnly Property MenuFileNew() As String
            Get
                Return ResourceManager.GetString("MenuFileNew", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _File.
        '''</summary>
        Public Shared ReadOnly Property MenuFileNewFile() As String
            Get
                Return ResourceManager.GetString("MenuFileNewFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Solution.
        '''</summary>
        Public Shared ReadOnly Property MenuFileNewSolution() As String
            Get
                Return ResourceManager.GetString("MenuFileNewSolution", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Open.
        '''</summary>
        Public Shared ReadOnly Property MenuFileOpen() As String
            Get
                Return ResourceManager.GetString("MenuFileOpen", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open (_Auto-Detect File Type).
        '''</summary>
        Public Shared ReadOnly Property MenuFileOpenAuto() As String
            Get
                Return ResourceManager.GetString("MenuFileOpenAuto", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open (Let me _Choose File Type).
        '''</summary>
        Public Shared ReadOnly Property MenuFileOpenManual() As String
            Get
                Return ResourceManager.GetString("MenuFileOpenManual", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Save.
        '''</summary>
        Public Shared ReadOnly Property MenuFileSave() As String
            Get
                Return ResourceManager.GetString("MenuFileSave", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Save All.
        '''</summary>
        Public Shared ReadOnly Property MenuFileSaveAll() As String
            Get
                Return ResourceManager.GetString("MenuFileSaveAll", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save _As....
        '''</summary>
        Public Shared ReadOnly Property MenuFileSaveAs() As String
            Get
                Return ResourceManager.GetString("MenuFileSaveAs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save _File.
        '''</summary>
        Public Shared ReadOnly Property MenuFileSaveFile() As String
            Get
                Return ResourceManager.GetString("MenuFileSaveFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save _As....
        '''</summary>
        Public Shared ReadOnly Property MenuFileSaveFileAs() As String
            Get
                Return ResourceManager.GetString("MenuFileSaveFileAs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save _Solution.
        '''</summary>
        Public Shared ReadOnly Property MenuFileSaveSolution() As String
            Get
                Return ResourceManager.GetString("MenuFileSaveSolution", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Properties.
        '''</summary>
        Public Shared ReadOnly Property MenuProperties() As String
            Get
                Return ResourceManager.GetString("MenuProperties", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Solution.
        '''</summary>
        Public Shared ReadOnly Property MenuSolution() As String
            Get
                Return ResourceManager.GetString("MenuSolution", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Build.
        '''</summary>
        Public Shared ReadOnly Property MenuSolutionBuild() As String
            Get
                Return ResourceManager.GetString("MenuSolutionBuild", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Tools.
        '''</summary>
        Public Shared ReadOnly Property MenuTools() As String
            Get
                Return ResourceManager.GetString("MenuTools", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Extensions.
        '''</summary>
        Public Shared ReadOnly Property MenuToolsExtensions() As String
            Get
                Return ResourceManager.GetString("MenuToolsExtensions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Settings.
        '''</summary>
        Public Shared ReadOnly Property MenuToolsSettings() As String
            Get
                Return ResourceManager.GetString("MenuToolsSettings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _View.
        '''</summary>
        Public Shared ReadOnly Property MenuView() As String
            Get
                Return ResourceManager.GetString("MenuView", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Solution _Build Progress.
        '''</summary>
        Public Shared ReadOnly Property MenuViewSolutionBuildProgress() As String
            Get
                Return ResourceManager.GetString("MenuViewSolutionBuildProgress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Solution _Explorer.
        '''</summary>
        Public Shared ReadOnly Property MenuViewSolutionExplorer() As String
            Get
                Return ResourceManager.GetString("MenuViewSolutionExplorer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Name.
        '''</summary>
        Public Shared ReadOnly Property Name() As String
            Get
                Return ResourceManager.GetString("Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to New File.
        '''</summary>
        Public Shared ReadOnly Property NewFile() As String
            Get
                Return ResourceManager.GetString("NewFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to What kind of file are you adding?.
        '''</summary>
        Public Shared ReadOnly Property NewFileQuestion() As String
            Get
                Return ResourceManager.GetString("NewFileQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to New Folder.
        '''</summary>
        Public Shared ReadOnly Property NewFolder() As String
            Get
                Return ResourceManager.GetString("NewFolder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to What should the folder be named?.
        '''</summary>
        Public Shared ReadOnly Property NewFolderQuestion() As String
            Get
                Return ResourceManager.GetString("NewFolderQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to What should the new file be called?.
        '''</summary>
        Public Shared ReadOnly Property NewNameWindowQuestion() As String
            Get
                Return ResourceManager.GetString("NewNameWindowQuestion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to New Solution.
        '''</summary>
        Public Shared ReadOnly Property NewSolution() As String
            Get
                Return ResourceManager.GetString("NewSolution", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to There is no available UI for this object of type &quot;{0}&quot;..
        '''</summary>
        Public Shared ReadOnly Property NoAvailableUI() As String
            Get
                Return ResourceManager.GetString("NoAvailableUI", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to OK.
        '''</summary>
        Public Shared ReadOnly Property OK() As String
            Get
                Return ResourceManager.GetString("OK", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Progress.
        '''</summary>
        Public Shared ReadOnly Property Progress() As String
            Get
                Return ResourceManager.GetString("Progress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Project Name.
        '''</summary>
        Public Shared ReadOnly Property ProjectName() As String
            Get
                Return ResourceManager.GetString("ProjectName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Solution Explorer.
        '''</summary>
        Public Shared ReadOnly Property SolutionExplorerToolWindowTitle() As String
            Get
                Return ResourceManager.GetString("SolutionExplorerToolWindowTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Status.
        '''</summary>
        Public Shared ReadOnly Property Status() As String
            Get
                Return ResourceManager.GetString("Status", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Type.
        '''</summary>
        Public Shared ReadOnly Property Type() As String
            Get
                Return ResourceManager.GetString("Type", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Version.
        '''</summary>
        Public Shared ReadOnly Property Version() As String
            Get
                Return ResourceManager.GetString("Version", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Alpha.
        '''</summary>
        Public Shared ReadOnly Property VersionPrefix() As String
            Get
                Return ResourceManager.GetString("VersionPrefix", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
