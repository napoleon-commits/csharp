Write-Host "Hello, World!"

function Start-Something
{
	New-Item -Path "c:\" -Name "logfiles\/:*?<>|" -ItemType "directory" -ErrorAction Stop
}

try
{
	Start-Something
}
catch
{
	Write-Output "An Exception has occured."
	Write-Output "Details: $($PSItem.ToString())"
}
