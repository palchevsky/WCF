namespace Library
{
    public class Game
    {
        //public bool IsWin { get; set; }
        private MarkType[] _Results;

        private bool _Player1Turn;
        private bool _GameEnded;

        public void NewGame()
        {
            _Results=new MarkType[9];
            for (int i = 0; i < _Results.Length; i++)
            {
                _Results[i]=MarkType.Free;
                _Player1Turn = true;
            }
        }
    }
}