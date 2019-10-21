using System;
using System.Collections.Generic;
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
        private string storage = "users.txt";
        private string password;

        public string Username { get; set; }

        public string Password
        {
            get => password;

            set
            {
                // encreypt password before stroting into the file or database 
                password = Encryption.EncryptText(value, encryptionPassword);
            }
        }

        public bool ValidateCredential
        {
            get
            {
                bool valid = false;
                try
                {
                    //open user.txt storage file
                    StreamReader reader = new StreamReader(storage);

                    //while theree aree lines to read 
                    while (!reader.EndOfStream)
                    {
                        //**replace this with database connection
                        //seperator used to break apart each file line
                        char[] separators = { ',' };
                        //break the line - the result is an array containing each part of the lines that was seperated by the above seperator
                        string[] line = reader.ReadLine().Split(separators);
                        //**

                        string usernameToCheck = line[0];
                        string passwordToCheck = line[1];

                        if (Username == usernameToCheck && password == passwordToCheck)
                        {
                            valid = true;
                            break;
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.FileName + "Please contact System Administrator");
                }

                return valid;

            }
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
