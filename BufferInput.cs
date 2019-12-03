using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScintillaNET;

namespace CRC
{
    public partial class BufferInputForm : Form
    {
        private bool DealogIsOk = false;
        public byte[] buf { get; set; }
        public byte BytesNum, RemainingNum, count = 1;
       
        public BufferInputForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

                BytesNum = (byte)BytesNumericUD.Value;
                RemainingNum = BytesNum;
                BytesNumericUD.Visible = false;
                buf = new byte[BytesNum];
                BytesNumLabel.Text = BytesNum.ToString();
                BytesLeftLabel.Text = BytesNum.ToString(); ;
                BytesNumLabel.Visible = true;
                MsgPanel.Visible = true;
                NextButton.Visible = false;

        }
        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private void BufferInputForm_Load(object sender, EventArgs e)
        {
            MsgScintilla.StyleResetDefault();
            MsgScintilla.Styles[Style.Default].Font = "Consolas";
            MsgScintilla.Styles[Style.Default].Size = 14;
            MsgScintilla.Styles[Style.Default].BackColor = IntToColor(0x212121);
            MsgScintilla.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            MsgScintilla.StyleClearAll();

            foreach (var margin in MsgScintilla.Margins)
                margin.Width = 0;
        }

        private void EndInputButton_Click(object sender, EventArgs e)
        {
           DealogIsOk = true;
           this.Close();
        }

        private void BufferInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DealogIsOk)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;

        }

        private void InputByteButton_Click_1(object sender, EventArgs e)
        {
            if (RemainingNum > 0)
            {
                buf[BytesNum - RemainingNum] = (byte)HexInput.Value;
                RemainingNum--;
                MsgScintilla.ReadOnly = false;
                if (count % 8 == 0) 
                {
                    MsgScintilla.AppendText(((int)HexInput.Value).ToString("X") + "\r\n");
                    count = 1;
                }
                else
                {
                    count++;
                    MsgScintilla.AppendText(((int)HexInput.Value).ToString("X") + " ");
                }
                
                MsgScintilla.ReadOnly = true;
                BytesLeftLabel.Text = RemainingNum.ToString();
                HexInput.Value = 0;
                if (RemainingNum == 0)
                {
                    InputPanel.Visible = false;
                    EndInputButton.Visible = true;
                }
            }
            else
            {
                InputPanel.Visible = false;
                EndInputButton.Visible = true;
            }
        }
    }
}
