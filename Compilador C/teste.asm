#PRNAME detetor_top
#DIRNAM "C:"
#DATYPE 0
#NUBITS 29
#NDSTAC 16
#SDEPTH 16
#NUIOIN 2
#NUIOOU 2
#NUGAIN 2
@main LOAD 32
SET maina
LOAD 16
SET mainb
LOAD maina
PLD mainb
SIGN
SET mainc
@fim JMP fim
