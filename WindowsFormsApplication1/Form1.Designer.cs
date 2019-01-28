namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.MenuStrip ms;
        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ms.SuspendLayout();
            this.tlp.SuspendLayout();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(450, 24);
            this.ms.TabIndex = 0;
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.editToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Checked = true;
            this.gameToolStripMenuItem.CheckOnClick = true;
            this.gameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.CheckOnClick = true;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.AutoSize = true;
            this.tlp.ColumnCount = 5;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.Controls.Add(this.label1, 1, 0);
            this.tlp.Controls.Add(this.label2, 2, 0);
            this.tlp.Controls.Add(this.label8, 0, 4);
            this.tlp.Controls.Add(this.label7, 0, 3);
            this.tlp.Controls.Add(this.label3, 3, 0);
            this.tlp.Controls.Add(this.label6, 0, 2);
            this.tlp.Controls.Add(this.button4, 4, 1);
            this.tlp.Controls.Add(this.label5, 0, 1);
            this.tlp.Controls.Add(this.button8, 4, 2);
            this.tlp.Controls.Add(this.button13, 1, 4);
            this.tlp.Controls.Add(this.button14, 2, 4);
            this.tlp.Controls.Add(this.button9, 1, 3);
            this.tlp.Controls.Add(this.button5, 1, 2);
            this.tlp.Controls.Add(this.button15, 3, 4);
            this.tlp.Controls.Add(this.button16, 4, 4);
            this.tlp.Controls.Add(this.button10, 2, 3);
            this.tlp.Controls.Add(this.button6, 2, 2);
            this.tlp.Controls.Add(this.button2, 2, 1);
            this.tlp.Controls.Add(this.button12, 4, 3);
            this.tlp.Controls.Add(this.button7, 3, 2);
            this.tlp.Controls.Add(this.button3, 3, 1);
            this.tlp.Controls.Add(this.button1, 1, 1);
            this.tlp.Controls.Add(this.button11, 3, 3);
            this.tlp.Controls.Add(this.label4, 4, 0);
            this.tlp.Location = new System.Drawing.Point(0, 27);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 5;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.Size = new System.Drawing.Size(450, 298);
            this.tlp.TabIndex = 0;
            this.tlp.Paint += new System.Windows.Forms.PaintEventHandler(this.tlp_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Arial", 14F);
            this.label8.Location = new System.Drawing.Point(3, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 62);
            this.label8.TabIndex = 0;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(3, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 62);
            this.label7.TabIndex = 0;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(253, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 62);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(353, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 56);
            this.button4.TabIndex = 0;
            this.button4.Tag = new System.Drawing.Point(0, 0);
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button4.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 62);
            this.label5.TabIndex = 0;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(353, 115);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 56);
            this.button8.TabIndex = 0;
            this.button8.Tag = new System.Drawing.Point(0, 0);
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button8.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button13.BackColor = System.Drawing.Color.RoyalBlue;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(53, 239);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 56);
            this.button13.TabIndex = 0;
            this.button13.Text = "?";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button13.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button13.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.BackColor = System.Drawing.Color.RoyalBlue;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(153, 239);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 56);
            this.button14.TabIndex = 0;
            this.button14.Text = "?";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button14.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button14.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(53, 177);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 56);
            this.button9.TabIndex = 0;
            this.button9.Tag = new System.Drawing.Point(0, 0);
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button9.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(53, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 56);
            this.button5.TabIndex = 0;
            this.button5.Tag = new System.Drawing.Point(0, 0);
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button5.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button15.BackColor = System.Drawing.Color.RoyalBlue;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(253, 239);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 56);
            this.button15.TabIndex = 0;
            this.button15.Text = "?";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button15.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button15.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button16.BackColor = System.Drawing.Color.RoyalBlue;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(353, 239);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(94, 56);
            this.button16.TabIndex = 0;
            this.button16.Text = "?";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button16.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button16.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(153, 177);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 56);
            this.button10.TabIndex = 0;
            this.button10.Text = "?";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button10.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button10.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(153, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 56);
            this.button6.TabIndex = 0;
            this.button6.Tag = new System.Drawing.Point(0, 0);
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button6.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(153, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 56);
            this.button2.TabIndex = 0;
            this.button2.Tag = new System.Drawing.Point(0, 0);
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button2.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.BackColor = System.Drawing.Color.RoyalBlue;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(353, 177);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 56);
            this.button12.TabIndex = 0;
            this.button12.Text = "?";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button12.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button12.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(253, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 56);
            this.button7.TabIndex = 0;
            this.button7.Tag = new System.Drawing.Point(0, 0);
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button7.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(253, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 56);
            this.button3.TabIndex = 0;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button3.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(53, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 56);
            this.button1.TabIndex = 0;
            this.button1.Tag = new System.Drawing.Point(0, 0);
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.BackColor = System.Drawing.Color.RoyalBlue;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(253, 177);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 56);
            this.button11.TabIndex = 0;
            this.button11.Text = "?";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDown);
            this.button11.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.button11.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(353, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.ss.Location = new System.Drawing.Point(0, 328);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(450, 22);
            this.ss.TabIndex = 0;
            this.ss.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ss_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "lifes: 3 highscore: 0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 1000;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.tlp);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuzzleGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
    partial class Form2
    {
        private void InitializeComponent()
        {
            this.Text = "Settings";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 120);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Name = "SettingsBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            label1 = new System.Windows.Forms.Label();
            label1.Parent = this;
            label1.Text = "Lifes: ";
            this.label1.Location = new System.Drawing.Point(10, 20);
            n1 = new System.Windows.Forms.NumericUpDown();
            n1.Parent = this;
            n1.Location= new System.Drawing.Point(200, 20);
            n1.Value = lifeisbrutal;
            n1.Minimum = 1;
            label2 = new System.Windows.Forms.Label();
            label2.Parent = this;
            label2.Text = "Time[s]: ";
            this.label2.Location = new System.Drawing.Point(10, 60);
            n2 = new System.Windows.Forms.NumericUpDown();
            n2.Parent = this;
            n2.Location = new System.Drawing.Point(200, 60);
            n2.Value = timeisbrutal;
            n2.Minimum = 1;
            b1 = new System.Windows.Forms.Button();
            b1.Parent = this;
            b1.Text = "OK";
            b1.Location= new System.Drawing.Point(150, 90);
            b1.Click += new System.EventHandler(OKClick);
            b2 = new System.Windows.Forms.Button();
            b2.Parent = this;
            b2.Text = "Cancel";
            b2.Click += new System.EventHandler(CANCELClick);
            b2.Location = new System.Drawing.Point(250, 90);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ZamknijMnie);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(keyevencior);
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown n1;
        private System.Windows.Forms.NumericUpDown n2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;



    }
}

