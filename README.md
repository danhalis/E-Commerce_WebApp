# E-Commerce_WebApp

## Install Entity Framework
`dotnet tool install --global dotnet-ef`
## Integrate Tailwind into ASP.NET
Referencing: https://github.com/angeldev96/tailwind-aspdotnet

## Possible errors when building project

### When doing EF migrations: "The certificate chain was issued by an authority that is not trusted"

Referencing: https://learn.microsoft.com/en-us/troubleshoot/sql/database-engine/connect/certificate-chain-not-trusted?tabs=ole-db-driver-19

Solution: Add `TrustServerCertificate=True` to the connection string. This will force the client to trust the certificate without validation.