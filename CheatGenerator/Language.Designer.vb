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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CheatGenerator.Language", GetType(Language).Assembly)
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
        '''  Looks up a localized string similar to Activator.
        '''</summary>
        Public Shared ReadOnly Property Activator() As String
            Get
                Return ResourceManager.GetString("Activator", resourceCulture)
            End Get
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
        '''  Looks up a localized string similar to Category.
        '''</summary>
        Public Shared ReadOnly Property Category() As String
            Get
                Return ResourceManager.GetString("Category", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cheat Code Generator.
        '''</summary>
        Public Shared ReadOnly Property CodeGenerator() As String
            Get
                Return ResourceManager.GetString("CodeGenerator", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Code Type.
        '''</summary>
        Public Shared ReadOnly Property CodeType() As String
            Get
                Return ResourceManager.GetString("CodeType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You don&apos;t have any code generator plugins installed.  To use the code generator, install a valid code generator plugin and restart the program..
        '''</summary>
        Public Shared ReadOnly Property ErrorNoCheats() As String
            Get
                Return ResourceManager.GetString("ErrorNoCheats", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Game.
        '''</summary>
        Public Shared ReadOnly Property Game() As String
            Get
                Return ResourceManager.GetString("Game", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Generate.
        '''</summary>
        Public Shared ReadOnly Property Generate() As String
            Get
                Return ResourceManager.GetString("Generate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Property.
        '''</summary>
        Public Shared ReadOnly Property PropertyLbl() As String
            Get
                Return ResourceManager.GetString("PropertyLbl", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Region.
        '''</summary>
        Public Shared ReadOnly Property Region() As String
            Get
                Return ResourceManager.GetString("Region", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
