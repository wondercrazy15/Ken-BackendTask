using APIProject.Interface;
using APIProject.Model;
using System.ComponentModel;

namespace APIProject.Service;

public class ValueService : IValueService
{
    readonly DataContext _context;

    public ValueService(DataContext context)
    {
        this._context= context;
    }
    public bool addValues(StoreValues model)
    {
        try
        {
            _context.StoreValues.Add(model);
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
