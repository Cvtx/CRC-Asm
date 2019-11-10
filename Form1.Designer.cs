namespace CRC
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopCrcPanel = new System.Windows.Forms.Panel();
            this.BitsLabel = new System.Windows.Forms.Label();
            this.RefOutCB = new System.Windows.Forms.CheckBox();
            this.RefInCB = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.HideRegButton = new System.Windows.Forms.Button();
            this.HidePolyButton = new System.Windows.Forms.Button();
            this.CrcSelector = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msgScintilla = new ScintillaNET.Scintilla();
            this.scintillaAsm = new ScintillaNET.Scintilla();
            this.RegistersPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CxLabel = new System.Windows.Forms.Label();
            this.CxDecLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BxLabel = new System.Windows.Forms.Label();
            this.BxHexLabel = new System.Windows.Forms.Label();
            this.BxDecLabel = new System.Windows.Forms.Label();
            this.BxBinLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AxLabel = new System.Windows.Forms.Label();
            this.AxHexLabel = new System.Windows.Forms.Label();
            this.AxDecLabel = new System.Windows.Forms.Label();
            this.AxBinLabel = new System.Windows.Forms.Label();
            this.BinLabel = new System.Windows.Forms.Label();
            this.DecLabel = new System.Windows.Forms.Label();
            this.HexLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.NextStepButton = new System.Windows.Forms.Button();
            this.Commentary = new System.Windows.Forms.Label();
            this.CommentaryLabel = new System.Windows.Forms.Label();
            this.CrcPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.XorOutTextBox = new System.Windows.Forms.TextBox();
            this.XorOutLabel = new System.Windows.Forms.Label();
            this.InitTextBox = new System.Windows.Forms.TextBox();
            this.InitLabel = new System.Windows.Forms.Label();
            this.PolyTextBox = new System.Windows.Forms.TextBox();
            this.PolyLabel = new System.Windows.Forms.Label();
            this.BitsNumUD = new System.Windows.Forms.NumericUpDown();
            this.TopPanel.SuspendLayout();
            this.TopCrcPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.RegistersPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.CrcPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitsNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopPanel.Controls.Add(this.TopCrcPanel);
            this.TopPanel.Controls.Add(this.StartButton);
            this.TopPanel.Controls.Add(this.HideRegButton);
            this.TopPanel.Controls.Add(this.HidePolyButton);
            this.TopPanel.Controls.Add(this.CrcSelector);
            this.TopPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPanel.ForeColor = System.Drawing.Color.Black;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(806, 45);
            this.TopPanel.TabIndex = 0;
            // 
            // TopCrcPanel
            // 
            this.TopCrcPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopCrcPanel.Controls.Add(this.BitsNumUD);
            this.TopCrcPanel.Controls.Add(this.BitsLabel);
            this.TopCrcPanel.Controls.Add(this.RefOutCB);
            this.TopCrcPanel.Controls.Add(this.RefInCB);
            this.TopCrcPanel.Location = new System.Drawing.Point(221, 0);
            this.TopCrcPanel.Name = "TopCrcPanel";
            this.TopCrcPanel.Size = new System.Drawing.Size(428, 45);
            this.TopCrcPanel.TabIndex = 2;
            // 
            // BitsLabel
            // 
            this.BitsLabel.AutoSize = true;
            this.BitsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitsLabel.ForeColor = System.Drawing.Color.White;
            this.BitsLabel.Location = new System.Drawing.Point(13, 11);
            this.BitsLabel.Name = "BitsLabel";
            this.BitsLabel.Size = new System.Drawing.Size(82, 21);
            this.BitsLabel.TabIndex = 5;
            this.BitsLabel.Text = "Bits (1..64)";
            // 
            // RefOutCB
            // 
            this.RefOutCB.AutoSize = true;
            this.RefOutCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefOutCB.ForeColor = System.Drawing.Color.White;
            this.RefOutCB.Location = new System.Drawing.Point(334, 11);
            this.RefOutCB.Name = "RefOutCB";
            this.RefOutCB.Size = new System.Drawing.Size(78, 25);
            this.RefOutCB.TabIndex = 12;
            this.RefOutCB.Text = "RefOut";
            this.RefOutCB.UseVisualStyleBackColor = true;
            // 
            // RefInCB
            // 
            this.RefInCB.AutoSize = true;
            this.RefInCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefInCB.ForeColor = System.Drawing.Color.White;
            this.RefInCB.Location = new System.Drawing.Point(255, 11);
            this.RefInCB.Name = "RefInCB";
            this.RefInCB.Size = new System.Drawing.Size(65, 25);
            this.RefInCB.TabIndex = 11;
            this.RefInCB.Text = "RefIn";
            this.RefInCB.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Location = new System.Drawing.Point(672, 11);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(43, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // HideRegButton
            // 
            this.HideRegButton.BackColor = System.Drawing.Color.White;
            this.HideRegButton.BackgroundImage = global::CRC.Properties.Resources.down_arrow;
            this.HideRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HideRegButton.Location = new System.Drawing.Point(772, 12);
            this.HideRegButton.Name = "HideRegButton";
            this.HideRegButton.Size = new System.Drawing.Size(23, 23);
            this.HideRegButton.TabIndex = 3;
            this.HideRegButton.UseVisualStyleBackColor = false;
            this.HideRegButton.Click += new System.EventHandler(this.HideRegButton_Click);
            // 
            // HidePolyButton
            // 
            this.HidePolyButton.BackColor = System.Drawing.Color.White;
            this.HidePolyButton.BackgroundImage = global::CRC.Properties.Resources.down_arrow;
            this.HidePolyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HidePolyButton.Location = new System.Drawing.Point(743, 12);
            this.HidePolyButton.Name = "HidePolyButton";
            this.HidePolyButton.Size = new System.Drawing.Size(23, 23);
            this.HidePolyButton.TabIndex = 2;
            this.HidePolyButton.UseVisualStyleBackColor = false;
            this.HidePolyButton.Click += new System.EventHandler(this.HidePolyButton_Click);
            // 
            // CrcSelector
            // 
            this.CrcSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrcSelector.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrcSelector.ForeColor = System.Drawing.Color.Black;
            this.CrcSelector.FormattingEnabled = true;
            this.CrcSelector.Items.AddRange(new object[] {
            "Custom",
            "CRC-16 / MODBUS"});
            this.CrcSelector.Location = new System.Drawing.Point(12, 14);
            this.CrcSelector.Name = "CrcSelector";
            this.CrcSelector.Size = new System.Drawing.Size(121, 21);
            this.CrcSelector.TabIndex = 1;
            this.CrcSelector.SelectedIndexChanged += new System.EventHandler(this.CrcSelector_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.msgScintilla);
            this.panel2.Controls.Add(this.scintillaAsm);
            this.panel2.Controls.Add(this.RegistersPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.CrcPanel);
            this.panel2.Controls.Add(this.TopPanel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 566);
            this.panel2.TabIndex = 1;
            // 
            // msgScintilla
            // 
            this.msgScintilla.AutoCMaxHeight = 9;
            this.msgScintilla.CaretLineBackColor = System.Drawing.Color.Black;
            this.msgScintilla.CaretLineVisible = true;
            this.msgScintilla.Enabled = false;
            this.msgScintilla.HScrollBar = false;
            this.msgScintilla.Location = new System.Drawing.Point(270, 161);
            this.msgScintilla.Name = "msgScintilla";
            this.msgScintilla.ReadOnly = true;
            this.msgScintilla.Size = new System.Drawing.Size(137, 338);
            this.msgScintilla.TabIndex = 9;
            this.msgScintilla.VScrollBar = false;
            // 
            // scintillaAsm
            // 
            this.scintillaAsm.AutoCMaxHeight = 9;
            this.scintillaAsm.CaretLineBackColor = System.Drawing.Color.Black;
            this.scintillaAsm.CaretLineVisible = true;
            this.scintillaAsm.Enabled = false;
            this.scintillaAsm.HScrollBar = false;
            this.scintillaAsm.Lexer = ScintillaNET.Lexer.Asm;
            this.scintillaAsm.Location = new System.Drawing.Point(20, 161);
            this.scintillaAsm.Name = "scintillaAsm";
            this.scintillaAsm.Size = new System.Drawing.Size(231, 338);
            this.scintillaAsm.TabIndex = 7;
            this.scintillaAsm.Text = "\tmov crc, Init\r\n\tmov ax, crc\r\n\tmov bl, msgByte\r\n\txor ax, bx   \r\n\tmov ex, 9\r\n@@L1:" +
    "\r\n\tdec cx\r\n\tjcxz @@L2\r\n\tshr ax, 1      \r\n\tjnc  @@L1   \r\n\txor ax, $A001\r\n\tjmp @@L" +
    "1\r\n@@L2:         \r\n\tmov crc, ax";
            this.scintillaAsm.VScrollBar = false;
            // 
            // RegistersPanel
            // 
            this.RegistersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistersPanel.Controls.Add(this.panel9);
            this.RegistersPanel.Controls.Add(this.panel8);
            this.RegistersPanel.Controls.Add(this.panel5);
            this.RegistersPanel.Controls.Add(this.BinLabel);
            this.RegistersPanel.Controls.Add(this.DecLabel);
            this.RegistersPanel.Controls.Add(this.HexLabel);
            this.RegistersPanel.Controls.Add(this.label2);
            this.RegistersPanel.Location = new System.Drawing.Point(-2, 80);
            this.RegistersPanel.Name = "RegistersPanel";
            this.RegistersPanel.Size = new System.Drawing.Size(814, 66);
            this.RegistersPanel.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.CxLabel);
            this.panel9.Controls.Add(this.CxDecLabel);
            this.panel9.Location = new System.Drawing.Point(512, -1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(151, 66);
            this.panel9.TabIndex = 27;
            // 
            // CxLabel
            // 
            this.CxLabel.AutoSize = true;
            this.CxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CxLabel.ForeColor = System.Drawing.Color.White;
            this.CxLabel.Location = new System.Drawing.Point(5, 23);
            this.CxLabel.Name = "CxLabel";
            this.CxLabel.Size = new System.Drawing.Size(29, 21);
            this.CxLabel.TabIndex = 9;
            this.CxLabel.Text = "CX";
            // 
            // CxDecLabel
            // 
            this.CxDecLabel.AutoSize = true;
            this.CxDecLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CxDecLabel.ForeColor = System.Drawing.Color.White;
            this.CxDecLabel.Location = new System.Drawing.Point(50, 24);
            this.CxDecLabel.Name = "CxDecLabel";
            this.CxDecLabel.Size = new System.Drawing.Size(30, 17);
            this.CxDecLabel.TabIndex = 18;
            this.CxDecLabel.Text = "Dec";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.BxLabel);
            this.panel8.Controls.Add(this.BxHexLabel);
            this.panel8.Controls.Add(this.BxDecLabel);
            this.panel8.Controls.Add(this.BxBinLabel);
            this.panel8.Location = new System.Drawing.Point(362, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(151, 66);
            this.panel8.TabIndex = 27;
            // 
            // BxLabel
            // 
            this.BxLabel.AutoSize = true;
            this.BxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BxLabel.ForeColor = System.Drawing.Color.White;
            this.BxLabel.Location = new System.Drawing.Point(5, 23);
            this.BxLabel.Name = "BxLabel";
            this.BxLabel.Size = new System.Drawing.Size(28, 21);
            this.BxLabel.TabIndex = 9;
            this.BxLabel.Text = "BX";
            // 
            // BxHexLabel
            // 
            this.BxHexLabel.AutoSize = true;
            this.BxHexLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BxHexLabel.ForeColor = System.Drawing.Color.White;
            this.BxHexLabel.Location = new System.Drawing.Point(50, 3);
            this.BxHexLabel.Name = "BxHexLabel";
            this.BxHexLabel.Size = new System.Drawing.Size(30, 17);
            this.BxHexLabel.TabIndex = 17;
            this.BxHexLabel.Text = "Hex";
            // 
            // BxDecLabel
            // 
            this.BxDecLabel.AutoSize = true;
            this.BxDecLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BxDecLabel.ForeColor = System.Drawing.Color.White;
            this.BxDecLabel.Location = new System.Drawing.Point(50, 24);
            this.BxDecLabel.Name = "BxDecLabel";
            this.BxDecLabel.Size = new System.Drawing.Size(30, 17);
            this.BxDecLabel.TabIndex = 18;
            this.BxDecLabel.Text = "Dec";
            // 
            // BxBinLabel
            // 
            this.BxBinLabel.AutoSize = true;
            this.BxBinLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BxBinLabel.ForeColor = System.Drawing.Color.White;
            this.BxBinLabel.Location = new System.Drawing.Point(50, 45);
            this.BxBinLabel.Name = "BxBinLabel";
            this.BxBinLabel.Size = new System.Drawing.Size(25, 17);
            this.BxBinLabel.TabIndex = 19;
            this.BxBinLabel.Text = "Bin";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.AxLabel);
            this.panel5.Controls.Add(this.AxHexLabel);
            this.panel5.Controls.Add(this.AxDecLabel);
            this.panel5.Controls.Add(this.AxBinLabel);
            this.panel5.Location = new System.Drawing.Point(182, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(181, 66);
            this.panel5.TabIndex = 26;
            // 
            // AxLabel
            // 
            this.AxLabel.AutoSize = true;
            this.AxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AxLabel.ForeColor = System.Drawing.Color.White;
            this.AxLabel.Location = new System.Drawing.Point(5, 23);
            this.AxLabel.Name = "AxLabel";
            this.AxLabel.Size = new System.Drawing.Size(29, 21);
            this.AxLabel.TabIndex = 9;
            this.AxLabel.Text = "AX";
            // 
            // AxHexLabel
            // 
            this.AxHexLabel.AutoSize = true;
            this.AxHexLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AxHexLabel.ForeColor = System.Drawing.Color.White;
            this.AxHexLabel.Location = new System.Drawing.Point(50, 3);
            this.AxHexLabel.Name = "AxHexLabel";
            this.AxHexLabel.Size = new System.Drawing.Size(30, 17);
            this.AxHexLabel.TabIndex = 17;
            this.AxHexLabel.Text = "Hex";
            // 
            // AxDecLabel
            // 
            this.AxDecLabel.AutoSize = true;
            this.AxDecLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AxDecLabel.ForeColor = System.Drawing.Color.White;
            this.AxDecLabel.Location = new System.Drawing.Point(50, 24);
            this.AxDecLabel.Name = "AxDecLabel";
            this.AxDecLabel.Size = new System.Drawing.Size(30, 17);
            this.AxDecLabel.TabIndex = 18;
            this.AxDecLabel.Text = "Dec";
            // 
            // AxBinLabel
            // 
            this.AxBinLabel.AutoSize = true;
            this.AxBinLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AxBinLabel.ForeColor = System.Drawing.Color.White;
            this.AxBinLabel.Location = new System.Drawing.Point(50, 45);
            this.AxBinLabel.Name = "AxBinLabel";
            this.AxBinLabel.Size = new System.Drawing.Size(25, 17);
            this.AxBinLabel.TabIndex = 19;
            this.AxBinLabel.Text = "Bin";
            // 
            // BinLabel
            // 
            this.BinLabel.AutoSize = true;
            this.BinLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinLabel.ForeColor = System.Drawing.Color.White;
            this.BinLabel.Location = new System.Drawing.Point(121, 45);
            this.BinLabel.Name = "BinLabel";
            this.BinLabel.Size = new System.Drawing.Size(25, 17);
            this.BinLabel.TabIndex = 16;
            this.BinLabel.Text = "Bin";
            // 
            // DecLabel
            // 
            this.DecLabel.AutoSize = true;
            this.DecLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecLabel.ForeColor = System.Drawing.Color.White;
            this.DecLabel.Location = new System.Drawing.Point(121, 24);
            this.DecLabel.Name = "DecLabel";
            this.DecLabel.Size = new System.Drawing.Size(30, 17);
            this.DecLabel.TabIndex = 15;
            this.DecLabel.Text = "Dec";
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HexLabel.ForeColor = System.Drawing.Color.White;
            this.HexLabel.Location = new System.Drawing.Point(121, 3);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(30, 17);
            this.HexLabel.TabIndex = 14;
            this.HexLabel.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Регистры";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Commentary);
            this.panel1.Controls.Add(this.CommentaryLabel);
            this.panel1.Location = new System.Drawing.Point(-6, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 58);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.NextStepButton);
            this.panel4.Location = new System.Drawing.Point(574, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 61);
            this.panel4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Next Step";
            // 
            // NextStepButton
            // 
            this.NextStepButton.BackColor = System.Drawing.Color.White;
            this.NextStepButton.BackgroundImage = global::CRC.Properties.Resources.right_arrow;
            this.NextStepButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NextStepButton.Enabled = false;
            this.NextStepButton.Location = new System.Drawing.Point(173, 17);
            this.NextStepButton.Name = "NextStepButton";
            this.NextStepButton.Size = new System.Drawing.Size(23, 23);
            this.NextStepButton.TabIndex = 9;
            this.NextStepButton.UseVisualStyleBackColor = false;
            this.NextStepButton.Click += new System.EventHandler(this.NextStepButton_Click);
            // 
            // Commentary
            // 
            this.Commentary.AutoSize = true;
            this.Commentary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Commentary.ForeColor = System.Drawing.Color.White;
            this.Commentary.Location = new System.Drawing.Point(139, 15);
            this.Commentary.Name = "Commentary";
            this.Commentary.Size = new System.Drawing.Size(16, 21);
            this.Commentary.TabIndex = 8;
            this.Commentary.Text = "-";
            // 
            // CommentaryLabel
            // 
            this.CommentaryLabel.AutoSize = true;
            this.CommentaryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentaryLabel.ForeColor = System.Drawing.Color.White;
            this.CommentaryLabel.Location = new System.Drawing.Point(21, 15);
            this.CommentaryLabel.Name = "CommentaryLabel";
            this.CommentaryLabel.Size = new System.Drawing.Size(112, 21);
            this.CommentaryLabel.TabIndex = 7;
            this.CommentaryLabel.Text = "Комментарий:";
            // 
            // CrcPanel
            // 
            this.CrcPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CrcPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrcPanel.Controls.Add(this.panel7);
            this.CrcPanel.Controls.Add(this.panel6);
            this.CrcPanel.Controls.Add(this.XorOutTextBox);
            this.CrcPanel.Controls.Add(this.XorOutLabel);
            this.CrcPanel.Controls.Add(this.InitTextBox);
            this.CrcPanel.Controls.Add(this.InitLabel);
            this.CrcPanel.Controls.Add(this.PolyTextBox);
            this.CrcPanel.Controls.Add(this.PolyLabel);
            this.CrcPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrcPanel.ForeColor = System.Drawing.Color.Black;
            this.CrcPanel.Location = new System.Drawing.Point(-6, 45);
            this.CrcPanel.Name = "CrcPanel";
            this.CrcPanel.Size = new System.Drawing.Size(817, 36);
            this.CrcPanel.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(336, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 66);
            this.panel7.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(5, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 21);
            this.label16.TabIndex = 9;
            this.label16.Text = "AX";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(62, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Hex";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(62, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Dec";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(62, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 17);
            this.label19.TabIndex = 19;
            this.label19.Text = "Bin";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(332, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 66);
            this.panel6.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "AX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(62, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Hex";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(62, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Dec";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(62, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Bin";
            // 
            // XorOutTextBox
            // 
            this.XorOutTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XorOutTextBox.ForeColor = System.Drawing.Color.Black;
            this.XorOutTextBox.Location = new System.Drawing.Point(663, 4);
            this.XorOutTextBox.Name = "XorOutTextBox";
            this.XorOutTextBox.Size = new System.Drawing.Size(120, 22);
            this.XorOutTextBox.TabIndex = 11;
            // 
            // XorOutLabel
            // 
            this.XorOutLabel.AutoSize = true;
            this.XorOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XorOutLabel.ForeColor = System.Drawing.Color.White;
            this.XorOutLabel.Location = new System.Drawing.Point(557, 5);
            this.XorOutLabel.Name = "XorOutLabel";
            this.XorOutLabel.Size = new System.Drawing.Size(100, 21);
            this.XorOutLabel.TabIndex = 10;
            this.XorOutLabel.Text = "XorOut (Hex)";
            // 
            // InitTextBox
            // 
            this.InitTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitTextBox.ForeColor = System.Drawing.Color.Black;
            this.InitTextBox.Location = new System.Drawing.Point(376, 4);
            this.InitTextBox.Name = "InitTextBox";
            this.InitTextBox.Size = new System.Drawing.Size(120, 22);
            this.InitTextBox.TabIndex = 9;
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitLabel.ForeColor = System.Drawing.Color.White;
            this.InitLabel.Location = new System.Drawing.Point(296, 5);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(72, 21);
            this.InitLabel.TabIndex = 8;
            this.InitLabel.Text = "Init (Hex)";
            // 
            // PolyTextBox
            // 
            this.PolyTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolyTextBox.ForeColor = System.Drawing.Color.Black;
            this.PolyTextBox.Location = new System.Drawing.Point(101, 4);
            this.PolyTextBox.Name = "PolyTextBox";
            this.PolyTextBox.Size = new System.Drawing.Size(120, 22);
            this.PolyTextBox.TabIndex = 7;
            // 
            // PolyLabel
            // 
            this.PolyLabel.AutoSize = true;
            this.PolyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolyLabel.ForeColor = System.Drawing.Color.White;
            this.PolyLabel.Location = new System.Drawing.Point(13, 5);
            this.PolyLabel.Name = "PolyLabel";
            this.PolyLabel.Size = new System.Drawing.Size(79, 21);
            this.PolyLabel.TabIndex = 6;
            this.PolyLabel.Text = "Poly (Hex)";
            // 
            // BitsNumUD
            // 
            this.BitsNumUD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitsNumUD.Location = new System.Drawing.Point(128, 11);
            this.BitsNumUD.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.BitsNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BitsNumUD.Name = "BitsNumUD";
            this.BitsNumUD.Size = new System.Drawing.Size(66, 22);
            this.BitsNumUD.TabIndex = 13;
            this.BitsNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(820, 600);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "MainForm";
            this.Text = "CRC Step-by-Step";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopCrcPanel.ResumeLayout(false);
            this.TopCrcPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.RegistersPanel.ResumeLayout(false);
            this.RegistersPanel.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.CrcPanel.ResumeLayout(false);
            this.CrcPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitsNumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ComboBox CrcSelector;
        private System.Windows.Forms.Button HidePolyButton;
        private System.Windows.Forms.Button HideRegButton;
        private System.Windows.Forms.Label BitsLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CrcPanel;
        private System.Windows.Forms.TextBox XorOutTextBox;
        private System.Windows.Forms.Label XorOutLabel;
        private System.Windows.Forms.TextBox InitTextBox;
        private System.Windows.Forms.Label InitLabel;
        private System.Windows.Forms.TextBox PolyTextBox;
        private System.Windows.Forms.Label PolyLabel;
        private System.Windows.Forms.CheckBox RefOutCB;
        private System.Windows.Forms.CheckBox RefInCB;
        private System.Windows.Forms.Panel TopCrcPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Commentary;
        private System.Windows.Forms.Label CommentaryLabel;
        private System.Windows.Forms.Button StartButton;
        private ScintillaNET.Scintilla scintillaAsm;
        private System.Windows.Forms.Button NextStepButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private ScintillaNET.Scintilla msgScintilla;
        private System.Windows.Forms.Panel RegistersPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label CxLabel;
        private System.Windows.Forms.Label CxDecLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label BxLabel;
        private System.Windows.Forms.Label BxHexLabel;
        private System.Windows.Forms.Label BxDecLabel;
        private System.Windows.Forms.Label BxBinLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label AxLabel;
        private System.Windows.Forms.Label AxHexLabel;
        private System.Windows.Forms.Label AxDecLabel;
        private System.Windows.Forms.Label AxBinLabel;
        private System.Windows.Forms.Label BinLabel;
        private System.Windows.Forms.Label DecLabel;
        private System.Windows.Forms.Label HexLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown BitsNumUD;
    }
}

