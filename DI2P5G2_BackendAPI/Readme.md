DATABASE MIGRATION :
dotnet ef migrations add init --project DI2P5G2_Backend.EntitiesContext --startup-project DI2P5G2_BackendAPI --output-dir Migrations

DATABASE UPDATE :
dotnet ef database update --project DI2P5G2_Backend.EntitiesContext --startup-project DI2P5G2_BackendAPI