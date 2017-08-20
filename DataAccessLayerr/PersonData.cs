using Apttus.Assignment.PersonLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apttus.Assignment.PersonLibrary.GenderEnum;
using static Apttus.Assignment.PersonLibrary.RoleEnum;

namespace Apttus.Assignment.DataAccessLayerr
{
    public class PersonData : IPersonData
    {
        public Dictionary<string,IPerson> GetDetails()
        {
			Dictionary<string, IPerson> persons = new Dictionary<string, IPerson>();
			string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePerson.mdf;Integrated Security=True";
			SqlConnection connection = new SqlConnection(conn);
			connection.Open();
			string query = "select * from Person";
			SqlCommand cmd = new SqlCommand(query, connection);
			SqlDataReader read = cmd.ExecuteReader();
			while (read.Read())
			{
				string personName = read.GetString(0);
				int personAge = read.GetInt32(1);
				Gender personGender = (Gender)read.GetInt32(2);
			    string personRole = read.GetString(3);

				switch (personRole)
				{
					case "Children":
						persons.Add(personName,new Children { Name = personName, Age = personAge, Gender = personGender, Role = personRole});
						break;

					case "SeniorCitizen":
						 persons.Add(personName, new SeniorCitizen { Name = personName, Age = personAge, Gender = personGender, Role = personRole });
						break;

					case "Father":
						persons.Add(personName, new Father { Name = personName, Age = personAge, Gender = personGender, Role = personRole });
						break;

					case "Husband":
						persons.Add(personName, new Husband { Name = personName, Age = personAge, Gender = personGender, Role = personRole });
						break;

					case "Wife":
						persons.Add(personName, new Wife { Name = personName, Age = personAge, Gender = personGender, Role = personRole });
						break;

					case "Mother":
						persons.Add(personName, new Mother { Name = personName, Age = personAge, Gender = personGender, Role = personRole });
						break;
				}


			}

			connection.Close();
			return persons;

		}
    }
}
