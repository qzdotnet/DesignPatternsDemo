namespace ObserverPattern
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxObserverType = new System.Windows.Forms.ComboBox();
            this.btnAddObserver = new System.Windows.Forms.Button();
            this.btnDelObserver = new System.Windows.Forms.Button();
            this.btnChangeMenus = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbxObserver = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(32, 54);
            this.txtMenu.Multiline = true;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(232, 259);
            this.txtMenu.TabIndex = 0;
            this.txtMenu.Text = "糖醋排骨 50\r\n油焖大虾 20\r\n糖醋里脊 10\r\n土豆丝   15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "主题（菜单）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "观察者集合";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "新观察者";
            // 
            // cbxObserverType
            // 
            this.cbxObserverType.FormattingEnabled = true;
            this.cbxObserverType.Items.AddRange(new object[] {
            "客户",
            "采购"});
            this.cbxObserverType.Location = new System.Drawing.Point(286, 333);
            this.cbxObserverType.Name = "cbxObserverType";
            this.cbxObserverType.Size = new System.Drawing.Size(52, 20);
            this.cbxObserverType.TabIndex = 5;
            // 
            // btnAddObserver
            // 
            this.btnAddObserver.Location = new System.Drawing.Point(286, 370);
            this.btnAddObserver.Name = "btnAddObserver";
            this.btnAddObserver.Size = new System.Drawing.Size(75, 23);
            this.btnAddObserver.TabIndex = 6;
            this.btnAddObserver.Text = "添加观察者";
            this.btnAddObserver.UseVisualStyleBackColor = true;
            this.btnAddObserver.Click += new System.EventHandler(this.btnAddObserver_Click);
            // 
            // btnDelObserver
            // 
            this.btnDelObserver.Location = new System.Drawing.Point(367, 370);
            this.btnDelObserver.Name = "btnDelObserver";
            this.btnDelObserver.Size = new System.Drawing.Size(75, 23);
            this.btnDelObserver.TabIndex = 7;
            this.btnDelObserver.Text = "删除观察者";
            this.btnDelObserver.UseVisualStyleBackColor = true;
            this.btnDelObserver.Click += new System.EventHandler(this.btnDelObserver_Click);
            // 
            // btnChangeMenus
            // 
            this.btnChangeMenus.Location = new System.Drawing.Point(32, 330);
            this.btnChangeMenus.Name = "btnChangeMenus";
            this.btnChangeMenus.Size = new System.Drawing.Size(75, 23);
            this.btnChangeMenus.TabIndex = 8;
            this.btnChangeMenus.Text = "改变菜单";
            this.btnChangeMenus.UseVisualStyleBackColor = true;
            this.btnChangeMenus.Click += new System.EventHandler(this.btnChangeMenus_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(32, 401);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(395, 212);
            this.txtLog.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "消息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(377, 332);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(65, 21);
            this.txtName.TabIndex = 12;
            // 
            // lbxObserver
            // 
            this.lbxObserver.FormattingEnabled = true;
            this.lbxObserver.ItemHeight = 12;
            this.lbxObserver.Location = new System.Drawing.Point(286, 54);
            this.lbxObserver.Name = "lbxObserver";
            this.lbxObserver.Size = new System.Drawing.Size(120, 256);
            this.lbxObserver.TabIndex = 13;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 625);
            this.Controls.Add(this.lbxObserver);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnChangeMenus);
            this.Controls.Add(this.btnDelObserver);
            this.Controls.Add(this.btnAddObserver);
            this.Controls.Add(this.cbxObserverType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenu);
            this.Name = "MainFrom";
            this.Text = "ObserverPattern";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxObserverType;
        private System.Windows.Forms.Button btnAddObserver;
        private System.Windows.Forms.Button btnDelObserver;
        private System.Windows.Forms.Button btnChangeMenus;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lbxObserver;
    }
}

