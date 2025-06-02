using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;


namespace MyStore
{
    public class dbConnection
    {
        public static SqlConnection _CONNECT;
        public static SqlDataAdapter _DAdpt;
        public static DataSet _DTS;

        MD5 MD5Password;

        public String _Server = "";
        public String _DBname = "";
        public String _UsernameSQL = "";
        public String _PasswordSQL = "";
        private void ReadTextFile()
        {

            String strLine;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader _sr = new StreamReader("MarketManagement.ini");
                int _count = 0;
                //Read the first line of text
                strLine = _sr.ReadLine();

                //Continue to read until you reach end of file
                while (strLine != null)
                {
                    //write the line to console window
                    Console.WriteLine(strLine);
                    //Read the next line
                    strLine = _sr.ReadLine();
                    if (_count == 0)
                    {
                        _Server = strLine;
                    }
                    else
                        if (_count == 1)
                    {
                        _DBname = strLine;
                    }
                    else
                        if (_count == 2)
                    {
                        _UsernameSQL = strLine;
                    }
                    else
                        if (_count == 3)
                    {
                        _PasswordSQL = strLine;
                    }
                    _count = _count + 1;
                }

                //close the file
                _sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public Boolean ConnectString()
        {
            ReadTextFile();
            bool _state = false;
            try
            {
                /*establish connection with a database*/
                _CONNECT = new SqlConnection("Data Source=" + _Server + ";Initial Catalog=" + _DBname + ";User ID=" + _UsernameSQL + ";Password = " + _PasswordSQL + "");
                _state = true;
            }
            catch
            {
                _state = false;
                MessageBox.Show("Connection could not be established. Restart your program.", "Connection Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return _state;
            }
            return _state;
        }
        public Boolean OpenConnect()
        {
            //calls the method that establishes the connection
            ConnectString();
            bool _state = false;
            _CONNECT.Close();
            try
            {
                //open connection to allow reading of file
                _CONNECT.Open();
                _state = true;
            }
            catch
            {
                MessageBox.Show("Connection could not be open. Restart your program.", "Connection Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                _state = false;
            }
            return _state;
        }


        //Hash an input string and return the hash as 
        // a 32 character hexadecimal string. 
        public string makeMd5(string input)
        {
            // Create a new instance of the MD5 object. 
            MD5 md5Hasher = MD5.Create();
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes("DSW31B1" + input));
            // Create a new Stringbuilder to collect the bytes 
            // and create a string. 
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string. 
            int i = 0;
            for (i = 0; i <= data.Length - 1; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
        public bool charCheck(string input)
        {
            char[] _cSpecialCharacters = new char[] { '\'', '>', ',', '!', '&', '*', '-', '=', '+', '@', '~', '#', '<', '`', '%', '^', '$' };

            return input.Any(c => _cSpecialCharacters.Contains(c));
        }
    }
}