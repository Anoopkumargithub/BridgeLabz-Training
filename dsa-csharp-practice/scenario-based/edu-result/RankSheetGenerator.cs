using System;
using System.Collections.Generic;

namespace EduResult
{
    public class RankSheetGenerator
    {
        // Method to merge two sorted lists
        public List<Student> MergeSortedLists(List<Student> list1, List<Student> list2)
        {
            List<Student> mergedList = new List<Student>();
            int i = 0, j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i].Score <= list2[j].Score)
                {
                    mergedList.Add(list1[i]);
                    i++;
                }
                else
                {
                    mergedList.Add(list2[j]);
                    j++;
                }
            }

            // Add remaining elements
            while (i < list1.Count)
            {
                mergedList.Add(list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                mergedList.Add(list2[j]);
                j++;
            }

            return mergedList;
        }

        // Merge Sort method
        public List<Student> MergeSort(List<Student> students)
        {
            if (students.Count <= 1)
                return students;

            int mid = students.Count / 2;
            List<Student> left = MergeSort(students.GetRange(0, mid));
            List<Student> right = MergeSort(students.GetRange(mid, students.Count - mid));

            return MergeSortedLists(left, right);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}