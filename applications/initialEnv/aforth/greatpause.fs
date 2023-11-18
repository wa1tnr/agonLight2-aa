\ greatpause.fs

\ Seems likely that the line that offers a keypress based pause

\ can be freely reused:

\ : THIS X Y DO ACTION ?TERMINAL IF LEAVE THEN LOOP ;


FORGET SQUARES

: SQUARES ( n --- )
    \ Print squares from 1 up to
    \ and including n

    1+ 1

    CR ." SEE  HERE om" CR

    DO
	CR I 6 .R I DUP UM* 11 D.R
        ?TERMINAL IF LEAVE THEN
    LOOP ;

\ end.
