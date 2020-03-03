namespace Assignment_3.View
{
    partial class MainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.REF_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GEO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DGUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age_group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_response = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UOM_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SCALAR_FACTOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SCALAR_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VECTOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COORDINATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VALUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SYMBOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TERMINATED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DECIMALS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(162, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(316, 30);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(470, 29);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete Data";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.REF_DATE,
            this.GEO,
            this.DGUID,
            this.Sex,
            this.Age_group,
            this.Student_response,
            this.UOM,
            this.UOM_ID,
            this.SCALAR_FACTOR,
            this.SCALAR_ID,
            this.VECTOR,
            this.COORDINATE,
            this.VALUE,
            this.STATUS,
            this.SYMBOL,
            this.TERMINATED,
            this.DECIMALS});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 134);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1372, 394);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 45;
            // 
            // REF_DATE
            // 
            this.REF_DATE.Text = "REF_DATE";
            this.REF_DATE.Width = 45;
            // 
            // GEO
            // 
            this.GEO.Text = "GEO";
            this.GEO.Width = 120;
            // 
            // DGUID
            // 
            this.DGUID.Text = "DGUID";
            this.DGUID.Width = 110;
            // 
            // Sex
            // 
            this.Sex.Text = "Sex";
            this.Sex.Width = 70;
            // 
            // Age_group
            // 
            this.Age_group.Text = "Age group";
            this.Age_group.Width = 80;
            // 
            // Student_response
            // 
            this.Student_response.Text = "Student response";
            this.Student_response.Width = 110;
            // 
            // UOM
            // 
            this.UOM.Text = "UOM";
            // 
            // UOM_ID
            // 
            this.UOM_ID.Text = "UOM ID";
            // 
            // SCALAR_FACTOR
            // 
            this.SCALAR_FACTOR.Text = "SCALAR FACTOR";
            this.SCALAR_FACTOR.Width = 110;
            // 
            // SCALAR_ID
            // 
            this.SCALAR_ID.Text = "SCALAR ID";
            this.SCALAR_ID.Width = 110;
            // 
            // VECTOR
            // 
            this.VECTOR.Text = "VECTOR ";
            this.VECTOR.Width = 110;
            // 
            // COORDINATE
            // 
            this.COORDINATE.Text = "COORDINATE";
            this.COORDINATE.Width = 110;
            // 
            // STATUS
            // 
            this.STATUS.Text = "STATUS";
            this.STATUS.Width = 50;
            // 
            // SYMBOL
            // 
            this.SYMBOL.Text = "SYMBOL";
            this.SYMBOL.Width = 110;
            // 
            // TERMINATED
            // 
            this.TERMINATED.Text = "TERMINATED";
            this.TERMINATED.Width = 80;
            // 
            // DECIMALS
            // 
            this.DECIMALS.Text = "DECIMALS";
            this.DECIMALS.Width = 110;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(15, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Felipe Magnago";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader REF_DATE;
        private System.Windows.Forms.ColumnHeader GEO;
        private System.Windows.Forms.ColumnHeader DGUID;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Age_group;
        private System.Windows.Forms.ColumnHeader Student_response;
        private System.Windows.Forms.ColumnHeader UOM;
        private System.Windows.Forms.ColumnHeader UOM_ID;
        private System.Windows.Forms.ColumnHeader SCALAR_FACTOR;
        private System.Windows.Forms.ColumnHeader SCALAR_ID;
        private System.Windows.Forms.ColumnHeader VECTOR;
        private System.Windows.Forms.ColumnHeader COORDINATE;
        private System.Windows.Forms.ColumnHeader VALUE;
        private System.Windows.Forms.ColumnHeader STATUS;
        private System.Windows.Forms.ColumnHeader SYMBOL;
        private System.Windows.Forms.ColumnHeader TERMINATED;
        private System.Windows.Forms.ColumnHeader DECIMALS;
        private System.Windows.Forms.Button button1;
    }

}