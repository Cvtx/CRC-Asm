using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using ScintillaNET;

namespace CRC
{
    public partial class MainForm : Form
    {
        public byte[] buf = { 0 };
        public byte len = 0;
        UInt16 crc = 0xFFFF;
        bool ThreadIsAlive = false;
        private Thread CrcThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FillCrc(int n)
        {
            switch (n) {

                // Custom
                case 0:
                        BitsNumUD.Value = 1;
                        PolyTextBox.Clear();
                        InitTextBox.Clear();
                        XorOutTextBox.Clear();
                        RefInCB.Checked = false;
                        RefOutCB.Checked = false;
                        // CrcPanel.Enabled = true;
                        //TopCrcPanel.Enabled = true;
                        PolyTextBox.Enabled = true;
                        InitTextBox.Enabled = true;
                        BitsNumUD.Enabled = true;
                        XorOutTextBox.Enabled = true;
                        RefInCB.Enabled = true;
                        RefOutCB.Enabled = true;
                        StartButton.Enabled = false;
                        break;

                // CRC-16 / MODBUS
                case 1:
                        BitsNumUD.Value = 16;
                        PolyTextBox.Text = "8005";
                        InitTextBox.Text = "FFFF";
                        XorOutTextBox.Text = "0";
                        RefInCB.Checked = true;
                        RefOutCB.Checked = true;
                        //CrcPanel.Enabled = false;
                        PolyTextBox.Enabled = false;
                        InitTextBox.Enabled = false;
                        BitsNumUD.Enabled = false;
                        XorOutTextBox.Enabled = false;
                        RefInCB.Enabled = false;
                        RefOutCB.Enabled = false;
                        //TopCrcPanel.Enabled = false;
                        StartButton.Enabled = true;
                        break;
                        
            }
            
        }

        private void CrcSelector_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillCrc(CrcSelector.SelectedIndex);

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            using (var f = new BufferInputForm())
            {
                var result = f.ShowDialog();
                if (result == DialogResult.OK)
                {
                    buf = f.buf;
                    len = f.BytesNum;

                    scintillaAsm.CaretLineVisibleAlways = true;

                    msgScintilla.ReadOnly = false;
                    msgScintilla.ClearAll();
                    msgScintilla.Lines[0].Goto();
                    msgScintilla.AppendText(buf[0].ToString("X"));

                    for (byte i = 1; i < len; i++)
                    {
                        msgScintilla.AppendText("\n");
                        msgScintilla.Lines[i].Goto();
                        msgScintilla.AppendText(buf[i].ToString("X"));
                    }

                    msgScintilla.Lines[0].Goto();
                    msgScintilla.ReadOnly = true;

                    ThreadIsAlive = true;
                    NextStepButton.Enabled = true;

                    CrcThread = new Thread(new ThreadStart(CrcCalc));
                    CrcThread.Start();
                }
            }
        }

        void HighlightAsm(byte n)
        {
            scintillaAsm.Lines[n - 1].Goto();
            
        }
        void HighlightByte(byte n)
        {
            msgScintilla.Lines[n - 1].Goto();
        }

        void UpdCrc(UInt16 ax)
        {
            AxHexLabel.Text = ax.ToString("X");
            AxDecLabel.Text = ax.ToString();
            AxBinLabel.Text = Convert.ToString(ax, 2);
        }
        void UpdBx(short bx)
        {
           BxHexLabel.Text = bx.ToString("X");
           BxDecLabel.Text = bx.ToString();
           BxBinLabel.Text = Convert.ToString(bx, 2);
        }

        void UpdCx(short cx) 
        {
          
          CxDecLabel.Text = cx.ToString();

        }

