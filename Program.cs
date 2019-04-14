 using System;
 using Nethereum.Signer;
 using Nethereum.Signer.Crypto;
 
namespace Signing
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "This is the message!";
            var privateKey = "b5b1870957d373ef0eeffecc6e4812c0fd08f554b37b233526acc331bf1544f7";
            var providedAddress = "0x12890D2cce102216644c59daE5baed380d84830c";
    
            var signer = new Nethereum.Signer.MessageSigner();
            var signature = signer.HashAndSign(message, privateKey);
            Console.WriteLine("signature: {0} " ,signature);
            //verification
            var address = signer.HashAndEcRecover(message, signature);
            Console.WriteLine("\n address:  {0}" ,address);
            Console.WriteLine("\n result :  {0}" ,address == providedAddress);
        }
    }
}
