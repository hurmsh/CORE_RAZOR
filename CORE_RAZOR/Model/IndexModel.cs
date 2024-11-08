using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

public class IndexModel : PageModel
{
    private readonly UserService _userService;

    // Public property to hold the list of users
    public List<User> Users { get; set; }

    public IndexModel(UserService userService)
    {
        _userService = userService;
    }

    // OnGetAsync method to populate Users
    public async Task OnGetAsync()
    {
        Users = await _userService.GetUsersAsync();
    }
}