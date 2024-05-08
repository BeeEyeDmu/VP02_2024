namespace _024_SensorMonitoring
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.시뮬레이ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.끝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCount = new System.Windows.Forms.TextBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.btnConnect = new System.Windows.Forms.Button();
      this.btnDisconnect = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.시뮬레이ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(752, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.파일ToolStripMenuItem.Text = " 파일";
      // 
      // 시뮬레이ToolStripMenuItem
      // 
      this.시뮬레이ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem,
            this.끝ToolStripMenuItem});
      this.시뮬레이ToolStripMenuItem.Name = "시뮬레이ToolStripMenuItem";
      this.시뮬레이ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
      this.시뮬레이ToolStripMenuItem.Text = "시뮬레이션";
      // 
      // 시작ToolStripMenuItem
      // 
      this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
      this.시작ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.시작ToolStripMenuItem.Text = "시작";
      // 
      // 끝ToolStripMenuItem
      // 
      this.끝ToolStripMenuItem.Name = "끝ToolStripMenuItem";
      this.끝ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.끝ToolStripMenuItem.Text = "끝";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(32, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Connection Time : ";
      // 
      // txtCount
      // 
      this.txtCount.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtCount.Location = new System.Drawing.Point(313, 42);
      this.txtCount.Name = "txtCount";
      this.txtCount.Size = new System.Drawing.Size(204, 23);
      this.txtCount.TabIndex = 3;
      this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(46, 94);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(454, 23);
      this.progressBar1.TabIndex = 4;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.Location = new System.Drawing.Point(34, 71);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(483, 77);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "PhotoCell";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 51);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(14, 15);
      this.label2.TabIndex = 0;
      this.label2.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(437, 51);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 15);
      this.label3.TabIndex = 1;
      this.label3.Text = "1023";
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(34, 154);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(483, 184);
      this.listBox1.TabIndex = 6;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Controls.Add(this.btnDisconnect);
      this.groupBox2.Controls.Add(this.btnConnect);
      this.groupBox2.Controls.Add(this.comboBox2);
      this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox2.Location = new System.Drawing.Point(545, 48);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(177, 290);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Port";
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(17, 32);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(140, 23);
      this.comboBox2.TabIndex = 0;
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(17, 69);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(140, 23);
      this.btnConnect.TabIndex = 1;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Location = new System.Drawing.Point(17, 98);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(140, 23);
      this.btnDisconnect.TabIndex = 2;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(17, 127);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(140, 143);
      this.button3.TabIndex = 3;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // chart1
      // 
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart1.Legends.Add(legend3);
      this.chart1.Location = new System.Drawing.Point(34, 358);
      this.chart1.Name = "chart1";
      series3.ChartArea = "ChartArea1";
      series3.Legend = "Legend1";
      series3.Name = "Series1";
      this.chart1.Series.Add(series3);
      this.chart1.Size = new System.Drawing.Size(688, 300);
      this.chart1.TabIndex = 8;
      this.chart1.Text = "chart1";
      // 
      // chart2
      // 
      chartArea4.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea4);
      legend4.Name = "Legend1";
      this.chart2.Legends.Add(legend4);
      this.chart2.Location = new System.Drawing.Point(34, 665);
      this.chart2.Name = "chart2";
      series4.ChartArea = "ChartArea1";
      series4.Legend = "Legend1";
      series4.Name = "Series1";
      this.chart2.Series.Add(series4);
      this.chart2.Size = new System.Drawing.Size(688, 300);
      this.chart2.TabIndex = 10;
      this.chart2.Text = "chart3";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button1.Location = new System.Drawing.Point(241, 986);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "View All";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button2.Location = new System.Drawing.Point(370, 986);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 12;
      this.button2.Text = "Zoom";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(752, 1021);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.chart2);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.txtCount);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.groupBox1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 시뮬레이ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 끝ToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCount;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}

