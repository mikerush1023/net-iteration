using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation
           Down below you will find instructions for code to write.
           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests continuously check
           your work each time you save. If a test is failing you have not yet completed that method
           Once you finish a method and have it correct, the test will tell you how
           the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes a list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var yell = words.Select(word => word.ToUpper());
            return yell;
        }

        // 
        // 2) Complete the method named `Double` that takes a list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var timesTwo = numbers.Select(number => number * 2);
            return timesTwo;
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes a list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            var newList = data.Select((element, index) => $"{element} is at index {index}");
            return newList;
        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            var evenNumbers = data.Where(integers => integers % 2 == 0);
            return evenNumbers;
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts a
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            var evenIndexes = data.Where((element, index) => index % 2 == 0);
            return evenIndexes;
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts a list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            var moreThanNinety = data.Where(movie => movie.Year == year && movie.Score > 90);
            var nameOfBestMovies = moreThanNinety.Select(movie => movie.Name);
            return nameOfBestMovies;
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts a list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {
            var allAreOdd = data.All(element => element % 2 != 0);
            return allAreOdd;
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts a list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {
            var containsNeedle = data.FirstOrDefault(element => element.Contains("needle"));
            return containsNeedle;

        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts a list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            var containsNeedle = data.FindIndex(element => element.Contains("needle"));
            return containsNeedle;
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts a list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            var fourLetter = data.Any(element => element.Count() == 4);
            return fourLetter;
        }
    }
}