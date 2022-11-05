using System.Diagnostics;

namespace MenuContextualEnWindowsForms
{
    public partial class Form1 : Form
    {
        //vamos a declarar las variables globales q usare
        private List<PublicacionImagen> rows;
        private string idleido = "";
        private const string icono = "D:\\temp\\menu.png";
        private ContextMenuStrip menu = new ContextMenuStrip();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {//Inicializare las variables
            rows = new List<PublicacionImagen>();
            txttitulo.Focus();
            //aqui defino el numero max de columnas y el tipo de datos  contenidos
            dgvdatos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id" });
            dgvdatos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Titulo" });
            dgvdatos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Autor" });
            dgvdatos.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Publico" });
            dgvdatos.Columns.Add(new DataGridViewImageColumn { Name = "Menu" });
            //Aqui inicializamos el menu contextual q necesitamos para desplegarse con el click del mouse
            menu.Name = "Menu";
            menu.Items.Add("Mostrar", Image.FromFile(icono), menuopen);
            menu.Items.Add("Borrar", Image.FromFile(icono), menudelete);
            menu.Items.Add("Limpiar", Image.FromFile(icono), menuclose);
        }
        private void menuopen(object? sender, EventArgs e)
        {
            leeritem(idleido);
        }
        private void leeritem(string id)
        {
            //Aqui buscamos el id dentro del DataGridView con el uso de LinQ
            var elvalor = dgvdatos.Rows.Cast<DataGridViewRow>().
                Where(x => x.Cells[0].Value.ToString().Equals(id)).FirstOrDefault().Cells[0].Value;
            if (elvalor != null)
            {
                var item = rows.Where(x=>x.id.Equals(elvalor)).FirstOrDefault();
                txtautor.Text = item.autor;
                txttitulo.Text = item.titulo;
                lblidvalue.Text = item.id.ToString();
                cbxespublico.Checked = item.espublico;
            }
        }
        private void menudelete(object? sender, EventArgs e)
        {
            borrar();
        }
        private void borrar()
        {
            if (!idleido.Equals(""))
            {
                var elid = idleido;
                var msg = MessageBox.Show(
                    "Esta seguro de borrar este registro",
                    "Informativo",
                    MessageBoxButtons.OKCancel
                );
                //Aqui preguntamos y confirmamos si deseamos borra el elemento
                if (msg.Equals(DialogResult.OK))
                {
                    //aqui con LinQ preguntamos si el id proporcionado esta en la lista de elementos
                    //Aqui le indicamos q debe actualizar la lista exceptuando el id a borrar
                    rows = rows.Where(x => !x.id.ToString().Equals(elid)).ToList();
                    limpiar();
                    actualizarvista();
                }
            }
        }
        private void actualizarvista()
        {
            //con esta linea depuramos el source si es q viene de una tabla o BDs
            dgvdatos.DataSource = null;
            //Con esta linea limpiamos si viene de una lista de items de rows
            dgvdatos.Rows.Clear();
            foreach (var item in rows)
            {
                DataGridViewRow dr = new DataGridViewRow();

                dr.CreateCells(dgvdatos);

                dr.Cells[0].Value = item.id;
                dr.Cells[1].Value = item.titulo;
                dr.Cells[2].Value = item.autor;
                dr.Cells[3].Value = item.espublico;
                dr.Cells[4].Value = Image.FromFile(item.urlimagen);

                dgvdatos.Rows.Add(dr);
            }
        }
        private void menuclose(object? sender, EventArgs e)
        {
            limpiar();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!txttitulo.Text.Trim().Equals("") && !txtautor.Text.Trim().Equals(""))
            {
                var pub = new PublicacionImagen(
                    txttitulo.Text,
                    txtautor.Text,
                    icono,
                    cbxespublico.Checked
                );
                rows.Add(pub);
                Debug.WriteLine(pub.ToString());
                limpiar();
            }
            //Falto mandar a llamar q se actualice la tabla del DGV
            actualizarvista();
        }
        private void limpiar()
        {
            txtautor.Text = "";
            txttitulo.Text = "";
            lblidvalue.Text = "";
            cbxespublico.Checked = false;
        }

        private void dgvdatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//Primero identificamos q el boton sea el derecho del mouse
            if (e.Button.Equals(MouseButtons.Right))
            {
                var fila = e.RowIndex;
                if (fila >= 0)
                {
                    //Aqui obtenemos la fila con el row index y la celda 0 q contiene el id del registro
                    var obj = dgvdatos.Rows[fila].Cells[0];
                    idleido = obj.Value.ToString();
                    //Ahora posicionamos el menu en la coordenada del mouse en ese momento
                    //con la propiedad show haremos q aparezca
                    menu.Show(new Point(MousePosition.X, MousePosition.Y));
                }
            }
        }
        //Por ultimo agregaremos un evento q se activara cuando seleccionemos la celda con el click
        //derecho del mouse

    }
}