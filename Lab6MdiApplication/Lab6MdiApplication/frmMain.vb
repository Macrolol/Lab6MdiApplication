' Author: Michael Dormon (with acknowledgement to kyle chapman's "TheNetdExperience" https://github.com/KyleChapman/TheNetdExperience)
' Created 2020 - 4 - 11
'
' Description:
'   This is a Multi-Document-Interface that uses the last 2 labs we
'   we completed in NETD2201 as children.
'   The forms included are:
'   Text Editor lab 5
'   Car Form


Public Class frmMdiMain

#Region "Events"
    ''' <summary>
    ''' This is the event for when the save button is clicked it calls the save function of the child form if
    ''' if the child form is a text editor, otherwise it displays a message explianing the problem
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, tbSave.Click


        If TypeOf (ActiveMdiChild) Is frmTextEdit Then 'is the active child a text editor?
            CType(ActiveMdiChild, frmTextEdit).mnuSave_Click() 'use the child form save button
        Else
            MessageBox.Show("The current document does not have a save function.") 'child does not have a save function
        End If

    End Sub

    ''' <summary>
    ''' Same general funtion as the save button but it clicks the child form's save as button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click

        If TypeOf (ActiveMdiChild) Is frmTextEdit Then ' is the active child a text editor?
            CType(ActiveMdiChild, frmTextEdit).mnuSaveAs_Click() 'click save as
        Else
            MessageBox.Show("The current document does not have a save as function.") 'no saving on this form
        End If

    End Sub

    ''' <summary>
    ''' this is called when the open button is clicked. It uses the CreateNewTextEditor() function to
    ''' create a new text editor and passes the value of false which causes the function to open
    ''' an open file dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click, tbOpen.Click
        CreateNewTextEditor(False) 'sub call opens a new text editor with a file from an ofd

    End Sub

    ''' <summary>
    ''' called when the new button is clicked. Same functionality as open button but passes true to
    ''' the function to denote that it is not to open an ofd and just create the new form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click, tbNew.Click
        CreateNewTextEditor(True)

    End Sub

    ''' <summary>
    ''' called when the close button is clicked. Closes the active form until there are
    ''' no more children in which case closes the parent form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click

        If ActiveMdiChild Is Nothing Then ' is there an active child?
            Me.Close() 'close me
        Else
            ActiveMdiChild.Close() 'close child
        End If

    End Sub

    ''' <summary>
    ''' this is called when the exit putton is clicked. Creates a list of all the children
    ''' and itterates through them closing them all. Then closes itself
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click

        Dim children As Form() = MdiChildren 'create array of all child forms

        'for each of the child forms in the list 
        For Each child In children
            child.Close() 'close the child
        Next
        Me.Close() 'close myself

    End Sub

    ''' <summary>
    ''' this is called when the about button is clicked it just displays a message about 
    ''' the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click

        'display a message box that says stuff
        MessageBox.Show("Multi Editor" & vbCrLf & vbCrLf &
                         "By Michael Dormon" & vbCrLf & vbCrLf &
                         "April 11, 2020")
    End Sub

    ''' <summary>
    ''' this is called when the cut button is clicked. if the active child is a text 
    ''' editor, use it's cut button else beep to let the user know they've been bad
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click

        If TypeOf (ActiveMdiChild) Is frmTextEdit Then 'is the active child a text editor?
            CType(ActiveMdiChild, frmTextEdit).mnuCut_Click(Me, e) 'use the cut event from there
        Else
            Beep() 'bad user
        End If
    End Sub

    ''' <summary>
    ''' this is called when the copy button is used. it has the exact same functionality of 
    ''' cut exept it copies
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click

        If TypeOf (ActiveMdiChild) Is frmTextEdit Then 'is child text edit?
            CType(ActiveMdiChild, frmTextEdit).mnuCopy_Click(Me, e) 'use copy from child
        Else
            Beep() 'beep.
        End If
    End Sub

    ''' <summary>
    ''' called when paste is clicked. same as the above 2 but it pastes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        If TypeOf (ActiveMdiChild) Is frmTextEdit Then 'child is text editor?
            CType(ActiveMdiChild, frmTextEdit).mnuPaste_Click(Me, e) 'call child paste
        Else
            Beep() 'BEEEEEEP
        End If
    End Sub

    ''' <summary>
    ''' This is called when the Cascade button is clicked. Its uses the built in LayoutMdi sub
    ''' to make all the child forms cascade
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade) 'call LayoutMdi() sub pass the MdiLayout.Cascade value I think its just 0
    End Sub

    ''' <summary>
    ''' this is called when the tile vertical button is pressed. It uses the same sub as cascade 
    ''' but passes the MdiLayout.TileVertical value instead
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    ''' <summary>
    ''' this is called when the tile horizontal button is pressed. It uses the same sub as cascade 
    ''' but passes the MdiLayout.TileHorizontal value instead
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowTileHorizonal_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizonal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    ''' <summary>
    ''' this is called when the open car list button is pressed, it just creates a new car list and sets
    ''' it as a child of this form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowCarList_Click(sender As Object, e As EventArgs) Handles mnuWindowCarList.Click
        Dim newCarList As New frmCars 'initialize a car list form
        newCarList.MdiParent = Me 'the parent is me
        newCarList.Show() 'display the car list form
    End Sub
#End Region


#Region "Subroutine"
    ''' <summary>
    ''' this is a subroutine that is used to create new text editors. It takes a bool 
    ''' that denotes whether you want the new text editor to be blank or to use an ofd 
    ''' to open a file.
    ''' </summary>
    ''' <param name="isBlank"> boolean </param>
    Private Sub CreateNewTextEditor(isBlank As Boolean)

        Dim newTextEdit As New frmTextEdit 'create a new text editor

        newTextEdit.MdiParent = Me 'the new text editor is my child

        If Not isBlank Then 'do you want it to be blank?
            newTextEdit.mnuOpen_Click(Me, e:=New EventArgs) 'use open button of the new form
        End If

        newTextEdit.Show() 'show the new form

    End Sub
#End Region


End Class
