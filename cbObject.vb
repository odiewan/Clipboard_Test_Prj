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
  Private _ShortName As String
  Public Property ShortName() As String
    Get
      _ShortName = Strings.Left(_Name, _ShortNameLen) + "..."
      Return _ShortName
    End Get
    Set
      _ShortName = Value
    End Set
  End Property

  '----------------------------------------------------------------------------
  Private _ShortNameLen As Integer
  Public Property ShortNameLen() As Integer
    Get
      Return _ShortNameLen
    End Get
    Set
      _ShortNameLen = Value
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
  Public sub cboIncCount()
    _Count += 1
   End Sub

  '----------------------------------------------------------------------------
  Public sub cboDecCount()
    _Count -= 1
   End Sub

  '----------------------------------------------------------------------------
  Public sub cboIncRank()
    _Rank += 1
   End Sub

  '----------------------------------------------------------------------------
  Public sub cboDecRank()
    _Rank -= 1
   End Sub


  '----------------------------------------------------------------------------
  Public Sub cboWrap()
    _WrappedName = "<" + _Name + ">"
  End Sub

  '----------------------------------------------------------------------------
  Public Sub New(ByRef nName As String)
    cboInit(nName)
  End Sub


  '----------------------------------------------------------------------------
  Public Sub cboInit(ByRef nName As String)
    _Name = nName
    _ShortNameLen = 45
    _ShortName = Strings.Left(_Name, _ShortNameLen)
    _Count += 1
    _Rank = 0
    cboWrap()
  End Sub

  '----------------------------------------------------------------------------
  Public Sub cboInitDef()
    _Name = "Default"
    _ShortNameLen = 45
    _ShortName = Strings.Left(_Name, _ShortNameLen)
    _Count = 1
    _Rank = 0
    cboWrap()
  End Sub

  '----------------------------------------------------------------------------
  Public Sub cboClear()
    _Name = ""
    _ShortNameLen = 45
    _ShortName = ""
    _WrappedName = ""
    _Count = 0
    _Rank = 0
  End Sub


End Class