DATABASE MIGRATION :
dotnet ef migrations add init --project DI2P5G2_Backend.EntitiesContext --startup-project DI2P5G2_BackendAPI --output-dir Migrations

DATABASE UPDATE :
dotnet ef database update --project DI2P5G2_Backend.EntitiesContext --startup-project DI2P5G2_BackendAPI


Stored Procedure :  var sp = @"CREATE PROCEDURE [dbo].[StatUserOnShelter]
                        @IdShelter varchar(50),
                        @StartDatetime datetime2,
                        @EndDatetime datetime2
                    AS 
                    BEGIN 
                        select count(*) as CountUserByShelter from [dbo].[ShelterState]
                        where [ShelterState].[IdAbris] = @IdShelter 
                        and [ShelterState].[DateTimeRefresh] >= @StartDatetime
                        and [ShelterState].[DateTimeRefresh] <= @EndDatetime
                    END";

            migrationBuilder.Sql(sp);
