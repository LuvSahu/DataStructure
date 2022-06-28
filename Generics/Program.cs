namespace DSA
{
    class Program
    {
        //private static int[] arr;

        public static void Main(String[] args)
        {

            Console.WriteLine("Choose a number to go to the respective problem \n");
            Console.WriteLine("1 for Permutation");
            Console.WriteLine("2 for BinarySearch");
            Console.WriteLine("3 for InserationSort");
            Console.WriteLine("4 for BubbleSort");
            Console.WriteLine("5 for MrgeSort");
            Console.WriteLine("6 for Anagram");
            Console.WriteLine("7 for PrimeNumberRange");
            Console.WriteLine("8 for PrimePalindromecs");
            Console.WriteLine("9 for Search Sort Generics");
            Console.WriteLine("10 for Find Number");
            Console.WriteLine("11 for TaskDoneByMaximumAmount");



            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //UC1
                    Permutation permutationsofstring = new Permutation();
                    permutationsofstring.permutations();
                    break;

                case 2:
                    //UC2
                    BinarySearch bs = new BinarySearch();
                    bs.Binary();
                    break;

                case 3:
                    //UC3
                    int[] arr = { 12, 11, 13, 5, 6 };
                    InserationSort ob = new InserationSort();
                    ob.sort(arr);
                    ob.printArray(arr);
                    break;

                case 4:
                    //UC4
                    int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
                    BubbleSort BS = new BubbleSort();
                    BS.bubbleSort(arr1);
                    Console.WriteLine("Sorted array");
                    BS.printArray(arr1);
                    break;

                case 5:
                    //UC5
                    int[] arr2 = { 12, 11, 13, 5, 6, 7 };
                    //Console.WriteLine("Given Array");
                    MergeSort OB = new MergeSort();
                    OB.sort(arr2, 0, arr2.Length - 1);
                    Console.WriteLine("\nSorted array");
                    OB.printArray(arr2);
                    break;

                case 6:
                    //UC6
                    string str1 = "Luv";
                    string str2 = "Priyanka";

                    if (Anagram.areAnagram(str1, str2))
                        Console.Write("The two strings are " +
                                      "anagram of each other");
                    else
                        Console.Write("The two strings are " +
                                      "not anagram of each other");
                    break;

                case 7:
                    //UC7
                    PrimeNumberRange.PrimeNumber();
                    break;

                case 8:
                    //UC8
                    PrimePalindromecs.countPal(100, 1000);
                    break;

                case 9:
                    //UC9
                    SearchSortGenerics searchingandsortingusinggenerics = new SearchSortGenerics();
                    searchingandsortingusinggenerics.SearchingAndSorting();
                    break;

                case 10:
                    //UC10
                    FindNumber findnumber = new FindNumber();
                    findnumber.Find();
                    findnumber.Question(12, 23);
                    break;

                case 11:
                    TaskDoneByMaximumAmount taskdonebymaximumamount = new TaskDoneByMaximumAmount();
                    taskdonebymaximumamount.tasks();
                    break;
            }

        }
    }
}