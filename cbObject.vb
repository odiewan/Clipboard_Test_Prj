
Imports System.Text.RegularExpressions

Public Class cbObject
  Enum CboType
    UNDEF
    TEXT
    LONGTEXT
    INT
    FLOAT
    LINK
  End Enum

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
  Public ReadOnly Property ShortName() As String
    Get
      If _Name.Length > 80 Then
        _ShortName = Strings.Left(_Name, _ShortNameLen) + "..."
      Else
        _ShortName = _Name
      End If
      Return _ShortName
    End Get
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
  Private _ValueAsInt As Integer
  Public Property ValueAsInt() As Integer
    Get
      Return _ValueAsInt
    End Get
    Set
      _ValueAsInt = Value
    End Set
  End Property

  '----------------------------------------------------------------------------
  Private _ValueAsDouble As Double
  Public Property ValueAsDouble() As Double
    Get
      Return _ValueAsDouble
    End Get
    Set
      _ValueAsDouble = Value
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
  Private _Type As CboType
  Public Property Type() As CboType
    Get
      Return _Type
    End Get
    Set
      'TODO det type
      _Type = Value
    End Set
  End Property


  '----------------------------------------------------------------------------
  Private _StatMsg As String
  Public Property StatMsg() As String
    Get
      Return _StatMsg
    End Get
    Set
      'TODO det type
      _StatMsg = Value
    End Set
  End Property


  '----------------------------------------------------------------------------
  Public Sub cboIncCount()
    _Count += 1
  End Sub

  '----------------------------------------------------------------------------
  Public Sub cboDecCount()
    _Count -= 1
  End Sub

  '----------------------------------------------------------------------------
  Public Sub cboIncRank()
    _Rank += 1
  End Sub

  '----------------------------------------------------------------------------
  Public Sub cboDecRank()
    _Rank -= 1
  End Sub
  Public Sub cboGetType()
    Dim patternEmail As String
    patternEmail = "http(s)?://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?"

    If Regex.IsMatch(_Name, patternEmail) Then
      _StatMsg = "LINK"
      _Type = CboType.LINK
    ElseIf Integer.TryParse(_Name, ValueAsInt) Then
      _Type = CboType.INT
      _StatMsg = "INT"
    ElseIf Double.TryParse(_Name, ValueAsDouble) Then
      _Type = CboType.FLOAT
      _StatMsg = "FLOAT"

    ElseIf Name.Length > 80 Then
      _Type = CboType.LONGTEXT
      _StatMsg = "LONGTEXT"
    Else
      _Type = CboType.TEXT
      _StatMsg = "Default: TEXT"
    End If
    'If _Name Then
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
    _ValueAsInt = 0
    _ValueAsDouble = 0
    _Count = 0
    _Rank = 0
    cboWrap()
    cboGetType()
  End Sub

  '----------------------------------------------------------------------------
  Public Sub cboInitDef()
    _Name = "Default"
    _ShortNameLen = 45
    _ValueAsInt = 0
    _ValueAsDouble = 0
    _ShortName = Strings.Left(_Name, _ShortNameLen)
    _Count = 1
    _Rank = 0
    cboWrap()
    cboGetType()
  End Sub

  '----------------------------------------------------------------------------
  Public Sub cboClear()
    _Name = ""
    _ShortNameLen = 45
    _ValueAsInt = 0
    _ValueAsDouble = 0
    _ShortName = ""
    _WrappedName = ""
    _Count = 0
    _Rank = 0
  End Sub


End Class