let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20

//However, if you try to swap the values using tuples, it will not change the original values
let swapTuple (x, y) = (y, x)
let xTuple, yTuple = swapTuple (x, y) 
printf "%d %d" xTuple yTuple //This will print 20 10
printf "%d %d" x y //This will still print 20 20