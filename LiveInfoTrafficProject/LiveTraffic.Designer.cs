namespace LiveInfoTrafficProject
{
    partial class LiveTraffic
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnToDatabank = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.json = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUitleg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(158, 468);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 56);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START HERE TO FILL THIS PAGE UP";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(-1, 25);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(508, 422);
            this.tbData.TabIndex = 2;
            // 
            // btnToDatabank
            // 
            this.btnToDatabank.Location = new System.Drawing.Point(158, 546);
            this.btnToDatabank.Name = "btnToDatabank";
            this.btnToDatabank.Size = new System.Drawing.Size(151, 56);
            this.btnToDatabank.TabIndex = 5;
            this.btnToDatabank.Text = "DATABANK SYSTEM";
            this.btnToDatabank.UseVisualStyleBackColor = true;
            this.btnToDatabank.Click += new System.EventHandler(this.btnToDatabank_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(513, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser4);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 577);
            this.splitContainer1.SplitterDistance = 567;
            this.splitContainer1.TabIndex = 6;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(567, 577);
            this.webBrowser3.TabIndex = 0;
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(0, 0);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(551, 577);
            this.webBrowser4.TabIndex = 0;
            // 
            // json
            // 
            this.json.AutoSize = true;
            this.json.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.json.Location = new System.Drawing.Point(179, 9);
            this.json.Name = "json";
            this.json.Size = new System.Drawing.Size(71, 13);
            this.json.TabIndex = 7;
            this.json.Text = "JSON CODE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(755, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MAP TRAFFIC INCIDENTS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1334, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MAP TRAFFIC FLOW:";
            // 
            // btnUitleg
            // 
            this.btnUitleg.Location = new System.Drawing.Point(380, 468);
            this.btnUitleg.Name = "btnUitleg";
            this.btnUitleg.Size = new System.Drawing.Size(102, 28);
            this.btnUitleg.TabIndex = 10;
            this.btnUitleg.Text = "uitleg";
            this.btnUitleg.UseVisualStyleBackColor = true;
            this.btnUitleg.Click += new System.EventHandler(this.btnUitleg_Click);
            // 
            // LiveTraffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1647, 666);
            this.Controls.Add(this.btnUitleg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.json);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btnToDatabank);
            this.Controls.Add(this.btnStart);
            this.Name = "LiveTraffic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiveTraffic";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button btnToDatabank;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.Label json;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUitleg;
    }
}