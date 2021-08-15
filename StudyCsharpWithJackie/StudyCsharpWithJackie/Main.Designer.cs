
namespace StudyCsharpWithJackie
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tạo TreeView";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 41);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(234, 310);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            this.treeView1.Enter += new System.EventHandler(this.treeView1_Enter);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Group";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thêm Node tự động";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(261, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Option1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thêm Node lựa chọn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Option1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

