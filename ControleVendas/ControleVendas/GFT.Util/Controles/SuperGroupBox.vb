Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Drawing
Public Class SuperGroupBox
    Inherits System.Windows.Forms.GroupBox

    Private borderColor As Color

    Public Property BorderCollor() As Color
        Get
            Return Me.borderColor
        End Get
        Set(value As Color)
            Me.borderColor = value
        End Set
    End Property




End Class
