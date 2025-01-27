Public Class Editor
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents titulo As System.Windows.Forms.Label
    Friend WithEvents Bguardar As System.Windows.Forms.Button
    Friend WithEvents Bnuevo As System.Windows.Forms.Button
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bcopiar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Editor))
        Me.RichTextBox = New System.Windows.Forms.RichTextBox
        Me.TextBox = New System.Windows.Forms.TextBox
        Me.Bguardar = New System.Windows.Forms.Button
        Me.titulo = New System.Windows.Forms.Label
        Me.Bcopiar = New System.Windows.Forms.Button
        Me.Bnuevo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'RichTextBox
        '
        Me.RichTextBox.BackColor = System.Drawing.SystemColors.Desktop
        Me.RichTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RichTextBox.Location = New System.Drawing.Point(34, 32)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(224, 160)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = "Caja de texto multilinea:" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Este ejemplo te permitira editar texto."
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(110, 200)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(72, 20)
        Me.TextBox.TabIndex = 1
        Me.TextBox.Text = ""
        '
        'Bguardar
        '
        Me.Bguardar.Location = New System.Drawing.Point(192, 232)
        Me.Bguardar.Name = "Bguardar"
        Me.Bguardar.Size = New System.Drawing.Size(64, 23)
        Me.Bguardar.TabIndex = 2
        Me.Bguardar.Text = "Guardar"
        '
        'titulo
        '
        Me.titulo.Location = New System.Drawing.Point(96, 8)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(104, 23)
        Me.titulo.TabIndex = 3
        Me.titulo.Text = "Digita tu texto aqui:"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bcopiar
        '
        Me.Bcopiar.Location = New System.Drawing.Point(34, 197)
        Me.Bcopiar.Name = "Bcopiar"
        Me.Bcopiar.Size = New System.Drawing.Size(64, 23)
        Me.Bcopiar.TabIndex = 4
        Me.Bcopiar.Text = "Copiar"
        '
        'Bnuevo
        '
        Me.Bnuevo.Location = New System.Drawing.Point(34, 232)
        Me.Bnuevo.Name = "Bnuevo"
        Me.Bnuevo.Size = New System.Drawing.Size(64, 23)
        Me.Bnuevo.TabIndex = 5
        Me.Bnuevo.Text = "Nuevo"
        '
        'Editor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Bnuevo)
        Me.Controls.Add(Me.Bcopiar)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.Bguardar)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.RichTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Editor"
        Me.Text = "Editor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Bguardar_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bguardar.Click
        RichTextBox.SaveFile("C:\RichTextBox.txt")
        RichTextBox.ReadOnly() = True
    End Sub

    Private Sub Bnuevo_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnuevo.Click
        RichTextBox.ResetText()
        RichTextBox.Text = "bienvenido a RichTextBox"
        RichTextBox.ReadOnly() = False
    End Sub

    Private Sub Bcopiar_onClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcopiar.Click
        TextBox.Text = RichTextBox.SelectedText()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox.ReadOnly() = True
        TextBox.ReadOnly() = True
    End Sub
End Class
