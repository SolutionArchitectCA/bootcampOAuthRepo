using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bootcampOAuthRepo.Pages;

// Restrict access to the page to users in the "Admin" role.
[Authorize(Roles = "Admin")]
public class DashboardModel : PageModel
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    // Property to hold the data that will be passed to the view.
    public DashboardDataViewModel DashboardData { get; private set; }

    public DashboardModel(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

/*     public async Task OnGetAsync()
        {
            // Example: Add "Admin" role to an existing user
            var user = await _userManager.FindByEmailAsync("charles@graysoft.co.za");
            if (user != null)
            {
                if (!await _roleManager.RoleExistsAsync("Admin"))
                {
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));
                }

                if (!await _userManager.IsInRoleAsync(user, "Admin"))
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
*/
    // OnGet method to handle GET requests to the page.
    public void OnGet()
    {
        // Fetch the dashboard data.
        DashboardData = GetDashboardData();
    }

    // This method simulates fetching data for the dashboard.
    private DashboardDataViewModel GetDashboardData()
    {
        // Replace this with your actual data-fetching logic.
        return new DashboardDataViewModel
        {
            UserCount = 100,
            OrdersToday = 15,
            Revenue = 1500.50
        };
    }
}

// ViewModel to represent the data for the dashboard.
public class DashboardDataViewModel
{
    public int UserCount { get; set; }
    public int OrdersToday { get; set; }
    public double Revenue { get; set; }
}

