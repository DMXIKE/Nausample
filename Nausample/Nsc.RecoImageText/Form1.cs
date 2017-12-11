using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Nsc.RecoImageText.ResultDomain;

namespace Nsc.RecoImageText
{
    public partial class Form1 : Form
    {
        private readonly string APP_ID = "10503418";
        private readonly string API_KEY = "TGEV3P72zkP6wy43SQ568e7S";
        private readonly string SECRET_KEY = "sjlyiRLMItVTzGDqzbAFq4RZCWiB8Gk9";
        public Form1()
        {
            InitializeComponent();

            RegHotKey();
        }

        private void RegHotKey()
        {
            HotKey.RegisterHotKey(Handle, 1203, HotKey.KeyModifiers.None, Keys.F3);
            HotKey.RegisterHotKey(Handle, 1204, HotKey.KeyModifiers.None, Keys.F4);
        }

        private void btnOcr_Click(object sender, EventArgs e)
        {
            string imagepath = txtPath.Text;
            if (string.IsNullOrEmpty(imagepath) || !File.Exists(imagepath))
            {
                MessageBox.Show("图片路径不正确");
                return;
            }
            var image = File.ReadAllBytes(txtPath.Text);

            // 通用文字识别
            var client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            var result = client.GeneralBasic(image);
            ShowResult(result.ToObject<GeneralBasicResult>());
            //txtResult.Text = result.ToString();

            //// 图片url
            ////result = client.GeneralBasic("https://www.baidu.com/img/bd_logo1.png");
        }

        private void ShowResult(GeneralBasicResult result, bool clear = true)
        {
            if (result.words_result == null)
            {
                MessageBox.Show("未识别出文字。");
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in result.words_result)
            {
                sb.Append(item.words);
                sb.Append("\r\n");
            }
            if (clear || string.IsNullOrEmpty(txtResult.Text))
            {
                txtResult.Text = sb.ToString();
            }
            else
            {
                txtResult.Text = txtResult.Text + "\r\n----------\r\n" + sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "图片文件|*.jpg;*.png;*.bmp|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
                pbImage.Load(openFileDialog.FileName);
            }
        }

        private void btnClipOcr_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(typeof(Bitmap)))
            {
                var clipImg = (Image)data.GetData(typeof(Bitmap));
                this.pbImage.Image = clipImg;

                string filename = @"C:\TEST.png";
                clipImg.Save(filename);

                var image = File.ReadAllBytes(filename);
                var client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
                var result = client.GeneralBasic(image);
                File.Delete(filename);
                ShowResult(result.ToObject<GeneralBasicResult>(), false);
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 1203:
                            string snapshotpath = Path.Combine(System.Environment.CurrentDirectory, "QQSnapShot.exe");
                            if (!File.Exists(snapshotpath))
                            {
                                MessageBox.Show("文件[QQSnapShot.exe]不存在");
                            }
                            System.Diagnostics.Process.Start(snapshotpath);
                            break;
                        case 1204:
                            btnClipOcr_Click(null, null);
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
