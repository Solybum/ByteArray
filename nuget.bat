cd src/ByteArray/bin/Release

del *.nupkg

nuget pack "../../ByteArray.csproj" -Prop Configuration=Release

nuget push "*.nupkg" -Source https://www.nuget.org/api/v2/package

cd ../../../../
