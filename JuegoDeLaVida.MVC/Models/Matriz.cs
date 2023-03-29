namespace JuegoDeLaVida.MVC.Models
{
    public class Matriz
    {
        
        public int Iteraciones { get; set; }

        public string[,] Matriz1 { get; set; }
       
        public int Filas { get; set; }
       
        public int Columnas { get; set; }
        public Matriz()
        {
            
            Filas = 5;
            Columnas = 5;
            Matriz1 = new string[Filas, Columnas];
        }
      
    }
}
