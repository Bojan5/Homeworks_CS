using System;

namespace Homework08
{
    class Program
    {
        // TASK 01..................................................................
        //public class PhotoAlbum
        //{
        //    private int NumberOfPages;

        //    public PhotoAlbum()
        //    {
        //        NumberOfPages = 16;
        //    }

        //    public PhotoAlbum(int number)
        //    {
        //        NumberOfPages = number;
        //    }



        //    public void GetNumberOfPages()
        //    {
        //        Console.WriteLine($"Number of pages: {NumberOfPages}");
        //    }
        //}

        //public class BigPhotoAlbum
        //{
        //    public int NumberOfPages;

        //    public BigPhotoAlbum()
        //    {
        //        NumberOfPages = 64;
        //    }

        //    public void GetNumberOfPages()
        //    {
        //        Console.WriteLine($"Number of pages: {NumberOfPages}");
        //    }
        //}

        // TASK 02.......................................................................

        public class FirstCourse
        {
            public FirstCourse(string courseName, bool pass)
            {
                CourseName = courseName;
                passed = pass;
            }

            public bool Passed()
            {
                if(passed)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public string CourseName;
            public bool passed;
        }

        public class SecondCourse
        {
            public SecondCourse(string courseName, StudentGrades grade)
            {
                CourseName = courseName;
                Grades = grade;
            }

            public string CourseName;
            public StudentGrades Grades;

            public bool Passed()
            {
                if((int) Grades != 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Project
        {
            public Project(bool courseOne, bool courseTwo, bool courseThree, bool courseFour)
            {
                CourseOne = courseOne;
                CourseTwo = courseTwo;
                CourseThree = courseThree;
                CourseFour = courseFour;
            }

            bool CourseOne;
            bool CourseTwo;
            bool CourseThree;
            bool CourseFour;

            public void Passed()
            {
                bool[] array = { CourseOne, CourseTwo, CourseThree, CourseFour };
                int sumOfCourses = 0;

                foreach (var item in array)
                {
                    if(item == true)
                    {
                        sumOfCourses++;
                    }
                }
                if(sumOfCourses > 2)
                {
                    Console.WriteLine($"Student has passed, successifully achieving {sumOfCourses} courses!");
                }
                else
                {
                    Console.WriteLine("Student faild!");
                }
            }
        }

        public enum StudentGrades
        {
            Ten = 10,
            Nine = 9,
            Eight = 8,
            Seven = 7,
            Six = 6,
            Five = 5
        }
        static void Main(string[] args)
        {
            //PhotoAlbum myAlbum1 = new PhotoAlbum();
            //myAlbum1.GetNumberOfPages();

            //PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            //myAlbum2.GetNumberOfPages();

            //BigPhotoAlbum myAlbum3 = new BigPhotoAlbum();
            //myAlbum3.GetNumberOfPages();

            // TASK 02........................................................................

            var firstCourseOne = new FirstCourse("SEDC", true);
            var firstCourseTwo = new FirstCourse("SEDC", true);

            var secondCourseOne = new SecondCourse("SEDC", StudentGrades.Seven);
            var SecondCourseTwo = new SecondCourse("SEDC", StudentGrades.Six);

            Project Grades = new Project(firstCourseOne.Passed(), firstCourseTwo.Passed(), secondCourseOne.Passed(), SecondCourseTwo.Passed());

            Grades.Passed();

            Console.ReadLine();
        }
    }
}
