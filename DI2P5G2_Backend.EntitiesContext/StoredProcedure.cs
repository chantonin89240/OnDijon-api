using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.EntitiesContext
{
    public class StoredProcedure
    {
        public string GetProcedureStatUserOnShelter()
        {
            var sp = @"CREATE PROCEDURE [dbo].[StatUserOnShelter]
                        @IdShelter varchar(50),
                        @StartDatetime datetime,
                        @EndDatetime datetime
                    AS 
                    BEGIN 
                        select count(*) as CountUserByShelter from [dbo].[ShelterState]
                        where [ShelterState].[IdAbris] = @IdShelter 
                        and [ShelterState].[DateTimeRefresh] >= @StartDatetime
                        and [ShelterState].[DateTimeRefresh] <= @EndDatetime
                    END";
            return sp;
        }
    }
}
