namespace APP_Listbox
{
    public partial class TstSeries : Form
    {
        public TstSeries()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            listSeries.Items.Add(TxSeries.Text);
            TxSeries.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxLimpiar_Click(object sender, EventArgs e)
        {
            listSeries.Items.Clear();
        }

        private void TstSeries_Load(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

           



                if (listSeries.SelectedIndex != -1)
                {
                    listSeries.Items.RemoveAt(listSeries.SelectedIndex);
                }
            
        }

        private void TxTindex_Click(object sender, EventArgs e)
        {

        }

        private void listSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
          TxTindex.Text=listSeries.SelectedIndex.ToString();
            TxTindex.ForeColor = Color.Green;
          
        }
    }
}
