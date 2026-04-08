namespace CaveExplorerTracker
{
    // This class represents a Tourist Cave.
    // It inherits from Cave and adds features for caves open to visitors.
    // It also implements ICaveSafety for safety-related behavior.
    public class TouristCave : Cave, ICaveSafety
    {
        // Private fields for tourist cave details
        private bool guidedTours;
        private decimal ticketPrice;
        private bool giftShop;

        // Property: Whether guided tours are available
        public bool GuidedTours
        {
            get { return guidedTours; }
            set { guidedTours = value; }
        }

        // Property: Ticket price (cannot be negative)
        public decimal TicketPrice
        {
            get { return ticketPrice; }
            set { ticketPrice = value >= 0 ? value : 0; }
        }

        // Property: Whether there is a gift shop
        public bool GiftShop
        {
            get { return giftShop; }
            set { giftShop = value; }
        }

        // Constructor: sets both base Cave data and TouristCave-specific data
        public TouristCave(string name, string location, int depth, int length, bool explored, string danger,
                           bool tours, decimal price, bool shop)
            : base(name, location, depth, length, explored, danger)
        {
            GuidedTours = tours;
            TicketPrice = price;
            GiftShop = shop;
        }

        // Overrides the base display method to include tourist cave details
        public override string display()
        {
            return base.display() + $" | Tours: {GuidedTours} | Price: {TicketPrice} | Shop: {GiftShop}";
        }

        // Overloaded display method with different levels of detail
        public override string display(int num)
        {
            if (num == 1)
                return CaveName;
            else if (num == 2)
                return $"{CaveName} | Price: {TicketPrice}";
            else
                return display();
        }

        // From ICaveSafety:
        // Gives safety advice for tourists
        public string GetSafetyAdvice()
        {
            return "Stay on path and follow guide.";
        }

        // Extra method: shows ticket information
        public string ShowTourInfo()
        {
            return $"Ticket costs {TicketPrice}";
        }
    }
}