using API_GameList_WhitASPNETCore.Model;

namespace API_GameList_WhitASPNETCore.Services
{
    public interface IGameServices
    {
        Game Create (Game game);
        Game FindById (long id);
   
        List<Game> FindAll ();
        Game Update (Game game);
        void Delete (long id);
    }
}
