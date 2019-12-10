namespace CRC
{
    partial class BufferInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MsgPanel = new System.Windows.Forms.Panel();
            this.EndInputButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.ClearOneByteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HexInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BytesLeftLabel = new System.Windows.Forms.Label();
            this.InputByteButton = new System.Windows.Forms.Button();
            this.MsgScintilla = new ScintillaNET.Scintilla();
            this.label1 = new System.Windows.Forms.Label();
            this.BytesNumLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BytesNumericUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MsgPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HexInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BytesNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 228);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.MsgPanel);
            this.panel2.Controls.Add(this.BytesNumLabel);
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.BytesNumericUD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(14, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 216);
            this.panel2.TabIndex = 0;
            // 
            // MsgPanel
            // 
            this.MsgPanel.Controls.Add(this.EndInputButton);
            this.MsgPanel.Controls.Add(this.InputPanel);
            this.MsgPanel.Controls.Add(this.MsgScintilla);
            this.MsgPanel.Controls.Add(this.label1);
            this.MsgPanel.Location = new System.Drawing.Point(0, 56);
            this.MsgPanel.Name = "MsgPanel";
            this.MsgPanel.Size = new System.Drawing.Size(500, 160);
            this.MsgPanel.TabIndex = 20;
            this.MsgPanel.Visible = false;
            // 
            // EndInputButton
            // 
            this.EndInputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EndInputButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.EndInputButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.EndInputButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.EndInputButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.EndInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndInputButton.ForeColor = System.Drawing.Color.White;
            this.EndInputButton.Location = new System.Drawing.Point(384, 104);
            this.EndInputButton.Name = "EndInputButton";
            this.EndInputButton.Size = new System.Drawing.Size(67, 23);
            this.EndInputButton.TabIndex = 25;
            this.EndInputButton.TabStop = false;
            this.EndInputButton.Text = "Далее";
            this.EndInputButton.UseVisualStyleBackColor = true;
            this.EndInputButton.Visible = false;
            this.EndInputButton.Click += new System.EventHandler(this.EndInputButton_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.ClearOneByteButton);
            this.InputPanel.Controls.Add(this.label3);
            this.InputPanel.Controls.Add(this.HexInput);
            this.InputPanel.Controls.Add(this.label2);
            this.InputPanel.Controls.Add(this.BytesLeftLabel);
            this.InputPanel.Controls.Add(this.InputByteButton);
            this.InputPanel.Location = new System.Drawing.Point(320, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(180, 143);
            this.InputPanel.TabIndex = 25;
            // 
            // ClearOneByteButton
            // 
            this.ClearOneByteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearOneByteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClearOneByteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClearOneByteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClearOneByteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClearOneByteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearOneByteButton.ForeColor = System.Drawing.Color.White;
            this.ClearOneByteButton.Location = new System.Drawing.Point(139, 101);
            this.ClearOneByteButton.Name = "ClearOneByteButton";
            this.ClearOneByteButton.Size = new System.Drawing.Size(25, 23);
            this.ClearOneByteButton.TabIndex = 25;
            this.ClearOneByteButton.TabStop = false;
            this.ClearOneByteButton.Text = "<";
            this.ClearOneByteButton.UseVisualStyleBackColor = true;
            this.ClearOneByteButton.Click += new System.EventHandler(this.ClearOneByteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Осталось:";
            // 
            // HexInput
            // 
            this.HexInput.Hexadecimal = true;
            this.HexInput.Location = new System.Drawing.Point(29, 75);
            this.HexInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HexInput.Name = "HexInput";
            this.HexInput.Size = new System.Drawing.Size(135, 20);
            this.HexInput.TabIndex = 24;
            this.HexInput.Enter += new System.EventHandler(this.HexInput_Enter);
            this.HexInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HexInput_KeyDown);
            this.HexInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            this.HexInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HexInput_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ввод байтов (Hex)";
            // 
            // BytesLeftLabel
            // 
            this.BytesLeftLabel.AutoSize = true;
            this.BytesLeftLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BytesLeftLabel.ForeColor = System.Drawing.Color.White;
            this.BytesLeftLabel.Location = new System.Drawing.Point(112, 16);
            this.BytesLeftLabel.Name = "BytesLeftLabel";
            this.BytesLeftLabel.Size = new System.Drawing.Size(19, 21);
            this.BytesLeftLabel.TabIndex = 23;
            this.BytesLeftLabel.Text = "0";
            // 
            // InputByteButton
            // 
            this.InputByteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InputByteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.InputByteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.InputByteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.InputByteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.InputByteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputByteButton.ForeColor = System.Drawing.Color.White;
            this.InputByteButton.Location = new System.Drawing.Point(64, 101);
            this.InputByteButton.Name = "InputByteButton";
            this.InputByteButton.Size = new System.Drawing.Size(67, 23);
            this.InputByteButton.TabIndex = 22;
            this.InputByteButton.TabStop = false;
            this.InputByteButton.Text = "Ввод";
            this.InputByteButton.UseVisualStyleBackColor = true;
            this.InputByteButton.Click += new System.EventHandler(this.InputByteButton_Click_1);
            // 
            // MsgScintilla
            // 
            this.MsgScintilla.AutoCMaxHeight = 9;
            this.MsgScintilla.HScrollBar = false;
            this.MsgScintilla.Location = new System.Drawing.Point(17, 43);
            this.MsgScintilla.Name = "MsgScintilla";
            this.MsgScintilla.ReadOnly = true;
            this.MsgScintilla.Size = new System.Drawing.Size(297, 100);
            this.MsgScintilla.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Сообщение";
            // 
            // BytesNumLabel
            // 
            this.BytesNumLabel.AutoSize = true;
            this.BytesNumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BytesNumLabel.ForeColor = System.Drawing.Color.White;
            this.BytesNumLabel.Location = new System.Drawing.Point(235, 13);
            this.BytesNumLabel.Name = "BytesNumLabel";
            this.BytesNumLabel.Size = new System.Drawing.Size(19, 21);
            this.BytesNumLabel.TabIndex = 16;
            this.BytesNumLabel.Text = "0";
            this.BytesNumLabel.Visible = false;
            // 
            // NextButton
            // 
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.NextButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(330, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(67, 23);
            this.NextButton.TabIndex = 15;
            this.NextButton.TabStop = false;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BytesNumericUD
            // 
            this.BytesNumericUD.Location = new System.Drawing.Point(260, 14);
            this.BytesNumericUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BytesNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BytesNumericUD.Name = "BytesNumericUD";
            this.BytesNumericUD.Size = new System.Drawing.Size(54, 20);
            this.BytesNumericUD.TabIndex = 14;
            this.BytesNumericUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BytesNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество байт сообщения:";
            // 
            // BufferInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 229);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(540, 268);
            this.MinimumSize = new System.Drawing.Size(540, 268);
            this.Name = "BufferInputForm";
            this.Text = "Ввод сообщения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BufferInputForm_FormClosing);
            this.Load += new System.EventHandler(this.BufferInputForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MsgPanel.ResumeLayout(false);
            this.MsgPanel.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HexInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BytesNumericUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown BytesNumericUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BytesNumLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private ScintillaNET.Scintilla MsgScintilla;
        private System.Windows.Forms.Panel MsgPanel;
        private System.Windows.Forms.Label BytesLeftLabel;
        private System.Windows.Forms.Button InputByteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HexInput;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Button EndInputButton;
        private System.Windows.Forms.Button ClearOneByteButton;
    }
}