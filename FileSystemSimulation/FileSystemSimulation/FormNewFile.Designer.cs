namespace FileSystemSimulation
{
    partial class FormNewFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewFile));
            this.button确定 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox普通 = new System.Windows.Forms.CheckBox();
            this.label属性 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.文件名label = new System.Windows.Forms.Label();
            this.label提示 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button确定
            // 
            this.button确定.Location = new System.Drawing.Point(287, 272);
            this.button确定.Name = "button确定";
            this.button确定.Size = new System.Drawing.Size(83, 30);
            this.button确定.TabIndex = 23;
            this.button确定.Text = "确定";
            this.button确定.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(190, 199);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 22);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "系统文件";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 22);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "只读文件";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox普通
            // 
            this.checkBox普通.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox普通.AutoSize = true;
            this.checkBox普通.Location = new System.Drawing.Point(190, 143);
            this.checkBox普通.Name = "checkBox普通";
            this.checkBox普通.Size = new System.Drawing.Size(106, 22);
            this.checkBox普通.TabIndex = 20;
            this.checkBox普通.Text = "普通文件";
            this.checkBox普通.UseVisualStyleBackColor = true;
            // 
            // label属性
            // 
            this.label属性.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label属性.AutoSize = true;
            this.label属性.Location = new System.Drawing.Point(86, 143);
            this.label属性.Name = "label属性";
            this.label属性.Size = new System.Drawing.Size(98, 18);
            this.label属性.TabIndex = 19;
            this.label属性.Text = "文件属性：";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(190, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 28);
            this.textBoxName.TabIndex = 18;
            // 
            // 文件名label
            // 
            this.文件名label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.文件名label.AutoSize = true;
            this.文件名label.Location = new System.Drawing.Point(86, 99);
            this.文件名label.Name = "文件名label";
            this.文件名label.Size = new System.Drawing.Size(80, 18);
            this.文件名label.TabIndex = 17;
            this.文件名label.Text = "文件名：";
            // 
            // label提示
            // 
            this.label提示.AutoSize = true;
            this.label提示.Location = new System.Drawing.Point(86, 51);
            this.label提示.Name = "label提示";
            this.label提示.Size = new System.Drawing.Size(224, 18);
            this.label提示.TabIndex = 16;
            this.label提示.Text = "请输入新建文件名和属性：";
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(190, 227);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 22);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "隐藏文件";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // FormNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 337);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button确定);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox普通);
            this.Controls.Add(this.label属性);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.文件名label);
            this.Controls.Add(this.label提示);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewFile";
            this.Text = "New File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button确定;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox普通;
        private System.Windows.Forms.Label label属性;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label 文件名label;
        private System.Windows.Forms.Label label提示;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}