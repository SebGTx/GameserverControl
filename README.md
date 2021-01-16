# GameserverControl
A simple application to control game server on a computer

This software was developed to respond to one of my problem that I have at home: playing game with my friends on my self-hosted server.

## My needs:
1. Controlling the computer and game server from inside and outside the house network.
2. Do it from a NAS that can host PHP apps.

## My problems:
1. Most of games does not have a game server that work on Linux and if you have one it works only on x86/x64 so not on NAS.
2. A dedicated Microsoft Windows computer used as a game server consume lot of power if keep always on.

## My goal: Develop two applications
1. A Windows Systray application that I can start with the operating system and can be configured to start/stop game server, backup data after stop, show logs. Actions can be trigger from a web service.
2. A php app that can be hosted on my NAS to power on/shutdown the computer and connect to the web service to start/stop game server.

GameserverControl is the first one, I will create another GitHub repos for the second one.

## Today it can do:
* From the Systray menu:
  - Create/Edit/Delete Game configuration
  - Start/Stop game server
  - Backup Files/Folders after the game server shutdown

* From the web service:
  - Get configuration
  - Start/Stop game server

* From the GCSetComputerSettings
  - Change web service port
  - Configure Windows ACL and Firewall for you with netsh

## What's next:
- Rotate log after the game server shutdown
- Get log from the web service
- Support wildcard in logs parameter if the log filename change every time you launch the game server
- Develop the PHP application for the NAS that can start the computer with WOL and control the game server thru the web service

And maybe:
- Implement SSL web service
- Implement authenticated web service

## What support can i give you:
- None, do it yourself :grin:

_I'm French but this application was entirely developed in English. Why? Do i really need to answer this question?_
_I'm sorry if my English make your eyes bleed when you read it, you are welcome to correct my work if you want._
