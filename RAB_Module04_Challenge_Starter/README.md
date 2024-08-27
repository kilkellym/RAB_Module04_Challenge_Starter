
Revit Add-in Bootcamp - Module 4 Challenge Starter Repository

The repository contains an App.cs file and a Commands.cs file. 
The Commands.cs file has ten command classes. Each command class will be 
associated with a specific tool in the ribbon. The tool's mapping to the 
command file will match the tool's number to the letter of the command file. 
For example, “Tool 1” will map with “cmd1”, “Tool 1” will map with “cmd3”, “Tool 3” 
will map with “cmd4”, and so on to “Tool 10” mapping to “cmd10”. 

This solution supports Revit versions 2020 through 2025.
In order to build your code to Revit 2025, you must install the .Net 8 SDK. 
To do so, go to the following link and download the .Net 8 SDK: 
	https://dotnet.microsoft.com/download/dotnet/8.0

The template copies built code to a sub-folder in the Revit Addins folder.
The sub-folder is named after the add-in assembly name and contains the add-in manifest file and the add-in assembly.
The .addin file is automatically updated with the correct path to the add-in assembly.
