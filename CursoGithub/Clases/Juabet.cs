using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoGithub.Clases
{
    public class Juabet : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;

        [Required]
        [StringLength(50)]
        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }

        [Required]
        [StringLength(50)]
        public string Apellido
        {
            get => apellido;
            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged(nameof(Apellido));
                }
            }
        }

        [StringLength(100)]
        public string Direccion
        {
            get => direccion;
            set
            {
                if (direccion != value)
                {
                    direccion = value;
                    OnPropertyChanged(nameof(Direccion));
                }
            }
        }

        [Phone]
        public string Telefono
        {
            get => telefono;
            set
            {
                if (telefono != value)
                {
                    telefono = value;
                    OnPropertyChanged(nameof(Telefono));
                }
            }
        }

        public Juabet() { }

        public Juabet(string nombre, string apellido, string direccion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }

        public override string ToString() => $"{Nombre} {Apellido}, {Direccion}, {Telefono}";

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
