<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        LabelTitle = New Label()
        ButtonSatellites = New Button()
        ButtonSpacecraft = New Button()
        ButtonLanders = New Button()
        ButtonSpaceStations = New Button()
        LabelFooter = New Label()
        ButtonHome = New Button()
        ButtonExit = New Button()
        SuspendLayout()
        ' 
        ' LabelTitle
        ' 
        LabelTitle.BackColor = Color.MidnightBlue
        LabelTitle.Font = New Font("HP Simplified Hans", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.White
        LabelTitle.Location = New Point(12, 9)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(1058, 122)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Space Technology"
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ButtonSatellites
        ' 
        ButtonSatellites.BackColor = Color.Black
        ButtonSatellites.FlatStyle = FlatStyle.Flat
        ButtonSatellites.Font = New Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSatellites.ForeColor = Color.White
        ButtonSatellites.Location = New Point(12, 147)
        ButtonSatellites.Name = "ButtonSatellites"
        ButtonSatellites.Size = New Size(1058, 113)
        ButtonSatellites.TabIndex = 1
        ButtonSatellites.Text = "Satellites"
        ButtonSatellites.UseVisualStyleBackColor = False
        ' 
        ' ButtonSpacecraft
        ' 
        ButtonSpacecraft.BackColor = Color.Black
        ButtonSpacecraft.FlatStyle = FlatStyle.Flat
        ButtonSpacecraft.Font = New Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSpacecraft.ForeColor = Color.White
        ButtonSpacecraft.Location = New Point(12, 275)
        ButtonSpacecraft.Name = "ButtonSpacecraft"
        ButtonSpacecraft.Size = New Size(1058, 113)
        ButtonSpacecraft.TabIndex = 2
        ButtonSpacecraft.Text = "Spacecraft"
        ButtonSpacecraft.UseVisualStyleBackColor = False
        ' 
        ' ButtonLanders
        ' 
        ButtonLanders.BackColor = Color.Black
        ButtonLanders.FlatStyle = FlatStyle.Flat
        ButtonLanders.Font = New Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonLanders.ForeColor = Color.White
        ButtonLanders.Location = New Point(12, 404)
        ButtonLanders.Name = "ButtonLanders"
        ButtonLanders.Size = New Size(1058, 113)
        ButtonLanders.TabIndex = 3
        ButtonLanders.Text = "Landers"
        ButtonLanders.UseVisualStyleBackColor = False
        ' 
        ' ButtonSpaceStations
        ' 
        ButtonSpaceStations.BackColor = Color.Black
        ButtonSpaceStations.FlatStyle = FlatStyle.Flat
        ButtonSpaceStations.Font = New Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSpaceStations.ForeColor = Color.White
        ButtonSpaceStations.Location = New Point(12, 534)
        ButtonSpaceStations.Name = "ButtonSpaceStations"
        ButtonSpaceStations.Size = New Size(1058, 113)
        ButtonSpaceStations.TabIndex = 4
        ButtonSpaceStations.Text = "Space Stations"
        ButtonSpaceStations.UseVisualStyleBackColor = False
        ' 
        ' LabelFooter
        ' 
        LabelFooter.BackColor = Color.Navy
        LabelFooter.Font = New Font("HP Simplified Hans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelFooter.ForeColor = Color.White
        LabelFooter.Location = New Point(12, 659)
        LabelFooter.Name = "LabelFooter"
        LabelFooter.Size = New Size(1058, 85)
        LabelFooter.TabIndex = 5
        LabelFooter.Text = "App created by Lee Gallagher 2025"
        LabelFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ButtonHome
        ' 
        ButtonHome.BackColor = Color.Black
        ButtonHome.BackgroundImage = My.Resources.Resources.home_icon1
        ButtonHome.BackgroundImageLayout = ImageLayout.Stretch
        ButtonHome.FlatStyle = FlatStyle.Flat
        ButtonHome.ForeColor = Color.White
        ButtonHome.ImageAlign = ContentAlignment.TopLeft
        ButtonHome.Location = New Point(12, 674)
        ButtonHome.Name = "ButtonHome"
        ButtonHome.Size = New Size(64, 60)
        ButtonHome.TabIndex = 6
        ButtonHome.TextImageRelation = TextImageRelation.ImageAboveText
        ButtonHome.UseVisualStyleBackColor = False
        ' 
        ' ButtonExit
        ' 
        ButtonExit.BackColor = Color.Black
        ButtonExit.BackgroundImage = My.Resources.Resources.exit_icon
        ButtonExit.BackgroundImageLayout = ImageLayout.Stretch
        ButtonExit.FlatStyle = FlatStyle.Flat
        ButtonExit.ForeColor = Color.White
        ButtonExit.Location = New Point(1006, 674)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(64, 60)
        ButtonExit.TabIndex = 7
        ButtonExit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1082, 753)
        Controls.Add(ButtonExit)
        Controls.Add(ButtonHome)
        Controls.Add(LabelFooter)
        Controls.Add(ButtonSpaceStations)
        Controls.Add(ButtonLanders)
        Controls.Add(ButtonSpacecraft)
        Controls.Add(ButtonSatellites)
        Controls.Add(LabelTitle)
        Name = "Form1"
        Text = "Space Technology - Main Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonSatellites As Button
    Friend WithEvents ButtonSpacecraft As Button
    Friend WithEvents ButtonLanders As Button
    Friend WithEvents ButtonSpaceStations As Button
    Friend WithEvents LabelFooter As Label
    Friend WithEvents ButtonHome As Button
    Friend WithEvents ButtonExit As Button

End Class
