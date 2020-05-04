namespace SutarciuSistema
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.vardasbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pavardebox = new System.Windows.Forms.TextBox();
            this.pavlab = new System.Windows.Forms.Label();
            this.akodbox = new System.Windows.Forms.TextBox();
            this.telbox = new System.Windows.Forms.TextBox();
            this.emailb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.createbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sutartystable = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.greetingslable = new System.Windows.Forms.Label();
            this.log_out_b = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sutartystable)).BeginInit();
            this.SuspendLayout();
            // 
            // vardasbox
            // 
            this.vardasbox.Location = new System.Drawing.Point(118, 96);
            this.vardasbox.Name = "vardasbox";
            this.vardasbox.Size = new System.Drawing.Size(100, 22);
            this.vardasbox.TabIndex = 0;
            this.vardasbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vardas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // pavardebox
            // 
            this.pavardebox.Location = new System.Drawing.Point(224, 97);
            this.pavardebox.Name = "pavardebox";
            this.pavardebox.Size = new System.Drawing.Size(100, 22);
            this.pavardebox.TabIndex = 2;
            this.pavardebox.TextChanged += new System.EventHandler(this.Pavardebox_TextChanged);
            // 
            // pavlab
            // 
            this.pavlab.AutoSize = true;
            this.pavlab.Location = new System.Drawing.Point(246, 76);
            this.pavlab.Name = "pavlab";
            this.pavlab.Size = new System.Drawing.Size(61, 17);
            this.pavlab.TabIndex = 3;
            this.pavlab.Text = "Pavarde";
            // 
            // akodbox
            // 
            this.akodbox.Location = new System.Drawing.Point(330, 97);
            this.akodbox.Name = "akodbox";
            this.akodbox.Size = new System.Drawing.Size(100, 22);
            this.akodbox.TabIndex = 4;
            this.akodbox.TextChanged += new System.EventHandler(this.Akodbox_TextChanged);
            // 
            // telbox
            // 
            this.telbox.Location = new System.Drawing.Point(436, 96);
            this.telbox.Name = "telbox";
            this.telbox.Size = new System.Drawing.Size(100, 22);
            this.telbox.TabIndex = 5;
            this.telbox.TextChanged += new System.EventHandler(this.Telbox_TextChanged);
            // 
            // emailb
            // 
            this.emailb.Location = new System.Drawing.Point(555, 96);
            this.emailb.Name = "emailb";
            this.emailb.Size = new System.Drawing.Size(100, 22);
            this.emailb.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Asmens kodas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefono nr.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "El pastas";
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(52, 125);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(75, 23);
            this.createbutton.TabIndex = 10;
            this.createbutton.Text = "Sukurti";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(168, 125);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 11;
            this.updatebutton.Text = "Atnaujinti";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(265, 125);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 12;
            this.deletebutton.Text = "Ištrinti";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(24, 23);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(165, 23);
            this.printbutton.TabIndex = 13;
            this.printbutton.Text = "Spausdinti sutarti";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.Printbutton_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(12, 96);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 22);
            this.idbox.TabIndex = 14;
            this.idbox.TextChanged += new System.EventHandler(this.Idbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sutarties kodas";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // sutartystable
            // 
            this.sutartystable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sutartystable.Location = new System.Drawing.Point(64, 209);
            this.sutartystable.Name = "sutartystable";
            this.sutartystable.ReadOnly = true;
            this.sutartystable.RowTemplate.Height = 24;
            this.sutartystable.Size = new System.Drawing.Size(703, 265);
            this.sutartystable.TabIndex = 16;
            this.sutartystable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sutartystable_CellContentClick);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(330, 505);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 17;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // greetingslable
            // 
            this.greetingslable.AutoSize = true;
            this.greetingslable.Location = new System.Drawing.Point(398, 23);
            this.greetingslable.Name = "greetingslable";
            this.greetingslable.Size = new System.Drawing.Size(54, 17);
            this.greetingslable.TabIndex = 18;
            this.greetingslable.Text = "label11";
            this.greetingslable.Click += new System.EventHandler(this.Greetingslable_Click);
            // 
            // log_out_b
            // 
            this.log_out_b.Location = new System.Drawing.Point(758, 35);
            this.log_out_b.Name = "log_out_b";
            this.log_out_b.Size = new System.Drawing.Size(127, 23);
            this.log_out_b.TabIndex = 19;
            this.log_out_b.Text = "Atsijungti";
            this.log_out_b.UseVisualStyleBackColor = true;
            this.log_out_b.Click += new System.EventHandler(this.Log_out_b_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(401, 172);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 20;
            this.searchbutton.Text = "Paieška";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(932, 624);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.log_out_b);
            this.Controls.Add(this.greetingslable);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.sutartystable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailb);
            this.Controls.Add(this.telbox);
            this.Controls.Add(this.akodbox);
            this.Controls.Add(this.pavlab);
            this.Controls.Add(this.pavardebox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vardasbox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.sutartystable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox asmkodbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vardasbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pavardebox;
        private System.Windows.Forms.Label pavlab;
        private System.Windows.Forms.TextBox akodbox;
        private System.Windows.Forms.TextBox telbox;
        private System.Windows.Forms.TextBox emailb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView sutartystable;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label greetingslable;
        private System.Windows.Forms.Button log_out_b;
        private System.Windows.Forms.Button searchbutton;
    }
}

