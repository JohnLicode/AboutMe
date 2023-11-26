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
    }
}
