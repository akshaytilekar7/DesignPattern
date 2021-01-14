namespace LSP.ByInheritance
{
    class Rectangle
    {
        protected int Width, Height;

        public int GetWidth() => Width;

        public virtual void SetWidth(int width) => this.Width = width;

        public int GetHeight() => Height;

        public virtual void SetHeight(int height) => this.Height = height;

        public int GetArea() => Width * Height;
    }
}
