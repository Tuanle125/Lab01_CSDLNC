namespace Lab01_CSDLNC
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
            this.Pilot = new System.Windows.Forms.GroupBox();
            this.textBox_Point = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_Pilot = new System.Windows.Forms.DataGridView();
            this.button_DeleteAll = new System.Windows.Forms.Button();
            this.Pilot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pilot)).BeginInit();
            this.SuspendLayout();
            // 
            // Pilot
            // 
            this.Pilot.Controls.Add(this.textBox_Point);
            this.Pilot.Controls.Add(this.textBox_Name);
            this.Pilot.Controls.Add(this.label2);
            this.Pilot.Controls.Add(this.label1);
            this.Pilot.Location = new System.Drawing.Point(32, 31);
            this.Pilot.Name = "Pilot";
            this.Pilot.Size = new System.Drawing.Size(547, 94);
            this.Pilot.TabIndex = 0;
            this.Pilot.TabStop = false;
            this.Pilot.Text = "Pilot";
            // 
            // textBox_Point
            // 
            this.textBox_Point.Location = new System.Drawing.Point(423, 37);
            this.textBox_Point.Name = "textBox_Point";
            this.textBox_Point.Size = new System.Drawing.Size(100, 22);
            this.textBox_Point.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(70, 37);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(240, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(611, 43);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_Pilot
            // 
            this.dataGridView_Pilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pilot.Location = new System.Drawing.Point(32, 154);
            this.dataGridView_Pilot.Name = "dataGridView_Pilot";
            this.dataGridView_Pilot.RowHeadersWidth = 51;
            this.dataGridView_Pilot.RowTemplate.Height = 24;
            this.dataGridView_Pilot.Size = new System.Drawing.Size(734, 262);
            this.dataGridView_Pilot.TabIndex = 2;
            // 
            // button_DeleteAll
            // 
            this.button_DeleteAll.Location = new System.Drawing.Point(611, 102);
            this.button_DeleteAll.Name = "button_DeleteAll";
            this.button_DeleteAll.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteAll.TabIndex = 4;
            this.button_DeleteAll.Text = "Delete All";
            this.button_DeleteAll.UseVisualStyleBackColor = true;
            this.button_DeleteAll.Click += new System.EventHandler(this.button_DeleteAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DeleteAll);
            this.Controls.Add(this.dataGridView_Pilot);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.Pilot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pilot.ResumeLayout(false);
            this.Pilot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pilot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pilot;
        private System.Windows.Forms.TextBox textBox_Point;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView_Pilot;
        private System.Windows.Forms.Button button_DeleteAll;
    }
}

