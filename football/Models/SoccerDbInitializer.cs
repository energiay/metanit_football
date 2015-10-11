using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace football.Models
{

    /// <summary>
    /// Этот класс будет выполнять начальную инициализацию Базы Данных
    /// </summary>
    public class SoccerDbInitializer : DropCreateDatabaseAlways<SoccerContext> //При каждом запуске приложения наша БД будет создоваться заново
    {
        
        protected override void Seed (SoccerContext db)
        {
            var team = new Team { Name = "Высокий", Coach = "Недолужко" };
            db.Team.Add(team);
            db.Players.Add( new Player { Name = "Иван", Age=29, Position="Защитник", TeamId = team.Id } );
        }
    }
}