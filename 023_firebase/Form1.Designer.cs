namespace _023_firebase
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.txtId = new System.Windows.Forms.TextBox();
      this.txtSId = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnViewAll = new System.Windows.Forms.Button();
      this.btnDeleteAll = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnInsert = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnRetrieve = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(13, 13);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(409, 201);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(34, 257);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(17, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Id";
      // 
      // txtId
      // 
      this.txtId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtId.Location = new System.Drawing.Point(92, 254);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(100, 23);
      this.txtId.TabIndex = 2;
      // 
      // txtSId
      // 
      this.txtSId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSId.Location = new System.Drawing.Point(92, 295);
      this.txtSId.Name = "txtSId";
      this.txtSId.Size = new System.Drawing.Size(100, 23);
      this.txtSId.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(34, 298);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "학번";
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtName.Location = new System.Drawing.Point(92, 336);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(100, 23);
      this.txtName.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label3.Location = new System.Drawing.Point(34, 339);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "이름";
      // 
      // txtPhone
      // 
      this.txtPhone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtPhone.Location = new System.Drawing.Point(92, 377);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(100, 23);
      this.txtPhone.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label4.Location = new System.Drawing.Point(34, 380);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 15);
      this.label4.TabIndex = 7;
      this.label4.Text = "전화번호";
      // 
      // btnViewAll
      // 
      this.btnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnViewAll.Location = new System.Drawing.Point(224, 252);
      this.btnViewAll.Name = "btnViewAll";
      this.btnViewAll.Size = new System.Drawing.Size(75, 23);
      this.btnViewAll.TabIndex = 9;
      this.btnViewAll.Text = "View All";
      this.btnViewAll.UseVisualStyleBackColor = true;
      this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
      // 
      // btnDeleteAll
      // 
      this.btnDeleteAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnDeleteAll.Location = new System.Drawing.Point(324, 252);
      this.btnDeleteAll.Name = "btnDeleteAll";
      this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
      this.btnDeleteAll.TabIndex = 10;
      this.btnDeleteAll.Text = "Delete All";
      this.btnDeleteAll.UseVisualStyleBackColor = true;
      this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnDelete.Location = new System.Drawing.Point(324, 293);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 12;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnInsert
      // 
      this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnInsert.Location = new System.Drawing.Point(224, 293);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(75, 23);
      this.btnInsert.TabIndex = 11;
      this.btnInsert.Text = "Insert";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnUpdate.Location = new System.Drawing.Point(324, 334);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 23);
      this.btnUpdate.TabIndex = 14;
      this.btnUpdate.Text = "Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnRetrieve
      // 
      this.btnRetrieve.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnRetrieve.Location = new System.Drawing.Point(224, 334);
      this.btnRetrieve.Name = "btnRetrieve";
      this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
      this.btnRetrieve.TabIndex = 13;
      this.btnRetrieve.Text = "Retrieve";
      this.btnRetrieve.UseVisualStyleBackColor = true;
      this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnExit.Location = new System.Drawing.Point(324, 375);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 16;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnClear.Location = new System.Drawing.Point(224, 375);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 15;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label5.Location = new System.Drawing.Point(89, 234);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(227, 15);
      this.label5.TabIndex = 17;
      this.label5.Text = "※ Insert 할 때 Id값은 입력하지 않습니다.";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(432, 450);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnRetrieve);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnInsert);
      this.Controls.Add(this.btnDeleteAll);
      this.Controls.Add(this.btnViewAll);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSId);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "전화번호부";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtSId;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnViewAll;
    private System.Windows.Forms.Button btnDeleteAll;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnRetrieve;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label label5;
  }
}

