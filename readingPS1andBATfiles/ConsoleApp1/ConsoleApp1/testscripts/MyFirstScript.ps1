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
	Add-Content C:\testscripts\log.txt "An Exception has occured."
	Add-Content C:\testscripts\log.txt "Details: $($PSItem.ToString())"
}
