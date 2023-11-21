
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tburl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btoki = new System.Windows.Forms.Button();
            this.tbokiname = new System.Windows.Forms.TextBox();
            this.lboki = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tburl
            // 
            this.tburl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tburl.Location = new System.Drawing.Point(36, 26);
            this.tburl.Name = "tburl";
            this.tburl.Size = new System.Drawing.Size(513, 31);
            this.tburl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(566, 26);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(98, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(296, 136);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(368, 484);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(695, 26);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(583, 596);
            this.wbBrowser.TabIndex = 3;
            // 
            // btoki
            // 
            this.btoki.Location = new System.Drawing.Point(566, 85);
            this.btoki.Name = "btoki";
            this.btoki.Size = new System.Drawing.Size(98, 32);
            this.btoki.TabIndex = 4;
            this.btoki.Text = "お気に入り登録";
            this.btoki.UseVisualStyleBackColor = true;
            this.btoki.Click += new System.EventHandler(this.btoki_Click);
            // 
            // tbokiname
            // 
            this.tbokiname.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbokiname.Location = new System.Drawing.Point(36, 88);
            this.tbokiname.Multiline = true;
            this.tbokiname.Name = "tbokiname";
            this.tbokiname.Size = new System.Drawing.Size(513, 29);
            this.tbokiname.TabIndex = 5;
            // 
            // lboki
            // 
            this.lboki.FormattingEnabled = true;
            this.lboki.ItemHeight = 12;
            this.lboki.Location = new System.Drawing.Point(36, 164);
            this.lboki.Name = "lboki";
            this.lboki.Size = new System.Drawing.Size(193, 148);
            this.lboki.TabIndex = 6;
            this.lboki.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboki_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "お気に入り名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "お気に入り";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboki);
            this.Controls.Add(this.tbokiname);
            this.Controls.Add(this.btoki);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tburl);
            this.Name = "Form1";
            this.Text = "RSS Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tburl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btoki;
        private System.Windows.Forms.TextBox tbokiname;
        private System.Windows.Forms.ListBox lboki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

