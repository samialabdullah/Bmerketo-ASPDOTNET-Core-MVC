

using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Models.Entities;
using WebApp.ViewModels.ContactViewModel;

namespace WebApp.Services;

public class ContactFormService
{
    private readonly ContactContext _contactContext;

    public ContactFormService(ContactContext contactContext)
    {
        _contactContext = contactContext;
    }

    public async Task<bool> RegisterAsync(ContactFormViewModel viewModel)
    {
        try
        {
            //create user

            ContactFormEntity contactFormEntity = viewModel;
            _contactContext.Contacts.Add(contactFormEntity);
            await _contactContext.SaveChangesAsync();

            return true;
        }
        catch
        {
            return false;
        }
    }
}
