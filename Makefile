default: build run

build:
	@dotnet build

run:
# auto builds anyways, but build looks cooler
	@dotnet run

export:
	@dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true /p:SelfContained=true
	@echo "File is located in /bin/Release/net.x.x/win-x64/publish"