﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CSharp
{
    public class Student
    {
        public int Id { get; set; }

        public List<Subject> LstSubjects { get; set; }
    }
    public class Subject
    {
        public int Id { get; set; }

        public string SubjectName { get; set; }

    }
    class Linq1
    {
        public Linq1()
        {
            var lst = new string[] { "A", "B", "C", "D" };
            var res = lst.Aggregate((f, s) => f + " " + s);
            Console.WriteLine(res);


            /*
             1. A & B => A , B
             2. then A,B stored in f
                so f = A, B
                and s = C

            3.  A, B, C
            4.  f = A,B,C
                and s = D

            and so on
            */
        }

        public Linq1(int a)
        {

            var lstStudent = new List<Student>()
            {
                new Student() { Id =1 ,
                                LstSubjects = new List<Subject>()
                                {
                                    new Subject() {Id = 11, SubjectName= "A" }
                                }
                             },
                new Student() { Id =2 ,
                LstSubjects = new List<Subject>()
                {
                    new Subject() {Id = 22, SubjectName= "b" },
                    new Subject() {Id = 33, SubjectName= "c" }

                }
                },
            };
            /*
                SelectMany - 
                -   project each element of sequence to an IEnumerable<T>
                    and flat-tern resulting sequence into one sequence
            */

            var ls = lstStudent.SelectMany(r => r.LstSubjects);
            foreach (var item in ls)
            {
                Console.WriteLine(item.SubjectName);
            }
        }
    }

    public class TU
    {
        public static void Main1()
        {
            var linq1 = new Linq1(6);
            var lst1 = new List<Student>();
            var lst2 = new List<Student>();

            var res = from r1 in lst1
                      join r2 in lst2
                      on r1.Id equals r2.Id
                      into te
                      from r2 in te.DefaultIfEmpty()
                      select new
                      {
                          c1 = r1.Id,
                          c2 = r2.Id == null ? 0 : r2.Id
                      };

        }


    }
}

/*

    lazy - Select Where Take Skip
    eagar - Count Avg Min Max ToList forach



*/
