using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace COFFEESHOP
{
    public partial class Form1 : Form
    {
        //private string connectionString = "Server=myServerAddress;Database=myDatabase;User Id=sa;Password=root;";

        
        public Form1()
        {
            InitializeComponent();
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Choosen item

        private void Insert_Click(object sender, EventArgs e)
        {
            if (UCcombobox.SelectedItem.ToString() == "Ice Macha Tea Latte")
            {
                if (UScombobox.SelectedItem.ToString() == "Small(12 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 200).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Medium(16 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 250).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Large(24 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 300).ToString();
                }
                dataGridView1.Rows.Add(UNtextbox.Text, UCcombobox.Text, UScombobox.Text, UQcombobox.Text, Ptextbox.Text);
            }

            else if (UCcombobox.SelectedItem.ToString() == "Ice Caramel Macchiato")
            {
                if (UScombobox.SelectedItem.ToString() == "Small(12 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 200).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Medium(16 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 250).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Large(24 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 300).ToString();
                }
                dataGridView1.Rows.Add(UNtextbox.Text, UCcombobox.Text, UScombobox.Text, UQcombobox.Text, Ptextbox.Text);

            }

            else if (UCcombobox.SelectedItem.ToString() == "Vanila Ice Coffee")
            {
                if (UScombobox.SelectedItem.ToString() == "Small(12 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 200).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Medium(16 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 250).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Large(24 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 300).ToString();
                }
                dataGridView1.Rows.Add(UNtextbox.Text, UCcombobox.Text, UScombobox.Text, UQcombobox.Text, Ptextbox.Text);

            }

            int sum = 0;

            for (int row = 0 ; row < dataGridView1.Rows.Count; row++)
                {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);

                }
                TotalDisplay.Text = sum.ToString();         // Sum the total value of sum in Total Display




        }



        private void UNtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UScombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UQcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ptextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
           // UNtextbox.Text = "";
            UCcombobox.Text = "";
            UScombobox.Text = "";
            UQcombobox.Text = "";
            Ptextbox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            int minus = 0;

            for (int row = dataGridView1.Rows.Count - 1; row >= 0; row--)
            {
                int cellValue = 0;
                if (dataGridView1.Rows[row].Cells[4].Value != null &&
                    int.TryParse(dataGridView1.Rows[row].Cells[4].Value.ToString(), out cellValue))
                {
                    minus -= cellValue; // Subtract the cell value from 'minus'
                }
            }

            TotalDisplay.Text = minus.ToString();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
             //DataGridview connection to MicrosoftSql Server management studio

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ACHFCNO\SQLEXPRESS;Initial Catalog=coffeeshop;Integrated Security=True;Encrypt=False");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO coffeeuserdata(Name,Choice,Size,Quantity,Payment)VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value +"')",con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();




            }
            dataGridView1.Rows.Clear();


            this.Hide();
            var newform = new Form2();
            newform.Show();
           
            


            TotalDisplay.Text = "";


        }

        private void TotalDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
