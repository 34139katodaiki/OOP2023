
namespace CalendarApp {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnextyear = new System.Windows.Forms.Button();
            this.btbeforeyear = new System.Windows.Forms.Button();
            this.btnextmonth = new System.Windows.Forms.Button();
            this.btbeforemonth = new System.Windows.Forms.Button();
            this.btnextday = new System.Windows.Forms.Button();
            this.btbeforeday = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnowtime = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(84, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(84, 61);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(126, 40);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(314, 5);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(395, 131);
            this.tbMessage.TabIndex = 3;
            // 
            // btnextyear
            // 
            this.btnextyear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnextyear.Location = new System.Drawing.Point(192, 155);
            this.btnextyear.Name = "btnextyear";
            this.btnextyear.Size = new System.Drawing.Size(92, 39);
            this.btnextyear.TabIndex = 4;
            this.btnextyear.Text = "＋年";
            this.btnextyear.UseVisualStyleBackColor = true;
            this.btnextyear.Click += new System.EventHandler(this.btnextyear_Click);
            // 
            // btbeforeyear
            // 
            this.btbeforeyear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btbeforeyear.Location = new System.Drawing.Point(84, 155);
            this.btbeforeyear.Name = "btbeforeyear";
            this.btbeforeyear.Size = new System.Drawing.Size(92, 39);
            this.btbeforeyear.TabIndex = 5;
            this.btbeforeyear.Text = "ー年";
            this.btbeforeyear.UseVisualStyleBackColor = true;
            this.btbeforeyear.Click += new System.EventHandler(this.btbeforeyear_Click);
            // 
            // btnextmonth
            // 
            this.btnextmonth.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnextmonth.Location = new System.Drawing.Point(192, 200);
            this.btnextmonth.Name = "btnextmonth";
            this.btnextmonth.Size = new System.Drawing.Size(92, 39);
            this.btnextmonth.TabIndex = 6;
            this.btnextmonth.Text = "＋月";
            this.btnextmonth.UseVisualStyleBackColor = true;
            this.btnextmonth.Click += new System.EventHandler(this.btnextmonth_Click);
            // 
            // btbeforemonth
            // 
            this.btbeforemonth.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btbeforemonth.Location = new System.Drawing.Point(84, 200);
            this.btbeforemonth.Name = "btbeforemonth";
            this.btbeforemonth.Size = new System.Drawing.Size(92, 39);
            this.btbeforemonth.TabIndex = 7;
            this.btbeforemonth.Text = "ー月";
            this.btbeforemonth.UseVisualStyleBackColor = true;
            this.btbeforemonth.Click += new System.EventHandler(this.btbeforemonth_Click);
            // 
            // btnextday
            // 
            this.btnextday.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnextday.Location = new System.Drawing.Point(192, 245);
            this.btnextday.Name = "btnextday";
            this.btnextday.Size = new System.Drawing.Size(92, 39);
            this.btnextday.TabIndex = 8;
            this.btnextday.Text = "＋日";
            this.btnextday.UseVisualStyleBackColor = true;
            this.btnextday.Click += new System.EventHandler(this.btnextday_Click);
            // 
            // btbeforeday
            // 
            this.btbeforeday.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btbeforeday.Location = new System.Drawing.Point(84, 245);
            this.btbeforeday.Name = "btbeforeday";
            this.btbeforeday.Size = new System.Drawing.Size(92, 39);
            this.btbeforeday.TabIndex = 9;
            this.btbeforeday.Text = "ー日";
            this.btbeforeday.UseVisualStyleBackColor = true;
            this.btbeforeday.Click += new System.EventHandler(this.btbeforeday_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "現在時刻:";
            // 
            // tbnowtime
            // 
            this.tbnowtime.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbnowtime.Location = new System.Drawing.Point(143, 295);
            this.tbnowtime.Multiline = true;
            this.tbnowtime.Name = "tbnowtime";
            this.tbnowtime.Size = new System.Drawing.Size(361, 38);
            this.tbnowtime.TabIndex = 11;
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(84, 107);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(126, 37);
            this.btAge.TabIndex = 12;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 500;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 484);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.tbnowtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbeforeday);
            this.Controls.Add(this.btnextday);
            this.Controls.Add(this.btbeforemonth);
            this.Controls.Add(this.btnextmonth);
            this.Controls.Add(this.btbeforeyear);
            this.Controls.Add(this.btnextyear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnextyear;
        private System.Windows.Forms.Button btbeforeyear;
        private System.Windows.Forms.Button btnextmonth;
        private System.Windows.Forms.Button btbeforemonth;
        private System.Windows.Forms.Button btnextday;
        private System.Windows.Forms.Button btbeforeday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnowtime;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}

