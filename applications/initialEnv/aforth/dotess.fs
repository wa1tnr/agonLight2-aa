\ dotess.fs

\ Sun 29 Oct 03:45:15 UTC 2023 = tnr

\     - - - code - - -

FORGET KAFFIX \ reload as often as you like!

: KAFFIX 1 DROP ;

S" libr.fs" included

DECIMAL

: PAUSE 100 0 DO 
  KEY? IF 
    KEY 27 = IF 
      -1 THROW 
    THEN LEAVE THEN 
  100 MS LOOP ;

VARIABLE NOISY

-1 INVERT

NOISY !

: !NOISY NOISY @ INVERT NOISY ! ;

: .esiface? NOISY @ -1 = ;

: NOP 1 DROP ;

HEX

: #SD> ( -- )  DEPTH [CHAR] < EMIT . 8 EMIT [CHAR] > EMIT SPACE ;

: ###> ( n -- ) <# DUP ABS 0 #S ROT SIGN #> TYPE SPACE ;

: CYAB  (  ? -- )  1 DEPTH 0 2

  + = IF -1 EXIT THEN ;

: CYAO ( ? )

  0 DEPTH 0 1 + = IF -1 EXIT THEN

  NOP ;

: DOTTUS ( ? )

  DEPTH
  BEGIN
      SWAP >R
      DEPTH 2 = IF
          SWAP DUP ###> SWAP 2 -
          BEGIN
              R> DUP ###> SWAP 1 -
              DUP 1 + 0 = IF
                  EXIT THEN
          AGAIN
      EXIT THEN
  AGAIN ;

: .esmsga

  .esiface? -1 = IF
  ." Empty " THEN ;


: .esmsgb

  .esiface? -1 = IF
  ." Stack DEPTH = one " THEN ;

: .esmsgc

  .esiface? -1 = IF
  ." Stack DEPTH = two or more " THEN ;

: CYA ( ? )
  #SD>
  CYAO -1 = IF
      DROP .esmsga QUIT THEN
  CYAB -1 = IF
      DROP DUP ###> .esmsgb QUIT THEN
  DOTTUS .esmsgc DROP ;

: .ESS CYA ;

: .S .ESS ; \ remap

: CR.S  CR CR CR .S CR CR CR ;

DECIMAL

\ eof
