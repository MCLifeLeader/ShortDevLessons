winget install --id Microsoft.WindowsTerminal
winget install --id Microsoft.PowerShell
winget install --id Microsoft.DotNet.SDK.8
winget install --id Microsoft.DotNet.AspNetCore.8
winget install --id Microsoft.VisualStudioCode

dotnet workload update
dotnet workload install aspire
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
