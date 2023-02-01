// Task1
// List<int> Num = new List<int>  { 1, 233, 33, 45, 556, 66, 22, 33, 44, 55, 44, 33, 333, 333, 222, 222, 111, 555, 666, 777 };
// var Choosnum = Num.Where(x => x > 30).Where(x => x < 100);
// foreach (var l in Choosnum)
//     Console.WriteLine(l);


// Task 2
// List<string> TooUpper = new List<string> { "comuter", "softclub", "muhammad","Ahmad"};

// task3
// List<string> StartAEndM = new List<string> { "am", "softclub", "muhammad","ahmadm"};
// var returne = StartAEndM.Where(x => x.StartsWith("a")).Where(x => x.EndsWith("m"));
// foreach (var s in returne)
// {
//     Console.WriteLine(s);
// }

//task4
// int cnt = 0;
//  List<int> arr = new List<int>() { 50, 20, 40, 60, 33, 70 ,20,75};
// var desen = arr.OrderByDescending(  x => x);
//  foreach(int value in desen)
//  {
//      cnt++;
//      if (cnt > 5 )
//          break;
//      Console.Write(value + " ");
//
// }

//task5
//
// List<int> brr = new List<int>() { 5, 20, 4, 60, 3, 70 ,2,7};
// var kvd = brr.Where(x => x * x > 20);
//
// foreach(int value in kvd)
//  {
//      
//      Console.Write(value + " ");
//
// }



//Task 6

// var words = new[] {  "HHHea", "Polotiq", "Armyea", "Emloy", "fael", "abead" };
//
// var Selectword = words.Select(w => w.Contains("ea") ? w.Replace("ea", "*") : w);
//
// foreach(var s in Selectword)
// {
//     Console.Write(s + " ");
// }


//task7

         // List<string> Alphavit = new List<string> { "comuter", "softclub", "muhammad","Ahmade","Polotiq"};
         //
         // var alp = Alphavit.OrderBy(x => x).LastOrDefault((s => s.Contains("e")));
         //
         //
         //    Console.WriteLine(alp + " ");
         //
         //
         //

//task8
// var rnd = new Random();
// var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var shuffledArray = array.OrderBy(i => rnd.Next());
// foreach (var s in shuffledArray)
// {
//     Console.WriteLine(s);
// }

