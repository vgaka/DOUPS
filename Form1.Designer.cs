namespace Cshrp_doups
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
            this.btmsearch = new System.Windows.Forms.Button();
            this.btmaddnew = new System.Windows.Forms.Button();
            this.btmclose = new System.Windows.Forms.Button();
            this.txtclientsearchkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btmsearch
            // 
            this.btmsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btmsearch.Location = new System.Drawing.Point(223, 91);
            this.btmsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmsearch.Name = "btmsearch";
            this.btmsearch.Size = new System.Drawing.Size(190, 55);
            this.btmsearch.TabIndex = 0;
            this.btmsearch.Text = "Search Customer";
            this.btmsearch.UseVisualStyleBackColor = true;
            this.btmsearch.Click += new System.EventHandler(this.btmsearch_Click);
            // 
            // btmaddnew
            // 
            this.btmaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btmaddnew.Location = new System.Drawing.Point(421, 91);
            this.btmaddnew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmaddnew.Name = "btmaddnew";
            this.btmaddnew.Size = new System.Drawing.Size(249, 55);
            this.btmaddnew.TabIndex = 1;
            this.btmaddnew.Text = "Add New Customer";
            this.btmaddnew.UseVisualStyleBackColor = true;
            this.btmaddnew.Click += new System.EventHandler(this.btmaddnew_Click);
            // 
            // btmclose
            // 
            this.btmclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btmclose.Location = new System.Drawing.Point(678, 91);
            this.btmclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmclose.Name = "btmclose";
            this.btmclose.Size = new System.Drawing.Size(233, 55);
            this.btmclose.TabIndex = 2;
            this.btmclose.Text = "Add New Tax Invoice";
            this.btmclose.UseVisualStyleBackColor = true;
            this.btmclose.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtclientsearchkey
            // 
            this.txtclientsearchkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtclientsearchkey.Location = new System.Drawing.Point(293, 45);
            this.txtclientsearchkey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtclientsearchkey.Name = "txtclientsearchkey";
            this.txtclientsearchkey.Size = new System.Drawing.Size(618, 30);
            this.txtclientsearchkey.TabIndex = 3;
            this.txtclientsearchkey.Text = "123456789";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Customer";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer ID",
            "Customer Account"});
            this.comboBox1.Location = new System.Drawing.Point(20, 45);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Customer ID";
             // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(18, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(893, 272);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "AccountNo.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lang";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(25, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "List All Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclientsearchkey);
            this.Controls.Add(this.btmclose);
            this.Controls.Add(this.btmaddnew);
            this.Controls.Add(this.btmsearch);
            this.Name = "Form1";
            this.Text = "Search....";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmsearch;
        private System.Windows.Forms.Button btmaddnew;
        private System.Windows.Forms.Button btmclose;
        private System.Windows.Forms.TextBox txtclientsearchkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
    }
}

