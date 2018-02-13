using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ColoreCore = Corale.Colore.Core;

namespace YourNameHere
{
    public partial class YourNameHere_Form : Form
    {

        public YourNameHere_Form()
        {
            InitializeComponent();
            /*lettereBindingSource.SuspendBinding();
            ynhLoad.RunWorkerAsync();*/
        }

        private void ynhNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ynhNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.Show();
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ynhSave_DoWork(object sender, DoWorkEventArgs e)
        {
            var folder = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "YourNameHere");
            Directory.CreateDirectory(folder);
            var fileName = Path.Combine(folder, "config.json");
            Definitions.AllLetters temp = new Definitions.AllLetters();
            foreach (DataGridViewRow row in ynhDataGridView.Rows)
            {
                var lettemp = (Definitions.Lettere)row.DataBoundItem;
                temp.Text.Add(lettemp);
            }
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, temp);
            }
            MessageBox.Show("Saved!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ynhSave.RunWorkerAsync();
        }

        private void ynhLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            var folder = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "YourNameHere");
            var fileName = Path.Combine(folder, "config.json");
            if (!File.Exists(fileName))
            {
                e.Result = null;
                return;
            }
            var text = File.ReadAllText(fileName);
            Definitions.AllLetters full = JsonConvert.DeserializeObject<Definitions.AllLetters>(text);
            e.Result = full;
        }

        private void ynhLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result == null)
            {
                lettereBindingSource.ResumeBinding();
                MessageBox.Show("Config file not found! Save it first!");
                return;
            }
            lettereBindingSource.Clear();
            Definitions.AllLetters full = (Definitions.AllLetters)e.Result;
            foreach (Definitions.Lettere temp in full.Text)
            {
                if (temp != null)
                {
                    lettereBindingSource.Add(temp);
                }
            }
            ynhDataGridView.Rows[0].Selected = true;
            lettereBindingSource.ResumeBinding();
            ynhDataGridView.Refresh();
            MessageBox.Show("Loading complete");
        }

        private void ynhBtnSave_Click(object sender, EventArgs e)
        {
            if(!ynhSave.IsBusy)
                ynhSave.RunWorkerAsync();
        }

        private void ynhBtnLoad_Click(object sender, EventArgs e)
        {
            if (!ynhLoad.IsBusy)
            {
                lettereBindingSource.SuspendBinding();
                ynhLoad.RunWorkerAsync();
            }
        }

        private void ynhSetKeys_DoWork(object sender, DoWorkEventArgs e)
        {
            ColoreCore.Chroma.Instance.Keyboard.SetAll(ColoreCore.Color.Black);
            Utils utils = new Utils();
            List<int> success = new List<int>();
            foreach (DataGridViewRow row in ynhDataGridView.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                var color_rgb_array = row.Cells[1].Value.ToString().ToCharArray();
                string color_raw = row.Cells[1].Value.ToString();
                if (color_rgb_array[0].Equals('#'))
                {
                    color_raw = utils.HexToRgb(color_raw);
                }
                else if (char.IsLetter(color_rgb_array[0]))
                {
                    color_raw = utils.NameToRgb(color_raw);
                }
                else
                {
                    color_raw = row.Cells[1].Value.ToString();
                }

                if (color_raw.Split(',').Length != 3)
                {
                    //logger.Error("Colore male configurato! '{0}'", temp.Color);
                    continue;
                }
                var color_rbg = Array.ConvertAll(color_raw.Replace(" ", "").Split(','), byte.Parse);
                var letters = row.Cells[0].Value.ToString().ToCharArray();
                ColoreCore.Color color = new ColoreCore.Color(color_rbg[0], color_rbg[1], color_rbg[2]);
                DataGridViewCheckBoxCell numpad = (DataGridViewCheckBoxCell)row.Cells[2];
                for (int i = 0; i < letters.Length; i++)
                {
                    string myChar = char.ToString(char.ToUpper(letters[i]));
                    if (char.IsNumber(letters[i]))
                    {
                        if ((bool)numpad.Value)
                            myChar = "Num" + myChar;
                        else
                            myChar = "D" + myChar;
                    }
                    //logger.Debug("Carattere: {0}", (string)myChar);
                    ColoreCore.Chroma.Instance.Keyboard.SetKey(utils.GetKey(myChar), color);
                    Thread.Sleep(10);
                }
                success.Add(row.Index);
                //ynhDataGridView.Refresh();
            }
            e.Result = success;
        }

        private void ynhBtnSetKeys_Click(object sender, EventArgs e)
        {
            if(!ynhSetKeys.IsBusy)
                ynhSetKeys.RunWorkerAsync();
        }

        private void ynhSetKeys_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<int> result = (List<int>)e.Result;
            foreach (int rowIndex in result)
            {
                DataGridViewCheckBoxCell completion = (DataGridViewCheckBoxCell)ynhDataGridView.Rows[rowIndex].Cells[3];
                completion.Value = true;
            }
            ynhDataGridView.Refresh();
        }

        private void ynhMinimizeToTray_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
