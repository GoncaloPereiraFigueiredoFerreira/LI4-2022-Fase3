namespace SpotGuru.Models
{
    public class ReviewView
    {

        public string Id { get; set; }
        public string MonumentoID { get; set; } 
        
        public string Comentario { get; set; }

        public string UserID { get; set; }



        public ReviewView()
        {

        }

        public ReviewView(string id, string monumentoID, string comentario, string userID)
        {
            Id = id;
            MonumentoID = monumentoID;
            Comentario = comentario;
            UserID = userID;
        }
    }
}
