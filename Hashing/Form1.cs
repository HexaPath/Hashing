using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hashing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string originaltext = "";
        public static string salt = "Some~Random_Hash~";
        public static string HashText = "Placeholder";
        private void btnAddSalt_Click(object sender, EventArgs e)
        {
            originaltext += salt;
        }


        /*Hashing around*/

        public static class SHA
        {

            public static string GenerateSHA256String(string inputString)
            {
                SHA256 sha256 = SHA256Managed.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(inputString);
                byte[] hash = sha256.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }

            public static string GenerateSHA512String(string inputString)
            {
                SHA512 sha512 = SHA512Managed.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(inputString);
                byte[] hash = sha512.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }

            private static string GetStringFromHash(byte[] hash)
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    result.Append(hash[i].ToString("X2"));
                }
                return result.ToString();
            }

        }
        /**/
        

        private void btnHash512_Click(object sender, EventArgs e)
        {
            originaltext = textBoxOriginal.Text;
            HashText = SHA.GenerateSHA512String(originaltext);
            textBoxHashed.Text = HashText;
        }

        private void btnHash256_Click(object sender, EventArgs e)
        {
            originaltext = textBoxOriginal.Text;
            HashText = SHA.GenerateSHA256String(originaltext);
            textBoxHashed.Text = HashText;
        }
        
    }
}
