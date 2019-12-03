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
        private const string StandartHintString = "Наведитесь мышкой на элемент \r\nинтерфейса, чтобы получить \r\nкраткую справку о нем";
        private const string ActivateHintString = "Справка на данный момент \r\nнеактивна, подсказки \r\nотображаться не будут";
        public byte[] buf = { 0 };
        public byte len = 0;
        UInt16 crc = 0xFFFF;
        bool ThreadIsAlive = false, StepbyStep = true, ByBytes = false;
        private Thread CrcThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FillCrc(int n)
        {
            switch (n) {

                // Custom
                case 1:
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
                case 0:
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
                    Reset();
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

                    if (ThreadIsAlive) { CrcThread.Abort(); }

                    ThreadIsAlive = true;
                    NextStepButton.Enabled = true;
                    CalcAllButton.Enabled = true;
                    NextByteButton.Enabled = true;

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
                    StepbyStep = true;
                    UpdComment("Вычисление CRC завершено, результат хранится в регистре AX");
                    Sleep();
                }
                else
                {
                    HighlightAsm(2);
                    UpdComment("Регистр ax получает значение переменной CRC");
                    Sleep();
                    HighlightAsm(3);
                    UpdComment("Занесение очередного байта сообщения в регистр bl");
                    if (ByBytes)
                    {
                        StepbyStep = true;
                        ByBytes = false;
                    }
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
            CalcAllButton.Enabled = false;
            NextByteButton.Enabled = false;

            StepbyStep = true;
            ByBytes = false;

            msgScintilla.ReadOnly = false;
            msgScintilla.ClearAll();
            msgScintilla.ReadOnly = true;
        }

        void Sleep() { 
            if (StepbyStep)
            {
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
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSyntaxColoring();
            InitNumberMargin();
            CrcSelector.SelectedIndex = 0;
            //toolTipRefIn.SetToolTip(RefInLabel, "Флаг, указывающий на начало и направление вычислений. False — начиная со старшего значащего бита (MSB-first), или True — с младшего (LSB-first)");
            //toolTipRefOut.SetToolTip(RefOutLabel, "Флаг, определяющий, инвертируется ли порядок битов регистра при входе на элемент XOR");
            //toolTipStart.SetToolTip(StartButton, "Начать пошаговое вычислениие");
            //toolTipPoly.SetToolTip(PolyLabel, "Производящий полином в HEX");
            //toolTipInit.SetToolTip(InitLabel, "Стартовые данные, то есть значение регистра на момент начала вычислений");
            //toolTipXorOut.SetToolTip(XorOutLabel, "Число, с которым складывается по модулю 2 полученный результат");
            //toolTipAX.SetToolTip(AxLabel,"Регистр, в котором хранится CRC");
            //toolTipBX.SetToolTip(BxLabel, "Регистр, в котором хранится очередной байт сообщения");
            //toolTipCX.SetToolTip(CxLabel, "Регистр - счетчик для цикла");
            //toolTipBits.SetToolTip(BitsLabel, "Степень порождающего контрольную сумму многочлена");
            ////toolTipHideFirst.SetToolTip(HidePolyButton, "Скрыть/Показать первую панель");
            //toolTipHideRegisters.SetToolTip(HideRegButton, "Скрыть/Показать панель информации о текущем стандарте CRC");

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
            StepbyStep = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ThreadIsAlive)
            {
                if (CrcThread.IsAlive)
                    StepbyStep = false;
            }
            CrcThread.Interrupt();
        }

        private void CrcSelector_DropDownClosed(object sender, EventArgs e)
        {
            HelpLabel.Focus();
        }

        private void Hint(string message)
        {
            if (HelpCheckBox.Checked) {
                HintLabel.Text = message;
                StandartHint.Visible = false;
            }
        }

        private void NoHint()
        {
            if (HelpCheckBox.Checked)
            {
                HintLabel.Text = "";
                StandartHint.Visible = true;
            }
        }

        private void HelpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HelpCheckBox.Checked == false)
            {
                HintLabel.Text = "";
                StandartHint.Visible = true;
                StandartHint.Text = ActivateHintString;
            }
            else
            {
                HintLabel.Text = "";
                StandartHint.Visible = true;
                StandartHint.Text = StandartHintString;
            }
            
        }

        private void AxLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Регистр, в котором хранится \r\nконтрольная сумма (CRC)");
        }

        private void AxLabel_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void BxLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Регистр, в котором хранится \r\nбайт сообщения, который \r\nв данный момент обрабатывается");
        }

        private void BxLabel_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void CxLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Регистр, в котором хранится \r\nсчетчик цикла, который \r\nуменьшается с каждой итерацией");
        }

        private void CxLabel_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void ControlPanel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Панель управления содержит \r\nэлементы управления пошаговым \r\nвыполнением программы ");
        }

        private void ControlPanel_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void NextStepButton_MouseEnter(object sender, EventArgs e)
        {
            Hint("Выполнить одну строку в коде \r\nпрограммы");
        }

        private void NextStepButton_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Hint("Выполнить блок команд для \r\nрасчёта одного байта сообщения");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Hint("Выполнить окончательный расчёт \r\nконтрольной суммы");
        }

        private void CommentPanel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Комментарий к выделенной \r\nстроке в коде программы");
        }

        private void CommentPanel_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void msgPanel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Сообщение, разбитое по байтам, \r\nкаждый из которых находится на \r\nотдельной строке");
        }

        private void msgPanel_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void CodePanel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Код программы на языке \r\nассемблера, выполняющий расчёт \r\nкотрольной суммы");
        }

        private void CodePanel_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Hint("Панель управления содержит \r\nэлементы управления пошаговым \r\nвыполнением программы ");
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            Hint("Панель управления содержит \r\nэлементы управления пошаговым \r\nвыполнением программы ");
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Hint("Панель управления содержит \r\nэлементы управления пошаговым \r\nвыполнением программы ");
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            Hint("Панель управления содержит \r\nэлементы управления пошаговым \r\nвыполнением программы ");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Hint("Панель управления содержит \r\nэлементы управления пошаговым \r\nвыполнением программы ");
        }

        private void HelpCheckBox_MouseEnter(object sender, EventArgs e)
        {
            Hint("Включить/отключить работу \r\nсправки");
        }

        private void HelpCheckBox_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void HideRegButton_MouseEnter(object sender, EventArgs e)
        {
            Hint("Показать/Скрыть панель с \r\nинформацией о выбранном \r\nстандарте CRC");
        }

        private void StartButton_MouseEnter(object sender, EventArgs e)
        {
            Hint("Начать работу с программой, \r\nпереход к вводу сообщения");
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void CrcSelector_MouseEnter(object sender, EventArgs e)
        {
            Hint("Меню выбора стандарта CRC");
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            Hint("Флаг, указывающий на начало и \r\nнаправление вычислений. \r\nFalse — начиная со старшего \r\nзначащего бита (MSB - first), \r\nили True — с младшего (LSB - first)");
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            Hint("Флаг, определяющий, \r\nинвертируется ли порядок битов \r\nрегистра при входе на элемент XOR");
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            Hint("Стартовые данные, то есть значение \r\nрегистра AX на момент начала \r\nвычислений");
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            Hint("Число, с которым складывается \r\nпо модулю 2 полученный результат");
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            Hint("Производящий полином в HEX");
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Hint("Степень порождающего \r\nконтрольную сумму многочлена");
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void BitsLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Степень порождающего \r\nконтрольную сумму многочлена");
        }

        private void PolyLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Производящий полином в HEX");
        }

        private void InitLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Стартовые данные, то есть значение \r\nрегистра AX на момент начала \r\nвычислений");
        }

        private void XorOutLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Число, с которым складывается \r\nпо модулю 2 полученный результат");
        }

        private void NextByteButton_Click(object sender, EventArgs e)
        {
            ByBytes = true;
            StepbyStep = false;
            CrcThread.Interrupt();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            Hint("Приводит программу к\r\nпервоначальному виду");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            NoHint();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            Hint("Панель управления содержит \r\nэлементы управления пошаговым \r\nвыполнением программы ");
        }

        private void RefInLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Флаг, указывающий на начало и \r\nнаправление вычислений. \r\nFalse — начиная со старшего \r\nзначащего бита (MSB - first), \r\nили True — с младшего (LSB - first)");
        }

        private void RefOutLabel_MouseEnter(object sender, EventArgs e)
        {
            Hint("Флаг, определяющий, \r\nинвертируется ли порядок битов \r\nрегистра при входе на элемент XOR");
        }
    }
}
