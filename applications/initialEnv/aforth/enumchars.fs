\ logo.fs  31 Oct 2023 ddd


DECIMAL

: DELTHEE 1 DROP ;

VARIABLE COUNTING \ COWNT - system defines COUNT so unavailable


: ?EMITTER ( c -- )

  DUP 256 < IF EMIT EXIT THEN

  DROP
;



: WLAP 2 0 DO 33 MS LOOP ;


: DEMIA ( -- )

  CR  31  \ 31 is pointing to next char of a space

  COUNTING C! CR

  220 0 DO

      32 EMIT

      COUNTING C@ \ comment

      1 + DUP

      COUNTING C!

      ?EMITTER

      32 EMIT
 
      WLAP

      10 DEPTH = IF ." quitting suddenly" QUIT THEN

  LOOP



  CR CR CR CR CR


   153  NEGATE DUP 1 + DUP 1 +

   CR


   6 0 DO 188 MS LOOP
;



: DEMOCHARS ( -- )

  CR CR 5 SPACES ." ENTERING 2 SECOND LOOP   "

  2

  \ 10 +

  0 DO 122 MS LOOP \ WAIT 2 SECONDS

  DEMIA

  CR

  ." mark JJ" CR


  20 0 DO 55 MS LOOP \ let them see it
;
 


HEX

: CLS ( -- )

  C EMIT ;


CR CR CR DEMOCHARS CLS CR CR

: MOCKER

  SPACE [char] ( EMIT

  ." tnr" [char] ) EMIT ;

.( Agon Console8 VDP Version 2.0.0)

MOCKER CR

.( Agon Quark MOS Version 1.04 RC2)

MOCKER

FORGET DELTHEE \ or MOCKER

CR CR

HEX E 11 EMIT EMIT \ cyan - not only location


DECIMAL

: MARKING 1 DROP ;

\ end.

