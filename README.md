# Demo IaaS with ASP.NET CORE MVC and Azure VM
## Prerequisites
1. Registered Azure account with usable subscription.
## Step 1: Create azure VM
- Go to `portal.azure.com`.
- On home page, click `Create a resouce`, on search box, type `Virtual Machine`, OK. Choose `Virtual Machine`.
- Click `Create`.
- Fill in `Virtual machine name`, `Username`, `Password`, `Confirm password`.
- Check (✓) on `Licensing`
- Click `Review + create`.
- Click 'Create`.
- Wait until deployment is successful.
## Step 2: Remote desktop to virtual machine
- Open `Remote Desktop Connection`: press Window + R, type `mstsc`, enter.
- Type public IP address from virtual machine to `Computer` box on Remote Desktop Connection (RDC).
- Input `Username` and `Password` of virtual machine to RDC. 
- Click `Connect`.
## Step 3: Setup environment on virtual machine
### Enable IIS server
On virtual machine, open `Window PowerShell` with `Administrator`, enter command:
```bash
Install-WindowsFeature -name Web-Server -IncludeManagementTools
```
### [Install SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads?rtc=1)
### [Install .NET Core SDK](https://dotnet.microsoft.com/download)
### Install Web Hosting: AspNetCoreModuleV2 at [here](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-aspnetcore-2.2.2-windows-hosting-bundle-installer)
# To be continue...
