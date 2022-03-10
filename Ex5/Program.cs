class program
{
    static void Main(string[] args)
    {
        string firstName = "Денисов ";
        string lastName = "Михаил ";
        Console.WriteLine(firstName + lastName);

        string bufferVariable = firstName;
        firstName = lastName;
        lastName = bufferVariable;
        Console.WriteLine(firstName + lastName);
    }
}


   
