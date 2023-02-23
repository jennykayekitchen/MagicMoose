using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    
    // declares a variable that is true or false
    // in this case, if MooseAsks = true then it will run MooseAnswers
    // MooseAsks will be true if the user types anything in
    // MooseAnswers will provide a generated response
    bool answer = MooseAsks();
    
    if (answer)
        {
            MooseAnswers();
        }    
}

// declares that the function MooseAsks will return either true or false
// if the user enters a question, MooseAsks will be true
bool MooseAsks()
{
    // tells the console to write the prompt
    Console.Write("Please ask a question!");
    // declares a new string variable named userQuestion
    // reads what the user inputs and assigns that to userQuestion
    string userQuestion = Console.ReadLine();

    // creates a loop that executes as long as the user hasn't typed anything
    while (userQuestion.Length == 0)
    {
        // tells the console to write the prompt to the console
        Console.Write("Please ask a question!");
        // reads what the user inputs and assigns that to userQuestion
        userQuestion = Console.ReadLine();
    }

    // if the user types anything, that will equal true
    if (userQuestion.Length > 0 )
    {
        return true;
    }
    else
    {
        return false;
    }
};


void MooseAnswers()
{
    // declares an array of strings called responses which are the answers the moose can give
    string[] responses = {"As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don’t count on it", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Outlook good.", "Reply hazy, try again.",  "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it."};
    // creates a random object called r, this is a class (method) that will generate a random number
    Random r = new Random();
    // creates an integer variable that will hold the randomly generated number between 0-19
    int responseNumber = r.Next(0,19);

    // prints out the answer based on the array number, which was randomly generated
    Console.WriteLine(responses[responseNumber]);
}



