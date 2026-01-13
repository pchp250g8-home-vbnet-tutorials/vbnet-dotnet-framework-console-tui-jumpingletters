Imports System.Threading

Module Module1

    Sub Main()
        Dim strLine = "Hello,World!!! VBNet Conio Example!!!"
        Dim nLen = strLine.Length
        Console.Clear()
        Console.CursorVisible = False
        For i As Integer = 0 To nLen - 1
            For j As Integer = 70 To 10 + i Step -1
                Console.SetCursorPosition(10 + j, 10)
                Console.Write(strLine(i) + " ")
                Thread.Sleep(5)
            Next j
        Next i
        Console.SetCursorPosition(10, 10)
        Console.Write(strLine)
        Console.SetCursorPosition(10, 11)
        Console.Write("Press any key")
        Console.ReadKey()
    End Sub

End Module
