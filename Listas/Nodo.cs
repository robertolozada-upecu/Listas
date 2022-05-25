namespace Listas
{
    public class Nodo
    {
        private Auto auto;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo(Auto auto)
        {
            this.auto = auto;
        }

        public Nodo(Auto auto, Nodo siguiente, Nodo anterior)
        {
            this.auto = auto;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }

        public Auto getAuto()
        {
            return auto;
        }

        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }

        public void setAnterior(Nodo anterior)
        {
            this.anterior = anterior;
        }

        public Nodo getSiguiente()
        {
            return siguiente;
        }

        public Nodo getAnterior()
        {
            return anterior;
        }
    }
}
