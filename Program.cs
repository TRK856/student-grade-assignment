// See https://aka.ms/new-console-template for more information
#nullable disable

// init
int AmountOfGrades = 35;
int[] grades = new int[AmountOfGrades];
Random rnd = new Random();
for(int n=0; n < AmountOfGrades; n++){
    grades[n] = rnd.Next(0, 100);
}

// main process
bool loop = true;
while (loop){
    Console.Clear();
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("    1. Display All Grades");
    Console.WriteLine("    2. Display Honours");
    Console.WriteLine("    3. Stats");
    Console.WriteLine("    4. Randomize Grades");
    Console.WriteLine("    5. Exit");

    Console.Write("-> "); int mainMenuChoice = Convert.ToInt32(Console.ReadLine());
    if(mainMenuChoice == 1){
        Console.Clear();
        Console.WriteLine("ALL GRADES");
        for (int i = 0; i < grades.Length; i++) {
            Console.WriteLine($"{grades[i]}%");
        }
        Console.WriteLine("Back to Main Menu?");
        Console.Write("-> "); Console.ReadLine();
    }
    if(mainMenuChoice == 2){
        Console.Clear();
        Console.WriteLine("HONOURS");
        int honourCount = 0;
        for (int i = 0; i < grades.Length; i++) {
            if(grades[i] >= 80){
                Console.WriteLine($"{grades[i]}%");
                honourCount++;
            }
        }
        Console.WriteLine($"Number of Honours: {honourCount}");
        Console.WriteLine("");
        Console.WriteLine("Back to Main Menu?");
        Console.Write("-> "); Console.ReadLine();
    }
    if(mainMenuChoice == 3){
        Console.Clear();
        Console.WriteLine("STATS");
        int largestNum = 0;
        int smallestNum = 100;
        int averageNum = 0;

        for (int i = 0; i < grades.Length; i++) {
            if(grades[i] > largestNum){
                largestNum = grades[i];
            }
            if(grades[i] < smallestNum){
                smallestNum = grades[i];
            }
            averageNum += grades[i];
        }
        Console.WriteLine($"Highest Grade: {largestNum}");
        Console.WriteLine($"Lowest Grade: {smallestNum}");
        Console.WriteLine($"Average Grade: {averageNum/grades.Length}");
        Console.WriteLine("");
        Console.WriteLine("Back to Main Menu?");
        Console.Write("-> "); Console.ReadLine();
    }
    if(mainMenuChoice == 4){
        Console.Clear();
        Console.WriteLine("# of Students?");
        Console.Write("-> "); AmountOfGrades = Convert.ToInt32(Console.ReadLine());
        AmountOfGrades = 35;
        for(int n=0; n < AmountOfGrades; n++){
            grades[n] = rnd.Next(0, 100);
        }
        Console.WriteLine("GRADES HAVE BEEN RANDOMIZED");
    }
    if(mainMenuChoice == 5){
        Console.Clear();
        break;
    }
}