using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LislovSP.DocumentExample2;

public abstract class Document
{
    public virtual void Open()
    {
        // Open the document
    }

    public abstract void Save();
    public abstract void Delete();
}

public class EditableDocument : Document
{
    public override void Save()
    {
        // Save the document
    }

    public override void Delete()
    {
        // Delete the document
    }
}

// To adhere to LSP, we need to ensure that ReadOnlyDocument
// can be used wherever Document is used without breaking the contract.
public class ReadOnlyDocument : Document
{
    public override void Save()
    {
        // Do nothing or log that saving is not supported
    }

    public override void Delete()
    {
        // Do nothing or log that deletion is not supported
    }
}