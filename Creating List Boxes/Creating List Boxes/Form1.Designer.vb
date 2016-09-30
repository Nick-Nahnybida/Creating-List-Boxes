<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listBoxDemo
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
        Me.Months = New System.Windows.Forms.ListBox()
        Me.Years = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Months
        '
        Me.Months.FormattingEnabled = True
        Me.Months.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.Months.Location = New System.Drawing.Point(22, 33)
        Me.Months.Name = "Months"
        Me.Months.Size = New System.Drawing.Size(120, 95)
        Me.Months.TabIndex = 0
        '
        'Years
        '
        Me.Years.FormattingEnabled = True
        Me.Years.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.Years.Location = New System.Drawing.Point(171, 33)
        Me.Years.Name = "Years"
        Me.Years.Size = New System.Drawing.Size(120, 95)
        Me.Years.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(22, 237)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(216, 237)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'listBoxDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 331)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Years)
        Me.Controls.Add(Me.Months)
        Me.Name = "listBoxDemo"
        Me.Text = "List Box Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Months As System.Windows.Forms.ListBox
    Friend WithEvents Years As System.Windows.Forms.ListBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
