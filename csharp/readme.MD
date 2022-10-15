The main solution/program is in the directory PEMCollection.  Like the name already reveals it is a collection of 3 microprocessor simulations. Each constructed on top of the previous one.

All three cpu's are derived from the abstract/common components defined in and builded from PEM. Finally it's a .dll file on which the three cpu's depends.
final file: pem.dll

The basic cpu is PEM1. It's a 4 bits address/8 bits data cpu so it only can addres 16 8 bits memory registers.  It cannot hold more than 16 instructions in a ROM and contains 5 opcodes.
final file: pem1.dll

The second cpu calls PEM2. This an 8 bits address/12 bits data cpu derived from PEM1. This cpu can address 256 memory registers each 12 bits wide. In fact build on top of PEM1.  It has 28 opcodes.
final file: pem2.dll

The, for this moment, last cpu is called PEM3.  Also build 'on top of' PEM1 and PEM2 this cpu is a 16 bit address and data cpu.  This cpu counts 46 opcodes.  This cpu can address 4096 memory registers each 16 bits wide.

Finally PEMCollection is the main application in which the three cpu's are presented.  The simulation lacks programmability, so you cannot yet input a program and let it run.  It does however only works wen the CON unit is active. (click on it)

By putting the instructionset beside the blockdiagram you can follow what (should) happen when an instruction makes it journey through the cpu to be excuted and what (could) happen(s) when you decide to make your own instructions which is possible on PEM2 and PEM3.

My target is to make this trilogy programmable and executable. I even want to make an assembler for these three cpu's, watch execution on the blockdiagram and perhaps even to build an executable for windows/linux/mac osx (for what it is usefull for)

My final goal is to extend the application so that students can see how it all is be done on the logical level, which means that I have still a lot of work to do to design the logical diagrams and let them work in the application.

01-01-2016 - blockdiagrams, components and instructionsets ready.

to do: from c# to assembly language on windows with masm64.

for info: visit my unfinished website www.agguro.org or contact me at admin@agguro.be

enjoy
