using pryLopezEtapa3;

namespace pryLopezEtapa6
{
    public partial class frmVehiculos : Form
    {
        private List<clsVehiculo> vehiculos; // Lista para almacenar los vehículos
        public frmVehiculos()
        {
            vehiculos = new List<clsVehiculo>();
            InitializeComponent();
        }
        private int imagenesMostradas = 0;
        private void MostrarVehiculo(clsVehiculo vehiculo)
        {// Verificar si ya no hay espacio para mostrar más imágenes
            if (imagenesMostradas >= (this.ClientSize.Width * this.ClientSize.Height) / (80 * 100))
            {
                MessageBox.Show("Ya no hay espacio disponible para mostrar más imágenes.", "Sin espacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Generar una posición aleatoria dentro del formulario
            Random rnd = new Random();
            int x, y;

            do
            {
                x = rnd.Next(0, this.ClientSize.Width - 80); // Restamos 80 para que la imagen no se salga del formulario
                y = rnd.Next(0, this.ClientSize.Height - 100); // Restamos 100 para que la imagen no se salga del formulario
            } while (ExisteSuperposicion(x, y));

            // Crear una nueva imagen con el tamaño especificado
            Bitmap resizedImage = new Bitmap(80, 100);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(vehiculo.Imagen, new Rectangle(0, 0, 80, 100));
            }

            // Mostrar la imagen en el formulario en la posición aleatoria
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(x, y);
            pictureBox.Size = new Size(80, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = resizedImage;
            this.Controls.Add(pictureBox);

            // Agregar el vehículo a la lista
            vehiculos.Add(vehiculo);

            // Incrementar el contador de imágenes mostradas
            imagenesMostradas++;
        }

        private bool ExisteSuperposicion(int x, int y)
        {
            // Verificar si la posición (x, y) está ocupada por alguna imagen existente
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    if (pictureBox.Bounds.IntersectsWith(new Rectangle(x, y, 80, 100)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void btnAuto_Click(object sender, EventArgs e)
        {

            // Crea un nuevo objeto clsVehiculo y muestra la imagen
            clsVehiculo auto = new clsVehiculo("Auto", "Auto", Properties.Resources.auto);
            MostrarVehiculo(auto);
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {

            // Crea un nuevo objeto clsVehiculo y muestra la imagen
            clsVehiculo barco = new clsVehiculo("Barco", "Barco", Properties.Resources.barco);
            MostrarVehiculo(barco);
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {

            // Crea un nuevo objeto clsVehiculo y muestra la imagen
            clsVehiculo avion = new clsVehiculo("Avion", "Avion", Properties.Resources.avion);
            MostrarVehiculo(avion);
        }
    }
}
