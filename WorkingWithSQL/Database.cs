using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Secured_Development_Final_Project
{
	public class Database
	{
		//סינגלטון של Connection
		private static readonly string connectionString = @"Data Source=DESKTOP-SRD4KHU\SQLEXPRESS;Initial Catalog=SecuredDevelopmentFinal;Integrated Security=True";
		private static readonly SqlConnection connection = new SqlConnection(connectionString);

		//מציג את הטבלה ב DataGrid
		public DataView ShowTable()
		{
			//יצרתי משתנה מסוג אדפטר שמקבל פקודה וחיבור ואני יכול לייצא בעזרתו מידע ל דאטא טייבל שאותו אני מחזיר כ דאטא וויו לתצוגה
			SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Users", connection));
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			return dt.DefaultView;
		}
		public void AddUser(string firstName, string lastName, string email, string password)
		{
			connection.Open();
			string adduser = "INSERT Users Values(@firstname, @lastname, @email, @password)";
			SqlCommand sql = new SqlCommand(adduser, connection);
			sql.Parameters.AddWithValue("@firstname", firstName);
			sql.Parameters.AddWithValue("@lastname", lastName);
			sql.Parameters.AddWithValue("@email", email);
			sql.Parameters.AddWithValue("@password", password);
			sql.ExecuteNonQuery();
			connection.Close();
		}
		public void RemoveAllUsers()
		{
			//הפלה והקמה של הטבלה מחדש על מנת למחוק את כל הרשומות ולאפס את הרשומה איי די
			connection.Open();
			string removeAllUsers = "DROP TABLE Users";
			SqlCommand sql = new SqlCommand(removeAllUsers, connection);
			sql.ExecuteNonQuery();
			string createTable = "CREATE TABLE Users(id int IDENTITY,firstName varchar(max),lastName varchar(max),email varchar(max),password varchar(max))";
			SqlCommand sql2 = new SqlCommand(createTable, connection);
			sql2.ExecuteNonQuery();
			connection.Close();
		}
		public void UpdateUser(string selectedUserId, string[] values)
		{
			//בדיקה של אילו שדות המשתמש השאיר ריקים ולא רצה לשנות
			bool[] ifEmpty = new bool[values.Length];
			ifEmpty[0] = values[0].Length == 0;
			ifEmpty[1] = values[1].Length == 0;
			ifEmpty[2] = values[2].Length == 0;
			ifEmpty[3] = values[3].Length == 0;
			//כדי למנוע נפילה של התוכנית אם כולם ריקים זאת אומרת המשתמש לא רוצה לשנות כלום אז נחזיר שום דבר
			if (ifEmpty[0] && ifEmpty[1] && ifEmpty[2] && ifEmpty[3])
			{
				MessageBox.Show("Nothing Has Changed");
				return;
			}

			//זאתי מחרוזת שבהתאם לתנאים בונה את עצמה בשביל ליצור
			//שאילתה שתעדכן רק את הפרטים הספציפיים שהמשתמש ביקש לשנות
			StringBuilder sql = new StringBuilder("UPDATE Users SET ");
			string[] appends = new string[]
			{
				"firstName = @firstname",
				"lastName = @lastName",
				"email = @email",
				"password = @password"
			};
			bool conditionActive = false;
			for (int i = 0; i < ifEmpty.Length; i++)
			{
				//עוברים על כל האינפוטים ומחפשים את אלו שהמשתמש שינה זאת אומרת לא ריקים
				if (!ifEmpty[i])
				{
					if (conditionActive)//בריצה הראשונה הוא יהיה שלילי כדי שלא נוסיף לפקודה פסיק בהתחלה ואחר כך נוסיף עם פסיקים. זה כדי לשמור על הסינטקס של השפה 
					{
						sql.Append(", " + appends[i]);
					}
					else
					{
						sql.Append(appends[i]);
						conditionActive = true;
					}
				}
			}
			//הוספה של הדיוק הספציפי של איזה יוזר לשנות בפקודה לפי ה איי די
			sql.Append($" WHERE id = {int.Parse(selectedUserId)}");
			connection.Open();
			SqlCommand sqlCommand = new SqlCommand(sql.ToString(), connection);
			sqlCommand.Parameters.AddWithValue("@firstname", values[0]);
			sqlCommand.Parameters.AddWithValue("@lastname", values[1]);
			sqlCommand.Parameters.AddWithValue("@email", values[2]);
			sqlCommand.Parameters.AddWithValue("@password", values[3]);
			sqlCommand.ExecuteNonQuery();
			connection.Close();
		}
		public DataView ShowLongestName()
		{
			//שליחת המידע מהפרוצדורה כ דאטא וויו לתצוגה
			connection.Open();
			string procedure = "P_GetLongestFirstName";
			SqlDataAdapter adapter = new SqlDataAdapter(procedure, connection);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			connection.Close();
			return dt.DefaultView;
		}
		public void DeleteUser(int id)
		{
			//מחיקת משתמש על ידי קבלת איי די מהפונקציה והפעלת פרוצדורה למחיקת משתמש על ידי איי די
			connection.Open();
			string procedure = "P_DeleteUser @id";
			SqlCommand sqlCommand = new SqlCommand(procedure, connection);
			sqlCommand.Parameters.AddWithValue("@id", id);
			sqlCommand.ExecuteNonQuery();
			connection.Close();
		}
	}
}
