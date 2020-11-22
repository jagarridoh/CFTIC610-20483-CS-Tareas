------

# QUESTION 59

### PREGUNTA TEORICA

------

You are developing an application that will transmit large amounts of data between a client computer and a server.

You need to ensure the validity of the data by using a cryptographic hashing algorithm.

Which algorithm should you use?

A. Aes
B. Rfc2898DeriveBytes
C. DES
D. HMACSHA512





------

### RESPUESTA



Correct Answer: D  
Section: Volume A  
Explanation/Reference:  

The .NET Framework provides the following classes that implement hashing algorithms:

* HMACSHA1.

* MACTripleDES.

* MD5CryptoServiceProvider.

* RIPEMD160.

* SHA1Managed.

* SHA256Managed.

* SHA384Managed.

* SHA512Managed.

HMAC variants of all of the Secure Hash Algorithm (SHA), Message Digest 5 (MD5), and RIPEMD-160 algorithms.

CryptoServiceProvider implementations (managed code wrappers) of all the SHA algorithms.

Cryptography Next Generation (CNG) implementations of all the MD5 and SHA algorithms.

References:
http://msdn.microsoft.com/en-us/library/92f9ye3s.aspx#hash_values

------

