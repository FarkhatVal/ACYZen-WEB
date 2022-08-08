using System.Linq;
using ACYZenWEBAPP.Models;

namespace ACYZen;

public class SampleData
{public static void Initialize(ActionYaZenContext context)
    {
        if (!context.ActionYaZens.Any())
        {
            context.ActionYaZens.AddRange(
                new ActionYaZen
                {
                    Name = "Registration",
                    Description = "Registration 3 New Account",
                    Price = 60
                },
                new ActionYaZen
                {
                    Name = "Refresh",
                    Description = "Refresh 1 YaZen Account (set new password)",
                    Price = 10
                },
                new ActionYaZen
                {
                    Name = "AutoPosting",
                    Description = "AutoPosting Post from Akket.ru",
                    Price = 200
                }
            );
            context.SaveChanges();
        }
    }
}