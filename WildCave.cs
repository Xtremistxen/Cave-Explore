namespace CaveExplorerTracker
{
    // This class represents a Wild Cave.
    // It inherits from Cave and adds extra features specific to wild caves.
    // It also implements ICaveSafety for safety-related methods.
    public class WildCave : Cave, ICaveSafety
    {
        // Private fields for additional wild cave details
        private string wildlifeType;
        private string difficulty;
        private bool hasRiver;

        // Property: Type of wildlife in the cave
        // Defaults to "Unknown" if left empty
        public string WildlifeType
        {
            get { return wildlifeType; }
            set { wildlifeType = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        // Property: Difficulty level of exploring the cave
        // Defaults to "Unknown" if left empty
        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        // Property: Whether the cave has a river
        public bool HasRiver
        {
            get { return hasRiver; }
            set { hasRiver = value; }
        }

        // Constructor: sets both base Cave data and WildCave-specific data
        public WildCave(string name, string location, int depth, int length, bool explored, string danger,
                        string wildlife, string difficulty, bool hasRiver)
            : base(name, location, depth, length, explored, danger)
        {
            WildlifeType = wildlife;
            Difficulty = difficulty;
            HasRiver = hasRiver;
        }

        // Overrides the base display method to include wild cave details
        public override string display()
        {
            return base.display() + $" | Wildlife: {WildlifeType} | Difficulty: {Difficulty} | River: {HasRiver}";
        }

        // Overloaded display method with different levels of detail
        public override string display(int num)
        {
            if (num == 1)
                return CaveName;
            else if (num == 2)
                return $"{CaveName} | Wildlife: {WildlifeType}";
            else
                return display();
        }

        // From ICaveSafety:
        // Gives safety advice for exploring a wild cave
        public string GetSafetyAdvice()
        {
            return "Bring gear, rope, and light sources.";
        }

        // From ICaveSafety:
        // Describes the conditions of the cave
        public string CheckConditions()
        {
            return "Wild cave: uneven terrain and hazards.";
        }
    }
}