using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using WindowsInput;
using WindowsInput.Native;


namespace Timer_pog
{



    public partial class LogOutTimer : Form
    {
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        int all_time = 0;
        int h = 0; // Для лейбла
        int m = 0; // Для лейбла 
        int s = 0; // Для лейбла
        SoundPlayer AllOk;
        SoundPlayer Bad;
        int counter = 0;
        bool timer_is_stoped = true;
        InputSimulator InSim = new InputSimulator();
        System.Windows.Forms.Timer timer1;
        VirtualKeyCode SelectedKeyCode;

        [DllImport("user32.dll")]
        public static extern void LockWorkStation();

        public LogOutTimer()
        {
            InitializeComponent();
            for (int i = 0; i < 200; i++) 
            {
                FillComboBoxWithFilteredKeys();
            }

        }
        private void FillComboBoxWithFilteredKeys()
        {
            // Исключаем некоторые значения, которые обычно не нужны
            var excludedKeys = new[]
            {
            VirtualKeyCode.NONAME,
            VirtualKeyCode.OEM_1,
            VirtualKeyCode.OEM_2,
            VirtualKeyCode.OEM_3,
            VirtualKeyCode.OEM_4,
            VirtualKeyCode.OEM_5,
            VirtualKeyCode.OEM_6,
            VirtualKeyCode.OEM_7,
            VirtualKeyCode.OEM_8,
            VirtualKeyCode.OEM_102,
            VirtualKeyCode.OEM_CLEAR,
            VirtualKeyCode.OEM_COMMA,
            VirtualKeyCode.OEM_PERIOD,
            VirtualKeyCode.OEM_PLUS,
            VirtualKeyCode.OEM_MINUS,
            VirtualKeyCode.VOLUME_DOWN,
            VirtualKeyCode.VOLUME_UP,
            VirtualKeyCode.VOLUME_MUTE,
            VirtualKeyCode.BROWSER_BACK,
            VirtualKeyCode.BROWSER_FORWARD,
            VirtualKeyCode.BROWSER_STOP,
            VirtualKeyCode.BROWSER_FAVORITES,
            VirtualKeyCode.BROWSER_HOME,
            VirtualKeyCode.BROWSER_REFRESH,
            VirtualKeyCode.BROWSER_SEARCH,
            VirtualKeyCode.XBUTTON1,
            VirtualKeyCode.XBUTTON2,
            VirtualKeyCode.ZOOM,
            VirtualKeyCode.F13,
            VirtualKeyCode.F14,
            VirtualKeyCode.F15,
            VirtualKeyCode.F16,
            VirtualKeyCode.F17,
            VirtualKeyCode.F18,
            VirtualKeyCode.F19,
            VirtualKeyCode.F20,
            VirtualKeyCode.F21,
            VirtualKeyCode.F22,
            VirtualKeyCode.F23,
            VirtualKeyCode.F24,

            // добавь другие ненужные значения
        };

            var keyCodes = Enum.GetValues(typeof(VirtualKeyCode))
                              .Cast<VirtualKeyCode>()
                              .Where(k => !excludedKeys.Contains(k))
                              .OrderBy(k => k.ToString());

            foreach (var keyCode in keyCodes)
            {
                comboBox1.Items.Add(keyCode);
            }
            
            comboBox1.SelectedIndex = 24;
            SelectedKeyCode = (VirtualKeyCode)comboBox1.SelectedItem;

        }

        private void hours_mtb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (timer_is_stoped == true)
            {
                if (seconds_mtb.Text != null | minutes_mtb.Text != null | hours_mtb.Text != null)
                {
                    bool okay_s = false;
                    bool okay_m = false;
                    bool okay_h = false;

                    try
                    {
                        seconds = int.Parse(seconds_mtb.Text);
                        okay_s = true;
                    }
                    catch { okay_s = false; }
                    try
                    {
                        minutes = int.Parse(minutes_mtb.Text);
                        okay_m = true;
                    }
                    catch { okay_m = false; }
                    try
                    {
                        hours = int.Parse(hours_mtb.Text);
                        okay_h = true;
                    }
                    catch { okay_h = false; }
                    if (okay_s | okay_m | okay_h)
                    {
                        timer_is_stoped = false;
                        Debug.WriteLine(seconds);
                        Debug.WriteLine(minutes);
                        Debug.WriteLine(hours);
                        if (seconds <= 60 & minutes <= 60 & hours <= 24)
                        {
                            all_time = hours * 60 * 60 + minutes * 60 + seconds;
                            timer1 = new System.Windows.Forms.Timer();
                            timer1.Interval = 1000; // Установите интервал в 1000 миллисекунд (1 секунда)
                            timer1.Tick += timer_tick;
                            timer1.Start();
                        }
                        else
                        {
                            Bad?.Play();
                            MessageBox.Show("Wrong time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        Bad?.Play();
                        MessageBox.Show("Wrong time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }


                }
                else
                {
                    Bad?.Play();
                    MessageBox.Show("Wrong time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }



        }
        void timer_tick(object sender, EventArgs e)
        {

            Debug.WriteLine(all_time);
            counter++;
            s++;
            if (s >= 59)
            {
                s = 0;
                m++;
            }
            if (m == 59)
            {
                h++;
            }
            timer_label.Text = $"time: {h}:{m}:{s}";
            if (counter == all_time)
            {

                stopAndPress_timer();
                MessageBox.Show("Time has passed", "COMPLETED", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer_is_stoped == false)
            {
                stop_timer();
                MessageBox.Show("Timer is stopped", "STOP", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

            }
            else
            {
                stop_timer();
                Bad?.Play();
                MessageBox.Show("Time is alredy stopped", "STOP", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (AllOk == null | Bad == null)
                {
                    AllOk = new SoundPlayer(Resource1.waru_ku_nai_kashira);
                    Bad = new SoundPlayer(Resource1.ya);
                }
            }
            else
            {
                AllOk = null;
                Bad = null;
            }

        }
        private void stop_timer()
        {
            timer_is_stoped = true;
            timer1.Stop();
            timer1 = null;
            seconds_mtb.Clear();
            minutes_mtb.Clear();
            hours_mtb.Clear();
            Debug.Write("stop");
            timer_label.Text = "time: 0:0:0";
            AllOk?.Play();
            counter = 0;
            s = 0;
            m = 0;
            h = 0;
        }
        private void stopAndPress_timer()
        {
            timer_is_stoped = true;
            timer1.Stop();
            timer1 = null;
            seconds_mtb.Clear();
            minutes_mtb.Clear();
            hours_mtb.Clear();
            Debug.Write("Time has passed");
            //LockWorkStation();
            InSim.Keyboard.KeyPress(SelectedKeyCode);
            timer_label.Text = "time: 0:0:0";
            AllOk?.Play();
            counter = 0;
            s = 0;
            m = 0;
            h = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedKeyCode = (VirtualKeyCode)comboBox1.SelectedItem;
        }
    }
}
