appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.traceFailedRequestsLogging.enabled:"True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.traceFailedRequestsLogging.directory:"%SystemDrive%\inetpub\logs\FailedReqLogFiles" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.traceFailedRequestsLogging.maxLogFiles:"20" /commit:apphost