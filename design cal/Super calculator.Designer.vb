<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Super_calc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Super_calc))
        Me.Screen = New System.Windows.Forms.TextBox()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_moins = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_multiplication = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_egale = New System.Windows.Forms.Button()
        Me.btn_division = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_point = New System.Windows.Forms.Button()
        Me.btn_ans = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Minimise = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Scientifique = New System.Windows.Forms.Panel()
        Me.btn_cubique = New System.Windows.Forms.Button()
        Me.btn_puissance = New System.Windows.Forms.Button()
        Me.btn_racine = New System.Windows.Forms.Button()
        Me.btn_factoriel = New System.Windows.Forms.Button()
        Me.Answer_Box = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.DragBar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Switch = New MaterialSkin.Controls.Toggles.BasicToggle(Me.components)
        Me.Scientifique.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DragBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Screen
        '
        Me.Screen.BackColor = System.Drawing.Color.White
        Me.Screen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Screen.Font = New System.Drawing.Font("Zeroes Two", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Screen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Screen.Location = New System.Drawing.Point(0, 68)
        Me.Screen.Name = "Screen"
        Me.Screen.ReadOnly = True
        Me.Screen.Size = New System.Drawing.Size(249, 35)
        Me.Screen.TabIndex = 0
        Me.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.Transparent
        Me.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_1.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(0, 104)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(63, 58)
        Me.btn_1.TabIndex = 1
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.Transparent
        Me.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_2.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(62, 104)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(63, 58)
        Me.btn_2.TabIndex = 2
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.Transparent
        Me.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_3.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(124, 104)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(63, 58)
        Me.btn_3.TabIndex = 3
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_plus
        '
        Me.btn_plus.BackColor = System.Drawing.Color.Transparent
        Me.btn_plus.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_plus.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_plus.Location = New System.Drawing.Point(186, 104)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(63, 58)
        Me.btn_plus.TabIndex = 4
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = False
        '
        'btn_moins
        '
        Me.btn_moins.BackColor = System.Drawing.Color.Transparent
        Me.btn_moins.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_moins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_moins.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moins.Location = New System.Drawing.Point(186, 162)
        Me.btn_moins.Name = "btn_moins"
        Me.btn_moins.Size = New System.Drawing.Size(63, 58)
        Me.btn_moins.TabIndex = 8
        Me.btn_moins.Text = "-"
        Me.btn_moins.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.Color.Transparent
        Me.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_6.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(124, 162)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(63, 58)
        Me.btn_6.TabIndex = 7
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.Color.Transparent
        Me.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_5.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(62, 162)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(63, 58)
        Me.btn_5.TabIndex = 6
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.Color.Transparent
        Me.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_4.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(0, 162)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(63, 58)
        Me.btn_4.TabIndex = 5
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_multiplication
        '
        Me.btn_multiplication.BackColor = System.Drawing.Color.Transparent
        Me.btn_multiplication.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multiplication.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiplication.Location = New System.Drawing.Point(186, 220)
        Me.btn_multiplication.Name = "btn_multiplication"
        Me.btn_multiplication.Size = New System.Drawing.Size(63, 58)
        Me.btn_multiplication.TabIndex = 12
        Me.btn_multiplication.Text = "x"
        Me.btn_multiplication.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.Color.Transparent
        Me.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_9.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(124, 220)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(63, 58)
        Me.btn_9.TabIndex = 11
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.Color.Transparent
        Me.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_8.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(62, 220)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(63, 58)
        Me.btn_8.TabIndex = 10
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.Color.Transparent
        Me.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_7.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(0, 220)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(63, 58)
        Me.btn_7.TabIndex = 9
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_egale
        '
        Me.btn_egale.BackColor = System.Drawing.Color.Transparent
        Me.btn_egale.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_egale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_egale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_egale.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_egale.Location = New System.Drawing.Point(0, 334)
        Me.btn_egale.Name = "btn_egale"
        Me.btn_egale.Size = New System.Drawing.Size(125, 58)
        Me.btn_egale.TabIndex = 13
        Me.btn_egale.Text = "="
        Me.btn_egale.UseVisualStyleBackColor = False
        '
        'btn_division
        '
        Me.btn_division.BackColor = System.Drawing.Color.Transparent
        Me.btn_division.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_division.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_division.Location = New System.Drawing.Point(186, 277)
        Me.btn_division.Name = "btn_division"
        Me.btn_division.Size = New System.Drawing.Size(63, 58)
        Me.btn_division.TabIndex = 17
        Me.btn_division.Text = "/"
        Me.btn_division.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.Color.Transparent
        Me.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_0.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(124, 277)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(63, 58)
        Me.btn_0.TabIndex = 16
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'btn_point
        '
        Me.btn_point.BackColor = System.Drawing.Color.Transparent
        Me.btn_point.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_point.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_point.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_point.Location = New System.Drawing.Point(62, 277)
        Me.btn_point.Name = "btn_point"
        Me.btn_point.Size = New System.Drawing.Size(63, 58)
        Me.btn_point.TabIndex = 15
        Me.btn_point.Text = "."
        Me.btn_point.UseVisualStyleBackColor = False
        '
        'btn_ans
        '
        Me.btn_ans.BackColor = System.Drawing.Color.Transparent
        Me.btn_ans.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ans.Font = New System.Drawing.Font("Zeroes Two", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ans.Location = New System.Drawing.Point(0, 277)
        Me.btn_ans.Name = "btn_ans"
        Me.btn_ans.Size = New System.Drawing.Size(63, 58)
        Me.btn_ans.TabIndex = 14
        Me.btn_ans.Text = "Ans"
        Me.btn_ans.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(124, 334)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(63, 58)
        Me.btn_clear.TabIndex = 19
        Me.btn_clear.Text = "c"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(186, 334)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(63, 58)
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "⌫"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Minimise
        '
        Me.Minimise.BackColor = System.Drawing.Color.White
        Me.Minimise.BackgroundImage = Global.design_cal.My.Resources.Resources.underscore
        Me.Minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimise.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimise.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimise.Location = New System.Drawing.Point(193, 1)
        Me.Minimise.Name = "Minimise"
        Me.Minimise.Size = New System.Drawing.Size(27, 28)
        Me.Minimise.TabIndex = 22
        Me.Minimise.UseVisualStyleBackColor = False
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.White
        Me.Titre.Enabled = False
        Me.Titre.Font = New System.Drawing.Font("Neuropolitical Rg", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(65, 11)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(121, 13)
        Me.Titre.TabIndex = 23
        Me.Titre.Text = "Super Calculator"
        '
        'Scientifique
        '
        Me.Scientifique.BackColor = System.Drawing.Color.DimGray
        Me.Scientifique.Controls.Add(Me.btn_cubique)
        Me.Scientifique.Controls.Add(Me.btn_puissance)
        Me.Scientifique.Controls.Add(Me.btn_racine)
        Me.Scientifique.Controls.Add(Me.btn_factoriel)
        Me.Scientifique.Location = New System.Drawing.Point(248, 105)
        Me.Scientifique.Name = "Scientifique"
        Me.Scientifique.Size = New System.Drawing.Size(63, 230)
        Me.Scientifique.TabIndex = 24
        '
        'btn_cubique
        '
        Me.btn_cubique.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cubique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_cubique.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cubique.Font = New System.Drawing.Font("Zeroes Two", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cubique.Location = New System.Drawing.Point(0, 172)
        Me.btn_cubique.Name = "btn_cubique"
        Me.btn_cubique.Size = New System.Drawing.Size(63, 58)
        Me.btn_cubique.TabIndex = 28
        Me.btn_cubique.Text = "∛"
        Me.btn_cubique.UseVisualStyleBackColor = False
        '
        'btn_puissance
        '
        Me.btn_puissance.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_puissance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_puissance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_puissance.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_puissance.Location = New System.Drawing.Point(0, 57)
        Me.btn_puissance.Name = "btn_puissance"
        Me.btn_puissance.Size = New System.Drawing.Size(63, 58)
        Me.btn_puissance.TabIndex = 26
        Me.btn_puissance.Text = "yⁿ"
        Me.btn_puissance.UseVisualStyleBackColor = False
        '
        'btn_racine
        '
        Me.btn_racine.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_racine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_racine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_racine.Font = New System.Drawing.Font("Zeroes Two", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_racine.Location = New System.Drawing.Point(0, 115)
        Me.btn_racine.Name = "btn_racine"
        Me.btn_racine.Size = New System.Drawing.Size(63, 58)
        Me.btn_racine.TabIndex = 27
        Me.btn_racine.Text = "√"
        Me.btn_racine.UseVisualStyleBackColor = False
        '
        'btn_factoriel
        '
        Me.btn_factoriel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_factoriel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_factoriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_factoriel.Font = New System.Drawing.Font("Zeroes Two", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_factoriel.Location = New System.Drawing.Point(0, -1)
        Me.btn_factoriel.Name = "btn_factoriel"
        Me.btn_factoriel.Size = New System.Drawing.Size(63, 58)
        Me.btn_factoriel.TabIndex = 25
        Me.btn_factoriel.Text = "!"
        Me.btn_factoriel.UseVisualStyleBackColor = False
        '
        'Answer_Box
        '
        Me.Answer_Box.BackColor = System.Drawing.Color.White
        Me.Answer_Box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Answer_Box.Font = New System.Drawing.Font("Zeroes Two", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer_Box.ForeColor = System.Drawing.Color.Black
        Me.Answer_Box.Location = New System.Drawing.Point(0, 27)
        Me.Answer_Box.Name = "Answer_Box"
        Me.Answer_Box.ReadOnly = True
        Me.Answer_Box.Size = New System.Drawing.Size(249, 35)
        Me.Answer_Box.TabIndex = 31
        Me.Answer_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = Global.design_cal.My.Resources.Resources.attention_exclamation_warning_3d02badcb4494954_128x128
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Insert a number ")
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 73)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.White
        Me.btn_close.BackgroundImage = Global.design_cal.My.Resources.Resources.Power_Shutdown
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Location = New System.Drawing.Point(222, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 28)
        Me.btn_close.TabIndex = 21
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'DragBar
        '
        Me.DragBar.BackColor = System.Drawing.Color.White
        Me.DragBar.Location = New System.Drawing.Point(0, 0)
        Me.DragBar.Name = "DragBar"
        Me.DragBar.Size = New System.Drawing.Size(251, 31)
        Me.DragBar.TabIndex = 18
        Me.DragBar.TabStop = False
        '
        'Timer1
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Syntax Error"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "Scientific Buttons"
        '
        'Switch
        '
        Me.Switch.BackColor = System.Drawing.Color.Transparent
        Me.Switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Switch.Location = New System.Drawing.Point(0, 4)
        Me.Switch.MouseState = MaterialSkin.MouseState.HOVER
        Me.Switch.Name = "Switch"
        Me.Switch.Selected = True
        Me.Switch.Size = New System.Drawing.Size(40, 22)
        Me.Switch.TabIndex = 29
        Me.Switch.Text = "Switch"
        Me.ToolTip2.SetToolTip(Me.Switch, "Scientific Buttons")
        Me.Switch.UseVisualStyleBackColor = False
        '
        'Super_calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.design_cal.My.Resources.Resources.html_color_codes_color_tutorials_903ea3cb
        Me.ClientSize = New System.Drawing.Size(249, 393)
        Me.Controls.Add(Me.Minimise)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Answer_Box)
        Me.Controls.Add(Me.Screen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Switch)
        Me.Controls.Add(Me.Scientifique)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_division)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_point)
        Me.Controls.Add(Me.btn_ans)
        Me.Controls.Add(Me.btn_egale)
        Me.Controls.Add(Me.btn_multiplication)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_moins)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.DragBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Super_calc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Scientifique.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DragBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Screen As TextBox
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_moins As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_multiplication As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_egale As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_point As Button
    Friend WithEvents btn_ans As Button
    Friend WithEvents DragBar As PictureBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Minimise As Button
    Friend WithEvents Titre As Label
    Friend WithEvents Scientifique As Panel
    Friend WithEvents btn_cubique As Button
    Friend WithEvents btn_puissance As Button
    Friend WithEvents btn_racine As Button
    Friend WithEvents btn_factoriel As Button
    Friend WithEvents Switch As MaterialSkin.Controls.Toggles.BasicToggle
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Answer_Box As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
