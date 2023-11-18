HEX

S" vidsetup.fs" included
S" dotess.fs"   included
S" logo.fs"     included

\ cls ( -- ) HEX C EMIT ; \ clear screen see vdu.h case 0x0c: // CLS

\ HEX E 11 EMIT EMIT \ cyan in third place
\     E              bright cyan
  HEX 4 11 EMIT 80 + EMIT \ deep blue bg
  HEX F 11 EMIT EMIT \ bright white fg

DECIMAL

bye

