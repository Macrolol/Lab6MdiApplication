<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCars
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.ckNew = New System.Windows.Forms.CheckBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.lvwOutput = New System.Windows.Forms.ListView()
        Me.chNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chIdentification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ttpCarForm = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(125, 47)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(46, 17)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(121, 82)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(50, 17)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(129, 114)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(42, 17)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(127, 143)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 17)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNew
        '
        Me.lblNew.Location = New System.Drawing.Point(132, 167)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(39, 17)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "&New:"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMake
        '
        Me.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Items.AddRange(New Object() {"Volkwagen", "Hyundai", "Honda", "Ford", "GMC", "Chevrolet"})
        Me.cboMake.Location = New System.Drawing.Point(177, 44)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(121, 24)
        Me.cboMake.TabIndex = 1
        Me.ttpCarForm.SetToolTip(Me.cboMake, "Select the make of the vehicle")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(177, 140)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPrice.TabIndex = 4
        Me.ttpCarForm.SetToolTip(Me.txtPrice, "Enter the price of the vehicle")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(177, 79)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 2
        Me.ttpCarForm.SetToolTip(Me.txtModel, "Enter the model of the vehicle")
        '
        'ckNew
        '
        Me.ckNew.AutoSize = True
        Me.ckNew.Location = New System.Drawing.Point(177, 168)
        Me.ckNew.Name = "ckNew"
        Me.ckNew.Size = New System.Drawing.Size(18, 17)
        Me.ckNew.TabIndex = 5
        Me.ttpCarForm.SetToolTip(Me.ckNew, "Is the vehicle new or used")
        Me.ckNew.UseVisualStyleBackColor = True
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(177, 112)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(121, 22)
        Me.nudYear.TabIndex = 3
        Me.ttpCarForm.SetToolTip(Me.nudYear, "Select the year of the vehicle")
        Me.nudYear.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'lvwOutput
        '
        Me.lvwOutput.CheckBoxes = True
        Me.lvwOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNew, Me.chIdentification, Me.chMake, Me.chModel, Me.chYear, Me.chPrice})
        Me.lvwOutput.FullRowSelect = True
        Me.lvwOutput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwOutput.HideSelection = False
        Me.lvwOutput.Location = New System.Drawing.Point(124, 191)
        Me.lvwOutput.MultiSelect = False
        Me.lvwOutput.Name = "lvwOutput"
        Me.lvwOutput.Size = New System.Drawing.Size(489, 226)
        Me.lvwOutput.TabIndex = 9
        Me.ttpCarForm.SetToolTip(Me.lvwOutput, "The entered vehicles will be displayed here, select a vehicle from the list to ed" &
        "it it")
        Me.lvwOutput.UseCompatibleStateImageBehavior = False
        Me.lvwOutput.View = System.Windows.Forms.View.Details
        '
        'chNew
        '
        Me.chNew.Text = "New"
        Me.chNew.Width = 40
        '
        'chIdentification
        '
        Me.chIdentification.Text = "ID"
        '
        'chMake
        '
        Me.chMake.Text = "Make"
        Me.chMake.Width = 70
        '
        'chModel
        '
        Me.chModel.Text = "Model"
        '
        'chYear
        '
        Me.chYear.Text = "Year"
        '
        'chPrice
        '
        Me.chPrice.Text = "Price"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(120, 446)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarForm.SetToolTip(Me.btnEnter, "Press this button to enter a new vehicle")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(201, 446)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.ttpCarForm.SetToolTip(Me.btnReset, "Press this button to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 446)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Close"
        Me.ttpCarForm.SetToolTip(Me.btnExit, "Press this button to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(619, 191)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(165, 226)
        Me.lblResult.TabIndex = 15
        '
        'frmCars
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(800, 493)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvwOutput)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.ckNew)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cboMake)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Name = "frmCars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Input Form"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents cboMake As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents ckNew As CheckBox
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents lvwOutput As ListView
    Friend WithEvents chNew As ColumnHeader
    Friend WithEvents chIdentification As ColumnHeader
    Friend WithEvents chMake As ColumnHeader
    Friend WithEvents chModel As ColumnHeader
    Friend WithEvents chYear As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents ttpCarForm As ToolTip
End Class
