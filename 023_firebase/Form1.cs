using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace _023_firebase
{
  public partial class Form1 : Form
  {
    DataTable dt = new DataTable();

    IFirebaseConfig config = new FirebaseConfig 
    {
      AuthSecret = "M35WPcRuIrG82h4ymXIgfi3hTg3l76i1Fo9xDjfB",
      BasePath = "https://fbpproject-b4ea5-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);
      if(client != null)
      {
        MessageBox.Show("Connection 성공!");
      }

      dt.Columns.Add("Id");
      dt.Columns.Add("학번");
      dt.Columns.Add("이름");
      dt.Columns.Add("전화번호");

      dataGridView1.DataSource = dt;

      dt.Rows.Clear();
      export();
    }

    private async void btnInsert_Click(object sender, EventArgs e)
    {
      FirebaseResponse resp = await client.GetAsync("Counter/");
      Counter c = resp.ResultAs<Counter>();      

      Data data = new Data
      {
        Id = (c.cnt + 1).ToString(),
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };
      SetResponse response
        = await  client.SetAsync("Phonebook/" + data.Id, data);
      Data result = response.ResultAs<Data>();

      MessageBox.Show("Data Inserted : Id = " + result.Id);

      var obj = new Counter
      {
        cnt = c.cnt + 1
      };
      SetResponse response1 = await client.SetAsync("Counter/", obj);

      dt.Rows.Clear();
      export();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtId.Text = "";
      txtSId.Text = "";
      txtName.Text = "";
      txtPhone.Text = "";
    }

    private async void btnRetrieve_Click(object sender, EventArgs e)
    {
      FirebaseResponse response
        = await client.GetAsync("Phonebook/" + txtId.Text);
      Data obj = response.ResultAs<Data>();

      if (obj != null)
      {
        txtId.Text = obj.Id;
        txtName.Text = obj.Name;
        txtPhone.Text = obj.Phone;
        txtSId.Text = obj.SId;

        MessageBox.Show("Data retrieved successfully!");
      } 
      else
      {
        MessageBox.Show("Data not found!");
      }
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      Data data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      FirebaseResponse response = await
        client.UpdateAsync("Phonebook/"+txtId.Text, data);
      Data result = response.ResultAs<Data>();
      MessageBox.Show("Data updated successfully! : Id = "
        + result.Id);

      dt.Rows.Clear();
      export();
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
      FirebaseResponse response 
        = await client.DeleteAsync("Phonebook/" + txtId.Text);
      MessageBox.Show("Deleted! : id = " + txtId.Text);

      dt.Rows.Clear();
      export();
    }

    private async void btnDeleteAll_Click(object sender, EventArgs e)
    {
      DialogResult answer = MessageBox.Show(
        "저장된 모든 데이터가 삭제됩니다. 계속할까요?",
        "경고!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

      if (answer == DialogResult.No)
        return;

      // cnt를 0으로 초기화
      var obj = new Counter { cnt = 0 };

      SetResponse resp = await client.SetAsync("Counter/", obj);

      FirebaseResponse response
        = await client.DeleteAsync("Phonebook");
      MessageBox.Show("All data at Phonebook/ Deleted!");

      dt.Rows.Clear();
      export();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnViewAll_Click(object sender, EventArgs e)
    {
      dt.Rows.Clear();
      export();
    }

    private async void export()
    {
      int i = 0;
      FirebaseResponse response = await client.GetAsync("Counter/");
      Counter obj = response.ResultAs<Counter>();
      int cnt = obj.cnt;

      while(i != cnt)
      {
        i++;
        FirebaseResponse resp = await client.GetAsync("Phonebook/" + i);
        Data d = resp.ResultAs<Data>();

        if(d != null)
        {
          DataRow row = dt.NewRow();
          row["Id"] = d.Id;
          row["학번"] = d.SId;
          row["이름"] = d.Name;
          row["전화번호"] = d.Phone;
          dt.Rows.Add(row);
        }
      }
    }

    private void dataGridView1_CellClick(object sender, 
      DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;
      txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
      txtSId.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
      txtName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
      txtPhone.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
    }
  }
}
