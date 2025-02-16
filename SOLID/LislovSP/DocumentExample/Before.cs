using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LislovSP.DocumentExample;

public class Document
{
    public virtual void Open()
    {
        // Open the document
    }

    public virtual void Save()
    {
        // Save the document
    }

    public virtual void Delete()
    {
        // Delete the document
    }
}

// ReadOnlyDocument violates LSP because it throws exceptions for Save and Delete,
// breaking the contract of the base class Document.


public class ReadOnlyDocument : Document
{
    public override void Save()
    {
        throw new NotSupportedException("Cannot save a read-only document.");
    }

    public override void Delete()
    {
        throw new NotSupportedException("Cannot delete a read-only document.");
    }
}