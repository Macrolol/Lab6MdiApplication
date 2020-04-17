'Author: Michael Dormon
'Date: 2020-03-14
'Description:
'   This is the form created for lab 4. The basic functionalality of the
'   form is to add cars to a list of car objects and to be able to edit them
'   This form is loosly based off of the forms created as examples by Kyle Chapman
'   these forms can be found at https://github.com/KyleChapman/SmashCharacters/blob/master/SmashCharacters/SmashCharacters.vb
'   and https://github.com/KyleChapman/CustomerList/blob/master/CustomerList/CustomerList.vb
Option Strict On
Public Class frmCars
    Dim selectedCar As Car
    Dim carList As New List(Of Car)
    Dim isAddingToListView As Boolean = False
    Dim isCarSelected As Boolean = False

#Region "Events"




    ''' <summary>
    ''' This is the event for the exit button on the form. This is the button that causes the form to close,
    ''' it does this using the Close() method of the form class and "Me" refers to current form that most of this
    ''' program is contained in.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' This is the event that is called when the reset button is clicked. It resets the values on the
    ''' form to the defaults using the SetDesfaults() subroutine. Note the List View is un-effected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    Friend Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If IsValidInput() Then
            If Not isCarSelected Then
                selectedCar = New Car(cboMake.Text, txtModel.Text, Convert.ToInt32(nudYear.Value), ckNew.Checked, Convert.ToDecimal(txtPrice.Text))
                carList.Add(selectedCar)
            Else

                selectedCar.Make = cboMake.Text
                selectedCar.Model = txtModel.Text
                selectedCar.Year = Convert.ToInt32(nudYear.Value)
                selectedCar.Price = Convert.ToDecimal(txtPrice.Text)
                selectedCar.NewStatus = ckNew.Checked


            End If

        End If

        SetDefaults()

    End Sub
#End Region

#Region "Subs"
    Sub PopulateListView()
        lvwOutput.Items.Clear()
        For car As Integer = 0 To carList.Count - 1
            Dim carItem As New ListViewItem()

            carItem.Checked = carList(car).NewStatus()
            carItem.SubItems.Add(carList(car).IdentificationNumber.ToString())
            carItem.SubItems.Add(carList(car).Make())
            carItem.SubItems.Add(carList(car).Model())
            carItem.SubItems.Add(carList(car).Year.ToString())
            carItem.SubItems.Add(carList(car).Price.ToString())

            isAddingToListView = True

            lvwOutput.Items.Add(carItem)

            isAddingToListView = False

        Next
    End Sub

    Sub SetDefaults()
        txtModel.Text = String.Empty
        cboMake.SelectedIndex = 0
        nudYear.Value = 2020
        ckNew.Checked = False
        txtPrice.Text = String.Empty
        PopulateListView()
        isCarSelected = False
        txtModel.Focus()
    End Sub
#End Region
#Region "Functions"
    Function IsValidInput() As Boolean

        Dim resultMessage As String = String.Empty
        Dim returnValue As Boolean = True

        If cboMake.Text.Trim.Length = 0 Then
            resultMessage &= "Please select the make of the car." & vbCrLf

            returnValue = False
        End If

        If txtModel.Text.Trim.Length = 0 Then
            resultMessage &= "Please enter the Model of the car." & vbCrLf

            returnValue = False
        End If

        If txtPrice.Text.Trim.Length = 0 Then
            resultMessage &= "Please enter the Price of the car." & vbCrLf

            returnValue = False
        End If

        If returnValue = False Then
            lblResult.Text = "ERRORS: " & vbCrLf & resultMessage
        Else
            lblResult.Text = String.Empty
        End If
        Return returnValue
    End Function

    Friend Sub lvwOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwOutput.SelectedIndexChanged

        If lvwOutput.SelectedIndices.Count = 1 Then
            selectedCar = carList(lvwOutput.SelectedIndices(0))
            isCarSelected = True

            txtModel.Text = selectedCar.Model
            txtPrice.Text = selectedCar.Price.ToString()
            cboMake.Text = selectedCar.Make
            ckNew.Checked = selectedCar.NewStatus
            nudYear.Value = selectedCar.Year
        Else
            isCarSelected = False
        End If
    End Sub

    Friend Sub lvwCharacters_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwOutput.ItemCheck


        If Not isAddingToListView Then


            e.NewValue = e.CurrentValue

        End If

    End Sub


#End Region
End Class
