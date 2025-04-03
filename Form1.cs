namespace Crud2
{
    public partial class Form1 : Form
    {
        public List<Cerveza> Cervezas { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Cervezas = new List<Cerveza>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvCervezas.DataSource = Cervezas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CervezaForm cervezaFrom = new CervezaForm();
            if (cervezaFrom.ShowDialog() == DialogResult.OK)
            {
                this.Cervezas.Add(cervezaFrom.Cerveza);
                this.dgvCervezas.DataSource = this.Cervezas.ToList();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cerveza? seleccionada = (Cerveza)this.dgvCervezas.CurrentRow.DataBoundItem;
            CervezaForm cervezaFrom = new CervezaForm();
            if (cervezaFrom.ShowDialog() == DialogResult.OK)
            {
                Cerveza? editar = this.Cervezas.FirstOrDefault(c => c == seleccionada);
                editar = cervezaFrom.Cerveza;
                this.dgvCervezas.DataSource = this.Cervezas.ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cerveza? seleccionada = (Cerveza)this.dgvCervezas.CurrentRow.DataBoundItem;
            this.Cervezas.Remove(seleccionada);
            this.dgvCervezas.DataSource = this.Cervezas.ToList();
        }
    }
}
