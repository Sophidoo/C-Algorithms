using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Palindrome
    {
        ArrayList characters = new ArrayList();
        ArrayList reverse = new ArrayList();    
        ArrayList smallLarge = new ArrayList();
        public bool PalindromeSolution()
        {
            string name = "adda";
            string word = name.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                characters.Add(word[i]);
            }

            for(int j = word.Length -1; j >= 0; j--)
            {
                reverse.Add(word[j]);
            }

            for(int k = 0; k < word.Length; k++)
            {
                if (Convert.ToChar(characters[k]) != Convert.ToChar(reverse[k]))
                {
                    return false;
                }
            }

            return true;
                
        }


        public void smallestNumber()
        {
            int[] arrNum = { 1, 10, 9, 0, 4, 23 };

            int smallest = arrNum[0];
            int largest = arrNum[arrNum.Length-1];
            for(int i = 1; i < arrNum.Length; i++)
            {
                if(arrNum[i] <= smallest)
                {
                    smallest = arrNum[i];
                }
                if(arrNum[i] >= largest)
                {
                    largest = arrNum[i];
                }
            }

            smallLarge.Add(smallest);
            smallLarge.Add(largest);

            Console.Write("\nThe smallest and largest number is: ");
            for(int i = 0; i < smallLarge.Count; i++)
            {
                Console.Write(smallLarge[i] + " ");
            }
        }

        public void Duplicate()
        {
            int[] numArray = { 3, 6, 10, 23, 10, 10, 2 };
            
            ArrayList number = new ArrayList();
            ArrayList duplicate = new ArrayList();
            
            for(int i = 0; i < numArray.Length; i++)
            {
                if (number.Contains(numArray[i]))
                {
                    if (duplicate.Contains(numArray[i]))
                    {
                        continue;
                    }
                    else
                    {
                        duplicate.Add(numArray[i]);
                    }
                }
                else
                {
                    number.Add(numArray[i]);
                }
            }

            Console.WriteLine();

            Console.Write("\nThe duplicate number is: ");
            for (int i = 0; i < duplicate.Count; i++)
            {
                Console.Write(duplicate[i] + " ");
            }

        }

        public void reoccurChar()
        {
            Hashtable reoccur = new Hashtable();

            string word = "ada";
            int count = 0;

            for(int i = 0; i < word.Length; i++)
            {
                if (reoccur.ContainsKey(word[i]))
                {
                    count = Convert.ToInt32(reoccur[word[i]]) + 1;
                    reoccur[word[i]] = count;
                }
                else
                {
                    reoccur.Add(word[i], 1);
                }
            }

            Console.WriteLine("\n\nThe character and their given occurence is:");
            foreach(DictionaryEntry entry in reoccur)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }



    }
}
