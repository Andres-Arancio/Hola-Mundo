public class Product
{
    //Atributos del producto
    public string nombre{get; set;}
    public int precio{get; set;}
    List<Review> prodreview = new List<Review>();
    
    //Metodo que muestra cada review de un dado producto
    public void showreviews()
    {
            foreach(Review r in this.prodreview)
            {
                Console.WriteLine($"Puntuacion: {r.calificacion}");
                Console.WriteLine($"Comentario: {r.comentario}");
            }
    }

    //Metodo que agrega una review a un dado producto, con una dada calificacion y comentario
    public void addreview(int addcalificacion, string addcomentario)
    {
        Review newReview = new Review();
        newReview.calificacion = addcalificacion;
        newReview.comentario = addcomentario;
        this.prodreview.Add(newReview);
    }
}
