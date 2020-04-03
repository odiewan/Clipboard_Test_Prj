Public Class cbObject
  '----------------------------------------------------------------------------
  Private _Name As String
  Public Property Name() As String
    Get
      Return _Name
    End Get
    Set
      _Name = Value
    End Set
  End Property

  '----------------------------------------------------------------------------
  Private _WrappedName As String
  Public Property WrappedName() As String
    Get
      Return _WrappedName
    End Get
    Set
      _WrappedName = Value
    End Set
  End Property

  '----------------------------------------------------------------------------
  Private _Rank As Integer
  Public Property Rank() As Integer
    Get
      Return _Rank
    End Get
    Set
      _Rank = Value
    End Set
  End Property

  '----------------------------------------------------------------------------
  Private _Count As Integer
  Public Property Count() As Integer
    Get
      Return _Count
    End Get
    Set
      _Count = Value
    End Set
  End Property


  '----------------------------------------------------------------------------
  Public Sub cboWrap()
    _WrappedName = "<" + _Name + ">"
  End Sub

  '----------------------------------------------------------------------------
  Public Sub New(ByRef nName As String)
    _Name = nName
    _Count = 0
    _Rank = 0
    cboWrap()
  End Sub



End Class