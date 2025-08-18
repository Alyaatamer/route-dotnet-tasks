using System.Collections;
using System.Runtime.InteropServices;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            int[] arr = { 1, 2, 1, 3, 3, 1, 2, 3, 4, 4 };

            Hashtable h = new Hashtable();

            foreach (int i in arr)
            {
                if (h.ContainsKey(i))
                {
                    h[i] = (int)h[i] + 1;
                }
                else
                {
                    h.Add(i, 1);
                }
            }

            foreach (DictionaryEntry map in h)
            {
                Console.WriteLine($"key : {map.Key} , value : {map.Value}");
            }


            #endregion

            #region Q2

            // I used the one in the first question.

            int num = -1;
            int max = 0;
            foreach (DictionaryEntry map in h)
            {
                if ((int)map.Value > max)
                {
                    max = (int)map.Value;
                    num = (int)map.Key;
                }
            }

             Console.WriteLine($"Num : {num} , maxValue : {max}");
            #endregion

            #region Q3

            // I used the one in the first question.

            int target;
            bool isvalid = false;

            do
            {
                Console.WriteLine("Enter a number to search for:");
                isvalid = int.TryParse(Console.ReadLine(), out target);
            } while (!isvalid);


            foreach (DictionaryEntry map in h)
            {
                if ((int)map.Value == target)
                {
                    Console.WriteLine(map.Key);
                }
            }



            #endregion

            #region Q4

            // --------------size of array string -------------------
            int SzOfArray;
            bool isValid = false;
            do
            {
                Console.WriteLine("Enter the size of the array:");
                isValid = int.TryParse(Console.ReadLine(), out SzOfArray);
            } while (!isValid || SzOfArray <= 0);

            //-------------- array of strings -------------------
            string[] strings = new string[SzOfArray];
            Dictionary<string ,List<string>> stringDictionary = new Dictionary<string, List<string>>();

            // Loop to get strings from the user
            for (int i = 0; i < SzOfArray; i++)
            {
                isValid = false;
                do
                {
                    Console.WriteLine("Enter a string:");
                    strings[i] = Console.ReadLine();
                    isValid = !string.IsNullOrEmpty(strings[i]);
                } while (!isValid);

                char[] chars = strings[i].ToCharArray();
                Array.Sort(chars);
                string sortedString = new string(chars);

                if (!stringDictionary.ContainsKey(sortedString))
                    stringDictionary[sortedString] = new List<string>();

                stringDictionary[sortedString].Add(strings[i]);
            }

            foreach (var group in stringDictionary)
            {
                Console.WriteLine("[" + string.Join(", ", group.Value) + "]");
            }



            #endregion

            #region Q5

            int n;
            bool isValidN = false;

            do
            {
                Console.WriteLine("Enter a Size Of the Array :");
                isValidN = int.TryParse(Console.ReadLine(), out n);
            } while (!isValidN || n <= 1);

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1} : ");
                isValidN = int.TryParse(Console.ReadLine(), out array[i]);
                while (!isValidN)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    isValidN = int.TryParse(Console.ReadLine(), out array[i]);
                }
            }

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int number in array)
            {
                if (keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs[number]++;
                }
                else
                {
                    keyValuePairs[number] = 1;
                }
            }

            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine($"The number {kvp.Key} appears {kvp.Value} time(s).");
            }


            #endregion

            #region Q6

            SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            students.Add(1, "Alyaa");
            students.Add(2, "Soher");
            students.Add(3, "Engy");

            Console.WriteLine("Students after adding:");
            foreach (var map in students)
            {
                Console.WriteLine($"{map.Key} : {map.Value}");
            }

            students.Remove(1);
            Console.WriteLine("\nStudents after removing ID 1:");
            foreach (var map in students)
            {
                Console.WriteLine($"{map.Key} : {map.Value}");
            }

            int searchId = 2;
            if (students.ContainsKey(searchId))
            {
                Console.WriteLine($"Student with ID {searchId}: {students[searchId]}");
            }

            #endregion

            #region Q7

            SortedList<int, string> employees = new SortedList<int, string>();

            employees.Add(1, "Alyaa");
            employees.Add(2, "Soher");
            employees.Add(3, "Engy");

            Console.WriteLine("employees after adding:");
            foreach (var map in employees)
            {
                Console.WriteLine($"{map.Key} : {map.Value}");
            }

            employees.Remove(1);
            Console.WriteLine("\nStudents after removing ID 1:");
            foreach (var map in employees)
            {
                Console.WriteLine($"{map.Key} : {map.Value}");
            }

            int search_Id = 2;
            if (employees.ContainsKey(search_Id))
            {
                Console.WriteLine($"Student with ID {search_Id}: {employees[search_Id]}");
            }

            #endregion

            #region Q8

            int[] a = { 1, 3, 5, 7, 9 };

            HashSet<int> set = new HashSet<int>(arr);
            List<int> missing = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                if (!set.Contains(i))
                    missing.Add(i);
            }

            Console.WriteLine("Missing numbers: " + string.Join(", ", missing));

            #endregion

            #region Q9

            List<int> nums = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 1 };

            HashSet<int> unique = new HashSet<int>(nums);

            Console.WriteLine("Unique numbers:");
            foreach (int u in unique)
            {
                Console.WriteLine(u);
            }

            #endregion

            #region Q10

            Hashtable original = new Hashtable();
            original.Add(1, "Alyaa");
            original.Add(2, "Soher");
            original.Add(3, "Engy");

            Console.WriteLine("Original Hashtable:");
            foreach (DictionaryEntry entry in original)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Hashtable swapped = new Hashtable();
            foreach (DictionaryEntry entry in original)
            {
                swapped.Add(entry.Value, entry.Key);
            }

            Console.WriteLine("\nSwapped Hashtable:");
            foreach (DictionaryEntry entry in swapped)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            #endregion

            #region Q11

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };

            HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSet<int> unionSet = new HashSet<int>(set1);
            unionSet.UnionWith(set2);

            Console.WriteLine("Union of sets:");
            foreach (int s in unionSet)
            {
                Console.WriteLine(s);
            }

            #endregion

            #region Q12

            Dictionary<string, int> Pairs = new Dictionary<string, int>();

            Pairs.Add("Alyaa", 1);
            Pairs.Add("Soher", 2);
            Pairs.Add("Engy", 3);

            char targert;
            isValid = false;
            do
            {
                Console.WriteLine("Enter a character to search for:");
                isValid = char.TryParse(Console.ReadLine(), out targert);
            } while (!isValid);

            foreach (var pair in Pairs)
            {
                if (pair.Key.StartsWith(targert.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
                }
            }

            #endregion

            #region Q13

            HashSet<int> values = new HashSet<int>();

            values.Add(1);
            values.Add(2);
            values.Add(3);
            values.Add(4);

            int targetValue;
            bool isValidInput = false;
            do
            {
                Console.WriteLine("Enter a value to check if it exists in the HashSet:");
                isValidInput = int.TryParse(Console.ReadLine(), out targetValue);
            } while (!isValidInput);

            List<int> foundValues = new List<int>();

            if (values.Contains(targetValue))
            {
                foreach (var value in values)
                {
                    if (value > targetValue)
                    {
                        foundValues.Add(value);
                    }
                }
            }

            foreach (var value in foundValues)
            {
                Console.WriteLine(value);
            }

            #endregion

            #region Q14

            SortedList<int, int> List = new SortedList<int, int>();
            List.Add(1, 2);
            List.Add(2, 4);
            List.Add(3, 6);
            List.Add(4, 8);

            List<int> Even = new List<int>();

            foreach (var pair in List)
            {
                if (pair.Value % 2 == 0)
                {
                    Even.Add(pair.Key);
                }
            }

            Console.WriteLine("Keys with even values:");
            if (Even.Count > 0)
            {
                Console.WriteLine(string.Join(", ", Even));
            }
            else
            {
                Console.WriteLine("No keys found with even values.");
            }

            #endregion
        }
    }
}
