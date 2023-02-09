namespace Pokemon_Common
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pokemonsPnl = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.pikcBtn = new System.Windows.Forms.Button();
            this.crlBtn = new System.Windows.Forms.Button();
            this.chrBtn = new System.Windows.Forms.Button();
            this.krBtn = new System.Windows.Forms.Button();
            this.skillBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.pkmsBtn = new System.Windows.Forms.Button();
            this.atkBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nameBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pokemonsPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pokemon_Common.Properties.Resources._4070;
            this.pictureBox1.Location = new System.Drawing.Point(167, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Pokemon_Common.Properties.Resources._716;
            this.pictureBox2.Location = new System.Drawing.Point(681, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pokemonsPnl);
            this.panel1.Controls.Add(this.skillBtn);
            this.panel1.Controls.Add(this.runBtn);
            this.panel1.Controls.Add(this.pkmsBtn);
            this.panel1.Controls.Add(this.atkBtn);
            this.panel1.Location = new System.Drawing.Point(69, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 215);
            this.panel1.TabIndex = 8;
            // 
            // pokemonsPnl
            // 
            this.pokemonsPnl.BackColor = System.Drawing.Color.Transparent;
            this.pokemonsPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pokemonsPnl.BackgroundImage")));
            this.pokemonsPnl.Controls.Add(this.backBtn);
            this.pokemonsPnl.Controls.Add(this.pikcBtn);
            this.pokemonsPnl.Controls.Add(this.crlBtn);
            this.pokemonsPnl.Controls.Add(this.chrBtn);
            this.pokemonsPnl.Controls.Add(this.krBtn);
            this.pokemonsPnl.Location = new System.Drawing.Point(0, 0);
            this.pokemonsPnl.Name = "pokemonsPnl";
            this.pokemonsPnl.Size = new System.Drawing.Size(450, 215);
            this.pokemonsPnl.TabIndex = 9;
            this.pokemonsPnl.Visible = false;
            this.pokemonsPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pokemonsPnl_Paint);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 57);
            this.backBtn.TabIndex = 14;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pikcBtn
            // 
            this.pikcBtn.FlatAppearance.BorderSize = 0;
            this.pikcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pikcBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pikcBtn.Location = new System.Drawing.Point(234, 52);
            this.pikcBtn.Name = "pikcBtn";
            this.pikcBtn.Size = new System.Drawing.Size(167, 44);
            this.pikcBtn.TabIndex = 4;
            this.pikcBtn.Text = "Pikachu";
            this.pikcBtn.UseVisualStyleBackColor = true;
            this.pikcBtn.Click += new System.EventHandler(this.pikcBtn_Click);
            // 
            // crlBtn
            // 
            this.crlBtn.FlatAppearance.BorderSize = 0;
            this.crlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crlBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crlBtn.Location = new System.Drawing.Point(234, 119);
            this.crlBtn.Name = "crlBtn";
            this.crlBtn.Size = new System.Drawing.Size(167, 44);
            this.crlBtn.TabIndex = 3;
            this.crlBtn.Text = "Ceruledge";
            this.crlBtn.UseVisualStyleBackColor = true;
            this.crlBtn.Click += new System.EventHandler(this.crlBtn_Click);
            // 
            // chrBtn
            // 
            this.chrBtn.FlatAppearance.BorderSize = 0;
            this.chrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chrBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chrBtn.Location = new System.Drawing.Point(40, 119);
            this.chrBtn.Name = "chrBtn";
            this.chrBtn.Size = new System.Drawing.Size(188, 44);
            this.chrBtn.TabIndex = 1;
            this.chrBtn.Text = "Charizard";
            this.chrBtn.UseVisualStyleBackColor = true;
            this.chrBtn.Click += new System.EventHandler(this.chrBtn_Click);
            // 
            // krBtn
            // 
            this.krBtn.FlatAppearance.BorderSize = 0;
            this.krBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.krBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.krBtn.Location = new System.Drawing.Point(49, 52);
            this.krBtn.Name = "krBtn";
            this.krBtn.Size = new System.Drawing.Size(167, 44);
            this.krBtn.TabIndex = 0;
            this.krBtn.Text = "Kyurem";
            this.krBtn.UseVisualStyleBackColor = true;
            this.krBtn.Click += new System.EventHandler(this.krBtn_Click);
            // 
            // skillBtn
            // 
            this.skillBtn.FlatAppearance.BorderSize = 0;
            this.skillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skillBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skillBtn.Location = new System.Drawing.Point(234, 52);
            this.skillBtn.Name = "skillBtn";
            this.skillBtn.Size = new System.Drawing.Size(167, 44);
            this.skillBtn.TabIndex = 4;
            this.skillBtn.Text = "Skill";
            this.skillBtn.UseVisualStyleBackColor = true;
            // 
            // runBtn
            // 
            this.runBtn.FlatAppearance.BorderSize = 0;
            this.runBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.runBtn.Location = new System.Drawing.Point(234, 119);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(167, 44);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "RUN";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // pkmsBtn
            // 
            this.pkmsBtn.FlatAppearance.BorderSize = 0;
            this.pkmsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pkmsBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pkmsBtn.Location = new System.Drawing.Point(40, 119);
            this.pkmsBtn.Name = "pkmsBtn";
            this.pkmsBtn.Size = new System.Drawing.Size(188, 44);
            this.pkmsBtn.TabIndex = 1;
            this.pkmsBtn.Text = "Pokemons";
            this.pkmsBtn.UseVisualStyleBackColor = true;
            this.pkmsBtn.Click += new System.EventHandler(this.pkmsBtn_Click);
            // 
            // atkBtn
            // 
            this.atkBtn.FlatAppearance.BorderSize = 0;
            this.atkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atkBtn.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.atkBtn.Location = new System.Drawing.Point(49, 52);
            this.atkBtn.Name = "atkBtn";
            this.atkBtn.Size = new System.Drawing.Size(167, 44);
            this.atkBtn.TabIndex = 0;
            this.atkBtn.Text = "Attack";
            this.atkBtn.UseVisualStyleBackColor = true;
            this.atkBtn.Click += new System.EventHandler(this.atkBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(43, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 58);
            this.label3.TabIndex = 13;
            this.label3.Text = "What will \r\nKyurem do?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(588, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 215);
            this.panel2.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(240, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(170, 20);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.BackColor = System.Drawing.Color.Transparent;
            this.nameBox.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(167, 188);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(140, 29);
            this.nameBox.TabIndex = 11;
            this.nameBox.Text = "Kyurem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Upheaval TT (BRK)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(681, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yveltal";
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressBar2.Location = new System.Drawing.Point(754, 209);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(170, 20);
            this.progressBar2.TabIndex = 12;
            this.progressBar2.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1104, 685);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pokemon Battle made in China                               ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pokemonsPnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button runBtn;
        private Button pkmsBtn;
        private Button atkBtn;
        private Label label3;
        private Panel panel2;
        private BindingSource bindingSource1;
        private ProgressBar progressBar1;
        private Label nameBox;
        private Label label2;
        private ProgressBar progressBar2;
        private Button skillBtn;
        private Panel pokemonsPnl;
        private Button pikcBtn;
        private Button crlBtn;
        private Button chrBtn;
        private Button krBtn;
        private System.Windows.Forms.Timer timer1;
        private Button backBtn;
    }
}