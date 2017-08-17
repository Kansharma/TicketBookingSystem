using Apttus.Assignment.PersonLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apttus.Assignment.PersonLibrary.GenderEnum;

namespace Apttus.Assignment.DataAccessLayerr
{
    public class PersonData : IPersonData
    {
        public Dictionary<string,IPerson> GetDetails()
        {
			Dictionary<string, IPerson> persons = new Dictionary<string, IPerson>();
			//string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kansharma\Documents\Visual Studio 2015\Projects\Temp\PersonProject\PersonProject\PersonDb.mdf;Integrated Security=True";
			//SqlConnection connection = new SqlConnection(conn);
			//connection.Open();
			//string query = "select * from Person";
			//SqlCommand cmd = new SqlCommand(query, connection);
			//SqlDataReader read = cmd.ExecuteReader();
			//string personName;
			//int personAge;
			//Gender personGender;
			//personName = read.GetString(0);
			//personAge = read.GetInt32(1);
			//personGender = (Gender)read.GetInt32(2);
			//while (read.Read())
			//{
			//	persons.Add("Name", new Children { Name = personName, Age = personAge, Gender = personGender });
			//	persons.Add("Name", new SeniorCitizen { Name = personName, Age = personAge, Gender = personGender });
			//	persons.Add("Name", new Father { Name = personName, Age = personAge, Gender = personGender });
			//	persons.Add("Name", new Husband { Name = personName, Age = personAge, Gender = personGender });
			//	persons.Add("Name", new Wife { Name = personName, Age = personAge, Gender = personGender });
			//	persons.Add("Name", new Mother { Name = personName, Age = personAge, Gender = personGender });
			//}

			Children srinath = new Children()
			{
				Name = "Srinath",
				Age = 10
			};

			Father santosh = new Father()
			{
				Name = "Santosh",
				Age = 30
			};

			Husband suraj = new Husband()
			{
				Name = "Suraj",
				Age = 27
			};

			Mother jahnavi = new Mother()
			{
				Name = "Jahnavi",
				Age = 29
			};

			SeniorCitizen lakshman = new SeniorCitizen()
			{
				Name = "Lakshman",
				Age = 70
			};

			Wife susmita = new Wife()
			{
				Name = "Susmita",
				Age = 25
			};

			persons.Add(srinath.Name, srinath);
			persons.Add(santosh.Name, santosh);
			persons.Add(suraj.Name, suraj);
			persons.Add(jahnavi.Name, jahnavi);
			persons.Add(lakshman.Name, lakshman);
			persons.Add(susmita.Name, susmita);

			return persons;

		}
    }
}
