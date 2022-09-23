using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using CodeCalisthenics.Operations;
using static System.Int32;

namespace CodeCalisthenics
{
    class Program
    {   
        public static void Main(string[] args)
        {
            /*//RoadRepair.RoadRepair.Execute();

            //FizzBuzz.FizzBuzzKata.Execute(15);

            //SalesByMatch.SalesByMatch.Execute();
            new CodeChallenges.Solution().Execute();*/
            var breadthFirstSearch = new BreadthFirstSearch();
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = breadthFirstSearch.insert(root, data);
            }
            breadthFirstSearch.levelOrder(root);
        }
    }
    
}
