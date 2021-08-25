<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btncorr = New System.Windows.Forms.Button()
        Me.btnpat = New System.Windows.Forms.Button()
        Me.Titlebar = New System.Windows.Forms.Panel()
        Me.btnMinimizarMenu = New System.Windows.Forms.PictureBox()
        Me.btnCerrar_menu = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Titlebar.SuspendLayout()
        CType(Me.btnMinimizarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btncorr
        '
        Me.Btncorr.BackgroundImage = Global.CONEXXION_CLASE2.My.Resources.Resources._63142545_figura_de_hombre_en_ejecución_disciplinas_deportivas_icono_en_un_fondo_circular
        Me.Btncorr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btncorr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncorr.Location = New System.Drawing.Point(102, 80)
        Me.Btncorr.Name = "Btncorr"
        Me.Btncorr.Size = New System.Drawing.Size(115, 110)
        Me.Btncorr.TabIndex = 0
        Me.Btncorr.UseVisualStyleBackColor = True
        '
        'btnpat
        '
        Me.btnpat.BackgroundImage = Global.CONEXXION_CLASE2.My.Resources.Resources.línea_concepto_del_dinero_patrocinio_icono_ejemplo_linear_vector_símbolo_muestra_132544563
        Me.btnpat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpat.Location = New System.Drawing.Point(106, 250)
        Me.btnpat.Name = "btnpat"
        Me.btnpat.Size = New System.Drawing.Size(115, 110)
        Me.btnpat.TabIndex = 1
        Me.btnpat.UseVisualStyleBackColor = True
        '
        'Titlebar
        '
        Me.Titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Titlebar.Controls.Add(Me.LinkLabel1)
        Me.Titlebar.Controls.Add(Me.btnMinimizarMenu)
        Me.Titlebar.Controls.Add(Me.btnCerrar_menu)
        Me.Titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Titlebar.Location = New System.Drawing.Point(0, 0)
        Me.Titlebar.Name = "Titlebar"
        Me.Titlebar.Size = New System.Drawing.Size(348, 36)
        Me.Titlebar.TabIndex = 4
        '
        'btnMinimizarMenu
        '
        Me.btnMinimizarMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizarMenu.BackgroundImage = Global.CONEXXION_CLASE2.My.Resources.Resources.MINIMIZAR_NEGRO
        Me.btnMinimizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizarMenu.Location = New System.Drawing.Point(290, 0)
        Me.btnMinimizarMenu.Name = "btnMinimizarMenu"
        Me.btnMinimizarMenu.Size = New System.Drawing.Size(30, 20)
        Me.btnMinimizarMenu.TabIndex = 8
        Me.btnMinimizarMenu.TabStop = False
        '
        'btnCerrar_menu
        '
        Me.btnCerrar_menu.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_menu.BackgroundImage = Global.CONEXXION_CLASE2.My.Resources.Resources.cerrar_negro
        Me.btnCerrar_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_menu.Location = New System.Drawing.Point(318, 0)
        Me.btnCerrar_menu.Name = "btnCerrar_menu"
        Me.btnCerrar_menu.Size = New System.Drawing.Size(30, 20)
        Me.btnCerrar_menu.TabIndex = 3
        Me.btnCerrar_menu.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 435)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 15)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(102, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Corredores"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Patrocinadores"
        Me.Label2.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(107, 20)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cerrar sesion "
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(348, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Titlebar)
        Me.Controls.Add(Me.btnpat)
        Me.Controls.Add(Me.Btncorr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        Me.Titlebar.ResumeLayout(False)
        Me.Titlebar.PerformLayout()
        CType(Me.btnMinimizarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btncorr As Button
    Friend WithEvents btnpat As Button
    Friend WithEvents Titlebar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrar_menu As PictureBox
    Friend WithEvents btnMinimizarMenu As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
