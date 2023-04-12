// An array is an object who's job is to store multiple items of the same type
// Like any other vaiable you need to declare the datatype for an array variable
// As well as putting [] after the data
// Arrays have a set amout of spcaes in them, you cannot create or remove spaces from an already existing array
// Arrays have a default value when left empty depending on the data type 
// number data types - defaulkt to 0
// booleans - false
// string - empty string ""
// objects - null 
int[] nums = new int[5];

// How are arrays organized?
//Arrays are indexed starting at 0, each slot gets its own index
// [] [] [] [] [] 
// 0  1  2  3  4
// Most coding languages use this indexing convention (Exception being Python)

int num = nums[0]; // This is how you pull a single item out of an array, give it an index and set it equal to variable
int num2 = nums[2];

// This is how you set a value in an array:
nums[0] = 99;
nums[1] = 34; 
nums[2] = 100;
nums[3] = 199;
nums[4] = 70;

//This is how you fill up an array while creating it
int[] nums2 = { 12, 119, 107, 59, 25 };

// How to display contents of array
Console.WriteLine("For Loop");

// Memorize and save this, the most common for loop you will use. 
// Is we add or remove items, .Length will change to that index value
for (int i = 0; i < nums2.Length; i++)
{
    //This will loop thru and print the entire array
    Console.WriteLine($"Index: {i}, Value: {nums2[i]}");
}



int[] nums3 = new int[6];
Console.WriteLine("Empty Number Array");
for (int i = 0; i < nums3.Length; i++)
{
    //This will loop thru and print the entire array
    Console.WriteLine($"Index: {i}, Value: {nums3[i]}");
}

// You cna make an array of any data type, incuding classes you write yourself
string[] names = new string[5];
Console.WriteLine("Printing Empty String Array");
for (int i =0; i < names.Length; i++)
{
    Console.WriteLine($"Index: {i}, Value: {names[i]}");
}
