namespace Report_Pro.PL
{
    partial class frmDelivryNote
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
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delivryRow1 = new Report_Pro.MyControls.delivryRow();
            this.ddlSource = new System.Windows.Forms.ComboBox();
            this.ddlTarget = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.delivryRow1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 49);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(479, 136);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.flowLayoutPanel1_PreviewKeyDown_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delivryRow1
            // 
            this.delivryRow1.Location = new System.Drawing.Point(1, 1);
            this.delivryRow1.Margin = new System.Windows.Forms.Padding(1);
            this.delivryRow1.Name = "delivryRow1";
            this.delivryRow1.Size = new System.Drawing.Size(473, 18);
            this.delivryRow1.TabIndex = 0;
            this.delivryRow1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.delivryRow1_KeyDown);
            // 
            // ddlSource
            // 
            this.ddlSource.FormattingEnabled = true;
            this.ddlSource.Location = new System.Drawing.Point(57, 218);
            this.ddlSource.Name = "ddlSource";
            this.ddlSource.Size = new System.Drawing.Size(213, 21);
            this.ddlSource.TabIndex = 4;
            // 
            // ddlTarget
            // 
            this.ddlTarget.FormattingEnabled = true;
            this.ddlTarget.Location = new System.Drawing.Point(292, 218);
            this.ddlTarget.Name = "ddlTarget";
            this.ddlTarget.Size = new System.Drawing.Size(213, 21);
            this.ddlTarget.TabIndex = 5;
            // 
            // frmDelivryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 521);
            this.Controls.Add(this.ddlTarget);
            this.Controls.Add(this.ddlSource);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDelivryNote";
            this.Text = "frmDelivryNote";
            this.Load += new System.EventHandler(this.frmDelivryNote_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDelivryNote_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.delivryRow r = new MyControls.delivryRow();
       // private System.ComponentModel.IContainer components = (System.ComponentModel.IContainer)null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MyControls.delivryRow delivryRow1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ddlSource;
        private System.Windows.Forms.ComboBox ddlTarget;
    }
}