<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Save = New System.Windows.Forms.Button()
        Me.dGrid = New System.Windows.Forms.DataGridView()
        Me.Edit = New System.Windows.Forms.Button()
        Me.txtPesquisar = New System.Windows.Forms.Button()
        Me.Exibir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPersonagem = New System.Windows.Forms.TextBox()
        Me.txtJogador = New System.Windows.Forms.TextBox()
        Me.txtIDJogador = New System.Windows.Forms.TextBox()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.txtClasse = New System.Windows.Forms.ComboBox()
        Me.txtLvl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(15, 193)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(117, 45)
        Me.Save.TabIndex = 6
        Me.Save.Text = "Salvar"
        Me.Save.UseVisualStyleBackColor = True
        '
        'dGrid
        '
        Me.dGrid.AllowUserToAddRows = False
        Me.dGrid.AllowUserToDeleteRows = False
        Me.dGrid.AllowUserToResizeColumns = False
        Me.dGrid.AllowUserToResizeRows = False
        Me.dGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGrid.Location = New System.Drawing.Point(12, 244)
        Me.dGrid.Name = "dGrid"
        Me.dGrid.ReadOnly = True
        Me.dGrid.Size = New System.Drawing.Size(776, 194)
        Me.dGrid.TabIndex = 2
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(261, 193)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(117, 45)
        Me.Edit.TabIndex = 8
        Me.Edit.Text = "Editar"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(138, 193)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(117, 45)
        Me.txtPesquisar.TabIndex = 7
        Me.txtPesquisar.Text = "Pesquisar"
        Me.txtPesquisar.UseVisualStyleBackColor = True
        '
        'Exibir
        '
        Me.Exibir.Location = New System.Drawing.Point(384, 193)
        Me.Exibir.Name = "Exibir"
        Me.Exibir.Size = New System.Drawing.Size(117, 45)
        Me.Exibir.TabIndex = 9
        Me.Exibir.Text = "Exibir"
        Me.Exibir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Jogador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Personagem"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Classe"
        '
        'txtPersonagem
        '
        Me.txtPersonagem.Location = New System.Drawing.Point(94, 81)
        Me.txtPersonagem.Name = "txtPersonagem"
        Me.txtPersonagem.Size = New System.Drawing.Size(138, 20)
        Me.txtPersonagem.TabIndex = 3
        '
        'txtJogador
        '
        Me.txtJogador.Location = New System.Drawing.Point(94, 55)
        Me.txtJogador.Name = "txtJogador"
        Me.txtJogador.Size = New System.Drawing.Size(138, 20)
        Me.txtJogador.TabIndex = 2
        '
        'txtIDJogador
        '
        Me.txtIDJogador.Location = New System.Drawing.Point(94, 26)
        Me.txtIDJogador.Name = "txtIDJogador"
        Me.txtIDJogador.Size = New System.Drawing.Size(57, 20)
        Me.txtIDJogador.TabIndex = 1
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(671, 193)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(117, 45)
        Me.btnDeletar.TabIndex = 10
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'txtClasse
        '
        Me.txtClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClasse.FormattingEnabled = True
        Me.txtClasse.Items.AddRange(New Object() {"Guerreiro", "Ladino", "Mago"})
        Me.txtClasse.Location = New System.Drawing.Point(94, 133)
        Me.txtClasse.Name = "txtClasse"
        Me.txtClasse.Size = New System.Drawing.Size(138, 21)
        Me.txtClasse.TabIndex = 5
        '
        'txtLvl
        '
        Me.txtLvl.Location = New System.Drawing.Point(94, 107)
        Me.txtLvl.Name = "txtLvl"
        Me.txtLvl.Size = New System.Drawing.Size(57, 20)
        Me.txtLvl.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Level"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtLvl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtClasse)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.txtIDJogador)
        Me.Controls.Add(Me.txtJogador)
        Me.Controls.Add(Me.txtPersonagem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Exibir)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.dGrid)
        Me.Controls.Add(Me.Save)
        Me.Name = "Form1"
        Me.Text = "CrudRPG"
        CType(Me.dGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Save As Button
    Friend WithEvents dGrid As DataGridView
    Friend WithEvents Edit As Button
    Friend WithEvents txtPesquisar As Button
    Friend WithEvents Exibir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPersonagem As TextBox
    Friend WithEvents txtJogador As TextBox
    Friend WithEvents txtIDJogador As TextBox
    Friend WithEvents btnDeletar As Button
    Friend WithEvents txtClasse As ComboBox
    Friend WithEvents txtLvl As TextBox
    Friend WithEvents Label5 As Label
End Class
