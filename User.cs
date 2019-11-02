using spital.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spital
{
    class User
    {
        // encryption key 
        private string encryptionPassword = "7689iknh7564fbg6ghjgbt6";
        private string password;

        public string Username { get; set; }

        public string Password
        {
            get => password;

            set
            {
                // encreypt password before stroting into the database 
                password = Encryption.EncryptText(value, encryptionPassword);
            }
        }

        public bool ValidateCredential
        {
            get
            {
                bool valid = false;

                DataSet dataSet = DatabaseConnection.Instance.GetDataSet("SELECT username, password FROM user");

                foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            if (String.Equals(Username,row["username"].ToString()))
                            {
                                
                                string comparePassword = Encryption.DecryptText(row["password"].ToString(), encryptionPassword);

                                if (String.Equals(Username, comparePassword))
                                {
                                    // Credentials match
                                    valid = true;
                                }
                                else
                                {
                                    // Wrong password
                                }
                            }
                            else
                            {
                                // Wrong username
                            }
                        }
                    }

                return valid;
            }
        }

        internal void Save()
        {

            DataTable staff = new DataTable("staff");
            DataRow newMember = staff.NewRow();
            newMember["username"] = Username;
            newMember["password"] = Password;
            staff.Rows.Add(newMember);
        }
    }
}
