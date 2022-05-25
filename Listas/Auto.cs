namespace Listas
{
    public class Auto
    {
        private string marca { get; set; }
        private string modelo { get; set; }
        private double precio { get; set; }
        private int cantidadUnidades { get; set; }


        public Auto() { }
        public Auto(string marca, string modelo, double precio, int cantidadUnidades)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.cantidadUnidades = cantidadUnidades;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return modelo;
        }

        public string getMarca()
        {
            return marca;
        }
        public double getPrecio()
        {
            return precio;
        }
        public int getCantidadUnidades()
        {
            return cantidadUnidades;
        }
    }
}
