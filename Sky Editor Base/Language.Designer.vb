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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SkyEditorBase.Language", GetType(Language).Assembly)
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
        '''  Looks up a localized string similar to The following commands are available:.
        '''</summary>
        Public Shared ReadOnly Property ConsoleAvailableCommands() As String
            Get
                Return ResourceManager.GetString("ConsoleAvailableCommands", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unknown command &quot;{0}&quot;..
        '''</summary>
        Public Shared ReadOnly Property ConsoleUnknownCommand() As String
            Get
                Return ResourceManager.GetString("ConsoleUnknownCommand", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cannot add a file at the given path: {0}.
        '''</summary>
        Public Shared ReadOnly Property ErrorCantAddFile() As String
            Get
                Return ResourceManager.GetString("ErrorCantAddFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Using GenericFile.Save() requires GenericFile.OriginalFilename to not be null..
        '''</summary>
        Public Shared ReadOnly Property ErrorNoSaveFilename() As String
            Get
                Return ResourceManager.GetString("ErrorNoSaveFilename", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Project {0} has a circular reference.  Skipping its compilation..
        '''</summary>
        Public Shared ReadOnly Property ErrorProjectCircularReference() As String
            Get
                Return ResourceManager.GetString("ErrorProjectCircularReference", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Attempted to write to a read-only file..
        '''</summary>
        Public Shared ReadOnly Property ErrorWrittenReadonly() As String
            Get
                Return ResourceManager.GetString("ErrorWrittenReadonly", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Executing {0} {1}.
        '''</summary>
        Public Shared ReadOnly Property ExecutingProgram() As String
            Get
                Return ResourceManager.GetString("ExecutingProgram", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to (Async) Executing {0} {1}.
        '''</summary>
        Public Shared ReadOnly Property ExecutingProgramAsync() As String
            Get
                Return ResourceManager.GetString("ExecutingProgramAsync", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extensions.
        '''</summary>
        Public Shared ReadOnly Property Extensions() As String
            Get
                Return ResourceManager.GetString("Extensions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed.
        '''</summary>
        Public Shared ReadOnly Property Failed() As String
            Get
                Return ResourceManager.GetString("Failed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {0} ({1} of {2}).
        '''</summary>
        Public Shared ReadOnly Property GenericLoadingXofY() As String
            Get
                Return ResourceManager.GetString("GenericLoadingXofY", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Installed.
        '''</summary>
        Public Shared ReadOnly Property Installed() As String
            Get
                Return ResourceManager.GetString("Installed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Building projects....
        '''</summary>
        Public Shared ReadOnly Property LoadingBuildingProjects() As String
            Get
                Return ResourceManager.GetString("LoadingBuildingProjects", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Building projects... ({0} of {1}).
        '''</summary>
        Public Shared ReadOnly Property LoadingBuildingProjectsXofY() As String
            Get
                Return ResourceManager.GetString("LoadingBuildingProjectsXofY", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Copying file....
        '''</summary>
        Public Shared ReadOnly Property LoadingCopyingFile() As String
            Get
                Return ResourceManager.GetString("LoadingCopyingFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Copying files....
        '''</summary>
        Public Shared ReadOnly Property LoadingCopyingFiles() As String
            Get
                Return ResourceManager.GetString("LoadingCopyingFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Deleting files....
        '''</summary>
        Public Shared ReadOnly Property LoadingDeletingFiles() As String
            Get
                Return ResourceManager.GetString("LoadingDeletingFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Plugin Helper.
        '''</summary>
        Public Shared ReadOnly Property PluginHelper() As String
            Get
                Return ResourceManager.GetString("PluginHelper", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Plugin Manager.
        '''</summary>
        Public Shared ReadOnly Property PluginManager() As String
            Get
                Return ResourceManager.GetString("PluginManager", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Plugins.
        '''</summary>
        Public Shared ReadOnly Property Plugins() As String
            Get
                Return ResourceManager.GetString("Plugins", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &quot;{0}&quot; finished running..
        '''</summary>
        Public Shared ReadOnly Property ProgramFinished() As String
            Get
                Return ResourceManager.GetString("ProgramFinished", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ready.
        '''</summary>
        Public Shared ReadOnly Property Ready() As String
            Get
                Return ResourceManager.GetString("Ready", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Settings.
        '''</summary>
        Public Shared ReadOnly Property Settings() As String
            Get
                Return ResourceManager.GetString("Settings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Waiting on {0}....
        '''</summary>
        Public Shared ReadOnly Property WaitingOnProgram() As String
            Get
                Return ResourceManager.GetString("WaitingOnProgram", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
