using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace sqliteTest.Common {
	static class Common {
		public static string getHashedValue(string value) {
			SHA1 sha1 = SHA1CryptoServiceProvider.Create();
			byte[] passWords = Encoding.UTF8.GetBytes(value);
			byte[] hashedPass = sha1.ComputeHash(passWords);
			string result = string.Empty;
			foreach (byte pss in hashedPass) {
				result += pss.ToString("X2");
			}
			return result;
		}
	}
}

