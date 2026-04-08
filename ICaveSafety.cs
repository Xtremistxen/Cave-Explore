namespace CaveExplorerTracker
{
    // This interface defines a safety behavior for caves.
    // Any class that implements this must provide safety advice.
    public interface ICaveSafety
    {
        // Returns safety instructions for the specific type of cave
        string GetSafetyAdvice();
    }
}