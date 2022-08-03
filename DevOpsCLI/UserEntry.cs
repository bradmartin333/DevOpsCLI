using System.Linq;
using System.Windows.Forms;

namespace DevOpsCLI
{
    public partial class UserEntry : Form
    {
        public string UserName { get; internal set; }
        public string UserStoryTitle { get; internal set; }
        public string SprintNum { get; internal set; }
        private readonly string[] Names;

        public UserEntry(string[] names)
        {
            InitializeComponent();
            Names = names;
            ComboNames.Items.AddRange(Names);
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
                DialogResult result1 = MessageBox.Show("No title entered", "DevOpsCLI", MessageBoxButtons.OKCancel);
                if (result1 == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                else
                    return;
            }

            if (!int.TryParse(TextSprintNum.Text, out _))
            {
                DialogResult result1 = MessageBox.Show("Invalid sprint number", "DevOpsCLI", MessageBoxButtons.OKCancel);
                if (result1 == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }
                else
                    return;
            }

            UserName = ComboNames.Text;
            UserStoryTitle = TextTitle.Text;
            SprintNum = TextSprintNum.Text;
            DialogResult = DialogResult.OK;
            Close();
            return;
        }
    }
}
