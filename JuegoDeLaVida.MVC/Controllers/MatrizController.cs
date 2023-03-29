using Microsoft.AspNetCore.Mvc;
using JuegoDeLaVida.MVC.Models;
using JuegoDeLaVida.LogicaDeNegocio;

namespace JuegoDeLaVida.MVC.Controllers
{
    public class MatrizController : Controller
    {
        Tablero tablero = new Tablero(5, 5);
        Gestor gestor= new Gestor();
        public void convertirMatriz(string[,] matriz, Tablero tablero)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j=0;j < 5; j++)
                {
                    if (tablero.TableroCelulas[i, j].TieneVida)
                    {
                        matriz[i, j]= "*";
                    }
                    else
                    {
                        matriz[i, j]= "-";
                    }
                }
            }
        }
        public void convertirTablero(Matriz matriz, Tablero tablero)
        {
            string asterisco = "*";
            for (int i = 0; i < matriz.Filas; i++)
            {
                for (int j = 0; j < matriz.Columnas; j++)
                {
                    if (matriz.Matriz1[i,j]==asterisco)
                    {
                        tablero.TableroCelulas[i, j].TieneVida = true;
                    }
                    else
                    {
                        tablero.TableroCelulas[i, j].TieneVida = false;
                    }
                }
            }
        }
        public void RellenarTablero(Tablero tablero)
        {
            tablero.TableroCelulas[0, 1].TieneVida = true;
            tablero.TableroCelulas[0, 3].TieneVida = true;
            tablero.TableroCelulas[0, 4].TieneVida = true;

            tablero.TableroCelulas[1, 1].TieneVida = true;
            tablero.TableroCelulas[1, 3].TieneVida = true;
            tablero.TableroCelulas[1, 4].TieneVida = true;

            tablero.TableroCelulas[2, 1].TieneVida = true;
            tablero.TableroCelulas[2, 3].TieneVida = true;
            tablero.TableroCelulas[2, 4].TieneVida = true;

            tablero.TableroCelulas[3, 1].TieneVida = true;
            tablero.TableroCelulas[3, 3].TieneVida = true;
            tablero.TableroCelulas[3, 4].TieneVida = true;

            tablero.TableroCelulas[4, 1].TieneVida = true;
            tablero.TableroCelulas[4, 3].TieneVida = true;
            tablero.TableroCelulas[4, 4].TieneVida = true;
            
        }
        public IActionResult Matriz(Matriz matrizz)
        { 
            RellenarTablero(tablero);
            convertirMatriz(matrizz.Matriz1, tablero);
            return View(matrizz);
        }
        [HttpPost]
        public IActionResult SiguienteGeneracion(Matriz matriz)
        {
            RellenarTablero(tablero);
            for (int i = 0; i < matriz.Iteraciones; i++)
            {
                tablero = gestor.GetTableroActualizado(tablero);
            }
            convertirMatriz(matriz.Matriz1, tablero);
            return View( "Matriz",matriz);
        }
    }
}
