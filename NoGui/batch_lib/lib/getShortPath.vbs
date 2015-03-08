Set fso=CreateObject("Scripting.FileSystemObject")

' Is object a file or folder?
If fso.FolderExists(WScript.Arguments(0)) Then
   'It's a folder
   Set objFolder = fso.GetFolder(WScript.Arguments(0))
   WScript.StdOut.Write(objFolder.ShortPath)
ElseIf fso.FileExists(WScript.Arguments(0)) Then
   'It's a file
   Set objFile = fso.GetFile(WScript.Arguments(0))
   WScript.StdOut.Write(objFile.ShortPath)
Else
   WScript.StdOut.Write(WScript.Arguments(0))
End If