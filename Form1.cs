namespace WinFormsApp1
{
    public partial class PetClass : Form
    {
        public PetClass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Pet pet;
        private void btnShow_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string type = txtType.Text;
            decimal age = 0.0m;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(txtAge.Text, out age))
            {
                pet = new Pet(name, type, age);  
            }
            else
            {
                MessageBox.Show("Please correct your input", "Input invalid");
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                lstOutput.Items.Add("Pet's Name: " + pet.Name);
                lstOutput.Items.Add("Pet's Type: " + pet.Type);
                lstOutput.Items.Add("Pet's Age: " + pet.Age);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please enter the pet data first!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}