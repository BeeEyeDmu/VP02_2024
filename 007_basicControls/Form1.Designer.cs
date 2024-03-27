namespace _007_basicControls
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnClick = new System.Windows.Forms.Button();
      this.lblHello = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(43, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "이름 :";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(124, 44);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(100, 21);
      this.txtName.TabIndex = 1;
      // 
      // btnClick
      // 
      this.btnClick.Location = new System.Drawing.Point(264, 43);
      this.btnClick.Name = "btnClick";
      this.btnClick.Size = new System.Drawing.Size(75, 23);
      this.btnClick.TabIndex = 2;
      this.btnClick.Text = "클릭";
      this.btnClick.UseVisualStyleBackColor = true;
      this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
      // 
      // lblHello
      // 
      this.lblHello.AutoSize = true;
      this.lblHello.Location = new System.Drawing.Point(124, 104);
      this.lblHello.Name = "lblHello";
      this.lblHello.Size = new System.Drawing.Size(0, 12);
      this.lblHello.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(375, 160);
      this.Controls.Add(this.lblHello);
      this.Controls.Add(this.btnClick);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Basic Contros";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnClick;
    private System.Windows.Forms.Label lblHello;
  }
}

