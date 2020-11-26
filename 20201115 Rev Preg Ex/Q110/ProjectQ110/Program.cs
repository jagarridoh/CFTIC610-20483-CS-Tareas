using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ110
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fichero de pruebas: c:\tmp\Q110_fichero.txt.
            var miPrograma = new Program();
            var hasheado = miPrograma.GenerateHash(@"c:\tmp\Q110_fichero.txt", "HMACSHA512");
        }

        public byte[] GenerateHash(string filename, string hashAlgorithm)
        {
            var signatureAlgo = HashAlgorithm.Create(hashAlgorithm);
            var fileBuffer = System.IO.File.ReadAllBytes(filename);
            // LINEA 5 INSERTAR CODIGO AQUÍ
            // RESPUESTA A:
            /* var outputBuffer = new byte[fileBuffer.Length];   // RESPUESTA A
            signatureAlgo.TransformBlock(fileBuffer, 0, fileBuffer.Length, outputBuffer, 0);
            signatureAlgo.TransformFinalBlock(fileBuffer, fileBuffer.Length - 1, fileBuffer.Length);
            return outputBuffer; */
            // RESPUESTA B:
            /* signatureAlgo.ComputeHash(fileBuffer);           // RESPUESTA B
            return signatureAlgo.GetHashCode(); */
            // RESPUESTA C:
            /* var outputBuffer = new byte[fileBuffer.Length];   // RESPUESTA C
            signatureAlgo.TransformBlock(fileBuffer, 0, fileBuffer.Length, outputBuffer, 0);
            return outputBuffer; */
            // RESPUESTA D: 
            //return signatureAlgo.ComputeHash(fileBuffer);  // RESPUESTA D  */
            return signatureAlgo.ComputeHash(fileBuffer);  // RESPUESTA D  */
        }
    }
}
