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
Imports System.Reflection

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
    Friend Class Language
        
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
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SkyEditor.Core.Language", GetType(Language).GetTypeInfo.Assembly)
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
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to All Files.
        '''</summary>
        Friend Shared ReadOnly Property AllFiles() As String
            Get
                Return ResourceManager.GetString("AllFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The following commands are available:.
        '''</summary>
        Friend Shared ReadOnly Property ConsoleAvailableCommands() As String
            Get
                Return ResourceManager.GetString("ConsoleAvailableCommands", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unknown command &quot;{0}&quot;..
        '''</summary>
        Friend Shared ReadOnly Property ConsoleUnknownCommand() As String
            Get
                Return ResourceManager.GetString("ConsoleUnknownCommand", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Directory.
        '''</summary>
        Friend Shared ReadOnly Property Directory() As String
            Get
                Return ResourceManager.GetString("Directory", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to StepCount cannot be 0..
        '''</summary>
        Friend Shared ReadOnly Property ErrorAsyncForInfiniteLoop() As String
            Get
                Return ResourceManager.GetString("ErrorAsyncForInfiniteLoop", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cannot add a file at the given path: {0}.
        '''</summary>
        Friend Shared ReadOnly Property ErrorCantAddFile() As String
            Get
                Return ResourceManager.GetString("ErrorCantAddFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The specified path neither points to an existing file nor an existing directory..
        '''</summary>
        Friend Shared ReadOnly Property ErrorFileOrDirDoesntExist() As String
            Get
                Return ResourceManager.GetString("ErrorFileOrDirDoesntExist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The action&apos;s ActionPath needs to contain at least 1 item..
        '''</summary>
        Friend Shared ReadOnly Property ErrorMenuActionEmptyActionPath() As String
            Get
                Return ResourceManager.GetString("ErrorMenuActionEmptyActionPath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Using GenericFile.Save() requires GenericFile.OriginalFilename to not be null..
        '''</summary>
        Friend Shared ReadOnly Property ErrorNoSaveFilename() As String
            Get
                Return ResourceManager.GetString("ErrorNoSaveFilename", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sanity check failed.  Out of a list of non-zero length, no item exists that equals the max item..
        '''</summary>
        Friend Shared ReadOnly Property ErrorSanityNoMax() As String
            Get
                Return ResourceManager.GetString("ErrorSanityNoMax", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The given type must implement ICreatableFile..
        '''</summary>
        Friend Shared ReadOnly Property ErrorTypeMustInheritICreatableFile() As String
            Get
                Return ResourceManager.GetString("ErrorTypeMustInheritICreatableFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The given type must implement IOpenableFile..
        '''</summary>
        Friend Shared ReadOnly Property ErrorTypeMustInheritIOpenableFile() As String
            Get
                Return ResourceManager.GetString("ErrorTypeMustInheritIOpenableFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The given type must provide a default constructor..
        '''</summary>
        Friend Shared ReadOnly Property ErrorTypeNoDefaultConstructor() As String
            Get
                Return ResourceManager.GetString("ErrorTypeNoDefaultConstructor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Attempted to write to a read-only file..
        '''</summary>
        Friend Shared ReadOnly Property ErrorWrittenReadonly() As String
            Get
                Return ResourceManager.GetString("ErrorWrittenReadonly", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to File.
        '''</summary>
        Friend Shared ReadOnly Property File() As String
            Get
                Return ResourceManager.GetString("File", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You!.
        '''</summary>
        Friend Shared ReadOnly Property PluginDevExtAuthor() As String
            Get
                Return ResourceManager.GetString("PluginDevExtAuthor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to All of the plugins that are placed in the development directory..
        '''</summary>
        Friend Shared ReadOnly Property PluginDevExtDescription() As String
            Get
                Return ResourceManager.GetString("PluginDevExtDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Development Plugins.
        '''</summary>
        Friend Shared ReadOnly Property PluginDevExtName() As String
            Get
                Return ResourceManager.GetString("PluginDevExtName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 0.0.
        '''</summary>
        Friend Shared ReadOnly Property PluginDevExtVersion() As String
            Get
                Return ResourceManager.GetString("PluginDevExtVersion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Project.
        '''</summary>
        Friend Shared ReadOnly Property Project() As String
            Get
                Return ResourceManager.GetString("Project", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sky Editor Projects.
        '''</summary>
        Friend Shared ReadOnly Property SkyEditorProjects() As String
            Get
                Return ResourceManager.GetString("SkyEditorProjects", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Solution Explorer.
        '''</summary>
        Friend Shared ReadOnly Property SolutionExplorerToolWindowTitle() As String
            Get
                Return ResourceManager.GetString("SolutionExplorerToolWindowTitle", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
