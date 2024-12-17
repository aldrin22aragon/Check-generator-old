<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cbChequeCodes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewControl()
        Me.grpFields = New System.Windows.Forms.GroupBox()
        Me.tbXAxisAdjustment_ = New System.Windows.Forms.NumericUpDown()
        Me.tbYAxisAdjustment_ = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbHasChequeDate = New System.Windows.Forms.CheckBox()
        Me.chbCrossedCheque = New System.Windows.Forms.CheckBox()
        Me.tbAmountInWords = New System.Windows.Forms.TextBox()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.tbPayee2 = New System.Windows.Forms.TextBox()
        Me.tbPayee1 = New System.Windows.Forms.TextBox()
        Me.dtChequeDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEndorsement = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnPreviewEndorsement = New System.Windows.Forms.Button()
        Me.btnPrintEndorsement = New System.Windows.Forms.Button()
        Me.btnPreviewCheque = New System.Windows.Forms.Button()
        Me.printCheque = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnZout = New System.Windows.Forms.Button()
        Me.btnZin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnPrintCheque = New System.Windows.Forms.Button()
        Me.btnPrintAllCheque = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtImportPath = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstImportedCheques = New System.Windows.Forms.ListView()
        Me.itmnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pay1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pay2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clCrossed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsRecords = New System.Windows.Forms.ToolStripButton()
        Me.btnCodes = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsDt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.printEndorsement = New System.Drawing.Printing.PrintDocument()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.grpFields.SuspendLayout()
        CType(Me.tbXAxisAdjustment_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbYAxisAdjustment_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbChequeCodes
        '
        Me.cbChequeCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChequeCodes.FormattingEnabled = True
        Me.cbChequeCodes.Location = New System.Drawing.Point(57, 31)
        Me.cbChequeCodes.Margin = New System.Windows.Forms.Padding(2)
        Me.cbChequeCodes.Name = "cbChequeCodes"
        Me.cbChequeCodes.Size = New System.Drawing.Size(145, 25)
        Me.cbChequeCodes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code:"
        '
        'PrintPreview
        '
        Me.PrintPreview.AutoZoom = False
        Me.PrintPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreview.Location = New System.Drawing.Point(0, 177)
        Me.PrintPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(487, 396)
        Me.PrintPreview.TabIndex = 2
        '
        'grpFields
        '
        Me.grpFields.Controls.Add(Me.tbXAxisAdjustment_)
        Me.grpFields.Controls.Add(Me.tbYAxisAdjustment_)
        Me.grpFields.Controls.Add(Me.Label6)
        Me.grpFields.Controls.Add(Me.Label2)
        Me.grpFields.Controls.Add(Me.chbHasChequeDate)
        Me.grpFields.Controls.Add(Me.chbCrossedCheque)
        Me.grpFields.Controls.Add(Me.tbAmountInWords)
        Me.grpFields.Controls.Add(Me.tbAmount)
        Me.grpFields.Controls.Add(Me.tbPayee2)
        Me.grpFields.Controls.Add(Me.tbPayee1)
        Me.grpFields.Controls.Add(Me.dtChequeDate)
        Me.grpFields.Controls.Add(Me.Label4)
        Me.grpFields.Controls.Add(Me.Label3)
        Me.grpFields.Controls.Add(Me.cbChequeCodes)
        Me.grpFields.Controls.Add(Me.Label1)
        Me.grpFields.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFields.Location = New System.Drawing.Point(0, 0)
        Me.grpFields.Margin = New System.Windows.Forms.Padding(2)
        Me.grpFields.Name = "grpFields"
        Me.grpFields.Padding = New System.Windows.Forms.Padding(2)
        Me.grpFields.Size = New System.Drawing.Size(530, 230)
        Me.grpFields.TabIndex = 3
        Me.grpFields.TabStop = False
        Me.grpFields.Text = "Informations"
        '
        'tbXAxisAdjustment_
        '
        Me.tbXAxisAdjustment_.Location = New System.Drawing.Point(391, 202)
        Me.tbXAxisAdjustment_.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.tbXAxisAdjustment_.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.tbXAxisAdjustment_.Name = "tbXAxisAdjustment_"
        Me.tbXAxisAdjustment_.Size = New System.Drawing.Size(73, 23)
        Me.tbXAxisAdjustment_.TabIndex = 12
        Me.tbXAxisAdjustment_.Value = New Decimal(New Integer() {280, 0, 0, 0})
        '
        'tbYAxisAdjustment_
        '
        Me.tbYAxisAdjustment_.Location = New System.Drawing.Point(156, 202)
        Me.tbYAxisAdjustment_.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.tbYAxisAdjustment_.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.tbYAxisAdjustment_.Name = "tbYAxisAdjustment_"
        Me.tbYAxisAdjustment_.Size = New System.Drawing.Size(73, 23)
        Me.tbYAxisAdjustment_.TabIndex = 11
        Me.tbYAxisAdjustment_.Value = New Decimal(New Integer() {280, 0, 0, -2147483648})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 206)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "X Axis Adjustment:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Y Axis Adjustment:"
        '
        'chbHasChequeDate
        '
        Me.chbHasChequeDate.AutoSize = True
        Me.chbHasChequeDate.Checked = True
        Me.chbHasChequeDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbHasChequeDate.Location = New System.Drawing.Point(248, 32)
        Me.chbHasChequeDate.Margin = New System.Windows.Forms.Padding(2)
        Me.chbHasChequeDate.Name = "chbHasChequeDate"
        Me.chbHasChequeDate.Size = New System.Drawing.Size(66, 21)
        Me.chbHasChequeDate.TabIndex = 4
        Me.chbHasChequeDate.TabStop = False
        Me.chbHasChequeDate.Text = "Date:"
        Me.chbHasChequeDate.UseVisualStyleBackColor = True
        '
        'chbCrossedCheque
        '
        Me.chbCrossedCheque.AutoSize = True
        Me.chbCrossedCheque.Location = New System.Drawing.Point(248, 56)
        Me.chbCrossedCheque.Margin = New System.Windows.Forms.Padding(2)
        Me.chbCrossedCheque.Name = "chbCrossedCheque"
        Me.chbCrossedCheque.Size = New System.Drawing.Size(135, 21)
        Me.chbCrossedCheque.TabIndex = 4
        Me.chbCrossedCheque.TabStop = False
        Me.chbCrossedCheque.Text = "Crossed Check"
        Me.chbCrossedCheque.UseVisualStyleBackColor = True
        '
        'tbAmountInWords
        '
        Me.tbAmountInWords.Location = New System.Drawing.Point(14, 173)
        Me.tbAmountInWords.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAmountInWords.Name = "tbAmountInWords"
        Me.tbAmountInWords.ReadOnly = True
        Me.tbAmountInWords.Size = New System.Drawing.Size(511, 23)
        Me.tbAmountInWords.TabIndex = 6
        '
        'tbAmount
        '
        Me.tbAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbAmount.Location = New System.Drawing.Point(74, 146)
        Me.tbAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(155, 23)
        Me.tbAmount.TabIndex = 4
        '
        'tbPayee2
        '
        Me.tbPayee2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbPayee2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPayee2.Location = New System.Drawing.Point(12, 119)
        Me.tbPayee2.Margin = New System.Windows.Forms.Padding(2)
        Me.tbPayee2.Name = "tbPayee2"
        Me.tbPayee2.Size = New System.Drawing.Size(512, 23)
        Me.tbPayee2.TabIndex = 3
        '
        'tbPayee1
        '
        Me.tbPayee1.AutoCompleteCustomSource.AddRange(New String() {"test1"})
        Me.tbPayee1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbPayee1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPayee1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPayee1.Location = New System.Drawing.Point(12, 93)
        Me.tbPayee1.Margin = New System.Windows.Forms.Padding(2)
        Me.tbPayee1.Name = "tbPayee1"
        Me.tbPayee1.Size = New System.Drawing.Size(512, 23)
        Me.tbPayee1.TabIndex = 2
        '
        'dtChequeDate
        '
        Me.dtChequeDate.CustomFormat = "MMM dd, yyyy"
        Me.dtChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtChequeDate.Location = New System.Drawing.Point(310, 32)
        Me.dtChequeDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtChequeDate.Name = "dtChequeDate"
        Me.dtChequeDate.Size = New System.Drawing.Size(141, 23)
        Me.dtChequeDate.TabIndex = 2
        Me.dtChequeDate.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Payee Line:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEndorsement)
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 230)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(530, 176)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endorsment"
        '
        'txtEndorsement
        '
        Me.txtEndorsement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEndorsement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndorsement.Location = New System.Drawing.Point(2, 19)
        Me.txtEndorsement.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEndorsement.Multiline = True
        Me.txtEndorsement.Name = "txtEndorsement"
        Me.txtEndorsement.Size = New System.Drawing.Size(526, 110)
        Me.txtEndorsement.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnPreviewEndorsement)
        Me.Panel6.Controls.Add(Me.btnPrintEndorsement)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(2, 129)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(526, 45)
        Me.Panel6.TabIndex = 8
        '
        'btnPreviewEndorsement
        '
        Me.btnPreviewEndorsement.BackColor = System.Drawing.Color.Silver
        Me.btnPreviewEndorsement.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPreviewEndorsement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewEndorsement.Location = New System.Drawing.Point(331, 0)
        Me.btnPreviewEndorsement.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPreviewEndorsement.Name = "btnPreviewEndorsement"
        Me.btnPreviewEndorsement.Size = New System.Drawing.Size(86, 45)
        Me.btnPreviewEndorsement.TabIndex = 11
        Me.btnPreviewEndorsement.Text = "Preview"
        Me.btnPreviewEndorsement.UseVisualStyleBackColor = False
        '
        'btnPrintEndorsement
        '
        Me.btnPrintEndorsement.BackColor = System.Drawing.Color.Silver
        Me.btnPrintEndorsement.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrintEndorsement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintEndorsement.Location = New System.Drawing.Point(417, 0)
        Me.btnPrintEndorsement.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintEndorsement.Name = "btnPrintEndorsement"
        Me.btnPrintEndorsement.Size = New System.Drawing.Size(109, 45)
        Me.btnPrintEndorsement.TabIndex = 10
        Me.btnPrintEndorsement.Text = "Print Endorsement"
        Me.btnPrintEndorsement.UseVisualStyleBackColor = False
        '
        'btnPreviewCheque
        '
        Me.btnPreviewCheque.BackColor = System.Drawing.Color.Silver
        Me.btnPreviewCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewCheque.Location = New System.Drawing.Point(13, 7)
        Me.btnPreviewCheque.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPreviewCheque.Name = "btnPreviewCheque"
        Me.btnPreviewCheque.Size = New System.Drawing.Size(80, 44)
        Me.btnPreviewCheque.TabIndex = 6
        Me.btnPreviewCheque.Text = "Preview"
        Me.btnPreviewCheque.UseVisualStyleBackColor = False
        '
        'printCheque
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PrintPreview)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(536, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 573)
        Me.Panel1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnClear)
        Me.Panel4.Controls.Add(Me.btnZout)
        Me.Panel4.Controls.Add(Me.btnZin)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 115)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(487, 62)
        Me.Panel4.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(189, 0)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 62)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear List"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnZout
        '
        Me.btnZout.BackColor = System.Drawing.Color.Silver
        Me.btnZout.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnZout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZout.Image = CType(resources.GetObject("btnZout.Image"), System.Drawing.Image)
        Me.btnZout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZout.Location = New System.Drawing.Point(92, 0)
        Me.btnZout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZout.Name = "btnZout"
        Me.btnZout.Size = New System.Drawing.Size(97, 62)
        Me.btnZout.TabIndex = 0
        Me.btnZout.Text = "ZoomOut"
        Me.btnZout.UseVisualStyleBackColor = False
        '
        'btnZin
        '
        Me.btnZin.BackColor = System.Drawing.Color.Silver
        Me.btnZin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnZin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZin.Image = CType(resources.GetObject("btnZin.Image"), System.Drawing.Image)
        Me.btnZin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZin.Location = New System.Drawing.Point(0, 0)
        Me.btnZin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZin.Name = "btnZin"
        Me.btnZin.Size = New System.Drawing.Size(92, 62)
        Me.btnZin.TabIndex = 0
        Me.btnZin.Text = "ZoomIn"
        Me.btnZin.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 115)
        Me.Panel2.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnPrintCheque)
        Me.Panel5.Controls.Add(Me.btnPreviewCheque)
        Me.Panel5.Controls.Add(Me.btnPrintAllCheque)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 54)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(487, 61)
        Me.Panel5.TabIndex = 11
        '
        'btnPrintCheque
        '
        Me.btnPrintCheque.BackColor = System.Drawing.Color.Silver
        Me.btnPrintCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCheque.Location = New System.Drawing.Point(97, 7)
        Me.btnPrintCheque.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintCheque.Name = "btnPrintCheque"
        Me.btnPrintCheque.Size = New System.Drawing.Size(87, 44)
        Me.btnPrintCheque.TabIndex = 7
        Me.btnPrintCheque.Text = "Print"
        Me.btnPrintCheque.UseVisualStyleBackColor = False
        '
        'btnPrintAllCheque
        '
        Me.btnPrintAllCheque.BackColor = System.Drawing.Color.Silver
        Me.btnPrintAllCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAllCheque.Location = New System.Drawing.Point(188, 7)
        Me.btnPrintAllCheque.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintAllCheque.Name = "btnPrintAllCheque"
        Me.btnPrintAllCheque.Size = New System.Drawing.Size(96, 44)
        Me.btnPrintAllCheque.TabIndex = 8
        Me.btnPrintAllCheque.Text = "PrintAll"
        Me.btnPrintAllCheque.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtImportPath)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(487, 54)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Path"
        '
        'txtImportPath
        '
        Me.txtImportPath.AllowDrop = True
        Me.txtImportPath.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtImportPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImportPath.Location = New System.Drawing.Point(2, 19)
        Me.txtImportPath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImportPath.Name = "txtImportPath"
        Me.txtImportPath.ReadOnly = True
        Me.txtImportPath.Size = New System.Drawing.Size(483, 24)
        Me.txtImportPath.TabIndex = 10
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.15171!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.84829!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 37)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1025, 577)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.grpFields)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(530, 573)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstImportedCheques)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 406)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(530, 167)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imports"
        '
        'lstImportedCheques
        '
        Me.lstImportedCheques.AllowDrop = True
        Me.lstImportedCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itmnum, Me.code, Me.dt, Me.pay1, Me.pay2, Me.amount, Me.clCrossed})
        Me.lstImportedCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstImportedCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstImportedCheques.FullRowSelect = True
        Me.lstImportedCheques.GridLines = True
        Me.lstImportedCheques.HideSelection = False
        Me.lstImportedCheques.Location = New System.Drawing.Point(2, 18)
        Me.lstImportedCheques.Margin = New System.Windows.Forms.Padding(2)
        Me.lstImportedCheques.MultiSelect = False
        Me.lstImportedCheques.Name = "lstImportedCheques"
        Me.lstImportedCheques.Size = New System.Drawing.Size(526, 147)
        Me.lstImportedCheques.TabIndex = 0
        Me.lstImportedCheques.UseCompatibleStateImageBehavior = False
        Me.lstImportedCheques.View = System.Windows.Forms.View.Details
        '
        'itmnum
        '
        Me.itmnum.Text = "Item Number"
        Me.itmnum.Width = 126
        '
        'code
        '
        Me.code.Text = "Code"
        Me.code.Width = 80
        '
        'dt
        '
        Me.dt.Text = "Date"
        Me.dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dt.Width = 131
        '
        'pay1
        '
        Me.pay1.Text = "Payee Line1"
        Me.pay1.Width = 250
        '
        'pay2
        '
        Me.pay2.Text = "Payee Line 2"
        Me.pay2.Width = 270
        '
        'amount
        '
        Me.amount.Text = "Amount"
        '
        'clCrossed
        '
        Me.clCrossed.Text = "Crossed"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRecords, Me.btnCodes, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1025, 37)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsRecords
        '
        Me.tsRecords.Image = Global.CheckGenerator.My.Resources.Resources.records
        Me.tsRecords.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRecords.Name = "tsRecords"
        Me.tsRecords.Padding = New System.Windows.Forms.Padding(5)
        Me.tsRecords.Size = New System.Drawing.Size(83, 34)
        Me.tsRecords.Text = "Records"
        '
        'btnCodes
        '
        Me.btnCodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCodes.Image = CType(resources.GetObject("btnCodes.Image"), System.Drawing.Image)
        Me.btnCodes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCodes.Name = "btnCodes"
        Me.btnCodes.Size = New System.Drawing.Size(44, 34)
        Me.btnCodes.Text = "Codes"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.tsDt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1025, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripStatusLabel1.Text = "Date And Time :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'tsDt
        '
        Me.tsDt.ForeColor = System.Drawing.Color.Black
        Me.tsDt.Name = "tsDt"
        Me.tsDt.Size = New System.Drawing.Size(92, 17)
        Me.tsDt.Text = "00/00/00 00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'printEndorsement
        '
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 34)
        Me.ToolStripButton1.Text = "Settings"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ToolTipText = "Settings"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1025, 636)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Check Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpFields.ResumeLayout(False)
        Me.grpFields.PerformLayout()
        CType(Me.tbXAxisAdjustment_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbYAxisAdjustment_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbChequeCodes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintPreview As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents grpFields As System.Windows.Forms.GroupBox
    Friend WithEvents btnPreviewCheque As System.Windows.Forms.Button
    Friend WithEvents tbAmountInWords As System.Windows.Forms.TextBox
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbPayee1 As System.Windows.Forms.TextBox
    Friend WithEvents dtChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chbCrossedCheque As System.Windows.Forms.CheckBox
    Friend WithEvents printCheque As System.Drawing.Printing.PrintDocument
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnZin As System.Windows.Forms.Button
    Friend WithEvents btnZout As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents chbHasChequeDate As System.Windows.Forms.CheckBox
    Friend WithEvents tbPayee2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintCheque As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstImportedCheques As System.Windows.Forms.ListView
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents dt As System.Windows.Forms.ColumnHeader
    Friend WithEvents pay1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pay2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrintAllCheque As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtEndorsement As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents itmnum As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtImportPath As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrintEndorsement As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnPreviewEndorsement As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsRecords As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsDt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCodes As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents printEndorsement As Printing.PrintDocument
    Friend WithEvents clCrossed As ColumnHeader
    Friend WithEvents tbXAxisAdjustment_ As NumericUpDown
    Friend WithEvents tbYAxisAdjustment_ As NumericUpDown
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