        void CrcCalc()
        {
            // Инициализация crc нач. значением
            HighlightAsm(1);
            UpdComment("CRC получает начальное (Init) значение");
            Sleep();
            crc = 0xFFFF;

            // Инициализация ax
            HighlightAsm(2);
            UpdComment("Регистр ax получает значение переменной CRC");
            Sleep();
            UpdCrc(crc);

            // Первый байт в bx
            msgScintilla.CaretLineVisibleAlways = true;
            UpdComment("Занесение первого байта сообщения в регистр bl");
            HighlightAsm(3);
            HighlightByte(1);
            Sleep();
            UpdBx(buf[0]);


            for (byte pos = 0; pos < len; pos++)
            {
                // xor ax , bx
                UpdComment("Исключающее 'или' между регистрами ax, bx");
                HighlightAsm(4);
                Sleep();
                crc ^= (UInt16)buf[pos];
                UpdCrc(crc);

                // mov ex, 9;
                HighlightAsm(5);
                UpdComment("Изменение счетчика cx на число 9");
                Sleep();
                UpdCx((byte)(9));
                HighlightAsm(7);
                UpdComment("Уменьшение счетчика cx на единицу");
                Sleep();

                for (int i = 8; i != 0; i--)
                {
                    // dec cx
                    UpdCx((byte)(i));
                    HighlightAsm(8);
                    UpdComment("Проверка, равен ли cx нулю (cx = "+ CxDecLabel.Text + ")");
                    Sleep();

                    //shr ax,1
                    HighlightAsm(9);
                    UpdComment("Сдвиг регистра ax вправо (к LSB)");
                    Sleep();


                    if ((crc & 0x0001) != 0)
                    {
                       
                        // shr ax, 1
                        crc >>= 1;
                        UpdCrc(crc);
                        HighlightAsm(10);
                        UpdComment("Если сдвигаемый бит = 0 -> переходим к метке (LSB = 1)");
                        Sleep();
                        HighlightAsm(11);
                        UpdComment("Исключающее 'или' регистра ax и обратного полинома");
                        Sleep();

                        crc ^= 0xA001;
                        UpdCrc(crc);

                        HighlightAsm(12);
                        UpdComment("Безусловный переход к метке");
                        Sleep();
                    }
                    else
                    {
                        crc >>= 1;
                        UpdCrc(crc);
                        HighlightAsm(10);
                        UpdComment("Если сдвигаемый бит = 0 -> переходим к метке (LSB = 0)");
                        Sleep();
                    }

                    HighlightAsm(7);
                    UpdComment("Уменьшение счетчика cx на единицу");
                    Sleep();
                }
                
                UpdCx(0);
                HighlightAsm(8);
                UpdComment("Проверка, равен ли cx нулю (cx = 0)");
                Sleep();
                HighlightAsm(14);
                UpdComment("Сохранение результата в переменной CRC");
                Sleep();

                // байты закончились
                if (pos == (len-1))
                {
                    UpdComment("Вычисление CRC завершено След. шаг обнулит регистры");
                    Sleep();
                    Reset();
                }
                else
                {
                    HighlightAsm(2);
                    UpdComment("Регистр ax получает значение переменной CRC");
                    Sleep();
                    HighlightAsm(3);
                    UpdComment("Занесение очередного байта сообщения в регистр bl");
                    HighlightByte((byte)(pos + 2));
                    Sleep();
                    UpdBx(buf[pos + 1]);
                }
            }
        }
        void UpdComment(string msg)
        {
            Commentary.Text = msg;
        }
        void Reset()
        {
            AxHexLabel.Text = "Hex";
            AxDecLabel.Text = "Dec";
            AxBinLabel.Text = "Bin";

            BxHexLabel.Text = "Hex";
            BxDecLabel.Text = "Dec";
            BxBinLabel.Text = "Bin";

            CxDecLabel.Text = "Dec";

            UpdComment("-");

            scintillaAsm.CaretLineVisibleAlways = false;
            msgScintilla.CaretLineVisibleAlways = false;

            NextStepButton.Enabled = false;
        }

        void Sleep() { 
            try
            {
                Thread.Sleep(Timeout.Infinite);
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("Thread '{0}' awoken.",
                                  Thread.CurrentThread.Name);
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("Thread '{0}' aborted.",
                                  Thread.CurrentThread.Name);
            }
            finally
            {
                Console.WriteLine("Thread '{0}' executing finally block.",
                                  Thread.CurrentThread.Name);
            }
            Console.WriteLine("Thread '{0} finishing normal execution.",
                              Thread.CurrentThread.Name);
            Console.WriteLine();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSyntaxColoring();
            InitNumberMargin();
            CrcSelector.SelectedIndex = 0;
        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private void InitSyntaxColoring()
        {
            
            // Configure the default style
            msgScintilla.StyleResetDefault();
            msgScintilla.Styles[Style.Default].Font = "Consolas";
            msgScintilla.Styles[Style.Default].Size = 14;
            msgScintilla.Styles[Style.Default].BackColor = IntToColor(0x212121);
            msgScintilla.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            msgScintilla.StyleClearAll();

            // Configure the default style
            scintillaAsm.StyleResetDefault();
            scintillaAsm.Styles[Style.Default].Font = "Consolas";
            scintillaAsm.Styles[Style.Default].Size = 14;
            scintillaAsm.Styles[Style.Default].BackColor = IntToColor(0x212121);
            scintillaAsm.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            scintillaAsm.StyleClearAll();

           // scintillaAsm.Styles[Style.Asm.Identifier].ForeColor = IntToColor(0x000000);
            scintillaAsm.Styles[Style.Asm.Operator].ForeColor = IntToColor(0xFFFFFF);
            scintillaAsm.Styles[Style.Asm.Register].ForeColor = IntToColor(0xA6C628);
            scintillaAsm.Styles[Style.Asm.Number].ForeColor = IntToColor(0x6379FF);

            //Style.Asm.
            scintillaAsm.SetKeywords(8, "ax bx al bl");
            scintillaAsm.SetKeywords(2, "1 2 3 4 5 6 7 8 9 0 00ffh $A001");
            scintillaAsm.SetKeywords(4, "mov and xor dec jcxz shr jnc jmp");
        }

        private const int BACK_COLOR = 0x272822;
        private const int FORE_COLOR = 0x90908A;
        private const int NUMBER_MARGIN = 1;
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;
        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;

        private void InitNumberMargin()
        {


            scintillaAsm.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            scintillaAsm.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            scintillaAsm.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            scintillaAsm.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            msgScintilla.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            msgScintilla.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            msgScintilla.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            msgScintilla.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = scintillaAsm.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            var nums2 = msgScintilla.Margins[NUMBER_MARGIN];
            nums2.Width = 30;
            nums2.Type = MarginType.Number;
            nums2.Sensitive = true;
            nums2.Mask = 0;

            //scintillaAsm.MarginClick += scintillaAsm_MarginClick;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            CrcThread.Interrupt();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (ThreadIsAlive) {
                if (CrcThread.IsAlive)
                    CrcThread.Abort();
            }
            
        }

        private void HideRegButton_Click(object sender, EventArgs e)
        {
            RegistersPanel.Visible = !RegistersPanel.Visible;
        }

        private void HidePolyButton_Click(object sender, EventArgs e)
        {
            CrcPanel.Visible = !CrcPanel.Visible;
        }

    }
}
