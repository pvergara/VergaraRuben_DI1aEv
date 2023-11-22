namespace VergaraRuben_DI1aEv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            jugarToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            playAction = new Button();
            resetAction = new Button();
            exitAction = new Button();
            gamersList = new ListBox();
            deleteRecordsAction = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menu";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jugarToolStripMenuItem, resetToolStripMenuItem, toolStripMenuItem2, salirToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(74, 23);
            accionesToolStripMenuItem.Text = "&Acciones";
            // 
            // jugarToolStripMenuItem
            // 
            jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            jugarToolStripMenuItem.ShortcutKeys = Keys.F5;
            jugarToolStripMenuItem.Size = new Size(151, 24);
            jugarToolStripMenuItem.Text = "&Jugar";
            jugarToolStripMenuItem.Click += jugarToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.ShortcutKeys = Keys.F6;
            resetToolStripMenuItem.Size = new Size(151, 24);
            resetToolStripMenuItem.Text = "&Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(148, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            salirToolStripMenuItem.Size = new Size(151, 24);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // playAction
            // 
            playAction.BackColor = Color.Beige;
            playAction.Location = new Point(831, 65);
            playAction.Name = "playAction";
            playAction.Size = new Size(75, 23);
            playAction.TabIndex = 1;
            playAction.Text = "Jugar";
            playAction.UseVisualStyleBackColor = false;
            playAction.Click += playAction_Click;
            // 
            // resetAction
            // 
            resetAction.BackColor = Color.Beige;
            resetAction.Location = new Point(831, 94);
            resetAction.Name = "resetAction";
            resetAction.Size = new Size(75, 23);
            resetAction.TabIndex = 2;
            resetAction.Text = "Reset";
            resetAction.UseVisualStyleBackColor = false;
            resetAction.Click += resetAction_Click;
            // 
            // exitAction
            // 
            exitAction.BackColor = Color.Beige;
            exitAction.Location = new Point(831, 123);
            exitAction.Name = "exitAction";
            exitAction.Size = new Size(75, 23);
            exitAction.TabIndex = 3;
            exitAction.Text = "Salir";
            exitAction.UseVisualStyleBackColor = false;
            exitAction.Click += exitAction_Click;
            // 
            // gamersList
            // 
            gamersList.FormattingEnabled = true;
            gamersList.Location = new Point(12, 402);
            gamersList.Name = "gamersList";
            gamersList.SelectionMode = SelectionMode.MultiSimple;
            gamersList.Size = new Size(210, 156);
            gamersList.TabIndex = 4;
            // 
            // deleteRecordsAction
            // 
            deleteRecordsAction.Location = new Point(228, 402);
            deleteRecordsAction.Name = "deleteRecordsAction";
            deleteRecordsAction.Size = new Size(75, 23);
            deleteRecordsAction.TabIndex = 5;
            deleteRecordsAction.Text = "Eliminar";
            deleteRecordsAction.UseVisualStyleBackColor = true;
            deleteRecordsAction.Click += deleteRecordsAction_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 570);
            Controls.Add(deleteRecordsAction);
            Controls.Add(gamersList);
            Controls.Add(exitAction);
            Controls.Add(resetAction);
            Controls.Add(playAction);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Lotería simple";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem jugarToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private Button playAction;
        private Button resetAction;
        private Button exitAction;
        private ListBox gamersList;
        private Button deleteRecordsAction;
    }
}
