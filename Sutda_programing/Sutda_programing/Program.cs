
string[] deck = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                 "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};

Dictionary<string, int> jokbo = new Dictionary<string, int>()
{ //dictionary에 10땡까지 추가하기
    { "aA", 200 }, { "bB", 200 }, { "cC", 200 }, { "dD", 200 }, { "eE", 200 },
    { "fF", 200 }, { "gG", 200 }, { "hH", 200 }, { "iI", 200 }, { "jJ", 200 }
};

//  List를 사용해서 player0을 만들고, 카드 2장 만들어보기
List<string> player0 = new List<string>();
List<string> computer1 = new List<string>();

player0.Add(deck[0]);
player0.Add(deck[10]);

computer1.Add(deck[3]);
computer1.Add(deck[9]);

player0.Sort();

string player0_value = player0[0] + player0[1];
Console.WriteLine(player0_value);

Console.WriteLine(jokbo[player0_value]);