using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CharacterLibrary.DataAccess
{
    class SQLConnector : IDataConnection
    {
        public CharacterModel CreateCharacter(CharacterModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("NoUser_CharacterMakerDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Race", model.Race);
                p.Add("@Class", model.Class);
                p.Add("@HP", model.HP);
                p.Add("@STRENGTH", model.STR);
                p.Add("@INTELLIGENCE", model.INT);
                p.Add("@DEXTERITY", model.DEX);
                p.Add("@CONSTITUTION", model.CON);
                p.Add("@WISDOM", model.WIS);
                p.Add("@CHARISMA", model.CHA);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCharacters_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }
    }
}
