# Sharing A Library Across .NET Framework and .NET projects Project References
This is the easiest way to share code across projects that target different frameworks. 

BirdWranglers - is the library targeting .NET Standard 2.0. In order to share any code across both the library must target .NET standard 2.0
BirdWranglerInfo - .NET Framework Console App. The application type doesn't matter just that it targets .NET Framework part
BirdWranglerManagement - .NET 7 Web Application

Adding the BirdWranglers project as a project reference:
    - Allows you to change the library code as the front end projects change
	- Lowest startup cost. No need for nuget 
	- Creates a hard dependency. When you change the library all projects that reference the library must change as well. 
