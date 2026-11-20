using System.Security.Principal;

using var identity = WindowsIdentity.GetCurrent();

var user = new WindowsPrincipal(identity);

Console.WriteLine(user.Identity.Name);
Console.WriteLine(user.Identity.IsAuthenticated);
Console.WriteLine(user.IsInRole(WindowsBuiltInRole.Administrator));
Console.WriteLine(user.IsInRole(WindowsBuiltInRole.User));
Console.WriteLine(user.IsInRole("PC-KLASS\\Student"));

var groups = identity.Groups
    .Select(x => x.Translate(typeof(NTAccount)).Value);

foreach (var group in groups)
{
    Console.WriteLine(group);
}