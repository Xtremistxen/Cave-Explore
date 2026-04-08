namespace CaveExplorerTracker
{
    public class Cave
    {
        // Backing fields (encapsulation)
        private string caveName;
        private string location;
        private int depthInFeet;

        public int LengthInFeet { get; set; }
        public bool IsExplored { get; set; }
        public string DangerLevel { get; set; }

        // Encapsulated Property 1
        public string CaveName
        {
            get { return caveName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    caveName = value;
                else
                    caveName = "Unknown Cave";
            }
        }

        // Encapsulated Property 2
        public string Location
        {
            get { return location; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    location = value;
                else
                    location = "Unknown Location";
            }
        }

        // Encapsulated Property 3
        public int DepthInFeet
        {
            get { return depthInFeet; }
            set
            {
                if (value >= 0)
                    depthInFeet = value;
                else
                    depthInFeet = 0;
            }
        }

        public Cave() { }

        public Cave(string name, string location, int depth, int length, bool explored, string danger)
        {
            CaveName = name;
            Location = location;
            DepthInFeet = depth;
            LengthInFeet = length;
            IsExplored = explored;
            DangerLevel = danger;
        }

        // Display all
        public virtual string display()
        {
            return $"{CaveName} | {Location} | Depth: {DepthInFeet} | Length: {LengthInFeet} | Explored: {IsExplored} | Danger: {DangerLevel}";
        }

        // Display partial
        public virtual string display(int num)
        {
            if (num == 1)
                return $"Name: {CaveName}";
            else if (num == 2)
                return $"Name: {CaveName}, Location: {Location}";
            else
                return display();
        }
    }
}