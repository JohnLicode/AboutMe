using System.Xml;

namespace COFFEESHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Insert_Click(object sender, EventArgs e)
        {
            if (UCcombobox.SelectedItem.ToString() == "Ice Macha Tea Latte")
            {
                if (UScombobox.SelectedItem.ToString() == "Tall(12 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 190).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Grande(16 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 195).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Verti(24 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 200).ToString();
                }
                dataGridView1.Rows.Add(UNtextbox.Text, UCcombobox.Text, UScombobox.Text, UQcombobox.Text, Ptextbox.Text);
            }

            else if (UCcombobox.SelectedItem.ToString() == "Ice Caramel Macchiato")
            {
                if (UScombobox.SelectedItem.ToString() == "Tall(12 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 190).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Grande(16 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 195).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Verti(24 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 200).ToString();
                }
                dataGridView1.Rows.Add(UNtextbox.Text, UCcombobox.Text, UScombobox.Text, UQcombobox.Text, Ptextbox.Text);

            }

            else if (UCcombobox.SelectedItem.ToString() == "Vanila Ice Coffee")
            {
                if (UScombobox.SelectedItem.ToString() == "Tall(12 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 190).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Grande(16 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 195).ToString();
                }
                if (UScombobox.SelectedItem.ToString() == "Verti(24 fl oz)")
                {
                    Ptextbox.Text = (float.Parse(UQcombobox.Text) * 200).ToString();
                }
                dataGridView1.Rows.Add(UNtextbox.Text, UCcombobox.Text, UScombobox.Text, UQcombobox.Text, Ptextbox.Text);

            }

            int sum = 0;

            for (int row = 0 ; row < dataGridView1.Rows.Count; row++)
                {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);

                }
                TotalDisplay.Text = sum.ToString();




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
            UNtextbox.Text = "";
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

        }

        private void TotalDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
