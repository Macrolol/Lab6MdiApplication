'Author: Michael
'File: Car.vb
'Date:2020-03-11
'Description:
'   This is a car class that describes cars
'

Option Strict On
Public Class Car
#Region "Attributes"
    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private isNew As Boolean = False
    Private carPrice As Decimal = 0D
#End Region
#Region "Properties"
    ''' <summary>
    ''' This is the property for the carIdentificationNumber Attribute it is readOnly is it
    ''' only has a get and not a set
    ''' </summary>
    ''' <returns> carIdentificationNumber as an integer </returns>
    Friend ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' This is the property for the carCount Shared Attribute it is readOnly is it
    ''' only has a get and not a set
    ''' </summary>
    ''' <returns> carCount as an integer </returns>
    Public Shared ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' This is the property for the for the carMake Attribute it has get and set
    ''' </summary>
    ''' <returns> carMake as a String </returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property
    ''' <summary>
    ''' This is the property for the for the carModel Attribute it has get and set
    ''' </summary>
    ''' <returns> carModel as a String </returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' This is the property for the for the carYear Attribute it has get and set
    ''' </summary>
    ''' <returns> carYear as an Integer </returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' This is the property for the for the carPrice Attribute it has get and set
    ''' </summary>
    ''' <returns> carPrice as a Decimal </returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' This is the property for the for the newStatus Attribute it has get and set
    ''' </summary>
    ''' <returns> carMake as a String </returns>
    Public Property NewStatus() As Boolean
        Get
            Return isNew
        End Get
        Set(value As Boolean)
            isNew = value
        End Set
    End Property
#End Region

#Region "Constructors"
    ''' <summary>
    ''' This is the default constructor, it makes a plain car with default attributes
    ''' </summary>
    Friend Sub New()
        carCount += 1
        carIdentificationNumber = carCount

    End Sub

    ''' <summary>
    ''' This is the Parameterized constructor, it makes a car with the given parameters
    ''' </summary>
    ''' <param name="make"> sets this value to the carMake attribute</param>
    ''' <param name="model">sets this value to the carModel attribute</param>
    ''' <param name="year">sets this value to the carYear attribute</param>
    ''' <param name="isNew">sets this value to the newStatus attribute</param>
    ''' <param name="price">sets this value to the carPrice attribute</param>
    Public Sub New(make As String, model As String, year As Integer, isNew As Boolean, price As Decimal)
        Me.New()
        carMake = make
        carModel = model
        carYear = year
        newStatus = isNew
        carPrice = price
    End Sub
#End Region

#Region "Methods"

    ''' <summary>
    ''' This is a function that creates a string that represents the whole car object
    ''' </summary>
    ''' <returns>string representation of the car</returns>
    Public Function GetCarData() As String
        Dim carString As String
        Dim newString As String
        If isNew Then
            newString = "New"
        Else
            newString = "Used"
        End If
        carString = "A " & newString & " " & Convert.ToString(carYear) & " " & carMake & " " & carModel & " for $" & Convert.ToString(carPrice) & " with the ID number " & Convert.ToString(carIdentificationNumber)
        Return carString
    End Function
#End Region
End Class
