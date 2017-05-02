using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    public class Game
    {
        public enum GameStatesEnum { WaitFirstPlayer, WaitSecondPlayer, FirstPlayer, SecondPlayer, EndOfGame };
        public enum FieldStatesEnum { Free, Cross, Zero };

        [DataMember]
        public GameStatesEnum state;
        [DataMember]
        public string firstPlayer;
        [DataMember]
        public string secondPlayer;
        [DataMember]
        public string currentPlayer;
        [DataMember]
        public FieldStatesEnum[] field;

        public Game()
        {
            field = new FieldStatesEnum[9];
            state = GameStatesEnum.WaitFirstPlayer;
        }
    }
}