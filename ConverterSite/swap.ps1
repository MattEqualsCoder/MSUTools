$msu = ""
if ([string]::IsNullOrEmpty($msu))
{
    $msu = Read-Host "Please the full path to the msu file"
}
$msu = $msu -replace "`"", ""
if (-not $msu.EndsWith(".msu")) {
    Write-Error "Enter the full path to the msu";
    exit
}
$base = $msu.Substring(0, $msu.Length-4)
for ($i = 1; $i -lt 99; $i++)
{
    $a = "$base-$i.pcm"
    $aExists = Test-Path $a -PathType Leaf
    $b = "$base-$($i + 100).pcm"
    $bExists = [System.IO.File]::Exists($b)

    if ($aExists -and $bExists)
    {
        Write-Host "$a <-> $b"
        Move-Item -Path $a -Destination "$a.tmp"
        Move-Item -Path $b -Destination $a
        Move-Item -Path "$a.tmp" -Destination $b
    }
    elseif ($aExists)
    {
        Write-Host "$a --> $b"
        Move-Item -Path $a -Destination $b
    }
    elseif ($bExists)
    {
        Write-Host "$a <-- $b"
        Move-Item -Path $b -Destination $a
    }
}
Write-Host "Complete!"
