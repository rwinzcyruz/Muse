using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Muse {

    public class Utility {

        public static string SHA1Digest(string plain) {
            var sha1 = SHA1.Create();
            byte[] input = Encoding.ASCII.GetBytes(plain);
            byte[] hash = sha1.ComputeHash(input);

            var output = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                output.Append(hash[i].ToString("X2"));
            }
            return output.ToString();
        }

        public static bool RequiredCheck(ErrorProvider errorProvider, params Control[] controls) {
            errorProvider.Clear();
            foreach (var control in controls) {
                if (control.Text == String.Empty) {
                    errorProvider.SetError(control, "Input perlu diisi");
                    return false;
                }
            }
            return true;
        }

        public static bool ConfirmDelete() {
            var result = MessageBox.Show("Apakah anda yakin ingin menghapus record ini?", "Konfirmasi Penghapusan Record", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                return true;
            }
            return false;
        }
    }
}