Public Class Clientes
    ' defino los atributos de la clase (dni, apellido, nombre, direccion, telefono)
    Private _dni As Integer
    Private _apellido As String
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    ' defino las propiedades de la clase
    Public Property Dni As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            _dni = value
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    ' defino el constructor de la clase
    Public Sub New(dni As Integer, apellido As String, nombre As String, direccion As String, telefono As String)
        _dni = dni
        _apellido = apellido
        _nombre = nombre
        _direccion = direccion
        _telefono = telefono
    End Sub
    ' defino un constructor vacio
    Public Sub New()

    End Sub

    ' defino el metodo ToString para la clase
    Public Overrides Function ToString() As String
        Return _dni & " - " & _apellido & ", " & _nombre
    End Function

End Class
