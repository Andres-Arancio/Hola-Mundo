public class Product
{
    //Atributos del producto
    string nombre = new String();
    int precio = new Int();
    List<Review> prodreview = new List<Review>();
    
    //Metodo que muestra cada review de un dado producto
    public void showreviews()
    {
            foreach(List<Review> r in this.prodreview)
            {
                Console.WriteLine($"Puntuacion: {this.prodreview.calificacion}");
                Console.WriteLine($"Comentario: {this.prodreview.comentario}");
            }
    }

    //Metodo que agrega una review a un dado producto, con una dada calificacion y comentario
    public void addreview(int addcalificacion, string addcomentario)
    {
        Review newReview = new Review();
        Review.calificacion = addcalificacion;
        Review.comentario = addcomentario;
        List<Review>.add(newReview);
    }
}
