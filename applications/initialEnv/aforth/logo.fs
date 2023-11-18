\ logo.fs  17 Nov 2023 dee

: buhbye ( -- )
  CR CR
  ."  Fri 17 Nov 13:56:14  DECISION TO MAKE SECOND DISPLAY Agon Terminal
  CR CR
  ."  Fri 17 Nov 13:57:39 UTC  DECISION to MAKE AGON COMPANION system ;)"
  CR
; \ end

\ normal program below

HEX

E 11 EMIT EMIT C EMIT

: MOCKER
  SPACE [char] ( EMIT
  ." tnr" [char] ) EMIT ;

.( Agon Console8 VDP Version 2.1.0)

MOCKER CR

.( Agon Console8 MOS Version 2.1.0)

MOCKER FORGET MOCKER buhbye CR CR

HEX E 11 EMIT EMIT \ cyan - not only location

DECIMAL

: MARKING 1 DROP ;

\ end.
