You can run the server for the [JustPlanes](https://github.com/I-K0haku-I/Unity3D-JustPlanes-OnlineGame) repository with this.

## Instructions (Windows)

1. clone JustPlanes repository

2. clone this repository

3. open cmd as admin and change directory into the cloned repository (this one)

4. create symbolic link like this: `mklink /D .\src\Network\ <path to JustPlanes repo>\Assets\Scripts\Network\`

5. change dir into .\src\JustPlanesServer\

6. `dotnet run` (or whatever you use to execute C# console programs)