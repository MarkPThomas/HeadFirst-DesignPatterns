using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaver.Model
{
    public class MasterGameObject
    {
        private GameMemento _gameState;

        private int _levelNum;
        public int Level { get; set; }
        public string LevelName { get; set; }

        public MasterGameObject()
        {
            LevelName = "Current Level";
            Level = 9;
            _levelNum = 8;
        }

        public void ChangeCurrentState()
        {
            Console.WriteLine("\nChanging state ...\n");
            _levelNum++;
            Level++;
            LevelName = "The Final Battle!";
        }

        public object GetCurrentState()
        {
            // Gather state
            Console.WriteLine("\nSaving state ...\n");
            _gameState = new GameMemento();
            _gameState.Level = Level;
            _gameState.LevelName = LevelName;
            _gameState._levelNum = _levelNum;

            return _gameState;
        }

        public void RestoreState(object savedState)
        {
            if (savedState.GetType() == typeof(GameMemento))
            {
                GameMemento oldState = (GameMemento)savedState;

                // Restore state
                Console.WriteLine("\nRestoring state ...\n");
                Level = _gameState.Level;
                LevelName = _gameState.LevelName;
                _levelNum = _gameState._levelNum;
            }
        }

        private class GameMemento
        {
            public int _levelNum;
            public int Level { get; set; }
            public string LevelName { get; set; }
        }

        public override string ToString()
        {
            return string.Format("Level Name: {0} \nLevel Number: {1} \nPrivate Level Number: {2}", LevelName, Level, _levelNum);
        }
    }
}
