  
  
  mono ./SonarQube.Scanner.MSBuild.exe begin /k:"tik_travis-master" /n:"tik_travis" /v:"1.0.0" /d:sonar.host.url=https://sonarcloud.io /d:sonar.login=2ca6570170ed364d3d9c83c08c43831c9f97084f /d:"sonar.organization=sripirom-github" 
  dotnet build ./app/Tik.Travis.sln -c Release -f netcoreapp2.0
  dotnet test ./app/Tik.Travis.Lib.Tests/Tik.Travis.Lib.Tests.csproj
  mono ./SonarQube.Scanner.MSBuild.exe end /d:sonar.login=2ca6570170ed364d3d9c83c08c43831c9f97084f