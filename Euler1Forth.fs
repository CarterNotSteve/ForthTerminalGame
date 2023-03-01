variable total
: check5 dup 5 mod 0 = if dup total @ + total ! drop then ;
: check3 dup 3 mod 0 = if dup dup total @ + total ! drop else check5 then ;
: run 1000 0 do i dup check3 loop ;
run
total ?