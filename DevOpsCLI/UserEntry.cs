using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DevOpsCLI
{
    public partial class UserEntry : Form
    {
        public string UserName { get; internal set; }
        public string UserStoryTitle { get; internal set; }
        public string[] TaskTitles { get; internal set; } = new string[5];
        private readonly string[] Names;

        public UserEntry(string[] names)
        {
            InitializeComponent();
            Names = names;
            ComboNames.Items.AddRange(Names);
            LoadSettings();
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            if (!Names.ToList().Contains(ComboNames.Text))
            {
                DialogResult result1 = MessageBox.Show("Name not valid", "DevOpsCLI", MessageBoxButtons.OKCancel);
                if (result1 == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                else
                    return;
            }

            if (string.IsNullOrEmpty(TextTitle.Text))
            {
                DialogResult result1 = MessageBox.Show($"No entry for user story title", "DevOpsCLI", MessageBoxButtons.OKCancel);
                if (result1 == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                else
                    return;
            }

            int taskIdx = 0;
            foreach (TextBox textBox in TLP.Controls.OfType<TextBox>())
            {
                if (textBox.Tag.ToString() == "task" && !string.IsNullOrEmpty(textBox.Text))
                {
                    TaskTitles[taskIdx] = textBox.Text;
                    taskIdx++;
                }
            }
            
            UserName = ComboNames.Text;
            UserStoryTitle = TextTitle.Text;
            SaveSettings();
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        private void LoadSettings()
        {
            TextTask1.Text = Properties.Settings.Default.LastTask1;
            TextTask2.Text = Properties.Settings.Default.LastTask2;
            TextTask3.Text = Properties.Settings.Default.LastTask3;
            TextTask4.Text = Properties.Settings.Default.LastTask4;
            TextTask5.Text = Properties.Settings.Default.LastTask5;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.LastTask1 = TaskTitles[0];
            Properties.Settings.Default.LastTask2 = TaskTitles[1];
            Properties.Settings.Default.LastTask3 = TaskTitles[2];
            Properties.Settings.Default.LastTask4 = TaskTitles[3];
            Properties.Settings.Default.LastTask5 = TaskTitles[4];
            Properties.Settings.Default.Save();
        }
    }
}
