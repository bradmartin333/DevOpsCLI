using System.Linq;
using System.Windows.Forms;

namespace DevOpsCLI
{
    public partial class UserEntry : Form
    {
        private static string ChosenArea = null;

        public string UserName { get; internal set; }
        public string UserStoryTitle { get; internal set; }
        public string Area { get; set; }
        public string StoryPoints { get; internal set; }
        public string[] Tasks { get; internal set; } = new string[5];
        private readonly string[] Names, Areas;

        public UserEntry()
        {
            InitializeComponent();
            Names = Azure.Names.ToArray();
            ComboNames.Items.AddRange(Names);
            ComboNames.DropDownWidth = Names.Select(x => x.Length).Max();
            Areas = Azure.Areas.ToArray();
            ComboAreas.Items.AddRange(Areas);
            ComboAreas.DropDownWidth = Areas.Select(x => x.Length).Max();
            ComboAreas.Click += ComboAreas_Click;
            LoadSettings();
        }

        private void ComboAreas_Click(object sender, System.EventArgs e)
        {
            ComboAreas.Select(ComboAreas.Text.Length, 0);
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            if (!Names.ToList().Contains(ComboNames.Text))
            {
                DialogResult result = MessageBox.Show("Name not valid", "DevOpsCLI", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) DialogResult = DialogResult.Cancel;
                return;
            }

            if (string.IsNullOrEmpty(TextTitle.Text))
            {
                DialogResult result = MessageBox.Show($"No entry for user story title", "DevOpsCLI", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) DialogResult = DialogResult.Cancel;
                return;
            }

            if (!Areas.ToList().Contains(ComboAreas.Text))
            {
                DialogResult result = MessageBox.Show("Area not valid", "DevOpsCLI", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) DialogResult = DialogResult.Cancel;
                return;
            }

            int taskIdx = 0;
            foreach (TextBox textBox in TLP.Controls.OfType<TextBox>())
            {
                if (textBox.Tag.ToString() == "task" && !string.IsNullOrEmpty(textBox.Text))
                {
                    Tasks[taskIdx] = textBox.Text;
                    taskIdx++;
                }
            }
            
            UserName = ComboNames.Text;
            UserStoryTitle = TextTitle.Text;
            Area = ComboAreas.Text;
            ChosenArea = Area;
            StoryPoints = NumStoryPoints.Value.ToString();
            SaveSettings();
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        private void LoadSettings()
        {
            ComboAreas.Text = string.IsNullOrEmpty(ChosenArea) ? $"\\\\{Program.Project}\\\\Area\\\\" : ChosenArea;
            TextTask1.Text = Properties.Settings.Default.Task1;
            TextTask2.Text = Properties.Settings.Default.Task2;
            TextTask3.Text = Properties.Settings.Default.Task3;
            TextTask4.Text = Properties.Settings.Default.Task4;
            TextTask5.Text = Properties.Settings.Default.Task5;
            NumStoryPoints.Value = string.IsNullOrEmpty(Properties.Settings.Default.UserPoints) ? 2 : int.Parse(Properties.Settings.Default.UserPoints);
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Task1 = Tasks[0];
            Properties.Settings.Default.Task2 = Tasks[1];
            Properties.Settings.Default.Task3 = Tasks[2];
            Properties.Settings.Default.Task4 = Tasks[3];
            Properties.Settings.Default.Task5 = Tasks[4];
            Properties.Settings.Default.UserPoints = StoryPoints;
            Properties.Settings.Default.Save();
        }
    }
}
