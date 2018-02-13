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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourNameHere
{
    public partial class YourNameHere_Form : Form
    {
        public YourNameHere_Form()
        {
            InitializeComponent();
            /*Definitions.Lettere test = new Definitions.Lettere();
            test.Color = "black";
            test.Letters = "aeiou";
            test.NumPad = false;
            lettereBindingSource.Add(test);*/
            ynhLoad.RunWorkerAsync();
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
            if (!File.Exists(fileName)) return;
            var text = File.ReadAllText(fileName);
            Definitions.AllLetters full = JsonConvert.DeserializeObject<Definitions.AllLetters>(text);
            e.Result = full;
        }

        private void ynhLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Definitions.AllLetters full = (Definitions.AllLetters)e.Result;
            foreach (Definitions.Lettere temp in full.Text)
            { 
                MessageBox.Show(temp.Letters.ToString());
                if(temp != null) lettereBindingSource.Add(temp);
            }
            MessageBox.Show("Loading complete");
        }
    }
}
