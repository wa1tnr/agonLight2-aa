# bin2hex

Convert binary to intel hex, 0x40000 load address (agon light 2)

Writes to STDOUT (so capture the output)

A python3 application for Linux

  use:  ./bin2hex.py ./thisProgram.bin > ./thatConverted.hex

  picocom with ascii-xfr (from minicom) is enough to upload to
  Agon Light 2, using hexload.bin (in the presence of hexload.dll,
  both stored in /mos) capturing to a disk file, or loaded to
  SRAM at the usual address 0x40000 (or any other that 'works'
  for your use case).

  proper upstream:

  https://github.com/envenomator/agon-hexload.git

Sat 18 Nov 22:37:55 UTC 2023
