namespace LSP.ByInheritance
{
    class Square : Rectangle
    {
        public override void SetWidth(int width)
        {
            base.SetWidth(width);
            base.SetHeight(width);
        }

        public override void SetHeight(int height)
        {
            base.SetHeight(height);
            base.SetWidth(height);
        }
    }
}
