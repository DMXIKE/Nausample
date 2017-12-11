using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nsc.Text2Speech
{
    public partial class Form1 : Form
    {
        private readonly string s_start = "试听";
        private readonly string s_stop = "停止";
        private SpeechSynthesizer speech;
        public Form1()
        {
            InitializeComponent();
            this.btnListen.Text = s_start;

            speech = new SpeechSynthesizer
            {
                Rate = tbRate.Value,
                Volume = tbVolume.Value
            };
            speech.SpeakCompleted += speech_SpeakCompleted;//绑定事件
            speech.SelectVoice("Microsoft Lili");//设置播音员（中文）
            //speech.SelectVoice("Microsoft Anna"); //英文
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (this.btnListen.Text == s_start)
            {
                new Thread(Speak).Start();
                this.btnListen.Text = s_stop;
            }
            else
            {
                speech.SpeakAsyncCancelAll();
                this.btnListen.Text = s_start;
            }
        }

        private void Speak()
        {
            speech.SpeakAsync(txtText.Text);//语音阅读方法
        }

        private void speech_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            this.btnListen.Text = s_start;
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            speech.Volume = tbVolume.Value;
        }

        private void tbRate_Scroll(object sender, EventArgs e)
        {
            speech.Rate = tbRate.Value;
        }
        private void SaveFile(string text)
        {
            speech = new SpeechSynthesizer();
            var dialog = new SaveFileDialog
            {
                Filter = "*.wav|*.wav|*.mp3|*.mp3"
            };
            dialog.ShowDialog();

            string path = dialog.FileName;
            if (path.Trim().Length == 0)
            {
                return;
            }
            speech.SetOutputToWaveFile(path);
            speech.Volume = tbVolume.Value;
            speech.Rate = tbRate.Value;
            speech.Speak(text);
            speech.SetOutputToNull();
            MessageBox.Show("生成成功!在" + path + "路径中！", "提示");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string text = txtText.Text;

            if (text.Trim().Length == 0)
            {
                MessageBox.Show("空内容无法生成!", "错误提示");
                return;
            }

            this.SaveFile(text);

        }
    }
}
