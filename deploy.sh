ApiKey=$1
Source=$2

nuget pack ./FumeLab.Fume.Core/FumeLab.Fume.Core.nuspec -Verbosity detailed
nuget pack ./FumeLab.Fume.Selenium/FumeLab.Fume.Selenium.nuspec -Verbosity detailed

nuget push ./FumeLab.Fume.Core.*.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source
nuget push ./FumeLab.Fume.Selenium.*.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source
