string[] originalArray = { "fff", "a3dfr", "$", "jytr", "343"};
string[] newArray = new string[originalArray.Length];
int j = 0;
for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length <= 3)
    {
        newArray[j] = originalArray[i];
        j++;
    }
}