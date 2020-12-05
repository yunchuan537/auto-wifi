namespace wifi
{
    partial class main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerCounter = new System.Windows.Forms.Timer(this.components);
            this.Ping = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.WifiList = new System.Windows.Forms.ListBox();
            this.CurrentWifi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerCounter
            // 
            this.TimerCounter.Interval = 1000;
            this.TimerCounter.Tick += new System.EventHandler(this.TimerCounter_Tick);
            // 
            // Ping
            // 
            this.Ping.AutoSize = true;
            this.Ping.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ping.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Ping.Location = new System.Drawing.Point(365, 9);
            this.Ping.Name = "Ping";
            this.Ping.Size = new System.Drawing.Size(131, 38);
            this.Ping.TabIndex = 6;
            this.Ping.Text = "status";
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentTime.Location = new System.Drawing.Point(16, 290);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(133, 30);
            this.CurrentTime.TabIndex = 7;
            this.CurrentTime.Text = "当前时间";
            // 
            // WifiList
            // 
            this.WifiList.FormattingEnabled = true;
            this.WifiList.ItemHeight = 15;
            this.WifiList.Location = new System.Drawing.Point(21, 9);
            this.WifiList.Name = "WifiList";
            this.WifiList.Size = new System.Drawing.Size(320, 274);
            this.WifiList.TabIndex = 8;
            // 
            // CurrentWifi
            // 
            this.CurrentWifi.AutoSize = true;
            this.CurrentWifi.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentWifi.ForeColor = System.Drawing.Color.Red;
            this.CurrentWifi.Location = new System.Drawing.Point(347, 79);
            this.CurrentWifi.Name = "CurrentWifi";
            this.CurrentWifi.Size = new System.Drawing.Size(64, 25);
            this.CurrentWifi.TabIndex = 9;
            this.CurrentWifi.Text = "wifi";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 335);
            this.Controls.Add(this.CurrentWifi);
            this.Controls.Add(this.WifiList);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.Ping);
            this.Name = "main";
            this.Text = "win10断网自动重连-云川";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerCounter;
        private System.Windows.Forms.Label Ping;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.ListBox WifiList;
        private System.Windows.Forms.Label CurrentWifi;
    }
}

