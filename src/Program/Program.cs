﻿// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        //Declaracion del Producto
        Product NewProduct = new Product();
        NewProduct.nombre = "A Test Name";
        NewProduct.precio = 9999;
        
        //Declaracion de los componentes de la review
        string reviewcomment = "A very fine Test comment";
        int reviewscore = 5;
        
        //Llamado al metodo de agregar la review
        NewProduct.addreview(reviewscore, reviewcomment);

        //Confirmacion llamando al metodo de mostrar reviews
        NewProduct.showreviews();
    }
}
