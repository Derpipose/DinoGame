namespace DinoGame
{
    public interface Movers
    {
        //public Dictionary<> location {get;}
        public char[] Graphic { get; }
        public void MovesForward();
    }
}