namespace _022_daClock
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.아날로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.디지털ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.보기ToolStripMenuItem,
            this.옵션ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(352, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 보기ToolStripMenuItem
      // 
      this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.아날로그ToolStripMenuItem,
            this.디지털ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료ToolStripMenuItem});
      this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
      this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.보기ToolStripMenuItem.Text = "보기";
      // 
      // 아날로그ToolStripMenuItem
      // 
      this.아날로그ToolStripMenuItem.Name = "아날로그ToolStripMenuItem";
      this.아날로그ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.아날로그ToolStripMenuItem.Text = "아날로그";
      this.아날로그ToolStripMenuItem.Click += new System.EventHandler(this.아날로그ToolStripMenuItem_Click);
      // 
      // 디지털ToolStripMenuItem
      // 
      this.디지털ToolStripMenuItem.Name = "디지털ToolStripMenuItem";
      this.디지털ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.디지털ToolStripMenuItem.Text = "디지털";
      this.디지털ToolStripMenuItem.Click += new System.EventHandler(this.디지털ToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // 종료ToolStripMenuItem
      // 
      this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
      this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.종료ToolStripMenuItem.Text = "종료";
      this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
      // 
      // 옵션ToolStripMenuItem
      // 
      this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
      this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.옵션ToolStripMenuItem.Text = "옵션";
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(50, 81);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(244, 252);
      this.panel1.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 아날로그ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 디지털ToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
  }
}

