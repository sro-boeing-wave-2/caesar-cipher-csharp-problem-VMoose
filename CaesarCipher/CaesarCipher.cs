using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string output = string.Empty;  
  
            foreach(char replace in text)  
            output += rot(replace, shiftKey);  
  
            return output; 
        }
        public static char rot(char replace, int shiftKey) {  
            if (!char.IsLetter(replace)) {  
  
                return replace;  
            }  
            char UpperorLower = char.IsUpper(replace) ? 'A' : 'a';  
            return (char)((((replace + shiftKey) - UpperorLower) % 26) + UpperorLower);  
  
  
        }  
    }
}
