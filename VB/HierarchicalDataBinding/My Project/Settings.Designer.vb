﻿' Developer Express Code Central Example:
' How to show check boxes near nodes and check child nodes when a parent node is checked
' 
' Modify our template to add the check edit near a node. Handle checked/unchecked
' events of this check edit and iterate via nodes to check/uncheck child nodes.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3466

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.225
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace