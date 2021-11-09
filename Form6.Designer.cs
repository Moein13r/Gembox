
namespace WindowsApp_TamrinA_
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem Strip1MenuItem1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firsname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Strip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StriMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            Strip1MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Strip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Strip1MenuItem1
            // 
            Strip1MenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            Strip1MenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            Strip1MenuItem1.Name = "Strip1MenuItem1";
            Strip1MenuItem1.Size = new System.Drawing.Size(180, 22);
            Strip1MenuItem1.Text = "toolStripMenuItem1";
            Strip1MenuItem1.ToolTipText = "Delete Row";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 117);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 92);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "My SQL Connection";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(5, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 442);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.search);
            this.panel6.Location = new System.Drawing.Point(534, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 61);
            this.panel6.TabIndex = 3;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search.Location = new System.Drawing.Point(25, 12);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(227, 35);
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.delete);
            this.panel5.Controls.Add(this.update);
            this.panel5.Controls.Add(this.AddNew);
            this.panel5.Location = new System.Drawing.Point(534, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 349);
            this.panel5.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(14, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(14, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Gainsboro;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Location = new System.Drawing.Point(14, 123);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(250, 45);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Gainsboro;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Location = new System.Drawing.Point(14, 70);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(250, 45);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // AddNew
            // 
            this.AddNew.BackColor = System.Drawing.Color.Gainsboro;
            this.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNew.Location = new System.Drawing.Point(14, 17);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(250, 45);
            this.AddNew.TabIndex = 0;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.emailbox);
            this.panel4.Controls.Add(this.postcode);
            this.panel4.Controls.Add(this.Email);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.adress);
            this.panel4.Controls.Add(this.surname);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.firsname);
            this.panel4.Controls.Add(this.id);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 415);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 110);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // emailbox
            // 
            this.emailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.emailbox.Location = new System.Drawing.Point(130, 246);
            this.emailbox.Multiline = true;
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(369, 33);
            this.emailbox.TabIndex = 11;
            // 
            // postcode
            // 
            this.postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.postcode.Location = new System.Drawing.Point(130, 207);
            this.postcode.Multiline = true;
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(369, 33);
            this.postcode.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(50, 256);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Postcode";
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.adress.Location = new System.Drawing.Point(130, 158);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(369, 33);
            this.adress.TabIndex = 7;
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.surname.Location = new System.Drawing.Point(130, 119);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(369, 33);
            this.surname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surname";
            // 
            // firsname
            // 
            this.firsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.firsname.Location = new System.Drawing.Point(130, 68);
            this.firsname.Multiline = true;
            this.firsname.Name = "firsname";
            this.firsname.Size = new System.Drawing.Size(369, 33);
            this.firsname.TabIndex = 3;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.id.Location = new System.Drawing.Point(130, 27);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(369, 33);
            this.id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Firsname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Id";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Strip1
            // 
            this.Strip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Strip1MenuItem1,
            this.StriMenuItem2});
            this.Strip1.Name = "Strip1";
            this.Strip1.Size = new System.Drawing.Size(181, 48);
            // 
            // StriMenuItem2
            // 
            this.StriMenuItem2.Name = "StriMenuItem2";
            this.StriMenuItem2.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.StriMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.StriMenuItem2.Text = "Edit";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.SizeChanged += new System.EventHandler(this.form_sizechange);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Strip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firsname;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ContextMenuStrip Strip1;
        private System.Windows.Forms.ToolStripMenuItem StriMenuItem2;
    }
}