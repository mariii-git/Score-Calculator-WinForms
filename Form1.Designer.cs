namespace score_calculator
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
            btnadd = new Button();
            btnclear = new Button();
            btncalculate = new Button();
            lblmax = new Label();
            lblmin = new Label();
            lblaverage = new Label();
            txtscore = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Location = new Point(12, 45);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 0;
            btnadd.Text = "add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(139, 45);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 1;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(284, 45);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(75, 23);
            btncalculate.TabIndex = 2;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // lblmax
            // 
            lblmax.AutoSize = true;
            lblmax.Location = new Point(26, 105);
            lblmax.Name = "lblmax";
            lblmax.Size = new Size(38, 15);
            lblmax.TabIndex = 3;
            lblmax.Text = "label1";
            // 
            // lblmin
            // 
            lblmin.AutoSize = true;
            lblmin.Location = new Point(26, 149);
            lblmin.Name = "lblmin";
            lblmin.Size = new Size(38, 15);
            lblmin.TabIndex = 4;
            lblmin.Text = "label2";
            // 
            // lblaverage
            // 
            lblaverage.AutoSize = true;
            lblaverage.Location = new Point(26, 195);
            lblaverage.Name = "lblaverage";
            lblaverage.Size = new Size(38, 15);
            lblaverage.TabIndex = 5;
            lblaverage.Text = "label3";
            // 
            // txtscore
            // 
            txtscore.Location = new Point(124, 12);
            txtscore.Name = "txtscore";
            txtscore.Size = new Size(100, 23);
            txtscore.TabIndex = 6;
            txtscore.TextChanged += txtscore_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(206, 105);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 222);
            Controls.Add(listBox1);
            Controls.Add(txtscore);
            Controls.Add(lblaverage);
            Controls.Add(lblmin);
            Controls.Add(lblmax);
            Controls.Add(btncalculate);
            Controls.Add(btnclear);
            Controls.Add(btnadd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadd;
        private Button btnclear;
        private Button btncalculate;
        private Label lblmax;
        private Label lblmin;
        private Label lblaverage;
        private TextBox txtscore;
        private ListBox listBox1;
    }
}
