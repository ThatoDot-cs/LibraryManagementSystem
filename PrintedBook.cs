// See https://aka.ms/new-console-template for more information
class PrintedBook : Book
{
    public double Weight { get; set; } //in kg

    public PrintedBook(string isbn, string title, string author, int copiesAvailable, double weight) : base(isbn, title, author, copiesAvailable)
    {
        Weight = weight;
    }

    public override string ToString()
    {
        return base.ToString() + $", Weight: {Weight}kg";
    }
}