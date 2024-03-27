namespace _004_bmiForm
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
      this.txtH = new System.Windows.Forms.TextBox();
      this.txtW = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnBMI = new System.Windows.Forms.Button();
      this.lblBMI = new System.Windows.Forms.Label();
      this.lblResult = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(46, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "키(cm)";
      // 
      // txtH
      // 
      this.txtH.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtH.Location = new System.Drawing.Point(108, 59);
      this.txtH.Name = "txtH";
      this.txtH.Size = new System.Drawing.Size(100, 23);
      this.txtH.TabIndex = 1;
      this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtW
      // 
      this.txtW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtW.Location = new System.Drawing.Point(108, 105);
      this.txtW.Name = "txtW";
      this.txtW.Size = new System.Drawing.Size(100, 23);
      this.txtW.TabIndex = 3;
      this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(46, 108);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "체중(kg)";
      // 
      // btnBMI
      // 
      this.btnBMI.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnBMI.Location = new System.Drawing.Point(108, 154);
      this.btnBMI.Name = "btnBMI";
      this.btnBMI.Size = new System.Drawing.Size(100, 30);
      this.btnBMI.TabIndex = 4;
      this.btnBMI.Text = "BMI 계산";
      this.btnBMI.UseVisualStyleBackColor = true;
      this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
      // 
      // lblBMI
      // 
      this.lblBMI.AutoSize = true;
      this.lblBMI.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblBMI.Location = new System.Drawing.Point(48, 227);
      this.lblBMI.Name = "lblBMI";
      this.lblBMI.Size = new System.Drawing.Size(44, 15);
      this.lblBMI.TabIndex = 5;
      this.lblBMI.Text = "BMI = ";
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblResult.Location = new System.Drawing.Point(48, 278);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(42, 15);
      this.lblResult.TabIndex = 6;
      this.lblResult.Text = "판정 : ";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(203, 240);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(47, 60);
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(279, 391);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.lblBMI);
      this.Controls.Add(this.btnBMI);
      this.Controls.Add(this.txtW);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtH);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "BMI 계산기";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtH;
    private System.Windows.Forms.TextBox txtW;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnBMI;
    private System.Windows.Forms.Label lblBMI;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

