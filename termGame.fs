\ 35 # 32 [SPACE] 64 @ 10 [NewLine]
\ at-xy u1 u2

\ can be snake or pathfinding

variable y
variable x
variable width

32 width !
1 x ! 1 y !

: cls 0 0 at-xy 60 0 do 60 0 do 32 emit loop 10 emit loop ;

: map 
cls
0 0 at-xy
width @ 0 do 35 emit loop 10 emit
width @ 2 / 0 do 35 emit width @ 2 - 0 do 32 emit loop 35 emit 10 emit loop
width @ 0 do 35 emit loop 10 emit ;

: drawplayer x @ y @ at-xy 64 emit ;
: rlop begin 1 1 = while 0 0 at-xy map drawplayer

80 80 at-xy

key

dup 115 = if y @ 1 + y ! then ( s )
dup 100 = if x @ 1 + x ! then ( d )
dup 97 =  if x @ 1 - x ! then ( a )
dup 119 = if y @ 1 - y ! then ( w )
drop

x @ 0 = if 1 x ! then 
y @ 0 = if 1 y ! then

x @ width @ 1 - = if width @ 2 - x ! then
y @ width @ 2 / 1 + = if width @ 2 / y ! then


repeat ;

rlop
