# E-Commerce WebApp

## Description
This is an e-commerce website that sells products of different categories like books, movies, video games
## Technology Stack
- [ASP.NET](https://dotnet.microsoft.com/en-us/apps/aspnet)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [Bootstrap](https://getbootstrap.com/)
- [Tailwind CSS](https://tailwindcss.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)

## Development
### **Setup [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) and [Entity Framework .NET CLI Tool](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)**

#### **Install SQL Server**

SQL Server has free editions:
[Developer](https://go.microsoft.com/fwlink/p/?linkid=2215158&clcid=0x409&culture=en-us&country=us) and
[Express](https://go.microsoft.com/fwlink/p/?linkid=2216019&clcid=0x409&culture=en-us&country=us) (*I personally used Express edition*).

After installing SQL Server,

1) Get the **server/host name** (if SQL Server is hosted on the same machine as the code is, the host name can be put as ".")
1) Get the **instance name** (ex: *SQLEXPRESS*, *SQLEXPRESS01*, ...)
1) Construct your database connection string according to the below format:

    `"Data Source=[server_name]\\[instance_name];Initial Catalog=[database_name]; Integrated Security=True; TrustServerCertificate=True;"`

    Example:

    - My SQL Server is on my local machine, hence the server name is **"."**
    - The instance name I use is **"SQLEXPRESS01"**
    - The database name I use is **"ecommerce_webapp"** (it can be whatever)
    - Therefore, the database connection string is:

      `"Data Source=.\\SQLEXPRESS01;Initial Catalog=ecommerce_webapp; Integrated Security=True; TrustServerCertificate=True;"`
1) Add the connection string to the configuration in **`appsettings.json`**
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Data Source=.\\SQLEXPRESS01;Initial Catalog=ecommerce_webapp; Integrated Security=True; TrustServerCertificate=True;"
    }
    ```

#### **Install dotnet-ef**
```
dotnet tool install --global dotnet-ef
```
#### **Update dotnet-ef** (if it needs updating)
```
dotnet tool update --global dotnet-ef
```
#### **Apply database migrations**
Make sure to `cd` into the **Server** directory before running this command.
```
dotnet ef database update
```

### **Integrate Tailwind into ASP.NET**

The project uses styling from Tailwind CSS.

All configurations were already done in the project.

Referencing: https://github.com/angeldev96/tailwind-aspdotnet

Below is the Tailwind configuration used for the project (in **`tailwind.config.js`**):
```js
/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ['./**/*.{razor,html}'],
    prefix: "tw-", // to avoid conflicts with Bootstrap class names
    important: true, // make tailwind styling !important
    theme: {
        extend: {},
    },
    plugins: [],
}
```

### Possible errors when building project

#### When doing EF migrations: "The certificate chain was issued by an authority that is not trusted"

Referencing: https://learn.microsoft.com/en-us/troubleshoot/sql/database-engine/connect/certificate-chain-not-trusted?tabs=ole-db-driver-19

Solution: Add `TrustServerCertificate=True` to the connection string. This will force the client to trust the certificate without validation.