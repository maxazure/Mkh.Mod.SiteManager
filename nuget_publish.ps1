Write-Host '请输入Key：'

$key = Read-Host
$dir = './_packages'

if(Test-Path -Path $dir){
    Remove-Item $dir -Recurse
}

dotnet build -c Release

Get-ChildItem -Path $dir | ForEach-Object -Process{
    dotnet nuget push $_.fullname -s http://pi.iamoldli.com:1084/repository/nuget-hosted/ -k $key
}

pause