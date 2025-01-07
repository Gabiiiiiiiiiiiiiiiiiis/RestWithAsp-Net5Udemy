namespace API_GameList_WhitASPNETCore.Model
{
    public class Game
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Plataform { get; set;}
        public string Gender {  get; set; }
        public long DataLaunch {  get; set; }

    }
}
