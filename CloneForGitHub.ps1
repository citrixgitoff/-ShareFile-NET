﻿$Destination = $args[0]

Copy-Item .\* $Destination -Recurse -Force

Remove-Item $Destination -include *internal*,*.bat,*.ps*,*.fsx,.git,packages,*.nuspec,bin,obj -Exclude generate_coverage.bat -Recurse -Force
