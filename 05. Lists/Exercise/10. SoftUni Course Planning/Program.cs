using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string[] commandInput = Console.ReadLine().Split(":");

            string command = commandInput[0];

            while (command != "course start")
            {
                string lesson = commandInput[1];

                switch (command)
                {
                    case "Add":
                        if (!schedule.Contains(lesson))
                        {
                            schedule.Add(lesson);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(commandInput[2]);

                        if (!schedule.Contains(lesson))
                        {
                            schedule.Insert(index, lesson);
                        }
                        break;
                    case "Remove":
                        schedule.Remove(lesson);

                        string exercise = lesson + "-Excercise";

                        schedule.Remove(exercise);
                        break;
                    case "Swap":
                        string secondLesson = commandInput[2];

                        if (schedule.Contains(lesson) && schedule.Contains(secondLesson))
                        {
                            int firstLessonIndex = schedule.IndexOf(lesson);
                            int secondLessonIndex = schedule.IndexOf(secondLesson);

                            schedule[firstLessonIndex] = secondLesson;
                            schedule[secondLessonIndex] = lesson;

                            exercise = lesson + "-Exercise";
                            if (schedule.Remove(exercise))
                            {
                                schedule.Insert(secondLessonIndex + 1, exercise);
                            }

                            exercise = secondLesson + "-Exercise";
                            if (schedule.Remove(exercise))
                            {
                                schedule.Insert(firstLessonIndex + 1, exercise);
                            }
                        }
                        break;
                    case "Exercise":
                        exercise = lesson + "-Exercise";

                        if (!schedule.Contains(lesson))
                        {
                            schedule.Add(lesson);
                            schedule.Add(exercise);
                        }

                        if (!schedule.Contains(exercise))
                        {
                            schedule.Insert(schedule.IndexOf(lesson) + 1, exercise);
                        }
                        break;
                    default:
                        break;
                }

                commandInput = Console.ReadLine().Split(":");

                command = commandInput[0];
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
