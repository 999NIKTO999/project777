
namespace project777
{
    partial class FormBD
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
            this.dg_bd = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_chage = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bd)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_bd
            // 
            this.dg_bd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bd.Location = new System.Drawing.Point(93, 0);
            this.dg_bd.Name = "dg_bd";
            this.dg_bd.RowTemplate.Height = 25;
            this.dg_bd.Size = new System.Drawing.Size(715, 460);
            this.dg_bd.TabIndex = 0;
            this.dg_bd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(12, 54);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "button1";
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(12, 112);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "button2";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_chage
            // 
            this.bt_chage.Location = new System.Drawing.Point(12, 170);
            this.bt_chage.Name = "bt_chage";
            this.bt_chage.Size = new System.Drawing.Size(75, 23);
            this.bt_chage.TabIndex = 3;
            this.bt_chage.Text = "button3";
            this.bt_chage.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 233);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "button4";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(12, 423);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 5;
            this.bt_exit.Text = "Выйти";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // FormBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 562);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_chage);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dg_bd);
            this.Name = "FormBD";
            this.Text = "FormBD";
            this.Load += new System.EventHandler(this.FormBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_bd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_bd;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_chage;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_exit;
    }
}