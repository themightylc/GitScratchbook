Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataContext = Me
    End Sub


    Private _Boxes As List(Of Box)
    Public ReadOnly Property Boxes As List(Of Box)
        Get
            If _Boxes Is Nothing Then
                _Boxes = {New Box() With {.Name = "Box 1"}, New Box() With {.Name = "Box 1"}}.ToList
            End If
            Return _Boxes
        End Get
    End Property




End Class

Public Class Box

    Public Property Name

    Private _Compartments As List(Of Compartment)
    Public ReadOnly Property Compartments As List(Of Compartment)
        Get
            If _Compartments Is Nothing Then
                _Compartments = {New Compartment(), New Compartment(), New Compartment(), New Compartment()}.ToList
            End If
            Return _Compartments
        End Get
    End Property
End Class



Public Class Compartment
    Shared _LastValue As Integer = 100

    Public Sub New()
        _LastValue = _LastValue + 100
        Me.TotalValue = _LastValue
    End Sub

    Public Property TotalValue



End Class
