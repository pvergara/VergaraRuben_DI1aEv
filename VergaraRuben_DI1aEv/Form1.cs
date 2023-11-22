using System.Drawing;
using Timer = System.Windows.Forms.Timer;

namespace VergaraRuben_DI1aEv
{
    public partial class Form1 : Form
    {
        private CheckBox[,] checkBoxes = new CheckBox[6, 9];
        ToolTip toolTip1 = new ToolTip();
        ToolTip toolTip2 = new ToolTip();
        private int actionIndex = 0;
        private int counter = 0;
        private List<Record> gamers;

        public Form1()
        {
            gamers = new List<Record>()
            {
                new Record("PErico",10,1),
                new Record("Perica",21,6),
                new Record("PeriquE",41,6),
                new Record("Piriqui",61,4),
                new Record("LolaLaExploradora",41,5)
            };
            InitializeComponent();
            InitializeCheckboxes();
            InitializeTimer();
            InitializeGamers();
        }

        private void InitializeGamers()
        {
            foreach (var record in this.gamers)
            {
                this.gamersList.Items.Add(record);
            }

        }

        private void InitializeTimer()
        {
            Timer MyTimer;
            MyTimer = new Timer();
            MyTimer.Interval = (300);
            MyTimer.Tick += new EventHandler(onTimerEvent);
            MyTimer.Start();
        }

        private void onTimerEvent(object sender, EventArgs e)
        {
            this.playAction.BackColor = Color.Beige;
            this.resetAction.BackColor = Color.Beige;
            this.exitAction.BackColor = Color.Beige;
            switch (actionIndex)
            {
                case 0:
                    this.playAction.BackColor = Color.Yellow;
                    break;
                case 1:
                    this.resetAction.BackColor = Color.Yellow;
                    break;
                case 2:
                    this.exitAction.BackColor = Color.Yellow;
                    this.actionIndex = -1;
                    break;
            }

            this.actionIndex++;
        }

        private void InitializeCheckboxes()
        {
            var size = new Size(30, 30);
            for (int i = 0; i < this.checkBoxes.GetUpperBound(0); i++)
            {
                for (int j = 0; j < this.checkBoxes.GetUpperBound(1); j++)
                {
                    var aux = new CheckBox();
                    aux.Location = new Point(30 + (j * (40)), 30 + (i * (40)));
                    toolTip1.SetToolTip(aux, "No marcado");
                    aux.Click += this.onCheckBoxEvent;
                    aux.Size = size;
                    this.checkBoxes[i, j] = aux;
                    this.Controls.Add(aux);
                }
            }
        }

        private void onCheckBoxEvent(object? sender, EventArgs e)
        {
            if (sender == null)
                return;
            if (!(sender is CheckBox))
                return;
            var aux = (CheckBox)sender;
            if (aux.Checked)
            {
                toolTip1.SetToolTip(aux, null);
                toolTip2.SetToolTip(aux, "Marcado");
                this.counter++;
            }
            else
            {
                toolTip2.SetToolTip(aux, null);
                toolTip1.SetToolTip(aux, "No marcado");
                this.counter--;
            }
        }


        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.playEvent();
        }

        private void playAction_Click(object sender, EventArgs e)
        {
            this.playEvent();
        }

        private void resetAction_Click(object sender, EventArgs e)
        {
            this.resetEvent();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.resetEvent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exitEvent();
        }

        private void exitAction_Click(object sender, EventArgs e)
        {
            this.exitEvent();
        }
        private void playEvent()
        {
            if (this.counter != 6)
            {
                MessageBox.Show("Necesitas marcar 6 elementos");
                return;
            }

            MessageBox.Show("Play" + this.counter);
        }
        private void resetEvent()
        {
            for (int i = 0; i < this.checkBoxes.GetUpperBound(0); i++)
            {
                for (int j = 0; j < this.checkBoxes.GetUpperBound(1); j++)
                {
                    this.checkBoxes[i, j].Checked = false;
                }
            }
        }
        private void exitEvent()
        {
            Close();
        }

        private void deleteRecordsAction_Click(object sender, EventArgs e)
        {
            var aux = new List<Record>();
            for (var i = 0; i < this.gamersList.SelectedIndices.Count; i++)
            {
                aux.Add((Record) this.gamersList.Items[this.gamersList.SelectedIndices[i]]);
            }

            foreach (var record in aux)
            {
                this.gamersList.Items.Remove(record);
            }
        }
    }
}
