
Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        Dim R As New Regex("\s+(\d+)(\w)(\d+)")
        Dim M As Match = R.Match("May 16A9,1998")
        Console.WriteLine(M.Groups(0).Value)
        Console.WriteLine(M.Groups(1).Value)
        Console.WriteLine(M.Groups(2).Value)
        Console.WriteLine(M.Groups(3).Value)
        'Match.Groups()储存的是预定义字符集对应的文本
        Console.WriteLine(M.Groups.Count)

        'Console.WriteLine(M.Groups(1).Value)
        Console.ReadKey()
    End Sub

End Module
