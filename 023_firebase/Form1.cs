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
    }

    private async void btnInsert_Click(object sender, EventArgs e)
    {
      Data data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };
      SetResponse response
        = await  client.SetAsync("Phonebook/" + txtId.Text, data);
      Data result = response.ResultAs<Data>();

      MessageBox.Show("Data Inserted : Id = " + result.Id);
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

      txtId.Text = obj.Id;
      txtName.Text = obj.Name;
      txtPhone.Text = obj.Phone;
      txtSId.Text = obj.SId;

      MessageBox.Show("Data retrieved successfully!");
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
    }
  }
}
