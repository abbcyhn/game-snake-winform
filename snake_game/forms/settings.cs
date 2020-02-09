using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Settings : Form
    {
        private RadioButton[] level;
        private ComboBox[] cmbOwnKeys;

        public Settings()
        {
            InitializeComponent();
            level = new RadioButton[] { rb1, rb2, rb3, rb4, rb5, rb6 };
            cmbOwnKeys = new ComboBox[] { cmbUp, cmbDown, cmbRight, cmbLeft };

            for (int i = 0; i < cmbOwnKeys.Length; i++)
                cmbOwnKeys[i].SelectedIndex = i;
        }

        public RadioButton Arrows
        {
            get { return rbUDRL; }
        }

        public RadioButton Keys
        {
            get { return rbWSAD; }
        }

        public RadioButton OwnKeys
        {
            get { return rbOwbKeys; }
        }

        public void ChooseLevel(Timer timer)
        {
            for (int i = 0; i < level.Length; i++)
                if (level[i].Checked)
                    timer.Interval = (6 - i) * 20; //1-120; 2-100; 3-80; 4-60;5- 40; 6 - 20
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (rbOwbKeys.Checked)
                for (int i = 0; i < cmbOwnKeys.Length; i++)
                    cmbOwnKeys[i].Enabled = true;
        }
    }
}