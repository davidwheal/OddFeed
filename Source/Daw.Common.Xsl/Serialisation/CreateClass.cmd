f:
cd %~dp0
xsd.exe transform.xml
xsd.exe transform.xsd /c /n:GeneratedClass

pause