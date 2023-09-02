namespace BirdWranglers
{
    public class Bird
    {
        public Bird(int wingLength,string featherColor,string name) {
            WingSpan = wingLength;
            FeatherColor = featherColor;
            Name = name; 
        }
        public bool Fed { get; private set; }
        public int WingSpan { get;}
        public string FeatherColor { get;  }
        public string Name { get; }
        public string ImagePath { get; set; }
        public void Feed()
        {
            Fed = true;
        }
    }
}
