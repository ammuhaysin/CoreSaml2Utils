﻿using System.Security.Cryptography.X509Certificates;

namespace CoreSaml2Utils.Utilities
{
    public static class CertificateUtilities
    {
        public static X509Certificate2 LoadCertificateFile(string certificateFilePath, string password = null)
        {
            return new X509Certificate2(certificateFilePath, password, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
        }

        public static X509Certificate2 LoadCertificate(string certificate)
        {
            return LoadCertificate(StringToByteArray(certificate));
        }

        public static X509Certificate2 LoadCertificate(byte[] certificate, string password = null)
        {
            return new X509Certificate2(certificate, password, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
        }

        private static byte[] StringToByteArray(string st)
        {
            var bytes = new byte[st.Length];
            for (int i = 0; i < st.Length; i++)
            {
                bytes[i] = (byte)st[i];
            }
            return bytes;
        }
    }
}