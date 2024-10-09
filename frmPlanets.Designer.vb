<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picPlanet = New PictureBox()
        lblHeading = New Label()
        lblWeight = New Label()
        lblDisplayWeight = New Label()
        txtWeight = New TextBox()
        grpWeight = New GroupBox()
        radMars = New RadioButton()
        radVenus = New RadioButton()
        btnDisplay = New Button()
        btnClear = New Button()
        CType(picPlanet, ComponentModel.ISupportInitialize).BeginInit()
        grpWeight.SuspendLayout()
        SuspendLayout()
        ' 
        ' picPlanet
        ' 
        picPlanet.Dock = DockStyle.Left
        picPlanet.Image = My.Resources.Resources.planet
        picPlanet.Location = New Point(0, 0)
        picPlanet.Name = "picPlanet"
        picPlanet.Size = New Size(262, 331)
        picPlanet.SizeMode = PictureBoxSizeMode.StretchImage
        picPlanet.TabIndex = 0
        picPlanet.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(355, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(163, 28)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Venus or Mars?"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Goudy Old Style", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWeight.Location = New Point(358, 60)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(129, 25)
        lblWeight.TabIndex = 2
        lblWeight.Text = "Enter Weight:"
        ' 
        ' lblDisplayWeight
        ' 
        lblDisplayWeight.AutoSize = True
        lblDisplayWeight.Font = New Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDisplayWeight.Location = New Point(268, 284)
        lblDisplayWeight.Name = "lblDisplayWeight"
        lblDisplayWeight.Size = New Size(53, 21)
        lblDisplayWeight.TabIndex = 3
        lblDisplayWeight.Text = "Label3"
        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Goudy Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtWeight.Location = New Point(493, 60)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(38, 30)
        txtWeight.TabIndex = 4
        txtWeight.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpWeight
        ' 
        grpWeight.BackColor = Color.FloralWhite
        grpWeight.Controls.Add(radMars)
        grpWeight.Controls.Add(radVenus)
        grpWeight.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpWeight.Location = New Point(318, 141)
        grpWeight.Name = "grpWeight"
        grpWeight.Size = New Size(200, 80)
        grpWeight.TabIndex = 5
        grpWeight.TabStop = False
        grpWeight.Text = "Convert Weight"
        ' 
        ' radMars
        ' 
        radMars.AutoSize = True
        radMars.Font = New Font("Tahoma", 9.75F)
        radMars.Location = New Point(6, 45)
        radMars.Name = "radMars"
        radMars.Size = New Size(160, 20)
        radMars.TabIndex = 1
        radMars.Text = "Convert to Mars Weight"
        radMars.UseVisualStyleBackColor = True
        ' 
        ' radVenus
        ' 
        radVenus.AutoSize = True
        radVenus.Checked = True
        radVenus.Font = New Font("Tahoma", 9.75F)
        radVenus.Location = New Point(6, 20)
        radVenus.Name = "radVenus"
        radVenus.Size = New Size(167, 20)
        radVenus.TabIndex = 0
        radVenus.TabStop = True
        radVenus.Text = "Convert to Venus Weight"
        radVenus.UseVisualStyleBackColor = True
        ' 
        ' btnDisplay
        ' 
        btnDisplay.BackColor = Color.Goldenrod
        btnDisplay.Location = New Point(318, 246)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(75, 23)
        btnDisplay.TabIndex = 6
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Goldenrod
        btnClear.Location = New Point(431, 246)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' frmPlanets
        ' 
        AcceptButton = btnDisplay
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        CancelButton = btnClear
        ClientSize = New Size(612, 331)
        Controls.Add(btnClear)
        Controls.Add(btnDisplay)
        Controls.Add(grpWeight)
        Controls.Add(txtWeight)
        Controls.Add(lblDisplayWeight)
        Controls.Add(lblWeight)
        Controls.Add(lblHeading)
        Controls.Add(picPlanet)
        Name = "frmPlanets"
        Text = "Planets Weight"
        CType(picPlanet, ComponentModel.ISupportInitialize).EndInit()
        grpWeight.ResumeLayout(False)
        grpWeight.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPlanet As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblDisplayWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents grpWeight As GroupBox
    Friend WithEvents radMars As RadioButton
    Friend WithEvents radVenus As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button

End Class
