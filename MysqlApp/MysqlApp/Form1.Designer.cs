namespace MysqlApp
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
            this.nev_form = new System.Windows.Forms.TextBox();
            this.jelszo_form = new System.Windows.Forms.TextBox();
            this.szuletesiido = new System.Windows.Forms.DateTimePicker();
            this.regButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.del_form = new System.Windows.Forms.TextBox();
            this.nevupdate_form = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jelszoupdate_form = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_userek_label = new System.Windows.Forms.Label();
            this.regisztraltak_list = new System.Windows.Forms.ListBox();
            this.stat_list = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nev_form
            // 
            this.nev_form.Location = new System.Drawing.Point(27, 38);
            this.nev_form.Name = "nev_form";
            this.nev_form.Size = new System.Drawing.Size(434, 20);
            this.nev_form.TabIndex = 0;
            // 
            // jelszo_form
            // 
            this.jelszo_form.Location = new System.Drawing.Point(27, 64);
            this.jelszo_form.Name = "jelszo_form";
            this.jelszo_form.PasswordChar = '*';
            this.jelszo_form.Size = new System.Drawing.Size(434, 20);
            this.jelszo_form.TabIndex = 1;
            // 
            // szuletesiido
            // 
            this.szuletesiido.Location = new System.Drawing.Point(27, 91);
            this.szuletesiido.Name = "szuletesiido";
            this.szuletesiido.Size = new System.Drawing.Size(434, 20);
            this.szuletesiido.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(357, 140);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Regisztráció";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(357, 318);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Törlés";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(357, 406);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Módosít";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // del_form
            // 
            this.del_form.Location = new System.Drawing.Point(27, 320);
            this.del_form.Name = "del_form";
            this.del_form.Size = new System.Drawing.Size(180, 20);
            this.del_form.TabIndex = 6;
            // 
            // nevupdate_form
            // 
            this.nevupdate_form.Location = new System.Drawing.Point(30, 383);
            this.nevupdate_form.Name = "nevupdate_form";
            this.nevupdate_form.Size = new System.Drawing.Size(180, 20);
            this.nevupdate_form.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Törlés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Név módosítás";
            // 
            // jelszoupdate_form
            // 
            this.jelszoupdate_form.Location = new System.Drawing.Point(30, 441);
            this.jelszoupdate_form.Name = "jelszoupdate_form";
            this.jelszoupdate_form.Size = new System.Drawing.Size(180, 20);
            this.jelszoupdate_form.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jelszó módosítás";
            // 
            // reg_userek_label
            // 
            this.reg_userek_label.AutoSize = true;
            this.reg_userek_label.Location = new System.Drawing.Point(27, 140);
            this.reg_userek_label.Name = "reg_userek_label";
            this.reg_userek_label.Size = new System.Drawing.Size(165, 13);
            this.reg_userek_label.TabIndex = 12;
            this.reg_userek_label.Text = "PLACEHOLDER_REG_USEREK";
            // 
            // regisztraltak_list
            // 
            this.regisztraltak_list.FormattingEnabled = true;
            this.regisztraltak_list.Location = new System.Drawing.Point(27, 168);
            this.regisztraltak_list.Name = "regisztraltak_list";
            this.regisztraltak_list.Size = new System.Drawing.Size(165, 121);
            this.regisztraltak_list.TabIndex = 13;
            // 
            // stat_list
            // 
            this.stat_list.FormattingEnabled = true;
            this.stat_list.Location = new System.Drawing.Point(209, 168);
            this.stat_list.Name = "stat_list";
            this.stat_list.Size = new System.Drawing.Size(189, 121);
            this.stat_list.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stat_list);
            this.Controls.Add(this.regisztraltak_list);
            this.Controls.Add(this.reg_userek_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jelszoupdate_form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nevupdate_form);
            this.Controls.Add(this.del_form);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.szuletesiido);
            this.Controls.Add(this.jelszo_form);
            this.Controls.Add(this.nev_form);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev_form;
        private System.Windows.Forms.TextBox jelszo_form;
        private System.Windows.Forms.DateTimePicker szuletesiido;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox del_form;
        private System.Windows.Forms.TextBox nevupdate_form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jelszoupdate_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label reg_userek_label;
        private System.Windows.Forms.ListBox regisztraltak_list;
        private System.Windows.Forms.ListBox stat_list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

