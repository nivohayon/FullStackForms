using Secured_Development_Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithSQL
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			ShowTable();
		}
		public void ShowTable()
		{
			Database database = new Database();
			//הצגה של המשתמשים הקיימים ב DataGrid
			UsersList.DataSource = database.ShowTable();
		}
		public void ShowTable(object sender, EventArgs e)
		{
			Database database = new Database();
			//הצגה של המשתמשים הקיימים ב DataGrid
			UsersList.DataSource = database.ShowTable();
		}

		public void Add_User(object sender, EventArgs e)
		{
			Database database = new Database();
			database.AddUser(FirstName.Text, LastName.Text, Email.Text, Password.Text);
			ShowTable();
			Clear_Add_Fields(); //ניקוי השדות טקסט
		}

		public void Remove_All_Users(object sender, EventArgs e)
		{
			Database database = new Database();
			database.RemoveAllUsers();
			ShowTable();
		}

		public void Update_User(object sender, EventArgs e)
		{
			/*
			 * המתודה עובדת בשיטה הבאה
			 * נשלח אל המתודה שני מערכים
			 * מערך ראשון יכיל בתוכו את השם פרטי שם משפחה אימייל וסיסמא
			 * זה יהיה לצורך זיהוי המשתמש אותו נרצה למחוק ופרטים אלו ייכנסו ל WHERE
			 * מערך שני מכיל בתוכו את הנתונים החדשים שנרצה לעדכן.
			 * הנתונים האלו יכנסו ל SET
			 */
			Database database = new Database();
			string selectedUserId = GetSelectedUserId();
			//אם האיי די הוא ריק אז נמנע נפילה של התוכנית ולא נפעיל את הפונקציה
			if (selectedUserId == "")
				return;
			string[] values = new string[4];//מערך של כל הערכים החדשים שהמשתמש הכניס באינפוטים
			values[0] = FirstName_Update.Text;
			values[1] = LastName_Update.Text;
			values[2] = Email_Update.Text;
			values[3] = Password_Update.Text;
			database.UpdateUser(selectedUserId, values);
			ShowTable();
			Clear_Update_Fields();
		}
		public void Clear_Add_Fields() // מנקה את השדות של הוספת משתמש
		{
			FirstName.Text = "";
			LastName.Text = "";
			Email.Text = "";
			Password.Text = "";
		}
		public void Clear_Update_Fields() // מנקה את השדות של עדכון משתמש
		{
			FirstName_Update.Text = "";
			LastName_Update.Text = "";
			Email_Update.Text = "";
			Password_Update.Text = "";
		}
		public string GetSelectedUserId()
		{
			try
			{
				if(UsersList.SelectedRows[0].Cells["id"].Value.ToString() != null)
					return UsersList.SelectedRows[0].Cells["id"].Value.ToString();
				else
				{
					MessageBox.Show("Please Select A User");
					return "";
				}
			}
			catch(Exception)
			{
				MessageBox.Show("Please Select A User");
				return "";
			}
		}
		public void ShowLongestName(object sender, EventArgs e)
		{
			Database database = new Database();
			UsersList.DataSource = database.ShowLongestName(); // הצגת התוצאה של הפרוצדורה ב דאטא גריד
		}
		public void DeleteUser(object sender, EventArgs e)
		{
			Database database = new Database();
			try
			{
				DataGridViewSelectedRowCollection row = UsersList.SelectedRows;//לקיחת מידע מהמשתמש שסימנו בטבלה
				foreach (DataGridViewRow item in row)
				{
					if(item.Cells[0].Value == null)
					{
						MessageBox.Show("Please Select A Row");
						return;
					}

				}
				int id = int.Parse(row[0].Cells["id"].Value.ToString());
				database.DeleteUser(id);
			}
			catch (Exception)
			{
				MessageBox.Show("Please Select A Row");
			}
			ShowTable();
		}
	}
}
