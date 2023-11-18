\ libr.fs

DECIMAL

: CUROFF ( ---)
\G Switch cursor off
  23 EMIT 1 EMIT 0 EMIT ;

: CURON ( ---)
\G Switch cursor on
  23 EMIT 1 EMIT 1 EMIT ;

: FG ( c ---)
  17 EMIT EMIT ;

: BG ( c ---)
  17 EMIT 128 + EMIT ;

: GC ( c ---)
  18 EMIT 0 EMIT EMIT ;

: MODE ( n ---)
\G Select graphics mode
  22 EMIT DUP EMIT ;

: SEEME ( --- )
  8 MODE ;

HEX
\ end.

