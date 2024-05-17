// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

class EBoook : Book
{
    public double FileSize { get; set; } // in MB

    public EBoook(string isbn, string title, string author, int copiesAvailable, double fileSize) : base(isbn, title, author, copiesAvailable)
    {
        FileSize = fileSize;
    }

    public override string ToString()
    {
        return base.ToString() + $", File Size: {FileSize}MB";
    }

}
