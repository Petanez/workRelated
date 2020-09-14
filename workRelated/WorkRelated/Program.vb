Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        '   First create directoryinfo var
        Dim dirInfo As DirectoryInfo = New DirectoryInfo("C:\Users\Pete\Downloads")

        '   Then use it to get Files 
        Dim fileInfos As IEnumerable(Of FileInfo) = dirInfo.GetFiles().Where(Function(x As FileInfo) x.Name.Contains("HAKEMUS"))
        Dim fileCreationDate As DateTime

        Console.WriteLine(fileInfos.Count)
        For index As Integer = 0 To fileInfos.Count - 1
            fileCreationDate = File.GetCreationTime(fileInfos(index).FullName)
            If (DateTime.Now.Year - fileCreationDate.Year) > 4 Then
                Console.WriteLine(fileInfos(index).Name)
            End If
        Next
    End Sub
End Module
