REM netsh http add urlacl url="http://+:8080/" user="Tout le monde"
netsh http add urlacl url="http://+:8080/" user=%USERNAME%
netsh advfirewall firewall add rule name= "GameserverControl" dir=in action=allow protocol=TCP localport=8080
