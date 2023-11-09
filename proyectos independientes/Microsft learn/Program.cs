// initialize variables - graded assignments 
using System.ComponentModel.Design;

int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];
string currentStudentsLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t  \tExam Score \tOverall \tGrade\t Extra Credit \n");

    foreach (string name in studentNames)
    {
        string currentStudent = name;

        if (currentStudent == "Sophia")
            studentScores = sophiaScores;

        else if (currentStudent == "Andrew")
            studentScores = andrewScores;

        else if (currentStudent == "Emma")
            studentScores = emmaScores;

        else if (currentStudent == "Logan")
            studentScores = loganScores;

        else if (currentStudent == "Becky")
            studentScores = beckyScores;

        else if (currentStudent == "Chris")
            studentScores = chrisScores;

        else if (currentStudent == "Eric")
            studentScores = ericScores;

        else if (currentStudent == "Gregor")
            studentScores = gregorScores;
        else
            continue;



        // initialize/reset the sum of scored assignments
        int sumAssignmentScores = 0;

        // initialize/reset the calculated average of exam + extra credit scores
        decimal currentStudentGrade = 0;
        int gradeAssignments= 0;

        

        foreach (int score in studentScores)
        {
            gradeAssignments += 1;
            
            // add the exam score to the sum
            if (gradeAssignments <= examAssignments)
                sumAssignmentScores += score;
            else
                sumAssignmentScores += score / 10;

            
        }
       
        currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
        if (currentStudentGrade >= 97)
            currentStudentsLetterGrade = "A+";

        else if (currentStudentGrade >= 93)
            currentStudentsLetterGrade = "A";

        else if (currentStudentGrade >= 90)
            currentStudentsLetterGrade = "A-";

        else if (currentStudentGrade >= 87)
            currentStudentsLetterGrade = "B+";

        else if (currentStudentGrade >= 83)
            currentStudentsLetterGrade = "B";

        else if (currentStudentGrade >= 80)
            currentStudentsLetterGrade = "B-";

        else if (currentStudentGrade >= 77)
            currentStudentsLetterGrade = "C+";

        else if (currentStudentGrade >= 73)
            currentStudentsLetterGrade = "C";

        else if (currentStudentGrade >= 70)
            currentStudentsLetterGrade = "C-";

        else if (currentStudentGrade >= 67)
            currentStudentsLetterGrade = "D+";

        else if (currentStudentGrade >= 63)
            currentStudentsLetterGrade = "D";

        else if (currentStudentGrade >= 60)
            currentStudentsLetterGrade = "D-";

        else  currentStudentsLetterGrade = "F";

        int creditXtra = 0;
    foreach (int xtra in studentScores)
     {
         creditXtra = gradeAssignments;
     }


        decimal noteExam = 0;
        foreach (decimal examen in studentScores) 
        { 

        }



    Console.WriteLine($"{currentStudent}\t \t{noteExam}\t\t{currentStudentGrade}\t\t{currentStudentsLetterGrade}\t{creditXtra}  ({creditXtra} pts)");
    }
console.WriteLine("esto es prueba");
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
