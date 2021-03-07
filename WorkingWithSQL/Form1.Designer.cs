
namespace WorkingWithSQL
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.UsersList = new System.Windows.Forms.DataGridView();
			this.btnDeleteAll = new System.Windows.Forms.Button();
			this.Email = new System.Windows.Forms.TextBox();
			this.LastName = new System.Windows.Forms.TextBox();
			this.FirstName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Password_Update = new System.Windows.Forms.TextBox();
			this.Email_Update = new System.Windows.Forms.TextBox();
			this.LastName_Update = new System.Windows.Forms.TextBox();
			this.FirstName_Update = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.btnLongestName = new System.Windows.Forms.Button();
			this.btnShowTable = new System.Windows.Forms.Button();
			this.btnDeleteUser = new System.Windows.Forms.Button();
			this.p_GetLongestFirstNameTableAdapter1 = new WorkingWithSQL.SecuredDevelopmentFinalDataSetTableAdapters.P_GetLongestFirstNameTableAdapter();
			this.Password = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.UsersList)).BeginInit();
			this.SuspendLayout();
			// 
			// UsersList
			// 
			this.UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UsersList.Location = new System.Drawing.Point(440, 9);
			this.UsersList.Name = "UsersList";
			this.UsersList.ReadOnly = true;
			this.UsersList.RowHeadersWidth = 51;
			this.UsersList.RowTemplate.Height = 24;
			this.UsersList.Size = new System.Drawing.Size(580, 622);
			this.UsersList.TabIndex = 0;
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Location = new System.Drawing.Point(316, 9);
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Size = new System.Drawing.Size(118, 29);
			this.btnDeleteAll.TabIndex = 1;
			this.btnDeleteAll.Text = "Delete All";
			this.btnDeleteAll.UseVisualStyleBackColor = true;
			this.btnDeleteAll.Click += new System.EventHandler(this.Remove_All_Users);
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(98, 102);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(195, 22);
			this.Email.TabIndex = 21;
			// 
			// LastName
			// 
			this.LastName.Location = new System.Drawing.Point(98, 74);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(195, 22);
			this.LastName.TabIndex = 20;
			// 
			// FirstName
			// 
			this.FirstName.Location = new System.Drawing.Point(98, 46);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(195, 22);
			this.FirstName.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label5.Location = new System.Drawing.Point(11, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 18;
			this.label5.Text = "Password:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label4.Location = new System.Drawing.Point(11, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 17);
			this.label4.TabIndex = 17;
			this.label4.Text = "Emal:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label3.Location = new System.Drawing.Point(11, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 17);
			this.label3.TabIndex = 16;
			this.label3.Text = "Last Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(11, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "First Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 29);
			this.label1.TabIndex = 14;
			this.label1.Text = "Add User:";
			// 
			// Password_Update
			// 
			this.Password_Update.Location = new System.Drawing.Point(97, 369);
			this.Password_Update.Name = "Password_Update";
			this.Password_Update.PasswordChar = '*';
			this.Password_Update.Size = new System.Drawing.Size(195, 22);
			this.Password_Update.TabIndex = 31;
			// 
			// Email_Update
			// 
			this.Email_Update.Location = new System.Drawing.Point(98, 341);
			this.Email_Update.Name = "Email_Update";
			this.Email_Update.Size = new System.Drawing.Size(195, 22);
			this.Email_Update.TabIndex = 30;
			// 
			// LastName_Update
			// 
			this.LastName_Update.Location = new System.Drawing.Point(98, 313);
			this.LastName_Update.Name = "LastName_Update";
			this.LastName_Update.Size = new System.Drawing.Size(195, 22);
			this.LastName_Update.TabIndex = 29;
			// 
			// FirstName_Update
			// 
			this.FirstName_Update.Location = new System.Drawing.Point(98, 285);
			this.FirstName_Update.Name = "FirstName_Update";
			this.FirstName_Update.Size = new System.Drawing.Size(195, 22);
			this.FirstName_Update.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label6.Location = new System.Drawing.Point(11, 368);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 27;
			this.label6.Text = "Password:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label7.Location = new System.Drawing.Point(11, 339);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 17);
			this.label7.TabIndex = 26;
			this.label7.Text = "Emal:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label8.Location = new System.Drawing.Point(11, 310);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 17);
			this.label8.TabIndex = 25;
			this.label8.Text = "Last Name:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label9.Location = new System.Drawing.Point(11, 284);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 17);
			this.label9.TabIndex = 24;
			this.label9.Text = "First Name:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label10.Location = new System.Drawing.Point(7, 244);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(166, 29);
			this.label10.TabIndex = 23;
			this.label10.Text = "Update User:";
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(12, 159);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(279, 40);
			this.btnAddUser.TabIndex = 32;
			this.btnAddUser.Text = "Add User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.Add_User);
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.Location = new System.Drawing.Point(12, 398);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(279, 40);
			this.btnUpdateUser.TabIndex = 33;
			this.btnUpdateUser.Text = "Update User";
			this.btnUpdateUser.UseVisualStyleBackColor = true;
			this.btnUpdateUser.Click += new System.EventHandler(this.Update_User);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(179, 254);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(143, 17);
			this.label11.TabIndex = 34;
			this.label11.Text = "Blanks Won\'t Change";
			// 
			// btnLongestName
			// 
			this.btnLongestName.Location = new System.Drawing.Point(316, 44);
			this.btnLongestName.Name = "btnLongestName";
			this.btnLongestName.Size = new System.Drawing.Size(118, 29);
			this.btnLongestName.TabIndex = 35;
			this.btnLongestName.Text = "Longest Name";
			this.btnLongestName.UseVisualStyleBackColor = true;
			this.btnLongestName.Click += new System.EventHandler(this.ShowLongestName);
			// 
			// btnShowTable
			// 
			this.btnShowTable.Location = new System.Drawing.Point(316, 79);
			this.btnShowTable.Name = "btnShowTable";
			this.btnShowTable.Size = new System.Drawing.Size(118, 29);
			this.btnShowTable.TabIndex = 36;
			this.btnShowTable.Text = "Show Table";
			this.btnShowTable.UseVisualStyleBackColor = true;
			this.btnShowTable.Click += new System.EventHandler(this.ShowTable);
			// 
			// btnDeleteUser
			// 
			this.btnDeleteUser.Location = new System.Drawing.Point(316, 114);
			this.btnDeleteUser.Name = "btnDeleteUser";
			this.btnDeleteUser.Size = new System.Drawing.Size(118, 29);
			this.btnDeleteUser.TabIndex = 37;
			this.btnDeleteUser.Text = "Delete User";
			this.btnDeleteUser.UseVisualStyleBackColor = true;
			this.btnDeleteUser.Click += new System.EventHandler(this.DeleteUser);
			// 
			// p_GetLongestFirstNameTableAdapter1
			// 
			this.p_GetLongestFirstNameTableAdapter1.ClearBeforeFill = true;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(97, 130);
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.Password.Size = new System.Drawing.Size(195, 22);
			this.Password.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 643);
			this.Controls.Add(this.btnDeleteUser);
			this.Controls.Add(this.btnShowTable);
			this.Controls.Add(this.btnLongestName);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.btnUpdateUser);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.Password_Update);
			this.Controls.Add(this.Email_Update);
			this.Controls.Add(this.LastName_Update);
			this.Controls.Add(this.FirstName_Update);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.LastName);
			this.Controls.Add(this.FirstName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.UsersList);
			this.Name = "Form1";
			this.Text = "y";
			((System.ComponentModel.ISupportInitialize)(this.UsersList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView UsersList;
		private System.Windows.Forms.Button btnDeleteAll;
		private System.Windows.Forms.TextBox Email;
		private System.Windows.Forms.TextBox LastName;
		private System.Windows.Forms.TextBox FirstName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Password_Update;
		private System.Windows.Forms.TextBox Email_Update;
		private System.Windows.Forms.TextBox LastName_Update;
		private System.Windows.Forms.TextBox FirstName_Update;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnUpdateUser;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnLongestName;
		private System.Windows.Forms.Button btnShowTable;
		private System.Windows.Forms.Button btnDeleteUser;
		private SecuredDevelopmentFinalDataSetTableAdapters.P_GetLongestFirstNameTableAdapter p_GetLongestFirstNameTableAdapter1;
		private System.Windows.Forms.TextBox Password;
	}
}

