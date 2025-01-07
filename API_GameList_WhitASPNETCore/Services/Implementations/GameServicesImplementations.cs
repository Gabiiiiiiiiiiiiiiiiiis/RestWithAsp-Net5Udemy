using API_GameList_WhitASPNETCore.Model;
using System.Reflection;

namespace API_GameList_WhitASPNETCore.Services.Implementations
{
    public class GameServicesImplementations : IGameServices
    {
        volatile int count;

        public Game Create(Game game)
        {
            return game;
        }
        public List<Game> FindAll()
        {
            List<Game> games = new List<Game>();
            for (int i = 0; i < 8; i++)
            {
                Game game = MockGame(i);
                games.Add(game);
               
            }
            return games;
        }
              

        public Game FindById(long id)
        {
            return new Game
            {
                Id = IncrementAndGet(),
                Title = "Brawl Stars",
                Plataform = "Celular",
                Gender = "Multiplayer",
                DataLaunch = 15-07-2017
            };
        }

        public Game Update(Game game)
        {
            return game;
        }
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
        private Game MockGame(int i)
        {
            return new Game
            {
                Id = IncrementAndGet(),
                Title = "GameTitle" + 1,
                Plataform = "SomePlataform" + 1,
                Gender = "SomeGender" + 1,
                DataLaunch = IncrementAndGet()
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
