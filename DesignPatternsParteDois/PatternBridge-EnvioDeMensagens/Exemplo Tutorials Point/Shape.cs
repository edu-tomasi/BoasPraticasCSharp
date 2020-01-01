namespace PatternBridge_EnvioDeMensagens
{
    public abstract class Shape
    {
        protected IDrawAPI DrawAPI;

        public Shape(IDrawAPI drawAPI)
        {
            this.DrawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
