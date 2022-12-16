Namespace Part2
    Public Class Programmer
        Inherits Employee2      'inherits, untuk deklarasi parent nya si Class

        Private _transportasi As Double



        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _transportasi = transportasi
        End Sub
        Public Overrides Function ToString() As String
            Return $" {MyBase.ToString()}
Bonus transportasi : {_transportasi}"
        End Function
        Public Property Transportasi1 As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
            End Set
        End Property
    End Class
End Namespace